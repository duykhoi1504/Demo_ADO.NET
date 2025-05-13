namespace PresentationLayer
{
    partial class USIngredientDetail
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            btnCancel = new Button();
            btnAdd = new Button();
            cbStatus = new ComboBox();
            label7 = new Label();
            panel2 = new Panel();
            txtQuantity = new TextBox();
            label3 = new Label();
            panel1 = new Panel();
            txtUnit = new TextBox();
            label4 = new Label();
            panel3 = new Panel();
            dtpEXP = new DateTimePicker();
            txtName = new TextBox();
            label6 = new Label();
            cbSupplier = new ComboBox();
            label9 = new Label();
            label5 = new Label();
            panel4 = new Panel();
            txtID = new TextBox();
            label8 = new Label();
            dgvTransaction = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            lbClose = new Label();
            btnImport = new Button();
            btnExport = new Button();
            usUpdateTransaction1 = new USUpdateTransaction();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransaction).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(202, 12);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(181, 28);
            label1.TabIndex = 70;
            label1.Text = "Ingredient's Info";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(164, 254);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(256, 28);
            label2.TabIndex = 71;
            label2.Text = "Ingredient's Transaction";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCancel);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(cbStatus);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(panel2);
            groupBox1.Controls.Add(txtQuantity);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(panel1);
            groupBox1.Controls.Add(txtUnit);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(panel3);
            groupBox1.Controls.Add(dtpEXP);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(cbSupplier);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(panel4);
            groupBox1.Controls.Add(txtID);
            groupBox1.Controls.Add(label8);
            groupBox1.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(12, 42);
            groupBox1.Margin = new Padding(2, 2, 2, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2, 2, 2, 2);
            groupBox1.Size = new Size(539, 203);
            groupBox1.TabIndex = 72;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ingredient Details";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.White;
            btnCancel.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.SeaGreen;
            btnCancel.Location = new Point(287, 152);
            btnCancel.Margin = new Padding(2, 2, 2, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(80, 38);
            btnCancel.TabIndex = 70;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.White;
            btnAdd.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.SeaGreen;
            btnAdd.Location = new Point(172, 152);
            btnAdd.Margin = new Padding(2, 2, 2, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(84, 38);
            btnAdd.TabIndex = 69;
            btnAdd.Text = "Update";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // cbStatus
            // 
            cbStatus.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbStatus.FormattingEnabled = true;
            cbStatus.Items.AddRange(new object[] { "STOCK", "OUT_OF_STOCK", "LOW_STOCK", "EXPIRED" });
            cbStatus.Location = new Point(270, 113);
            cbStatus.Margin = new Padding(2, 2, 2, 2);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(243, 28);
            cbStatus.TabIndex = 68;
            cbStatus.SelectedIndexChanged += cbStatus_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(211, 112);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(57, 23);
            label7.TabIndex = 67;
            label7.Text = "Status";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(268, 96);
            panel2.Margin = new Padding(2, 2, 2, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(57, 2);
            panel2.TabIndex = 66;
            // 
            // txtQuantity
            // 
            txtQuantity.BackColor = Color.SeaGreen;
            txtQuantity.BorderStyle = BorderStyle.None;
            txtQuantity.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtQuantity.ForeColor = Color.White;
            txtQuantity.Location = new Point(269, 72);
            txtQuantity.Margin = new Padding(2, 2, 2, 2);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(57, 23);
            txtQuantity.TabIndex = 65;
            txtQuantity.TextChanged += txtQuantity_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(212, 72);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(38, 23);
            label3.TabIndex = 64;
            label3.Text = "Qty";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Location = new Point(70, 98);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(119, 2);
            panel1.TabIndex = 60;
            // 
            // txtUnit
            // 
            txtUnit.BackColor = Color.SeaGreen;
            txtUnit.BorderStyle = BorderStyle.None;
            txtUnit.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUnit.ForeColor = Color.White;
            txtUnit.Location = new Point(71, 73);
            txtUnit.Margin = new Padding(2, 2, 2, 2);
            txtUnit.Name = "txtUnit";
            txtUnit.Size = new Size(119, 23);
            txtUnit.TabIndex = 59;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(23, 72);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(42, 23);
            label4.TabIndex = 58;
            label4.Text = "Unit";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Location = new Point(269, 59);
            panel3.Margin = new Padding(2, 2, 2, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(242, 2);
            panel3.TabIndex = 63;
            // 
            // dtpEXP
            // 
            dtpEXP.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpEXP.Format = DateTimePickerFormat.Short;
            dtpEXP.Location = new Point(70, 112);
            dtpEXP.Margin = new Padding(2, 2, 2, 2);
            dtpEXP.MinDate = new DateTime(1890, 1, 1, 0, 0, 0, 0);
            dtpEXP.Name = "dtpEXP";
            dtpEXP.Size = new Size(120, 27);
            dtpEXP.TabIndex = 57;
            dtpEXP.ValueChanged += dtpEXP_ValueChanged;
            // 
            // txtName
            // 
            txtName.BackColor = Color.SeaGreen;
            txtName.BorderStyle = BorderStyle.None;
            txtName.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtName.ForeColor = Color.White;
            txtName.Location = new Point(270, 34);
            txtName.Margin = new Padding(2, 2, 2, 2);
            txtName.Name = "txtName";
            txtName.Size = new Size(242, 23);
            txtName.TabIndex = 62;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(211, 34);
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
            cbSupplier.Location = new Point(405, 72);
            cbSupplier.Margin = new Padding(2, 2, 2, 2);
            cbSupplier.Name = "cbSupplier";
            cbSupplier.Size = new Size(109, 28);
            cbSupplier.TabIndex = 56;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(23, 112);
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
            label5.Location = new Point(329, 72);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(72, 23);
            label5.TabIndex = 54;
            label5.Text = "Supplier";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Location = new Point(70, 59);
            panel4.Margin = new Padding(2, 2, 2, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(119, 2);
            panel4.TabIndex = 53;
            // 
            // txtID
            // 
            txtID.BackColor = Color.SeaGreen;
            txtID.BorderStyle = BorderStyle.None;
            txtID.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtID.ForeColor = Color.White;
            txtID.Location = new Point(71, 34);
            txtID.Margin = new Padding(2, 2, 2, 2);
            txtID.Name = "txtID";
            txtID.Size = new Size(119, 23);
            txtID.TabIndex = 52;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(23, 34);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(27, 23);
            label8.TabIndex = 51;
            label8.Text = "ID";
            // 
            // dgvTransaction
            // 
            dgvTransaction.BackgroundColor = Color.SeaGreen;
            dgvTransaction.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransaction.Columns.AddRange(new DataGridViewColumn[] { Id, Column2, Column3, Column4, Date, Column6 });
            dgvTransaction.Location = new Point(12, 287);
            dgvTransaction.Margin = new Padding(2, 2, 2, 2);
            dgvTransaction.Name = "dgvTransaction";
            dgvTransaction.RowHeadersWidth = 82;
            dgvTransaction.Size = new Size(539, 224);
            dgvTransaction.TabIndex = 73;
            dgvTransaction.CellContentClick += dgvTransaction_CellContentClick;
            // 
            // Id
            // 
            Id.DataPropertyName = "id";
            Id.HeaderText = "ID";
            Id.MinimumWidth = 10;
            Id.Name = "Id";
            Id.Width = 200;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "ingredientID";
            Column2.HeaderText = "Ingredient ID";
            Column2.MinimumWidth = 10;
            Column2.Name = "Column2";
            Column2.Width = 200;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "quantity";
            Column3.HeaderText = "Quantity";
            Column3.MinimumWidth = 10;
            Column3.Name = "Column3";
            Column3.Width = 200;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "type";
            Column4.HeaderText = "Type";
            Column4.MinimumWidth = 10;
            Column4.Name = "Column4";
            Column4.Width = 200;
            // 
            // Date
            // 
            Date.DataPropertyName = "date";
            Date.HeaderText = "Date";
            Date.MinimumWidth = 10;
            Date.Name = "Date";
            Date.Width = 200;
            // 
            // Column6
            // 
            Column6.DataPropertyName = "note";
            Column6.HeaderText = "Note";
            Column6.MinimumWidth = 10;
            Column6.Name = "Column6";
            Column6.Width = 200;
            // 
            // lbClose
            // 
            lbClose.AutoSize = true;
            lbClose.Font = new Font("Segoe UI Black", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbClose.ForeColor = Color.White;
            lbClose.Location = new Point(542, 0);
            lbClose.Margin = new Padding(2, 0, 2, 0);
            lbClose.Name = "lbClose";
            lbClose.Size = new Size(21, 23);
            lbClose.TabIndex = 74;
            lbClose.Text = "x";
            lbClose.Click += lbClose_Click;
            // 
            // btnImport
            // 
            btnImport.BackColor = Color.White;
            btnImport.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnImport.ForeColor = Color.SeaGreen;
            btnImport.Location = new Point(184, 524);
            btnImport.Margin = new Padding(2, 2, 2, 2);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(84, 38);
            btnImport.TabIndex = 75;
            btnImport.Text = "Import";
            btnImport.UseVisualStyleBackColor = false;
            btnImport.Click += btnImport_Click;
            // 
            // btnExport
            // 
            btnExport.BackColor = Color.White;
            btnExport.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExport.ForeColor = Color.SeaGreen;
            btnExport.Location = new Point(299, 524);
            btnExport.Margin = new Padding(2, 2, 2, 2);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(94, 38);
            btnExport.TabIndex = 76;
            btnExport.Text = "Export";
            btnExport.UseVisualStyleBackColor = false;
            btnExport.Click += btnExport_Click;
            // 
            // usUpdateTransaction1
            // 
            usUpdateTransaction1.BackColor = Color.SeaGreen;
            usUpdateTransaction1.Location = new Point(43, 156);
            usUpdateTransaction1.Margin = new Padding(1, 1, 1, 1);
            usUpdateTransaction1.Name = "usUpdateTransaction1";
            usUpdateTransaction1.Size = new Size(485, 266);
            usUpdateTransaction1.TabIndex = 77;
            // 
            // USIngredientDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaGreen;
            BorderStyle = BorderStyle.Fixed3D;
            Controls.Add(usUpdateTransaction1);
            Controls.Add(btnExport);
            Controls.Add(btnImport);
            Controls.Add(lbClose);
            Controls.Add(dgvTransaction);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "USIngredientDetail";
            Size = new Size(562, 572);
            Load += USIngredientDetail_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransaction).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private Button btnCancel;
        private Button btnAdd;
        private ComboBox cbStatus;
        private Label label7;
        private Panel panel2;
        private TextBox txtQuantity;
        private Label label3;
        private Panel panel1;
        private TextBox txtUnit;
        private Label label4;
        private Panel panel3;
        private DateTimePicker dtpEXP;
        private TextBox txtName;
        private Label label6;
        private ComboBox cbSupplier;
        private Label label9;
        private Label label5;
        private Panel panel4;
        private TextBox txtID;
        private Label label8;
        private DataGridView dgvTransaction;
        private Label lbClose;
        private Button btnImport;
        private Button btnExport;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Column6;
        private USUpdateTransaction usUpdateTransaction1;
    }
}
