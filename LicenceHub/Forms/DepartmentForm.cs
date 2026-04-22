using LicenseHub.Models;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LicenseHub.Forms
{
    public partial class DepartmentForm : Form
    {
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
            txtName.Text = department.Name;
        }

        private void ApplyEvent(object sender, EventArgs e)
        {
            try
            {
                string name = txtName.Text.Trim();
                if (string.IsNullOrEmpty(name))
                    throw new ArgumentNullException(nameof(name));

                this.Result = new Department
                {
                    Name = name
                };
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"An error occurred while trying to make new department.\n\nERROR: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void CancelEvent(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
