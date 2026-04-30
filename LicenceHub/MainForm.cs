using LicenseHub.DB;
using LicenseHub.Extensions;
using LicenseHub.Factories;
using LicenseHub.Forms;
using LicenseHub.Helpers;
using LicenseHub.Models;
using Microsoft.EntityFrameworkCore;
using License = LicenseHub.Models.License;

namespace LicenceHub
{
    public partial class MainForm : Form
    {
        private readonly AppDbContext _dbContext;

        private FilterService _filterService;
        private FormFactory _formFactory;

        public MainForm()
        {
            InitializeComponent();

            _dbContext = new();
            _dbContext.Database.Migrate();

            _filterService = new(_dbContext);
            _formFactory = new(_dbContext);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            PopulateDataGrids();
            PopulateCombos();
            RefreshStats();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            _dbContext.Dispose();
        }

        private void AddEntryEvent(object sender, EventArgs e) => ExecuteSafe(() =>
        {
            switch (tabControl.SelectedTab?.Name)
            {
                case "licensePage":
                    AddEntity(
                        _dbContext.Licenses,
                        () => new LicenseForm(
                            _dbContext.Owners.Local.ToBindingList(),
                            _dbContext.Suppliers.Local.ToBindingList(),
                            _dbContext.Departments.Local.ToBindingList()
                        )
                    );
                    break;

                case "supplierPage":
                    AddEntity(
                        _dbContext.Suppliers,
                        () => new SupplierForm()
                    );
                    break;

                case "ownerPage":
                    AddEntity(
                        _dbContext.Owners,
                        () => new OwnerForm(_dbContext.Departments.Local.ToBindingList())
                    );
                    break;

                case "departmentPage":
                    AddEntity(
                        _dbContext.Departments,
                        () => new DepartmentForm()
                    );
                    break;

                default:
                    throw new ArgumentException("Unknown tab selected");
            }
            RefreshStats();
        }, "An error occurred while trying to add a new entry.");

        private void ModifyEntryEvent(object sender, EventArgs e) => ExecuteSafe(() =>
        {
            DataGridView view = GetCurrentDataGridView();

            if (view.SelectedRows.Count == 0) return;
            if (view.SelectedRows.Count > 1)
                throw new ArgumentException("Multiple rows selected. Please select only one row to modify.");

            var selectedEntity = view.SelectedRows[0].DataBoundItem
                ?? throw new ArgumentException("Selected row does not have a valid data bound item.");

            bool wasModified = tabControl.SelectedTab?.Name switch
            {
                "licensePage" => ModifyEntity(
                    _dbContext.Licenses,
                   () => new LicenseForm(
                       (License)selectedEntity,
                       _dbContext.Owners.Local.ToBindingList(),
                       _dbContext.Suppliers.Local.ToBindingList(),
                       _dbContext.Departments.Local.ToBindingList()
                   ),
                    (License)selectedEntity
                ),

                "supplierPage" => ModifyEntity(
                    _dbContext.Suppliers,
                    () => new SupplierForm((Supplier)selectedEntity),
                    (Supplier)selectedEntity
                ),

                "ownerPage" => ModifyEntity(
                   _dbContext.Owners,
                    () => new OwnerForm(
                        (Owner)selectedEntity,
                        _dbContext.Departments.Local.ToBindingList()
                    ),
                    (Owner)selectedEntity
                ),

                "departmentPage" => ModifyEntity(
                    _dbContext.Departments,
                    () => new DepartmentForm((Department)selectedEntity),
                    (Department)selectedEntity
                ),

                _ => throw new ArgumentException("Unknown tab selected")
            };

            if (wasModified)
            {
                view.RefreshCurrentRow();
                RefreshStats();
            }
        }, "An error occurred while trying to modify an entry.");

        private void DeleteEntryEvent(object sender, EventArgs e) => ExecuteSafe(() =>
        {
            DataGridView view = GetCurrentDataGridView();

            foreach (DataGridViewRow row in view.SelectedRows)
            {
                if (row.DataBoundItem is object entity) _dbContext.Remove(entity);
            }

            _dbContext.SaveChanges();
            RefreshStats();
        }, "An error occurred while trying to delete an entry.");

