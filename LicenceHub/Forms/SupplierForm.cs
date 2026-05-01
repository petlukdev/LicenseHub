using LicenseHub.Helpers;
using LicenseHub.Models;

namespace LicenseHub.Forms
{
    public partial class SupplierForm : Form, IEntityDialog<Supplier>
    {
        private int _originalId = -1;

        public Supplier? Result { get; private set; }

        public SupplierForm()
        {
            InitializeComponent();
            this.Text = "Add Supplier";
        }

        public SupplierForm(Supplier supplier) : this()
        {
            ArgumentNullException.ThrowIfNull(supplier, nameof(supplier));
            
            this.Text = "Edit Supplier";
            _originalId = supplier.Id;
            txtName.Text = supplier.Name;
            txtEmail.Text = supplier.ContactEmail;
            txtNumber.Text = supplier.ContactPhone;
        }

        private void ApplyEvent(object sender, EventArgs e)
        {
            try
            {
                string name = txtName.Text.Trim();
                string email = txtEmail.Text.Trim();
                string number = txtNumber.Text.Trim();

                if (string.IsNullOrEmpty(name))
                    throw new ArgumentNullException(nameof(name));
                if (string.IsNullOrEmpty(email))
                    throw new ArgumentNullException(nameof(email));
                if (string.IsNullOrEmpty(number))
                    throw new ArgumentNullException(nameof(number));

                if (name.Length > 150)
                    throw new ArgumentException("Name cannot be longer than 150 characters.", nameof(name));
                if (email.Length > 255)
                    throw new ArgumentException("Email cannot be longer than 255 characters.", nameof(email));
                if (number.Length > 17)
                    throw new ArgumentException("Number cannot be longer than 17 characters.", nameof(number));

                Supplier supplier = _originalId == -1
                    ? new Supplier { 
                        Name = name, 
                        ContactEmail = email, 
                        ContactPhone = number 
                    }
                    : new Supplier { 
                        Id = _originalId, 
                        Name = name, 
                        ContactEmail = email, 
                        ContactPhone = number 
                    };

                this.Result = supplier;
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageViewer.ShowError("An error occurred while trying to make new supplier.", ex.Message);
            }
        }

        private void CancelEvent(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
