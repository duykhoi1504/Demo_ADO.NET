﻿namespace PresentationLayer
{
    partial class FrmIngredient
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
            label1 = new Label();
            dgvIngredients = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            btnClear = new Button();
            btnAdd = new Button();
            cbStatus = new ComboBox();
            label7 = new Label();
            panel2 = new Panel();
            txtQuantity = new TextBox();
            label3 = new Label();
            panel1 = new Panel();
            txtUnit = new TextBox();
            label2 = new Label();
            panel3 = new Panel();
            dtpEXP = new DateTimePicker();
            txtName = new TextBox();
            label6 = new Label();
            cbSupplier = new ComboBox();
            label9 = new Label();
            label5 = new Label();
            panel4 = new Panel();
            txtID = new TextBox();
            label4 = new Label();
            groupBox2 = new GroupBox();
            btnFilterbySupp = new Button();
            cbFilterbySup = new ComboBox();
            groupBox3 = new GroupBox();
            btnFilterbyStatus = new Button();
            cbFilterbyStatus = new ComboBox();
            groupBox4 = new GroupBox();
            btnTransaction = new Button();
            btnExport = new Button();
            btnImport = new Button();
            panel5 = new Panel();
            panel6 = new Panel();
            txtSearch = new TextBox();
            pictureBox1 = new PictureBox();
            btnAllProds = new Button();
            usIngredientDetail1 = new USIngredientDetail();
            usUpdateTransaction1 = new USUpdateTransaction();
            ((System.ComponentModel.ISupportInitialize)dgvIngredients).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(7, 6);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(210, 48);
            label1.TabIndex = 2;
            label1.Text = "Ingredients";
            // 
            // dgvIngredients
            // 
            dgvIngredients.BackgroundColor = Color.SeaGreen;
            dgvIngredients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvIngredients.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            dgvIngredients.Location = new Point(7, 60);
            dgvIngredients.Margin = new Padding(2);
            dgvIngredients.Name = "dgvIngredients";
            dgvIngredients.RowHeadersWidth = 82;
            dgvIngredients.Size = new Size(1181, 326);
            dgvIngredients.TabIndex = 3;
            dgvIngredients.CellContentClick += dgvIngredients_CellContentClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "id";
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 10;
            Column1.Name = "Column1";
            Column1.Width = 200;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "name";
            Column2.HeaderText = "Name";
            Column2.MinimumWidth = 10;
            Column2.Name = "Column2";
            Column2.Width = 200;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "unit";
            Column3.HeaderText = "Unit";
            Column3.MinimumWidth = 10;
            Column3.Name = "Column3";
            Column3.Width = 200;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "quantity";
            Column4.HeaderText = "Quantity";
            Column4.MinimumWidth = 10;
            Column4.Name = "Column4";
            Column4.Width = 200;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "expirationDate";
            Column5.HeaderText = "EXP";
            Column5.MinimumWidth = 10;
            Column5.Name = "Column5";
            Column5.Width = 200;
            // 
            // Column6
            // 
            Column6.DataPropertyName = "status";
            Column6.HeaderText = "Status";
            Column6.MinimumWidth = 10;
            Column6.Name = "Column6";
            Column6.Width = 200;
            // 
            // Column7
            // 
            Column7.DataPropertyName = "supplierID";
            Column7.HeaderText = "Supplier";
            Column7.MinimumWidth = 10;
            Column7.Name = "Column7";
            Column7.Width = 200;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnClear);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(cbStatus);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(panel2);
            groupBox1.Controls.Add(txtQuantity);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(panel1);
            groupBox1.Controls.Add(txtUnit);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(panel3);
            groupBox1.Controls.Add(dtpEXP);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(cbSupplier);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(panel4);
            groupBox1.Controls.Add(txtID);
            groupBox1.Controls.Add(label4);
            groupBox1.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(7, 456);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(1181, 117);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add Ingredient";
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.White;
            btnClear.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.SeaGreen;
            btnClear.Location = new Point(1075, 72);
            btnClear.Margin = new Padding(2);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(80, 31);
            btnClear.TabIndex = 70;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.White;
            btnAdd.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.SeaGreen;
            btnAdd.Location = new Point(980, 73);
            btnAdd.Margin = new Padding(2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(80, 31);
            btnAdd.TabIndex = 69;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // cbStatus
            // 
            cbStatus.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbStatus.FormattingEnabled = true;
            cbStatus.Items.AddRange(new object[] { "STOCK", "OUT_OF_STOCK", "LOW_STOCK", "EXPIRED" });
            cbStatus.Location = new Point(980, 37);
            cbStatus.Margin = new Padding(2);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(175, 28);
            cbStatus.TabIndex = 68;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(919, 39);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(57, 23);
            label7.TabIndex = 67;
            label7.Text = "Status";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(699, 60);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(104, 2);
            panel2.TabIndex = 66;
            // 
            // txtQuantity
            // 
            txtQuantity.BackColor = Color.SeaGreen;
            txtQuantity.BorderStyle = BorderStyle.None;
            txtQuantity.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtQuantity.ForeColor = Color.White;
            txtQuantity.Location = new Point(700, 35);
            txtQuantity.Margin = new Padding(2);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(152, 23);
            txtQuantity.TabIndex = 65;
            txtQuantity.TextChanged += txtQuantity_TextChanged;
            txtQuantity.KeyPress += txtQuantity_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(620, 34);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(77, 23);
            label3.TabIndex = 64;
            label3.Text = "Quantity";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Location = new Point(80, 98);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(104, 2);
            panel1.TabIndex = 60;
            // 
            // txtUnit
            // 
            txtUnit.BackColor = Color.SeaGreen;
            txtUnit.BorderStyle = BorderStyle.None;
            txtUnit.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUnit.ForeColor = Color.White;
            txtUnit.Location = new Point(81, 73);
            txtUnit.Margin = new Padding(2);
            txtUnit.Name = "txtUnit";
            txtUnit.Size = new Size(104, 23);
            txtUnit.TabIndex = 59;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(23, 72);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(42, 23);
            label2.TabIndex = 58;
            label2.Text = "Unit";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Location = new Point(307, 59);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(209, 2);
            panel3.TabIndex = 63;
            // 
            // dtpEXP
            // 
            dtpEXP.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpEXP.Format = DateTimePickerFormat.Short;
            dtpEXP.Location = new Point(308, 73);
            dtpEXP.Margin = new Padding(2);
            dtpEXP.MinDate = new DateTime(1890, 1, 1, 0, 0, 0, 0);
            dtpEXP.Name = "dtpEXP";
            dtpEXP.Size = new Size(210, 27);
            dtpEXP.TabIndex = 57;
            dtpEXP.ValueChanged += dtpEXP_ValueChanged;
            // 
            // txtName
            // 
            txtName.BackColor = Color.SeaGreen;
            txtName.BorderStyle = BorderStyle.None;
            txtName.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtName.ForeColor = Color.White;
            txtName.Location = new Point(308, 34);
            txtName.Margin = new Padding(2);
            txtName.Name = "txtName";
            txtName.Size = new Size(209, 23);
            txtName.TabIndex = 62;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(251, 34);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(56, 23);
            label6.TabIndex = 61;
            label6.Text = "Name";
            // 
            // cbSupplier
            // 
            cbSupplier.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbSupplier.FormattingEnabled = true;
            cbSupplier.Location = new Point(701, 75);
            cbSupplier.Margin = new Padding(2);
            cbSupplier.Name = "cbSupplier";
            cbSupplier.Size = new Size(151, 28);
            cbSupplier.TabIndex = 56;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(251, 72);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(40, 23);
            label9.TabIndex = 55;
            label9.Text = "EXP";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(620, 73);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(72, 23);
            label5.TabIndex = 54;
            label5.Text = "Supplier";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Location = new Point(80, 59);
            panel4.Margin = new Padding(2);
            panel4.Name = "panel4";
            panel4.Size = new Size(104, 2);
            panel4.TabIndex = 53;
            // 
            // txtID
            // 
            txtID.BackColor = Color.SeaGreen;
            txtID.BorderStyle = BorderStyle.None;
            txtID.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtID.ForeColor = Color.White;
            txtID.Location = new Point(81, 34);
            txtID.Margin = new Padding(2);
            txtID.Name = "txtID";
            txtID.Size = new Size(104, 23);
            txtID.TabIndex = 52;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(23, 34);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(27, 23);
            label4.TabIndex = 51;
            label4.Text = "ID";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnFilterbySupp);
            groupBox2.Controls.Add(cbFilterbySup);
            groupBox2.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(7, 390);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(351, 63);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Filter by Supplier";
            // 
            // btnFilterbySupp
            // 
            btnFilterbySupp.BackColor = Color.White;
            btnFilterbySupp.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFilterbySupp.ForeColor = Color.SeaGreen;
            btnFilterbySupp.Location = new Point(277, 26);
            btnFilterbySupp.Margin = new Padding(2);
            btnFilterbySupp.Name = "btnFilterbySupp";
            btnFilterbySupp.Size = new Size(68, 28);
            btnFilterbySupp.TabIndex = 70;
            btnFilterbySupp.Text = "Apply";
            btnFilterbySupp.UseVisualStyleBackColor = false;
            btnFilterbySupp.Click += btnFilterbySupp_Click;
            // 
            // cbFilterbySup
            // 
            cbFilterbySup.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbFilterbySup.FormattingEnabled = true;
            cbFilterbySup.Location = new Point(9, 26);
            cbFilterbySup.Margin = new Padding(2);
            cbFilterbySup.Name = "cbFilterbySup";
            cbFilterbySup.Size = new Size(248, 31);
            cbFilterbySup.TabIndex = 57;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnFilterbyStatus);
            groupBox3.Controls.Add(cbFilterbyStatus);
            groupBox3.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.ForeColor = Color.White;
            groupBox3.Location = new Point(375, 390);
            groupBox3.Margin = new Padding(2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(2);
            groupBox3.Size = new Size(386, 63);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "Filter by Status";
            // 
            // btnFilterbyStatus
            // 
            btnFilterbyStatus.BackColor = Color.White;
            btnFilterbyStatus.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFilterbyStatus.ForeColor = Color.SeaGreen;
            btnFilterbyStatus.Location = new Point(314, 26);
            btnFilterbyStatus.Margin = new Padding(2);
            btnFilterbyStatus.Name = "btnFilterbyStatus";
            btnFilterbyStatus.Size = new Size(68, 28);
            btnFilterbyStatus.TabIndex = 71;
            btnFilterbyStatus.Text = "Apply";
            btnFilterbyStatus.UseVisualStyleBackColor = false;
            btnFilterbyStatus.Click += btnFilterbyStatus_Click;
            // 
            // cbFilterbyStatus
            // 
            cbFilterbyStatus.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbFilterbyStatus.FormattingEnabled = true;
            cbFilterbyStatus.Items.AddRange(new object[] { "STOCK", "OUT_OF_STOCK", "LOW_STOCK", "EXPIRED" });
            cbFilterbyStatus.Location = new Point(9, 26);
            cbFilterbyStatus.Margin = new Padding(2);
            cbFilterbyStatus.Name = "cbFilterbyStatus";
            cbFilterbyStatus.Size = new Size(291, 31);
            cbFilterbyStatus.TabIndex = 57;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnTransaction);
            groupBox4.Controls.Add(btnExport);
            groupBox4.Controls.Add(btnImport);
            groupBox4.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox4.ForeColor = Color.White;
            groupBox4.Location = new Point(781, 390);
            groupBox4.Margin = new Padding(2);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(2);
            groupBox4.Size = new Size(407, 63);
            groupBox4.TabIndex = 7;
            groupBox4.TabStop = false;
            groupBox4.Text = "Inventory Transaction";
            // 
            // btnTransaction
            // 
            btnTransaction.BackColor = Color.White;
            btnTransaction.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTransaction.ForeColor = Color.SeaGreen;
            btnTransaction.Location = new Point(226, 26);
            btnTransaction.Margin = new Padding(2);
            btnTransaction.Name = "btnTransaction";
            btnTransaction.Size = new Size(155, 28);
            btnTransaction.TabIndex = 74;
            btnTransaction.Text = "All Transaction";
            btnTransaction.UseVisualStyleBackColor = false;
            btnTransaction.Click += btnTransaction_Click;
            // 
            // btnExport
            // 
            btnExport.BackColor = Color.White;
            btnExport.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExport.ForeColor = Color.SeaGreen;
            btnExport.Location = new Point(126, 26);
            btnExport.Margin = new Padding(2);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(87, 28);
            btnExport.TabIndex = 73;
            btnExport.Text = "Export";
            btnExport.UseVisualStyleBackColor = false;
            btnExport.Click += btnExport_Click;
            // 
            // btnImport
            // 
            btnImport.BackColor = Color.White;
            btnImport.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnImport.ForeColor = Color.SeaGreen;
            btnImport.Location = new Point(26, 26);
            btnImport.Margin = new Padding(2);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(87, 28);
            btnImport.TabIndex = 72;
            btnImport.Text = "Import";
            btnImport.UseVisualStyleBackColor = false;
            btnImport.Click += btnImport_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(panel6);
            panel5.Controls.Add(txtSearch);
            panel5.Controls.Add(pictureBox1);
            panel5.Location = new Point(284, 6);
            panel5.Margin = new Padding(2);
            panel5.Name = "panel5";
            panel5.Size = new Size(458, 49);
            panel5.TabIndex = 8;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Location = new Point(52, 41);
            panel6.Margin = new Padding(2);
            panel6.Name = "panel6";
            panel6.Size = new Size(281, 2);
            panel6.TabIndex = 2;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.SeaGreen;
            txtSearch.BorderStyle = BorderStyle.None;
            txtSearch.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.ForeColor = Color.White;
            txtSearch.Location = new Point(52, 10);
            txtSearch.Margin = new Padding(2);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search here ...";
            txtSearch.Size = new Size(281, 23);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.search;
            pictureBox1.Location = new Point(2, 7);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(41, 39);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnAllProds
            // 
            btnAllProds.BackColor = Color.White;
            btnAllProds.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAllProds.ForeColor = Color.SeaGreen;
            btnAllProds.Location = new Point(759, 11);
            btnAllProds.Margin = new Padding(2);
            btnAllProds.Name = "btnAllProds";
            btnAllProds.Size = new Size(169, 41);
            btnAllProds.TabIndex = 9;
            btnAllProds.Text = "All Ingredients";
            btnAllProds.UseVisualStyleBackColor = false;
            btnAllProds.Click += btnAllProds_Click;
            // 
            // usIngredientDetail1
            // 
            usIngredientDetail1.BackColor = Color.SeaGreen;
            usIngredientDetail1.BorderStyle = BorderStyle.Fixed3D;
            usIngredientDetail1.Location = new Point(185, 3);
            usIngredientDetail1.Margin = new Padding(1);
            usIngredientDetail1.Name = "usIngredientDetail1";
            usIngredientDetail1.Size = new Size(566, 575);
            usIngredientDetail1.TabIndex = 10;
            // 
            // usUpdateTransaction1
            // 
            usUpdateTransaction1.BackColor = Color.SeaGreen;
            usUpdateTransaction1.Location = new Point(215, 156);
            usUpdateTransaction1.Margin = new Padding(1);
            usUpdateTransaction1.Name = "usUpdateTransaction1";
            usUpdateTransaction1.Size = new Size(485, 266);
            usUpdateTransaction1.TabIndex = 11;
            // 
            // FrmIngredient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaGreen;
            ClientSize = new Size(1199, 605);
            Controls.Add(usUpdateTransaction1);
            Controls.Add(usIngredientDetail1);
            Controls.Add(btnAllProds);
            Controls.Add(panel5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dgvIngredients);
            Controls.Add(label1);
            Margin = new Padding(2);
            MaximumSize = new Size(1217, 652);
            MinimumSize = new Size(1217, 652);
            Name = "FrmIngredient";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ingredients";
            Load += FrmIngredient_Load;
            ((System.ComponentModel.ISupportInitialize)dgvIngredients).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvIngredients;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DateTimePicker dtpEXP;
        private ComboBox cbSupplier;
        private Label label9;
        private Label label5;
        private Panel panel4;
        private TextBox txtID;
        private Label label4;
        private Panel panel1;
        private TextBox txtUnit;
        private Label label2;
        private Panel panel3;
        private TextBox txtName;
        private Label label6;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private GroupBox groupBox3;
        private Panel panel2;
        private TextBox txtQuantity;
        private Label label3;
        private ComboBox cbFilterbySup;
        private ComboBox cbFilterbyStatus;
        private ComboBox cbStatus;
        private Label label7;
        private Button btnClear;
        private Button btnAdd;
        private Button btnFilterbySupp;
        private Button btnFilterbyStatus;
        private GroupBox groupBox4;
        private Button btnTransaction;
        private Button btnExport;
        private Button btnImport;
        private Panel panel5;
        private Panel panel6;
        private TextBox txtSearch;
        private PictureBox pictureBox1;
        private Button btnAllProds;
        private USIngredientDetail usIngredientDetail1;
        private USUpdateTransaction usUpdateTransaction1;
    }
}