        private void ApplyFilterEvent(object sender, EventArgs e)
        {
            try
            {
                Action applyAction = tabControl.SelectedTab?.Name switch
                {
                    "licensePage" => ApplyLicenseFilters,
                    "supplierPage" => ApplySupplierFilters,
                    "ownerPage" => ApplyOwnerFilters,
                    "departmentPage" => ApplyDepartmentFilters,
                    _ => throw new ArgumentException("Unknown tab selected")
                };

                applyAction();
            }
            catch (Exception ex)
            {
                MessageViewer.ShowError("An error occurred while trying to filter an entries.", ex.Message);
            }
        }

        private void ClearFilterEvent(object sender, EventArgs e)
        {
            try
            {
                DataGridView view = GetCurrentDataGridView();

                switch (tabControl.SelectedTab?.Name)
                {
                    case "licensePage":
                        view.DataSource = _dbContext.Licenses.Local.ToBindingList();
                        btnClearLicense.Enabled = false;
                        break;
                    case "supplierPage":
                        view.DataSource = _dbContext.Suppliers.Local.ToBindingList();
                        btnClearSupplier.Enabled = false;
                        break;
                    case "ownerPage":
                        view.DataSource = _dbContext.Owners.Local.ToBindingList();
                        btnClearOwner.Enabled = false;
                        break;
                    case "departmentPage":
                        view.DataSource = _dbContext.Departments.Local.ToBindingList();
                        btnClearOwner.Enabled = false;
                        break;
                    default:
                        throw new ArgumentException("Unknown tab selected");
                }
            }
            catch (Exception ex)
            {
                MessageViewer.ShowError("An error occurred while trying to clear a filters.", ex.Message);
            }
        }

        private void AddEntity<TForm, TEntity>(DbSet<TEntity> dbSet, Func<TForm> createForm)
            where TForm : Form, IEntityDialog<TEntity>
            where TEntity : class
        {
            using (var form = createForm())
            {
                if (form.ShowDialog() != DialogResult.OK) return;

                TEntity result = form.Result
                    ?? throw new ArgumentNullException("Result is null!");

                dbSet.Add(result);

                try
                {
                    _dbContext.SaveChanges();
                }
                catch (Exception ex)
                {
                    dbSet.Remove(result); // Rollback the addition if save fails
                    throw ex.InnerException ?? ex;
                }
            }
        }

        private bool ModifyEntity<TForm, TEntity>(DbSet<TEntity> dbSet, Func<TForm> createForm, TEntity entity)
            where TForm : Form, IEntityDialog<TEntity>
            where TEntity : class
        {
            using (var form = createForm())
            {
                if (form.ShowDialog() != DialogResult.OK) return false;

                TEntity result = form.Result
                    ?? throw new ArgumentNullException("Result is null!");

                try
                {
                    var entry = _dbContext.Entry(entity);

                    entry.CurrentValues.SetValues(result);

                    foreach (var navigation in entry.Navigations)
                    {
                        var propertyInfo = typeof(TEntity).GetProperty(navigation.Metadata.Name);
                        if (propertyInfo != null)
                        {
                            var newValue = propertyInfo.GetValue(result);
                            propertyInfo.SetValue(entity, newValue);
                        }
                    }

                    _dbContext.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    _dbContext
                        .Entry(entity).CurrentValues
                        .SetValues(_dbContext.Entry(entity).OriginalValues);
                    throw ex.InnerException ?? ex;
                }
            }
        }

        private void ApplyLicenseFilters()
        {
            IEnumerable<License> query = _filterService.GetFilteredLicenses(
                searchLicense.Text.Trim(),
                comboOwner.SelectedValue as int?,
                comboSupplier.SelectedValue as int?,
                comboTypeLicense.SelectedText,
                comboExpiration.SelectedText
            );

            DataGridViewExtensions.ApplyFilters(dataGridLicense, query);
            btnClearLicense.Enabled = true;
        }

