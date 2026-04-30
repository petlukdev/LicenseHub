namespace LicenceHub
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            toolStrip1 = new ToolStrip();
            btnAddEntry = new ToolStripButton();
            btnModifyEntry = new ToolStripButton();
            btnDeleteEntry = new ToolStripButton();
            tabControl = new TabControl();
            licensePage = new TabPage();
            groupBox2 = new GroupBox();
            flowLayoutPanel4 = new FlowLayoutPanel();
            label8 = new Label();
            searchLicense = new TextBox();
            comboTypeLicense = new ComboBox();
            comboExpiration = new ComboBox();
            comboOwner = new ComboBox();
            comboSupplier = new ComboBox();
            btnApplyLicense = new Button();
            btnClearLicense = new Button();
            dataGridLicense = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            titleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            keyDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            typeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            costDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            expirationDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ownerIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ownerDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            supplierIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            supplierDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            expirationStatusDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            licenseBindingSource = new BindingSource(components);
            ownerPage = new TabPage();
            groupBox1 = new GroupBox();
            flowLayoutPanel3 = new FlowLayoutPanel();
            label7 = new Label();
            searchOwner = new TextBox();
            comboDepartment = new ComboBox();
            btnApplyOwner = new Button();
            btnClearOwner = new Button();
            dataGridOwner = new DataGridView();
            idDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            firstNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lastNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            departmentIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            departmentDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            licensesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ownerBindingSource = new BindingSource(components);
            supplierPage = new TabPage();
            groupBox3 = new GroupBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            label6 = new Label();
            searchSupplier = new TextBox();
            btnApplySupplier = new Button();
            btnClearSupplier = new Button();
            dataGridSupplier = new DataGridView();
            idDataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            contactEmailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            contactPhoneDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            licensesDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            supplierBindingSource = new BindingSource(components);
            departmentPage = new TabPage();
            groupBox4 = new GroupBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label5 = new Label();
            searchDepartment = new TextBox();
            btnApplyDepartment = new Button();
            btnClearDepartment = new Button();
            dataGridDepartment = new DataGridView();
            idDataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            ownersDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            departmentBindingSource = new BindingSource(components);
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            lblTotalLicenses = new Label();
            lblExpire30Days = new Label();
            label3 = new Label();
            lblExpired = new Label();
            panel1 = new Panel();
            toolStrip1.SuspendLayout();
            tabControl.SuspendLayout();
            licensePage.SuspendLayout();
            groupBox2.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridLicense).BeginInit();
            ((System.ComponentModel.ISupportInitialize)licenseBindingSource).BeginInit();
            ownerPage.SuspendLayout();
            groupBox1.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridOwner).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ownerBindingSource).BeginInit();
            supplierPage.SuspendLayout();
            groupBox3.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridSupplier).BeginInit();
            ((System.ComponentModel.ISupportInitialize)supplierBindingSource).BeginInit();
            departmentPage.SuspendLayout();
            groupBox4.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridDepartment).BeginInit();
            ((System.ComponentModel.ISupportInitialize)departmentBindingSource).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.AutoSize = false;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnAddEntry, btnModifyEntry, btnDeleteEntry });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(914, 51);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnAddEntry
            // 
            btnAddEntry.Image = LicenseHub.Properties.Resources.PlusIcon;
            btnAddEntry.ImageTransparentColor = Color.Magenta;
            btnAddEntry.Name = "btnAddEntry";
            btnAddEntry.Size = new Size(100, 48);
            btnAddEntry.Text = "New Entry";
            btnAddEntry.ToolTipText = "Create new entry in selected tab";
            btnAddEntry.Click += AddEntryEvent;
            // 
            // btnModifyEntry
            // 
            btnModifyEntry.Image = LicenseHub.Properties.Resources.PenIcon;
            btnModifyEntry.ImageTransparentColor = Color.Magenta;
            btnModifyEntry.Name = "btnModifyEntry";
            btnModifyEntry.Size = new Size(80, 48);
            btnModifyEntry.Text = "Modify";
            btnModifyEntry.ToolTipText = "Modify selected row";
            btnModifyEntry.Click += ModifyEntryEvent;
            // 
            // btnDeleteEntry
            // 
            btnDeleteEntry.Image = LicenseHub.Properties.Resources.BinIcon;
            btnDeleteEntry.ImageTransparentColor = Color.Magenta;
            btnDeleteEntry.Name = "btnDeleteEntry";
            btnDeleteEntry.Size = new Size(77, 48);
            btnDeleteEntry.Text = "Delete";
            btnDeleteEntry.ToolTipText = "Delete selected row";
            btnDeleteEntry.Click += DeleteEntryEvent;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(licensePage);
            tabControl.Controls.Add(ownerPage);
            tabControl.Controls.Add(supplierPage);
            tabControl.Controls.Add(departmentPage);
            tabControl.Location = new Point(14, 55);
            tabControl.Margin = new Padding(3, 4, 3, 4);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(887, 469);
            tabControl.TabIndex = 0;
            // 
            // licensePage
            // 
            licensePage.Controls.Add(groupBox2);
            licensePage.Controls.Add(dataGridLicense);
            licensePage.Location = new Point(4, 29);
            licensePage.Margin = new Padding(3, 4, 3, 4);
            licensePage.Name = "licensePage";
            licensePage.Padding = new Padding(3, 4, 3, 4);
            licensePage.Size = new Size(879, 436);
            licensePage.TabIndex = 0;
            licensePage.Text = "Licenses";
            licensePage.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(flowLayoutPanel4);
            groupBox2.Location = new Point(6, 7);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(867, 111);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Filter";
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.Controls.Add(label8);
            flowLayoutPanel4.Controls.Add(searchLicense);
            flowLayoutPanel4.Controls.Add(comboTypeLicense);
            flowLayoutPanel4.Controls.Add(comboExpiration);
            flowLayoutPanel4.Controls.Add(comboOwner);
            flowLayoutPanel4.Controls.Add(comboSupplier);
            flowLayoutPanel4.Controls.Add(btnApplyLicense);
            flowLayoutPanel4.Controls.Add(btnClearLicense);
            flowLayoutPanel4.Dock = DockStyle.Fill;
            flowLayoutPanel4.Location = new Point(3, 24);
            flowLayoutPanel4.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(861, 83);
            flowLayoutPanel4.TabIndex = 1;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Location = new Point(3, 8);
            label8.Name = "label8";
            label8.Size = new Size(56, 20);
            label8.TabIndex = 0;
            label8.Text = "Search:";
            // 
            // searchLicense
            // 
            searchLicense.Anchor = AnchorStyles.Left;
            searchLicense.Location = new Point(65, 4);
            searchLicense.Margin = new Padding(3, 4, 3, 4);
            searchLicense.Name = "searchLicense";
            searchLicense.Size = new Size(171, 27);
            searchLicense.TabIndex = 1;
            // 
            // comboTypeLicense
            // 
            comboTypeLicense.DropDownStyle = ComboBoxStyle.DropDownList;
            comboTypeLicense.FormattingEnabled = true;
            comboTypeLicense.Location = new Point(242, 4);
            comboTypeLicense.Margin = new Padding(3, 4, 3, 4);
            comboTypeLicense.Name = "comboTypeLicense";
            comboTypeLicense.Size = new Size(138, 28);
            comboTypeLicense.TabIndex = 4;
            // 
            // comboExpiration
            // 
            comboExpiration.DropDownStyle = ComboBoxStyle.DropDownList;
            comboExpiration.FormattingEnabled = true;
            comboExpiration.Location = new Point(386, 4);
            comboExpiration.Margin = new Padding(3, 4, 3, 4);
            comboExpiration.Name = "comboExpiration";
            comboExpiration.Size = new Size(138, 28);
            comboExpiration.TabIndex = 5;
            // 
            // comboOwner
            // 
            comboOwner.DropDownStyle = ComboBoxStyle.DropDownList;
            comboOwner.FormattingEnabled = true;
            comboOwner.Location = new Point(530, 4);
            comboOwner.Margin = new Padding(3, 4, 3, 4);
            comboOwner.Name = "comboOwner";
            comboOwner.Size = new Size(138, 28);
            comboOwner.TabIndex = 6;
            // 
            // comboSupplier
            // 
            comboSupplier.DropDownStyle = ComboBoxStyle.DropDownList;
            comboSupplier.FormattingEnabled = true;
            comboSupplier.Location = new Point(674, 4);
            comboSupplier.Margin = new Padding(3, 4, 3, 4);
            comboSupplier.Name = "comboSupplier";
            comboSupplier.Size = new Size(138, 28);
            comboSupplier.TabIndex = 7;
            // 
            // btnApplyLicense
            // 
            btnApplyLicense.Anchor = AnchorStyles.Left;
            btnApplyLicense.Location = new Point(3, 40);
            btnApplyLicense.Margin = new Padding(3, 4, 3, 4);
            btnApplyLicense.Name = "btnApplyLicense";
            btnApplyLicense.Size = new Size(86, 31);
            btnApplyLicense.TabIndex = 2;
            btnApplyLicense.Text = "Apply";
            btnApplyLicense.UseVisualStyleBackColor = true;
            btnApplyLicense.Click += ApplyFilterEvent;
            // 
            // btnClearLicense
            // 
            btnClearLicense.Anchor = AnchorStyles.Left;
            btnClearLicense.Enabled = false;
            btnClearLicense.Location = new Point(95, 40);
            btnClearLicense.Margin = new Padding(3, 4, 3, 4);
            btnClearLicense.Name = "btnClearLicense";
            btnClearLicense.Size = new Size(86, 31);
            btnClearLicense.TabIndex = 3;
            btnClearLicense.Text = "Clear";
            btnClearLicense.UseVisualStyleBackColor = true;
            btnClearLicense.Click += ClearFilterEvent;
            // 
            // dataGridLicense
            // 
            dataGridLicense.AllowUserToAddRows = false;
            dataGridLicense.AllowUserToDeleteRows = false;
            dataGridLicense.AutoGenerateColumns = false;
            dataGridLicense.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridLicense.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridLicense.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridLicense.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, titleDataGridViewTextBoxColumn, keyDataGridViewTextBoxColumn, typeDataGridViewTextBoxColumn, costDataGridViewTextBoxColumn, expirationDateDataGridViewTextBoxColumn, ownerIdDataGridViewTextBoxColumn, ownerDataGridViewTextBoxColumn, supplierIdDataGridViewTextBoxColumn, supplierDataGridViewTextBoxColumn, expirationStatusDataGridViewTextBoxColumn });
            dataGridLicense.DataSource = licenseBindingSource;
            dataGridLicense.Location = new Point(6, 121);
            dataGridLicense.Margin = new Padding(3, 4, 3, 4);
            dataGridLicense.Name = "dataGridLicense";
            dataGridLicense.ReadOnly = true;
            dataGridLicense.RowHeadersWidth = 51;
            dataGridLicense.Size = new Size(867, 305);
            dataGridLicense.TabIndex = 0;
            dataGridLicense.CellFormatting += LicenseCellFormatting;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Visible = false;
            idDataGridViewTextBoxColumn.Width = 42;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            titleDataGridViewTextBoxColumn.HeaderText = "Title";
            titleDataGridViewTextBoxColumn.MinimumWidth = 6;
            titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            titleDataGridViewTextBoxColumn.ReadOnly = true;
            titleDataGridViewTextBoxColumn.Width = 67;
            // 
            // keyDataGridViewTextBoxColumn
            // 
            keyDataGridViewTextBoxColumn.DataPropertyName = "Key";
            keyDataGridViewTextBoxColumn.HeaderText = "Key";
            keyDataGridViewTextBoxColumn.MinimumWidth = 6;
            keyDataGridViewTextBoxColumn.Name = "keyDataGridViewTextBoxColumn";
            keyDataGridViewTextBoxColumn.ReadOnly = true;
            keyDataGridViewTextBoxColumn.Width = 62;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            typeDataGridViewTextBoxColumn.HeaderText = "Type";
            typeDataGridViewTextBoxColumn.MinimumWidth = 6;
            typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            typeDataGridViewTextBoxColumn.ReadOnly = true;
            typeDataGridViewTextBoxColumn.Width = 69;
            // 
            // costDataGridViewTextBoxColumn
            // 
            costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            costDataGridViewTextBoxColumn.HeaderText = "Cost";
            costDataGridViewTextBoxColumn.MinimumWidth = 6;
            costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            costDataGridViewTextBoxColumn.ReadOnly = true;
            costDataGridViewTextBoxColumn.Width = 67;
            // 
            // expirationDateDataGridViewTextBoxColumn
            // 
            expirationDateDataGridViewTextBoxColumn.DataPropertyName = "ExpirationDate";
            expirationDateDataGridViewTextBoxColumn.HeaderText = "ExpirationDate";
            expirationDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            expirationDateDataGridViewTextBoxColumn.Name = "expirationDateDataGridViewTextBoxColumn";
            expirationDateDataGridViewTextBoxColumn.ReadOnly = true;
            expirationDateDataGridViewTextBoxColumn.Width = 137;
            // 
            // ownerIdDataGridViewTextBoxColumn
            // 
            ownerIdDataGridViewTextBoxColumn.DataPropertyName = "OwnerId";
            ownerIdDataGridViewTextBoxColumn.HeaderText = "OwnerId";
            ownerIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            ownerIdDataGridViewTextBoxColumn.Name = "ownerIdDataGridViewTextBoxColumn";
            ownerIdDataGridViewTextBoxColumn.ReadOnly = true;
            ownerIdDataGridViewTextBoxColumn.Visible = false;
            ownerIdDataGridViewTextBoxColumn.Width = 77;
            // 
            // ownerDataGridViewTextBoxColumn
            // 
            ownerDataGridViewTextBoxColumn.DataPropertyName = "Owner";
            ownerDataGridViewTextBoxColumn.HeaderText = "Owner";
            ownerDataGridViewTextBoxColumn.MinimumWidth = 6;
            ownerDataGridViewTextBoxColumn.Name = "ownerDataGridViewTextBoxColumn";
            ownerDataGridViewTextBoxColumn.ReadOnly = true;
            ownerDataGridViewTextBoxColumn.Width = 81;
            // 
            // supplierIdDataGridViewTextBoxColumn
            // 
            supplierIdDataGridViewTextBoxColumn.DataPropertyName = "SupplierId";
            supplierIdDataGridViewTextBoxColumn.HeaderText = "SupplierId";
            supplierIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            supplierIdDataGridViewTextBoxColumn.Name = "supplierIdDataGridViewTextBoxColumn";
            supplierIdDataGridViewTextBoxColumn.ReadOnly = true;
            supplierIdDataGridViewTextBoxColumn.Visible = false;
            supplierIdDataGridViewTextBoxColumn.Width = 85;
            // 
            // supplierDataGridViewTextBoxColumn
            // 
            supplierDataGridViewTextBoxColumn.DataPropertyName = "Supplier";
            supplierDataGridViewTextBoxColumn.HeaderText = "Supplier";
            supplierDataGridViewTextBoxColumn.MinimumWidth = 6;
            supplierDataGridViewTextBoxColumn.Name = "supplierDataGridViewTextBoxColumn";
            supplierDataGridViewTextBoxColumn.ReadOnly = true;
            supplierDataGridViewTextBoxColumn.Width = 93;
            // 
            // expirationStatusDataGridViewTextBoxColumn
            // 
            expirationStatusDataGridViewTextBoxColumn.DataPropertyName = "ExpirationStatus";
            expirationStatusDataGridViewTextBoxColumn.HeaderText = "ExpirationStatus";
            expirationStatusDataGridViewTextBoxColumn.MinimumWidth = 6;
            expirationStatusDataGridViewTextBoxColumn.Name = "expirationStatusDataGridViewTextBoxColumn";
            expirationStatusDataGridViewTextBoxColumn.ReadOnly = true;
            expirationStatusDataGridViewTextBoxColumn.Visible = false;
            expirationStatusDataGridViewTextBoxColumn.Width = 117;
            // 
            // licenseBindingSource
            // 
            licenseBindingSource.DataSource = typeof(LicenseHub.Models.License);
            // 
            // ownerPage
            // 
            ownerPage.Controls.Add(groupBox1);
            ownerPage.Controls.Add(dataGridOwner);
            ownerPage.Location = new Point(4, 29);
            ownerPage.Margin = new Padding(3, 4, 3, 4);
            ownerPage.Name = "ownerPage";
            ownerPage.Padding = new Padding(3, 4, 3, 4);
            ownerPage.Size = new Size(879, 436);
            ownerPage.TabIndex = 1;
            ownerPage.Text = "Owners";
            ownerPage.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(flowLayoutPanel3);
            groupBox1.Location = new Point(6, 7);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(867, 84);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filter";
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(label7);
            flowLayoutPanel3.Controls.Add(searchOwner);
            flowLayoutPanel3.Controls.Add(comboDepartment);
            flowLayoutPanel3.Controls.Add(btnApplyOwner);
            flowLayoutPanel3.Controls.Add(btnClearOwner);
            flowLayoutPanel3.Dock = DockStyle.Fill;
            flowLayoutPanel3.Location = new Point(3, 24);
            flowLayoutPanel3.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(861, 56);
            flowLayoutPanel3.TabIndex = 1;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Location = new Point(3, 9);
            label7.Name = "label7";
            label7.Size = new Size(56, 20);
            label7.TabIndex = 0;
            label7.Text = "Search:";
            // 
            // searchOwner
            // 
            searchOwner.Anchor = AnchorStyles.Left;
            searchOwner.Location = new Point(65, 6);
            searchOwner.Margin = new Padding(3, 4, 3, 4);
            searchOwner.Name = "searchOwner";
            searchOwner.Size = new Size(171, 27);
            searchOwner.TabIndex = 1;
            // 
            // comboDepartment
            // 
            comboDepartment.DropDownStyle = ComboBoxStyle.DropDownList;
            comboDepartment.FormattingEnabled = true;
            comboDepartment.Location = new Point(242, 4);
            comboDepartment.Margin = new Padding(3, 4, 3, 4);
            comboDepartment.Name = "comboDepartment";
            comboDepartment.Size = new Size(171, 28);
            comboDepartment.TabIndex = 4;
            // 
            // btnApplyOwner
            // 
            btnApplyOwner.Anchor = AnchorStyles.Left;
            btnApplyOwner.Location = new Point(419, 4);
            btnApplyOwner.Margin = new Padding(3, 4, 3, 4);
            btnApplyOwner.Name = "btnApplyOwner";
            btnApplyOwner.Size = new Size(86, 31);
            btnApplyOwner.TabIndex = 2;
            btnApplyOwner.Text = "Apply";
            btnApplyOwner.UseVisualStyleBackColor = true;
            btnApplyOwner.Click += ApplyFilterEvent;
            // 
            // btnClearOwner
            // 
            btnClearOwner.Anchor = AnchorStyles.Left;
            btnClearOwner.Enabled = false;
            btnClearOwner.Location = new Point(511, 4);
            btnClearOwner.Margin = new Padding(3, 4, 3, 4);
            btnClearOwner.Name = "btnClearOwner";
            btnClearOwner.Size = new Size(86, 31);
            btnClearOwner.TabIndex = 3;
            btnClearOwner.Text = "Clear";
            btnClearOwner.UseVisualStyleBackColor = true;
            btnClearOwner.Click += ClearFilterEvent;
            // 
            // dataGridOwner
            // 
            dataGridOwner.AllowUserToAddRows = false;
            dataGridOwner.AllowUserToDeleteRows = false;
            dataGridOwner.AutoGenerateColumns = false;
            dataGridOwner.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridOwner.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridOwner.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridOwner.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn1, firstNameDataGridViewTextBoxColumn, lastNameDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn, departmentIdDataGridViewTextBoxColumn, departmentDataGridViewTextBoxColumn, licensesDataGridViewTextBoxColumn });
            dataGridOwner.DataSource = ownerBindingSource;
            dataGridOwner.Location = new Point(6, 99);
            dataGridOwner.Margin = new Padding(3, 4, 3, 4);
            dataGridOwner.Name = "dataGridOwner";
            dataGridOwner.ReadOnly = true;
            dataGridOwner.RowHeadersWidth = 51;
            dataGridOwner.Size = new Size(867, 328);
            dataGridOwner.TabIndex = 2;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn1.HeaderText = "Id";
            idDataGridViewTextBoxColumn1.MinimumWidth = 6;
            idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            idDataGridViewTextBoxColumn1.ReadOnly = true;
            idDataGridViewTextBoxColumn1.Visible = false;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn.HeaderText = "Email";
            emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // departmentIdDataGridViewTextBoxColumn
            // 
            departmentIdDataGridViewTextBoxColumn.DataPropertyName = "DepartmentId";
            departmentIdDataGridViewTextBoxColumn.HeaderText = "DepartmentId";
            departmentIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            departmentIdDataGridViewTextBoxColumn.Name = "departmentIdDataGridViewTextBoxColumn";
            departmentIdDataGridViewTextBoxColumn.ReadOnly = true;
            departmentIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // departmentDataGridViewTextBoxColumn
            // 
            departmentDataGridViewTextBoxColumn.DataPropertyName = "Department";
            departmentDataGridViewTextBoxColumn.HeaderText = "Department";
            departmentDataGridViewTextBoxColumn.MinimumWidth = 6;
            departmentDataGridViewTextBoxColumn.Name = "departmentDataGridViewTextBoxColumn";
            departmentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // licensesDataGridViewTextBoxColumn
            // 
            licensesDataGridViewTextBoxColumn.DataPropertyName = "Licenses";
            licensesDataGridViewTextBoxColumn.HeaderText = "Licenses";
            licensesDataGridViewTextBoxColumn.MinimumWidth = 6;
            licensesDataGridViewTextBoxColumn.Name = "licensesDataGridViewTextBoxColumn";
            licensesDataGridViewTextBoxColumn.ReadOnly = true;
            licensesDataGridViewTextBoxColumn.Visible = false;
            // 
            // ownerBindingSource
            // 
            ownerBindingSource.DataSource = typeof(LicenseHub.Models.Owner);
            // 
            // supplierPage
            // 
            supplierPage.Controls.Add(groupBox3);
            supplierPage.Controls.Add(dataGridSupplier);
            supplierPage.Location = new Point(4, 29);
            supplierPage.Margin = new Padding(3, 4, 3, 4);
            supplierPage.Name = "supplierPage";
            supplierPage.Padding = new Padding(3, 4, 3, 4);
            supplierPage.Size = new Size(879, 436);
            supplierPage.TabIndex = 2;
            supplierPage.Text = "Suppliers";
            supplierPage.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(flowLayoutPanel2);
            groupBox3.Location = new Point(6, 7);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(867, 84);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Filter";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(label6);
            flowLayoutPanel2.Controls.Add(searchSupplier);
            flowLayoutPanel2.Controls.Add(btnApplySupplier);
            flowLayoutPanel2.Controls.Add(btnClearSupplier);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Location = new Point(3, 24);
            flowLayoutPanel2.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(861, 56);
            flowLayoutPanel2.TabIndex = 1;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Location = new Point(3, 9);
            label6.Name = "label6";
            label6.Size = new Size(56, 20);
            label6.TabIndex = 0;
            label6.Text = "Search:";
            // 
            // searchSupplier
            // 
            searchSupplier.Anchor = AnchorStyles.Left;
            searchSupplier.Location = new Point(65, 6);
            searchSupplier.Margin = new Padding(3, 4, 3, 4);
            searchSupplier.Name = "searchSupplier";
            searchSupplier.Size = new Size(171, 27);
            searchSupplier.TabIndex = 1;
            // 
            // btnApplySupplier
            // 
            btnApplySupplier.Anchor = AnchorStyles.Left;
            btnApplySupplier.Location = new Point(242, 4);
            btnApplySupplier.Margin = new Padding(3, 4, 3, 4);
            btnApplySupplier.Name = "btnApplySupplier";
            btnApplySupplier.Size = new Size(86, 31);
            btnApplySupplier.TabIndex = 2;
            btnApplySupplier.Text = "Apply";
            btnApplySupplier.UseVisualStyleBackColor = true;
            btnApplySupplier.Click += ApplyFilterEvent;
            // 
            // btnClearSupplier
            // 
            btnClearSupplier.Anchor = AnchorStyles.Left;
            btnClearSupplier.Enabled = false;
            btnClearSupplier.Location = new Point(334, 4);
            btnClearSupplier.Margin = new Padding(3, 4, 3, 4);
            btnClearSupplier.Name = "btnClearSupplier";
            btnClearSupplier.Size = new Size(86, 31);
            btnClearSupplier.TabIndex = 3;
            btnClearSupplier.Text = "Clear";
            btnClearSupplier.UseVisualStyleBackColor = true;
            btnClearSupplier.Click += ClearFilterEvent;
            // 
            // dataGridSupplier
            // 
            dataGridSupplier.AllowUserToAddRows = false;
            dataGridSupplier.AllowUserToDeleteRows = false;
            dataGridSupplier.AutoGenerateColumns = false;
            dataGridSupplier.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridSupplier.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridSupplier.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridSupplier.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn2, nameDataGridViewTextBoxColumn, contactEmailDataGridViewTextBoxColumn, contactPhoneDataGridViewTextBoxColumn, licensesDataGridViewTextBoxColumn1 });
            dataGridSupplier.DataSource = supplierBindingSource;
            dataGridSupplier.Location = new Point(6, 99);
            dataGridSupplier.Margin = new Padding(3, 4, 3, 4);
            dataGridSupplier.Name = "dataGridSupplier";
            dataGridSupplier.ReadOnly = true;
            dataGridSupplier.RowHeadersWidth = 51;
            dataGridSupplier.Size = new Size(867, 328);
            dataGridSupplier.TabIndex = 2;
            // 
            // idDataGridViewTextBoxColumn2
            // 
            idDataGridViewTextBoxColumn2.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn2.HeaderText = "Id";
            idDataGridViewTextBoxColumn2.MinimumWidth = 6;
            idDataGridViewTextBoxColumn2.Name = "idDataGridViewTextBoxColumn2";
            idDataGridViewTextBoxColumn2.ReadOnly = true;
            idDataGridViewTextBoxColumn2.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contactEmailDataGridViewTextBoxColumn
            // 
            contactEmailDataGridViewTextBoxColumn.DataPropertyName = "ContactEmail";
            contactEmailDataGridViewTextBoxColumn.HeaderText = "ContactEmail";
            contactEmailDataGridViewTextBoxColumn.MinimumWidth = 6;
            contactEmailDataGridViewTextBoxColumn.Name = "contactEmailDataGridViewTextBoxColumn";
            contactEmailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contactPhoneDataGridViewTextBoxColumn
            // 
            contactPhoneDataGridViewTextBoxColumn.DataPropertyName = "ContactPhone";
            contactPhoneDataGridViewTextBoxColumn.HeaderText = "ContactPhone";
            contactPhoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            contactPhoneDataGridViewTextBoxColumn.Name = "contactPhoneDataGridViewTextBoxColumn";
            contactPhoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // licensesDataGridViewTextBoxColumn1
            // 
            licensesDataGridViewTextBoxColumn1.DataPropertyName = "Licenses";
            licensesDataGridViewTextBoxColumn1.HeaderText = "Licenses";
            licensesDataGridViewTextBoxColumn1.MinimumWidth = 6;
            licensesDataGridViewTextBoxColumn1.Name = "licensesDataGridViewTextBoxColumn1";
            licensesDataGridViewTextBoxColumn1.ReadOnly = true;
            licensesDataGridViewTextBoxColumn1.Visible = false;
            // 
            // supplierBindingSource
            // 
            supplierBindingSource.DataSource = typeof(LicenseHub.Models.Supplier);
            // 
            // departmentPage
            // 
            departmentPage.Controls.Add(groupBox4);
            departmentPage.Controls.Add(dataGridDepartment);
            departmentPage.Location = new Point(4, 29);
            departmentPage.Margin = new Padding(3, 4, 3, 4);
            departmentPage.Name = "departmentPage";
            departmentPage.Padding = new Padding(3, 4, 3, 4);
            departmentPage.Size = new Size(879, 436);
            departmentPage.TabIndex = 3;
            departmentPage.Text = "Departments";
            departmentPage.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(flowLayoutPanel1);
            groupBox4.Location = new Point(6, 7);
            groupBox4.Margin = new Padding(3, 4, 3, 4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 4, 3, 4);
            groupBox4.Size = new Size(867, 84);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Filter";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label5);
            flowLayoutPanel1.Controls.Add(searchDepartment);
            flowLayoutPanel1.Controls.Add(btnApplyDepartment);
            flowLayoutPanel1.Controls.Add(btnClearDepartment);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 24);
            flowLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(861, 56);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Location = new Point(3, 9);
            label5.Name = "label5";
            label5.Size = new Size(56, 20);
            label5.TabIndex = 0;
            label5.Text = "Search:";
            // 
            // searchDepartment
            // 
            searchDepartment.Anchor = AnchorStyles.Left;
            searchDepartment.Location = new Point(65, 6);
            searchDepartment.Margin = new Padding(3, 4, 3, 4);
            searchDepartment.Name = "searchDepartment";
            searchDepartment.Size = new Size(171, 27);
            searchDepartment.TabIndex = 1;
            // 
            // btnApplyDepartment
            // 
            btnApplyDepartment.Anchor = AnchorStyles.Left;
            btnApplyDepartment.Location = new Point(242, 4);
            btnApplyDepartment.Margin = new Padding(3, 4, 3, 4);
            btnApplyDepartment.Name = "btnApplyDepartment";
            btnApplyDepartment.Size = new Size(86, 31);
            btnApplyDepartment.TabIndex = 2;
            btnApplyDepartment.Text = "Apply";
            btnApplyDepartment.UseVisualStyleBackColor = true;
            btnApplyDepartment.Click += ApplyFilterEvent;
            // 
            // btnClearDepartment
            // 
            btnClearDepartment.Anchor = AnchorStyles.Left;
            btnClearDepartment.Enabled = false;
            btnClearDepartment.Location = new Point(334, 4);
            btnClearDepartment.Margin = new Padding(3, 4, 3, 4);
            btnClearDepartment.Name = "btnClearDepartment";
            btnClearDepartment.Size = new Size(86, 31);
            btnClearDepartment.TabIndex = 3;
            btnClearDepartment.Text = "Clear";
            btnClearDepartment.UseVisualStyleBackColor = true;
            btnClearDepartment.Click += ClearFilterEvent;
            // 
            // dataGridDepartment
            // 
            dataGridDepartment.AllowUserToAddRows = false;
            dataGridDepartment.AllowUserToDeleteRows = false;
            dataGridDepartment.AutoGenerateColumns = false;
            dataGridDepartment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridDepartment.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridDepartment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridDepartment.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn3, nameDataGridViewTextBoxColumn1, ownersDataGridViewTextBoxColumn });
            dataGridDepartment.DataSource = departmentBindingSource;
            dataGridDepartment.Location = new Point(6, 99);
            dataGridDepartment.Margin = new Padding(3, 4, 3, 4);
            dataGridDepartment.Name = "dataGridDepartment";
            dataGridDepartment.ReadOnly = true;
            dataGridDepartment.RowHeadersWidth = 51;
            dataGridDepartment.Size = new Size(867, 328);
            dataGridDepartment.TabIndex = 2;
            // 
            // idDataGridViewTextBoxColumn3
            // 
            idDataGridViewTextBoxColumn3.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn3.HeaderText = "Id";
            idDataGridViewTextBoxColumn3.MinimumWidth = 6;
            idDataGridViewTextBoxColumn3.Name = "idDataGridViewTextBoxColumn3";
            idDataGridViewTextBoxColumn3.ReadOnly = true;
            idDataGridViewTextBoxColumn3.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            nameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            nameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // ownersDataGridViewTextBoxColumn
            // 
            ownersDataGridViewTextBoxColumn.DataPropertyName = "Owners";
            ownersDataGridViewTextBoxColumn.HeaderText = "Owners";
            ownersDataGridViewTextBoxColumn.MinimumWidth = 6;
            ownersDataGridViewTextBoxColumn.Name = "ownersDataGridViewTextBoxColumn";
            ownersDataGridViewTextBoxColumn.ReadOnly = true;
            ownersDataGridViewTextBoxColumn.Visible = false;
            // 
            // departmentBindingSource
            // 
            departmentBindingSource.DataSource = typeof(LicenseHub.Models.Department);
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75.15151F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.848484F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(lblTotalLicenses, 1, 0);
            tableLayoutPanel1.Controls.Add(lblExpire30Days, 1, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(lblExpired, 1, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(2, 3);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(183, 61);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 0;
            label1.Text = "Total licenses:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(3, 20);
            label2.Name = "label2";
            label2.Size = new Size(129, 20);
            label2.TabIndex = 1;
            label2.Text = "Expires in 30 days:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotalLicenses
            // 
            lblTotalLicenses.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblTotalLicenses.AutoSize = true;
            lblTotalLicenses.Location = new Point(163, 0);
            lblTotalLicenses.Name = "lblTotalLicenses";
            lblTotalLicenses.Size = new Size(17, 20);
            lblTotalLicenses.TabIndex = 2;
            lblTotalLicenses.Text = "0";
            lblTotalLicenses.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblExpire30Days
            // 
            lblExpire30Days.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblExpire30Days.AutoSize = true;
            lblExpire30Days.Location = new Point(163, 20);
            lblExpire30Days.Name = "lblExpire30Days";
            lblExpire30Days.Size = new Size(17, 20);
            lblExpire30Days.TabIndex = 3;
            lblExpire30Days.Text = "0";
            lblExpire30Days.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(3, 40);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 4;
            label3.Text = "Expired:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblExpired
            // 
            lblExpired.Anchor = AnchorStyles.Right;
            lblExpired.AutoSize = true;
            lblExpired.Location = new Point(163, 40);
            lblExpired.Name = "lblExpired";
            lblExpired.Size = new Size(17, 20);
            lblExpired.TabIndex = 5;
            lblExpired.Text = "0";
            lblExpired.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Location = new Point(711, 532);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(2, 3, 2, 3);
            panel1.Size = new Size(189, 69);
            panel1.TabIndex = 3;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 614);
            Controls.Add(tabControl);
            Controls.Add(panel1);
            Controls.Add(toolStrip1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
            Text = "LicenseHub";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            tabControl.ResumeLayout(false);
            licensePage.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridLicense).EndInit();
            ((System.ComponentModel.ISupportInitialize)licenseBindingSource).EndInit();
            ownerPage.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridOwner).EndInit();
            ((System.ComponentModel.ISupportInitialize)ownerBindingSource).EndInit();
            supplierPage.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridSupplier).EndInit();
            ((System.ComponentModel.ISupportInitialize)supplierBindingSource).EndInit();
            departmentPage.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridDepartment).EndInit();
            ((System.ComponentModel.ISupportInitialize)departmentBindingSource).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton btnAddEntry;
        private ToolStripButton btnModifyEntry;
        private ToolStripButton btnDeleteEntry;
        private TabControl tabControl;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label lblTotalLicenses;
        private Label lblExpire30Days;
        private Panel panel1;
        private TabPage licensePage;
        private DataGridView dataGridLicense;
        private GroupBox groupBox2;
        private TabPage ownerPage;
        private GroupBox groupBox1;
        private DataGridView dataGridOwner;
        private TabPage supplierPage;
        private GroupBox groupBox3;
        private DataGridView dataGridSupplier;
        private TabPage departmentPage;
        private GroupBox groupBox4;
        private DataGridView dataGridDepartment;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label5;
        private TextBox searchDepartment;
        private Button btnApplyDepartment;
        private Button btnClearDepartment;
        private FlowLayoutPanel flowLayoutPanel3;
        private Label label7;
        private TextBox searchOwner;
        private ComboBox comboDepartment;
        private Button btnApplyOwner;
        private Button btnClearOwner;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label label6;
        private TextBox searchSupplier;
        private Button btnApplySupplier;
        private Button btnClearSupplier;
        private FlowLayoutPanel flowLayoutPanel4;
        private Label label8;
        private TextBox searchLicense;
        private ComboBox comboTypeLicense;
        private ComboBox comboExpiration;
        private ComboBox comboOwner;
        private ComboBox comboSupplier;
        private Button btnApplyLicense;
        private Button btnClearLicense;
        private BindingSource licenseBindingSource;
        private BindingSource ownerBindingSource;
        private BindingSource supplierBindingSource;
        private BindingSource departmentBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn departmentIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn departmentDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn licensesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn contactEmailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn contactPhoneDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn licensesDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn ownersDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn keyDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn expirationDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ownerIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ownerDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn supplierIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn supplierDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn expirationStatusDataGridViewTextBoxColumn;
        private Label label3;
        private Label lblExpired;
    }
}
