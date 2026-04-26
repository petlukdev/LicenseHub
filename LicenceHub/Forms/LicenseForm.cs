using LicenseHub.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LicenseHub.Forms
{
    public partial class LicenseForm : Form, IEntityDialog<License>
    {
        public License? Result { get; private set; }

        public LicenseForm()
        {
            InitializeComponent();
        }

        public LicenseForm(License license) : this()
        {
            ArgumentNullException.ThrowIfNull(license, nameof(license));

            txtTitle.Text = license.Title;
            txtKey.Text = license.Key;
            comboType.SelectedItem = license.Type;
            numPrice.Value = (decimal)license.Cost;
            datePicker.Value = license.ExpirationDate;
            comboOwner.SelectedItem = license.Owner;
            comboSupplier.SelectedItem = license.Supplier;
        }
    }
}