        private void ApplyOwnerFilters()
        {
            IEnumerable<Owner> query = _filterService.GetFilteredOwners(
                searchOwner.Text.Trim(),
                comboDepartment.SelectedValue as int?
            );

            DataGridViewExtensions.ApplyFilters(dataGridOwner, query);
            btnClearOwner.Enabled = true;
        }

        private void ApplySupplierFilters()
        {
            IEnumerable<Supplier> query = _filterService.GetFilteredSuppliers(searchSupplier.Text);
            DataGridViewExtensions.ApplyFilters(dataGridSupplier, query);
            btnClearSupplier.Enabled = true;
        }

        private void ApplyDepartmentFilters()
        {
            IEnumerable<Department> query = _filterService.GetFilteredDepartments(searchDepartment.Text);
            DataGridViewExtensions.ApplyFilters(dataGridDepartment, query);
            btnClearDepartment.Enabled = true;
        }

        private DataGridView GetCurrentDataGridView() =>
            tabControl.SelectedTab?.Controls.OfType<DataGridView>().FirstOrDefault()
            ?? throw new InvalidOperationException("No grid found");

        private void ExecuteSafe(Action action, string errorMessage)
        {
            try { action(); }
            catch (Exception ex) { MessageViewer.ShowError(errorMessage, ex.Message); }
        }

        private void PopulateDataGrids()
        {
            _dbContext.Licenses.Load();
            _dbContext.Owners.Load();
            _dbContext.Suppliers.Load();
            _dbContext.Departments.Load();

            dataGridLicense.DataSource = _dbContext.Licenses.Local.ToBindingList();
            dataGridOwner.DataSource = _dbContext.Owners.Local.ToBindingList();
            dataGridSupplier.DataSource = _dbContext.Suppliers.Local.ToBindingList();
            dataGridDepartment.DataSource = _dbContext.Departments.Local.ToBindingList();

            DataGridView[] dataGrids = { dataGridLicense, dataGridOwner, dataGridSupplier, dataGridDepartment };

            foreach (var view in dataGrids)
            {
                view.AutoGenerateColumns = false;
                view.DataBindingComplete += (s, e) =>
                {
                    view.ClearSelection();
                    view.CurrentCell = null;
                };
            }
        }

        private void PopulateCombos()
        {
            comboOwner.Setup(
                _dbContext.Owners.Local,
                o => new FilterItem { Id = o.Id, Text = o.ToString() },
                "All Owners"
            );

            comboSupplier.Setup(
                _dbContext.Suppliers.Local,
                s => new FilterItem { Id = s.Id, Text = s.Name },
                "All Suppliers"
            );

            comboDepartment.Setup(
                _dbContext.Departments.Local,
                d => new FilterItem { Id = d.Id, Text = d.Name },
                "All Departments"
            );

            List<string> types = Enum.GetNames<LicenseType>().ToList();
            types.Insert(0, "All Types");

            List<string> statuses = Enum.GetNames<ExpirationStatus>().ToList();
            statuses.Insert(0, "All Statuses");

            comboTypeLicense.DataSource = types;
            comboExpiration.DataSource = statuses;
        }

        private void RefreshStats()
        {
            int totalLicenses = _dbContext.Licenses.Local.Count();

            int expiringLicenses = _dbContext.Licenses.Local.Count(l =>
                l.ExpirationStatus == ExpirationStatus.ExpiringSoon
            );

            int expiredLicenses = _dbContext.Licenses.Local.Count(l =>
                l.ExpirationStatus == ExpirationStatus.Expired
            );

            lblTotalLicenses.Text = totalLicenses.ToString();
            lblExpire30Days.Text = expiringLicenses.ToString();
            lblExpired.Text = expiredLicenses.ToString();
        }

        private void LicenseCellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridLicense.Rows[e.RowIndex].DataBoundItem is License license)
            {
                DataGridViewExtensions.FormatLicenseCell(e, license);
            }
        }
    }
}
