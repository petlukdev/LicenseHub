using LicenseHub.Extensions;
using LicenseHub.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LicenseHub.Forms
{
    public partial class OwnerForm : Form, IEntityDialog<Owner>
    {
        private int _originalId = -1;

        public Owner? Result { get; private set; }

        public OwnerForm()
        {
            InitializeComponent();
            this.Text = "Add Owner";

            // TODO: Load departments from database and populate comboDepartment
        }

        public OwnerForm(Owner owner) : this()
        {
            ArgumentNullException.ThrowIfNull(owner, nameof(owner));

            this.Text = "Edit Owner";
            _originalId = owner.Id;
            txtFirstName.Text = owner.FirstName;
            txtLastName.Text = owner.LastName;
            txtEmail.Text = owner.Email;
        }

        private void AddDepartmentEvent(object sender, EventArgs e)
        {
            // TODO: Implement department management form and logic
        }

        private void ApplyEvent(object sender, EventArgs e)
        {
            try
            {
                string firstName = txtFirstName.Text.Trim();
                string lastName = txtLastName.Text.Trim();
                string email = txtEmail.Text.Trim();
                Department? department = comboDepartment.SelectedItem as Department;

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
                    ? new Owner { 
                        FirstName = firstName, 
                        LastName = lastName, 
                        Email = email, 
                        Department = department 
                    }
                    : new Owner { 
                        Id = _originalId, 
                        FirstName = firstName, 
                        LastName = lastName, 
                        Email = email, 
                        Department = department 
                    };

                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageViewer.ShowError("An error occurred while trying to make new owner.", ex.Message);
            }
        }

        private void CancelEvent(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
