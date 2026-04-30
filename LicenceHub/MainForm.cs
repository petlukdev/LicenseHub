using LicenseHub.DB;
using LicenseHub.Extensions;
using LicenseHub.Forms;
using LicenseHub.Models;
using Microsoft.EntityFrameworkCore;
using License = LicenseHub.Models.License;

namespace LicenceHub
{
    public partial class MainForm : Form
    {
        private readonly AppDbContext _dbContext;

        public MainForm()
        {
            InitializeComponent();

            _dbContext = new AppDbContext();
            _dbContext.Database.Migrate();
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

        private void AddEntryEvent(object sender, EventArgs e)
        {
            try
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
            }
            catch (Exception ex)
            {
                MessageViewer.ShowError("An error occurred while trying to add a new entry.", ex.Message);
            }
        }

        private void ModifyEntryEvent(object sender, EventArgs e)
        {
            try
            {
                DataGridView dataGridView = tabControl.SelectedTab?.Controls.OfType<DataGridView>().FirstOrDefault()
                    ?? throw new ArgumentException("No DataGridView found in the selected tab");

                if (dataGridView.SelectedRows.Count == 0) return;
                if (dataGridView.SelectedRows.Count > 1)
                    throw new ArgumentException("Multiple rows selected. Please select only one row to modify.");

                var selectedEntity = dataGridView.SelectedRows[0].DataBoundItem
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
                    dataGridView.RefreshCurrentRow();
                    RefreshStats();
                }
            }
            catch (Exception ex)
            {
                MessageViewer.ShowError("An error occurred while trying to modify an entry.", ex.Message);
            }
        }

        private void DeleteEntryEvent(object sender, EventArgs e)
        {
            try
            {
                DataGridView dataGridView = tabControl.SelectedTab?.Controls.OfType<DataGridView>().FirstOrDefault()
                    ?? throw new ArgumentException("No DataGridView found in the selected tab");

                if (dataGridView.SelectedRows.Count == 0) return;

                foreach (DataGridViewRow row in dataGridView.SelectedRows)
                {
                    if (row.DataBoundItem == null) continue;
                    switch (tabControl.SelectedTab?.Name)
                    {
                        case "licensePage":
                            _dbContext.Licenses.Remove((License)row.DataBoundItem);
                            break;
                        case "supplierPage":
                            _dbContext.Suppliers.Remove((Supplier)row.DataBoundItem);
                            break;
                        case "ownerPage":
                            _dbContext.Owners.Remove((Owner)row.DataBoundItem);
                            break;
                        case "departmentPage":
                            _dbContext.Departments.Remove((Department)row.DataBoundItem);
                            break;
                        default:
                            throw new ArgumentException("Unknown tab selected");
                    }
                }

                _dbContext.SaveChanges();
                RefreshStats();
            }
            catch (Exception ex)
            {
                MessageViewer.ShowError("An error occurred while trying to delete an entry.", ex.Message);
            }
        }

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
                TabPage? tab = tabControl.SelectedTab;
                DataGridView dataGridView = tab?.Controls.OfType<DataGridView>().FirstOrDefault()
                    ?? throw new ArgumentException("No DataGridView found in the selected tab");

                switch (tab.Name)
                {
                    case "licensePage":
                        dataGridView.DataSource = _dbContext.Licenses.Local.ToBindingList();
                        btnClearLicense.Enabled = false;
                        break;
                    case "supplierPage":
                        dataGridView.DataSource = _dbContext.Suppliers.Local.ToBindingList();
                        btnClearSupplier.Enabled = false;
                        break;
                    case "ownerPage":
                        dataGridView.DataSource = _dbContext.Owners.Local.ToBindingList();
                        btnClearOwner.Enabled = false;
                        break;
                    case "departmentPage":
                        dataGridView.DataSource = _dbContext.Departments.Local.ToBindingList();
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
            IEnumerable<License> query = DataGridViewExtensions.ApplyTextFilter(
                _dbContext.Licenses.Local,
                l => l.Title,
                searchLicense.Text.Trim()
            );

            int? ownerId = comboOwner.SelectedValue as int?;
            int? supplierId = comboSupplier.SelectedValue as int?;

            if (Enum.TryParse<LicenseType>(comboTypeLicense.Text, out var type))
            {
                query = query.Where(l => l.Type == type);
            }

            if (Enum.TryParse<ExpirationStatus>(comboExpiration.Text, out var status))
            {
                query = query.Where(l => l.ExpirationStatus == status);
            }

            if (ownerId.HasValue && ownerId > 0)
            {
                query = query.Where(l => l.OwnerId == ownerId);
            }


            if (supplierId.HasValue && supplierId > 0)
            {
                query = query.Where(l => l.SupplierId == supplierId);
            }

            DataGridViewExtensions.ApplyFilters(dataGridLicense, query);
            btnClearLicense.Enabled = true;
        }

        private void ApplyOwnerFilters()
        {
            IEnumerable<Owner> query = _dbContext.Owners.Local.AsEnumerable();

            string txt = searchOwner.Text.Trim();
            int? departmentId = comboDepartment.SelectedValue as int?;

            if (!string.IsNullOrWhiteSpace(txt))
            {
                query = query.Where(s =>
                    s.FirstName.ToLower().Contains(txt, StringComparison.OrdinalIgnoreCase) ||
                    s.LastName.ToLower().Contains(txt, StringComparison.OrdinalIgnoreCase)
                );
            }

            if (departmentId.HasValue && departmentId > 0)
            {
                query = query.Where(s => s.Department is not null && s.Department.Id == departmentId);
            }

            DataGridViewExtensions.ApplyFilters(dataGridOwner, query);
            btnClearOwner.Enabled = true;
        }

        private void ApplySupplierFilters()
        {
            IEnumerable<Supplier> query = DataGridViewExtensions.ApplyTextFilter(
                _dbContext.Suppliers.Local,
                s => s.Name,
                searchSupplier.Text.Trim()
            );

            DataGridViewExtensions.ApplyFilters(dataGridSupplier, query);
            btnClearSupplier.Enabled = true;
        }

        private void ApplyDepartmentFilters()
        {
            IEnumerable<Department> query = DataGridViewExtensions.ApplyTextFilter(
                _dbContext.Departments.Local,
                d => d.Name,
                searchDepartment.Text.Trim()
            );

            DataGridViewExtensions.ApplyFilters(dataGridDepartment, query);
            btnClearDepartment.Enabled = true;
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
            if (e.RowIndex >= 0 && dataGridLicense.Rows[e.RowIndex].DataBoundItem is License licence)
            {
                Color colorBg = Color.White;
                Color colorFont = Color.Black;

                switch (licence.ExpirationStatus)
                {
                    case ExpirationStatus.Expired:
                        colorBg = Color.LightCoral;
                        break;

                    case ExpirationStatus.ExpiringSoon:
                        colorBg = Color.LightGoldenrodYellow;
                        break;

                    default:
                        break;
                }

                dataGridLicense.Rows[e.RowIndex].DefaultCellStyle.BackColor = colorBg;
                dataGridLicense.Rows[e.RowIndex].DefaultCellStyle.ForeColor = colorFont;
            }
        }
    }
}
