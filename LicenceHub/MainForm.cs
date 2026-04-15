using LicenseHub.DB;
using LicenseHub.Extensions;
using LicenseHub.Forms;
using LicenseHub.Models;
using Microsoft.EntityFrameworkCore;

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

        private void AddEntryEvent(object sender, EventArgs e)
        {
            try
            {
                switch (tabControl.SelectedTab?.Name)
                {
                    case "licensePage":
                        AddEntity<LicenseForm, License>(_dbContext.Licenses);
                        break;

                    case "supplierPage":
                        AddEntity<SupplierForm, Supplier>(_dbContext.Suppliers);
                        break;

                    case "ownerPage":
                        AddEntity<OwnerForm, Owner>(_dbContext.Owners);
                        break;

                    case "departmentPage":
                        AddEntity<DepartmentForm, Department>(_dbContext.Departments);
                        break;

                    default:
                        throw new ArgumentException("Unknown tab selected");
                }

                _dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"An error occurred while trying to add a new entry.\n\nERROR: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void ModifyEntryEvent(object sender, EventArgs e)
        {
            try
            {
                Form form = tabControl.SelectedTab?.Name switch
                {
                    "licensePage" => new LicenseForm(),
                    "supplierPage" => new SupplierForm(),
                    "ownerPage" => new OwnerForm(),
                    "departmentPage" => new DepartmentForm(),
                    _ => throw new ArgumentException("Unknown tab selected")
                };

                DataGridView dataGridView = tabControl.SelectedTab?.Controls.OfType<DataGridView>().FirstOrDefault()
                    ?? throw new ArgumentException("No DataGridView found in the selected tab");

                // ...

                if (form.ShowDialog() == DialogResult.Cancel) return;

                // ...
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"An error occurred while trying to modify an entry.\n\nERROR: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"An error occurred while trying to delete an entry.\n\nERROR: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            PopulateDataGrids();
            PopulateCombos();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            _dbContext.Dispose();
        }

        private void PopulateDataGrids()
        {
            _dbContext.Licenses.Load();
            _dbContext.Owners.Load();
            _dbContext.Suppliers.Load();
            _dbContext.Departments.Load();

            dataGridLicense.AutoGenerateColumns = false;
            dataGridOwner.AutoGenerateColumns = false;
            dataGridSupplier.AutoGenerateColumns = false;
            dataGridDepartment.AutoGenerateColumns = false;

            dataGridLicense.DataSource = _dbContext.Licenses.Local.ToBindingList();
            dataGridOwner.DataSource = _dbContext.Owners.Local.ToBindingList();
            dataGridSupplier.DataSource = _dbContext.Suppliers.Local.ToBindingList();
            dataGridDepartment.DataSource = _dbContext.Departments.Local.ToBindingList();
        }

        private void PopulateCombos()
        {
            comboOwner.Setup(
                _dbContext.Owners.Local,
                o => new FilterItem { Id = o.Id, Text = o.ToString()},
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

        private void AddEntity<TForm, TEntity>(DbSet<TEntity> dbSet)
            where TForm : Form, new()
            where TEntity : class
        {
            using (var form = new TForm())
            {
                if (form.ShowDialog() == DialogResult.Cancel) return;

                var resultProperty = typeof(TForm).GetProperty("Result");
                if (resultProperty == null)
                    throw new ArgumentException("The form does not have a Result property.");

                var result = resultProperty.GetValue(form) as TEntity;
                if (result == null)
                    throw new ArgumentNullException("Result is null!");

                dbSet.Add(result);
            }
        }
    }
}
