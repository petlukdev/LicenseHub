using LicenseHub.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LicenseHub.Forms
{
    public partial class SupplierForm : Form
    {
        public SupplierForm()
        {
            InitializeComponent();
        }

        public SupplierForm(Supplier supplier) : this()
        {
            ArgumentNullException.ThrowIfNull(supplier, nameof(supplier));

            txtName.Text = supplier.Name;
            txtEmail.Text = supplier.ContactEmail;
            txtNumber.Text = supplier.ContactPhone;
        }

        public Supplier? Result { get; private set; }
    }
}
