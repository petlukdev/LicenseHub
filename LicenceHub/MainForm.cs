using LicenseHub.DB;
using LicenseHub.Forms;
using Microsoft.EntityFrameworkCore;

namespace LicenceHub
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            using (var context = new AppDbContext())
            {
                context.Database.Migrate();
            }
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
    }
}
