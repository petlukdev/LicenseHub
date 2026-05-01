using LicenseHub.Helpers;
using LicenseHub.Models;

namespace LicenseHub.Forms
{
    public partial class DepartmentForm : Form, IEntityDialog<Department>
    {
        private int _originalId = -1;

        public Department? Result { get; private set; }

        public DepartmentForm()
        {
            InitializeComponent();
            this.Text = "Add Department";
        }

        public DepartmentForm(Department department) : this()
        {
            ArgumentNullException.ThrowIfNull(department, nameof(department));
            
            this.Text = "Edit Department";
            _originalId = department.Id;
            txtName.Text = department.Name;
        }

        private void ApplyEvent(object sender, EventArgs e) => UIHelper.ExecuteSafe(() =>
        {
            string name = txtName.Text.Trim();

            if (string.IsNullOrEmpty(name))
                throw new ArgumentNullException(nameof(name));
            if (name.Length > 255)
                throw new ArgumentException("Department name cannot be longer than 255 characters.", nameof(name));

            Department department = _originalId == -1
                ? new Department { Name = name }
                : new Department { Id = _originalId, Name = name };

            this.Result = department;
            this.DialogResult = DialogResult.OK;
        }, "An error occurred while trying to make new department.");

        private void CancelEvent(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
