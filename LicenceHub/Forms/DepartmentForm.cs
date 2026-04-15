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
    public partial class DepartmentForm : Form
    {
        public DepartmentForm()
        {
            InitializeComponent();
        }

        public DepartmentForm(Department department) : this()
        {
            ArgumentNullException.ThrowIfNull(department, nameof(department));
            txtName.Text = department.Name;
        }

        public Department? Result { get; private set; }
    }
}
