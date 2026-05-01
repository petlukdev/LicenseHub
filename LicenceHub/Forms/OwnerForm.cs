using LicenseHub.Extensions;
using LicenseHub.Helpers;
using LicenseHub.Models;
using System.ComponentModel;

namespace LicenseHub.Forms
{
    public partial class OwnerForm : Form, IEntityDialog<Owner>
    {
        private int _originalId = -1;
        private readonly IBindingList _bindingList;

        public Owner? Result { get; private set; }

        public OwnerForm(IBindingList departments)
        {
            InitializeComponent();
            this.Text = "Add Owner";
            _bindingList = departments;

            Department empty = new Department { Id = -1, Name  = "None" };

            comboDepartment.SetupOptionalData(_bindingList, empty);
        }

        public OwnerForm(Owner owner, IBindingList departments) : this(departments)
        {
            ArgumentNullException.ThrowIfNull(owner, nameof(owner));

            this.Text = "Edit Owner";
            _originalId = owner.Id;
            txtFirstName.Text = owner.FirstName;
            txtLastName.Text = owner.LastName;
            txtEmail.Text = owner.Email;

            if (owner.Department != null)
                comboDepartment.SelectedValue = owner.Department.Id;
            else
                comboDepartment.SelectedValue = -1;
        }

        private void AddDepartmentEvent(object sender, EventArgs e)
        {
            using (var form = new DepartmentForm())
            {
                if (form.ShowDialog() != DialogResult.OK) return;

                UIHelper.ExecuteSafe(() =>
                {
                    Department result = form.Result
                        ?? throw new ArgumentNullException(nameof(form.Result));

                    _bindingList.Add(result);
                    comboDepartment.SelectedItem = result;
                }, "An error occurred while trying to make new department.");
            }
        }

        private void ApplyEvent(object sender, EventArgs e) => UIHelper.ExecuteSafe(() =>
        {
            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();
            string email = txtEmail.Text.Trim();
            Department? department = comboDepartment.SelectedItem as Department;
            Department? finalDepartment = (department is null || department.Id == -1)
                ? null
                : department;

            if (string.IsNullOrEmpty(firstName))
                throw new ArgumentNullException(nameof(firstName));
            if (string.IsNullOrEmpty(lastName))
                throw new ArgumentNullException(nameof(lastName));
            if (string.IsNullOrEmpty(email))
                throw new ArgumentNullException(nameof(email));

            if (firstName.Length > 50)
                throw new ArgumentException("First name cannot be longer than 50 characters.");
            if (lastName.Length > 50)
                throw new ArgumentException("Last name cannot be longer than 50 characters.");
            if (email.Length > 255)
                throw new ArgumentException("Email cannot be longer than 255 characters.");

            this.Result = _originalId == -1
                ? new Owner
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Email = email,
                    Department = finalDepartment
                }
                : new Owner
                {
                    Id = _originalId,
                    FirstName = firstName,
                    LastName = lastName,
                    Email = email,
                    Department = finalDepartment
                };

            this.DialogResult = DialogResult.OK;
        }, "An error occurred while trying to make new owner.");

        private void CancelEvent(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
