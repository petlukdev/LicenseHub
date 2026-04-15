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
    public partial class OwnerForm : Form
    {
        public OwnerForm()
        {
            InitializeComponent();
        }

        public OwnerForm(Owner owner) : this()
        {
            ArgumentNullException.ThrowIfNull(owner, nameof(owner));

            txtFirstName.Text = owner.FirstName;
            txtLastName.Text = owner.LastName;
            txtEmail.Text = owner.Email;
        }

        public Owner? Result { get; private set; }
    }
}
