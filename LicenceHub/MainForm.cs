using LicenseHub.DB;
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
                Form form = tabControl.SelectedTab?.Name switch
                {
                    "licensePage" => new LicenseForm(),
                    "supplierPage" => new SupplierForm(),
                    "ownerPage" => new OwnerForm(),
                    "departmentPage" => new DepartmentForm(),
                    _ => throw new ArgumentException("Unknown tab selected")
                };

                if (form.ShowDialog() == DialogResult.Cancel) return;

                // ...
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

                // ...
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
            dataGridOwner.AutoGenerateColumns = false;
            dataGridDepartment.AutoGenerateColumns = false;

            dataGridLicense.DataSource = _dbContext.Licenses.Local.ToBindingList();
            dataGridOwner.DataSource = _dbContext.Owners.Local.ToBindingList();
            dataGridSupplier.DataSource = _dbContext.Suppliers.Local.ToBindingList();
            dataGridDepartment.DataSource = _dbContext.Departments.Local.ToBindingList();
        }
    }
}
