namespace LicenseHub.Forms
{
    partial class LicenseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LicenseForm));
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtTitle = new TextBox();
            comboType = new ComboBox();
            numPrice = new NumericUpDown();
            datePicker = new DateTimePicker();
            comboOwner = new ComboBox();
            comboSupplier = new ComboBox();
            btnAddOwner = new Button();
            btnAddSupplier = new Button();
            txtKey = new TextBox();
            btnApply = new Button();
            btnCancel = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numPrice).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 124F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 31F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(label5, 0, 4);
            tableLayoutPanel1.Controls.Add(label6, 0, 5);
            tableLayoutPanel1.Controls.Add(label7, 0, 6);
            tableLayoutPanel1.Controls.Add(txtTitle, 1, 0);
            tableLayoutPanel1.Controls.Add(comboType, 1, 2);
            tableLayoutPanel1.Controls.Add(numPrice, 1, 3);
            tableLayoutPanel1.Controls.Add(datePicker, 1, 4);
            tableLayoutPanel1.Controls.Add(comboOwner, 1, 5);
            tableLayoutPanel1.Controls.Add(comboSupplier, 1, 6);
            tableLayoutPanel1.Controls.Add(btnAddOwner, 2, 5);
            tableLayoutPanel1.Controls.Add(btnAddSupplier, 2, 6);
            tableLayoutPanel1.Controls.Add(txtKey, 1, 1);
            tableLayoutPanel1.Location = new Point(10, 9);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857113F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857161F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857161F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857161F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857161F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857161F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857161F));
            tableLayoutPanel1.Size = new Size(386, 245);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(32, 34);
            label1.TabIndex = 0;
            label1.Text = "Title:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(3, 34);
            label2.Name = "label2";
            label2.Size = new Size(71, 35);
            label2.TabIndex = 1;
            label2.Text = "License Key:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(3, 69);
            label3.Name = "label3";
            label3.Size = new Size(76, 35);
            label3.TabIndex = 2;
            label3.Text = "License Type:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(3, 104);
            label4.Name = "label4";
            label4.Size = new Size(103, 35);
            label4.TabIndex = 3;
            label4.Text = "Price (per month):";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Location = new Point(3, 139);
            label5.Name = "label5";
            label5.Size = new Size(90, 35);
            label5.TabIndex = 4;
            label5.Text = "Expiration Date:";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Location = new Point(3, 174);
            label6.Name = "label6";
            label6.Size = new Size(45, 35);
            label6.TabIndex = 5;
            label6.Text = "Owner:";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Location = new Point(3, 209);
            label7.Name = "label7";
            label7.Size = new Size(53, 36);
            label7.TabIndex = 6;
            label7.Text = "Supplier:";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtTitle
            // 
            txtTitle.Anchor = AnchorStyles.Right;
            txtTitle.Location = new Point(133, 5);
            txtTitle.Margin = new Padding(3, 2, 3, 2);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(219, 23);
            txtTitle.TabIndex = 7;
            // 
            // comboType
            // 
            comboType.Anchor = AnchorStyles.Right;
            comboType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboType.FormattingEnabled = true;
            comboType.Location = new Point(133, 75);
            comboType.Margin = new Padding(3, 2, 3, 2);
            comboType.Name = "comboType";
            comboType.Size = new Size(219, 23);
            comboType.TabIndex = 9;
            // 
            // numPrice
            // 
            numPrice.Anchor = AnchorStyles.Right;
            numPrice.Location = new Point(133, 110);
            numPrice.Margin = new Padding(3, 2, 3, 2);
            numPrice.Name = "numPrice";
            numPrice.Size = new Size(219, 23);
            numPrice.TabIndex = 10;
            // 
            // datePicker
            // 
            datePicker.Anchor = AnchorStyles.Right;
            datePicker.Format = DateTimePickerFormat.Short;
            datePicker.Location = new Point(133, 145);
            datePicker.Margin = new Padding(3, 2, 3, 2);
            datePicker.MinDate = new DateTime(1950, 1, 1, 0, 0, 0, 0);
            datePicker.Name = "datePicker";
            datePicker.Size = new Size(219, 23);
            datePicker.TabIndex = 11;
            datePicker.Value = new DateTime(2026, 4, 1, 10, 40, 24, 0);
            // 
            // comboOwner
            // 
            comboOwner.Anchor = AnchorStyles.Right;
            comboOwner.DropDownStyle = ComboBoxStyle.DropDownList;
            comboOwner.FormattingEnabled = true;
            comboOwner.Location = new Point(133, 180);
            comboOwner.Margin = new Padding(3, 2, 3, 2);
            comboOwner.Name = "comboOwner";
            comboOwner.Size = new Size(219, 23);
            comboOwner.TabIndex = 12;
            // 
            // comboSupplier
            // 
            comboSupplier.Anchor = AnchorStyles.Right;
            comboSupplier.DropDownStyle = ComboBoxStyle.DropDownList;
            comboSupplier.FormattingEnabled = true;
            comboSupplier.Location = new Point(133, 215);
            comboSupplier.Margin = new Padding(3, 2, 3, 2);
            comboSupplier.Name = "comboSupplier";
            comboSupplier.Size = new Size(219, 23);
            comboSupplier.TabIndex = 13;
            // 
            // btnAddOwner
            // 
            btnAddOwner.Anchor = AnchorStyles.Left;
            btnAddOwner.Location = new Point(358, 180);
            btnAddOwner.Margin = new Padding(3, 2, 3, 2);
            btnAddOwner.Name = "btnAddOwner";
            btnAddOwner.Size = new Size(25, 22);
            btnAddOwner.TabIndex = 15;
            btnAddOwner.Text = "+";
            btnAddOwner.UseVisualStyleBackColor = true;
            btnAddOwner.Click += AddOwnerEvent;
            // 
            // btnAddSupplier
            // 
            btnAddSupplier.Anchor = AnchorStyles.Left;
            btnAddSupplier.Location = new Point(358, 216);
            btnAddSupplier.Margin = new Padding(3, 2, 3, 2);
            btnAddSupplier.Name = "btnAddSupplier";
            btnAddSupplier.Size = new Size(25, 22);
            btnAddSupplier.TabIndex = 16;
            btnAddSupplier.Text = "+";
            btnAddSupplier.UseVisualStyleBackColor = true;
            btnAddSupplier.Click += AddSupplierEvent;
            // 
            // txtKey
            // 
            txtKey.Anchor = AnchorStyles.Right;
            txtKey.Location = new Point(133, 40);
            txtKey.Margin = new Padding(3, 2, 3, 2);
            txtKey.Name = "txtKey";
            txtKey.Size = new Size(219, 23);
            txtKey.TabIndex = 17;
            // 
            // btnApply
            // 
            btnApply.Location = new Point(119, 259);
            btnApply.Margin = new Padding(3, 2, 3, 2);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(82, 22);
            btnApply.TabIndex = 1;
            btnApply.Text = "Apply";
            btnApply.UseVisualStyleBackColor = true;
            btnApply.Click += ApplyEvent;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(206, 259);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(82, 22);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += CancelEvent;
            // 
            // LicenseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(407, 287);
            Controls.Add(btnCancel);
            Controls.Add(btnApply);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LicenseForm";
            Text = "Add/Modify License";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numPrice).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtTitle;
        private ComboBox comboType;
        private NumericUpDown numPrice;
        private DateTimePicker datePicker;
        private ComboBox comboOwner;
        private ComboBox comboSupplier;
        private Button btnAddOwner;
        private Button btnAddSupplier;
        private Button btnApply;
        private Button btnCancel;
        private TextBox txtKey;
    }
}