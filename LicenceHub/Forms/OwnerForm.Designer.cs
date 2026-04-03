namespace LicenseHub.Forms
{
    partial class OwnerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OwnerForm));
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            comboDepartment = new ComboBox();
            txtEmail = new TextBox();
            btnAddDepartment = new Button();
            btnApply = new Button();
            btnCancel = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 88F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 31F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(txtFirstName, 1, 0);
            tableLayoutPanel1.Controls.Add(txtLastName, 1, 1);
            tableLayoutPanel1.Controls.Add(comboDepartment, 1, 3);
            tableLayoutPanel1.Controls.Add(txtEmail, 1, 2);
            tableLayoutPanel1.Controls.Add(btnAddDepartment, 2, 3);
            tableLayoutPanel1.Location = new Point(10, 9);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(299, 152);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(67, 38);
            label1.TabIndex = 0;
            label1.Text = "First Name:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(3, 38);
            label2.Name = "label2";
            label2.Size = new Size(66, 38);
            label2.TabIndex = 1;
            label2.Text = "Last Name:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(3, 76);
            label3.Name = "label3";
            label3.Size = new Size(44, 38);
            label3.TabIndex = 2;
            label3.Text = "E-mail:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(3, 114);
            label4.Name = "label4";
            label4.Size = new Size(73, 38);
            label4.TabIndex = 3;
            label4.Text = "Department:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtFirstName
            // 
            txtFirstName.Anchor = AnchorStyles.Right;
            txtFirstName.Location = new Point(98, 7);
            txtFirstName.Margin = new Padding(3, 2, 3, 2);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(167, 23);
            txtFirstName.TabIndex = 4;
            // 
            // txtLastName
            // 
            txtLastName.Anchor = AnchorStyles.Right;
            txtLastName.Location = new Point(98, 45);
            txtLastName.Margin = new Padding(3, 2, 3, 2);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(167, 23);
            txtLastName.TabIndex = 5;
            // 
            // comboDepartment
            // 
            comboDepartment.Anchor = AnchorStyles.Right;
            comboDepartment.DropDownStyle = ComboBoxStyle.DropDownList;
            comboDepartment.FormattingEnabled = true;
            comboDepartment.Location = new Point(98, 121);
            comboDepartment.Margin = new Padding(3, 2, 3, 2);
            comboDepartment.Name = "comboDepartment";
            comboDepartment.Size = new Size(167, 23);
            comboDepartment.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Right;
            txtEmail.Location = new Point(98, 83);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(167, 23);
            txtEmail.TabIndex = 7;
            // 
            // btnAddDepartment
            // 
            btnAddDepartment.Anchor = AnchorStyles.Right;
            btnAddDepartment.Location = new Point(271, 122);
            btnAddDepartment.Margin = new Padding(3, 2, 3, 2);
            btnAddDepartment.Name = "btnAddDepartment";
            btnAddDepartment.Size = new Size(25, 22);
            btnAddDepartment.TabIndex = 8;
            btnAddDepartment.Text = "+";
            btnAddDepartment.UseVisualStyleBackColor = true;
            // 
            // btnApply
            // 
            btnApply.Location = new Point(83, 166);
            btnApply.Margin = new Padding(3, 2, 3, 2);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(82, 22);
            btnApply.TabIndex = 1;
            btnApply.Text = "Apply";
            btnApply.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(171, 166);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(82, 22);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // OwnerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(320, 196);
            Controls.Add(btnCancel);
            Controls.Add(btnApply);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "OwnerForm";
            Text = "Add/Modify Owner";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private ComboBox comboDepartment;
        private TextBox txtEmail;
        private Button btnAddDepartment;
        private Button btnApply;
        private Button btnCancel;
    }
}