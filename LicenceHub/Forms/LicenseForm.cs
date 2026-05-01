using LicenseHub.Extensions;
using LicenseHub.Helpers;
using LicenseHub.Models;
using System.ComponentModel;
using License = LicenseHub.Models.License;

namespace LicenseHub.Forms
{
    public partial class LicenseForm : Form, IEntityDialog<License>
    {
        private int _originalId = -1;
        private readonly IBindingList _owners;
        private readonly IBindingList _suppliers;
        private readonly IBindingList _departments;

        public License? Result { get; private set; }

        public LicenseForm(IBindingList owners, IBindingList suppliers, IBindingList departments)
        {
            InitializeComponent();

            this.Text = "Add License";
            _owners = owners;
            _suppliers = suppliers;
            _departments = departments;

            comboType.DataSource = Enum.GetValues(typeof(LicenseType));

            Owner emptyOwner = new Owner { Id = -1, FirstName = "No", LastName = "Owner", Email = "" };
            Supplier emptySupplier = new Supplier { Id = -1, Name = "No Supplier", ContactEmail = "", ContactPhone = "" };

            comboOwner.SetupOptionalData(_owners, emptyOwner, "FullName");
            comboSupplier.SetupOptionalData(_suppliers, emptySupplier);
        }

        public LicenseForm(
            License license,
            IBindingList owners,
            IBindingList suppliers,
            IBindingList departments
            ) : this(owners, suppliers, departments)
        {
            ArgumentNullException.ThrowIfNull(license, nameof(license));

            _originalId = license.Id;
            txtTitle.Text = license.Title;
            txtKey.Text = license.Key;
            comboType.SelectedItem = license.Type;
            numPrice.Value = (decimal)license.Cost;
            datePicker.Value = license.ExpirationDate;
            comboOwner.SelectedItem = license.Owner;
            comboSupplier.SelectedItem = license.Supplier;
        }

        private void AddOwnerEvent(object sender, EventArgs e)
        {
            using (var form = new OwnerForm(_departments))
            {
                if (form.ShowDialog() != DialogResult.OK) return;

                try
                {
                    Owner result = form.Result
                        ?? throw new ArgumentNullException(nameof(form.Result));

                    _owners.Add(result);
                    comboOwner.SelectedItem = result;
                }
                catch (Exception ex)
                {
                    MessageViewer.ShowError("An error occurred while trying to make new owner.", ex.Message);
                }
            }
        }

        private void AddSupplierEvent(object sender, EventArgs e)
        {
            using (var form = new SupplierForm())
            {
                if (form.ShowDialog() != DialogResult.OK) return;

                try
                {
                    Supplier result = form.Result
                        ?? throw new ArgumentNullException(nameof(form.Result));

                    _suppliers.Add(result);
                    comboSupplier.SelectedItem = result;
                }
                catch (Exception ex)
                {
                    MessageViewer.ShowError("An error occurred while trying to make new supplier.", ex.Message);
                }
            }
        }

        private void ApplyEvent(object sender, EventArgs e)
        {
            try
            {
                string title = txtTitle.Text.Trim();
                string key = txtKey.Text.Trim();
                double cost = (double)numPrice.Value;
                DateTime expirationDate = datePicker.Value;

                if (string.IsNullOrEmpty(title))
                    throw new ArgumentNullException(nameof(title));
                if (string.IsNullOrEmpty(key))
                    throw new ArgumentNullException(nameof(key));
                if (double.IsNaN(cost))
                    throw new ArgumentNullException(nameof(cost));
                if (double.IsNegative(cost) || cost.Equals(0))
                    throw new ArgumentException("Cost cannot be negative or zero.");

                if (title.Length > 150)
                    throw new ArgumentException("First name cannot be longer than 150 characters.");
                if (key.Length > 255)
                    throw new ArgumentException("Last name cannot be longer than 255 characters.");

                if (comboType.SelectedItem is not LicenseType type)
                    throw new InvalidOperationException("Type is not selected.");
                if (comboOwner.SelectedItem is not Owner owner || owner.Id == -1)
                    throw new InvalidOperationException("Owner is not selected.");
                if (comboSupplier.SelectedItem is not Supplier supplier || supplier.Id == -1)
                    throw new InvalidOperationException("Supplier is not selected.");

                this.Result = _originalId == -1
                    ? new License
                    {
                        Title = title,
                        Key = key,
                        Cost = cost,
                        Type = type,
                        ExpirationDate = expirationDate,
                        Owner = owner,
                        Supplier = supplier
                    }
                    : new License
                    {
                        Id = _originalId,
                        Title = title,
                        Key = key,
                        Cost = cost,
                        Type = type,
                        ExpirationDate = expirationDate,
                        Owner = owner,
                        Supplier = supplier
                    };

                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageViewer.ShowError("An error occurred while trying to make new license.", ex.Message);
            }
        }

        private void CancelEvent(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
