namespace PresentationLayer
{
    partial class FrmAccount
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
            dgvAccounts = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            btnAdd = new Button();
            btnClear = new Button();
            label2 = new Label();
            txtPassword = new TextBox();
            panel2 = new Panel();
            label4 = new Label();
            txtUsername = new TextBox();
            panel4 = new Panel();
            groupBox1 = new GroupBox();
            dtpDOB = new DateTimePicker();
            cbRole = new ComboBox();
            cbSex = new ComboBox();
            label9 = new Label();
            panel7 = new Panel();
            txtFullName = new TextBox();
            label8 = new Label();
            panel6 = new Panel();
            txtPhoneNumber = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            panel1 = new Panel();
            txtAddress = new TextBox();
            label3 = new Label();
            usUpdateAccount1 = new USUpdateAccount();
            btn_Checking = new Button();
            btn_Regis = new Button();
            btn_ShowAllWorkDay = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAccounts).BeginInit();
            groupBox1.SuspendLayout();
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
            label1.Size = new Size(166, 48);
            label1.TabIndex = 2;
            label1.Text = "Accounts";
            // 
            // dgvAccounts
            // 
            dgvAccounts.BackgroundColor = Color.SeaGreen;
            dgvAccounts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAccounts.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9, Column10 });
            dgvAccounts.Location = new Point(13, 54);
            dgvAccounts.Margin = new Padding(2);
            dgvAccounts.Name = "dgvAccounts";
            dgvAccounts.RowHeadersWidth = 82;
            dgvAccounts.Size = new Size(877, 299);
            dgvAccounts.TabIndex = 3;
            dgvAccounts.CellContentClick += dgvAccounts_CellContentClick;
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
            Column2.DataPropertyName = "username";
            Column2.HeaderText = "Username";
            Column2.MinimumWidth = 10;
            Column2.Name = "Column2";
            Column2.Width = 200;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "password";
            Column3.HeaderText = "Password";
            Column3.MinimumWidth = 10;
            Column3.Name = "Column3";
            Column3.Width = 200;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "role";
            Column4.HeaderText = "Role";
            Column4.MinimumWidth = 10;
            Column4.Name = "Column4";
            Column4.Width = 200;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "fullName";
            Column5.HeaderText = "Full Name";
            Column5.MinimumWidth = 10;
            Column5.Name = "Column5";
            Column5.Width = 200;
            // 
            // Column6
            // 
            Column6.DataPropertyName = "sex";
            Column6.HeaderText = "Sex";
            Column6.MinimumWidth = 10;
            Column6.Name = "Column6";
            Column6.Width = 200;
            // 
            // Column7
            // 
            Column7.DataPropertyName = "dateOfBirth";
            Column7.HeaderText = "Date Of Birth";
            Column7.MinimumWidth = 10;
            Column7.Name = "Column7";
            Column7.Width = 200;
            // 
            // Column8
            // 
            Column8.DataPropertyName = "address";
            Column8.HeaderText = "Address";
            Column8.MinimumWidth = 10;
            Column8.Name = "Column8";
            Column8.Width = 200;
            // 
            // Column9
            // 
            Column9.DataPropertyName = "phoneNumber";
            Column9.HeaderText = "Mobile";
            Column9.MinimumWidth = 10;
            Column9.Name = "Column9";
            Column9.Width = 200;
            // 
            // Column10
            // 
            Column10.DataPropertyName = "dateOfRegistration";
            Column10.HeaderText = "Date Of Registration ";
            Column10.MinimumWidth = 10;
            Column10.Name = "Column10";
            Column10.Width = 200;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.White;
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.SeaGreen;
            btnAdd.Location = new Point(775, 37);
            btnAdd.Margin = new Padding(2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(90, 40);
            btnAdd.TabIndex = 21;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.White;
            btnClear.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.SeaGreen;
            btnClear.Location = new Point(775, 94);
            btnClear.Margin = new Padding(2);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(90, 40);
            btnClear.TabIndex = 22;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(14, 73);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(82, 23);
            label2.TabIndex = 23;
            label2.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.SeaGreen;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = Color.White;
            txtPassword.Location = new Point(103, 74);
            txtPassword.Margin = new Padding(2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(140, 23);
            txtPassword.TabIndex = 24;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(102, 99);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(140, 2);
            panel2.TabIndex = 25;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(14, 37);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(87, 23);
            label4.TabIndex = 28;
            label4.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.SeaGreen;
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUsername.ForeColor = Color.White;
            txtUsername.Location = new Point(103, 38);
            txtUsername.Margin = new Padding(2);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(140, 23);
            txtUsername.TabIndex = 29;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Location = new Point(102, 62);
            panel4.Margin = new Padding(2);
            panel4.Name = "panel4";
            panel4.Size = new Size(140, 2);
            panel4.TabIndex = 30;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtpDOB);
            groupBox1.Controls.Add(cbRole);
            groupBox1.Controls.Add(cbSex);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(panel7);
            groupBox1.Controls.Add(txtFullName);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(panel6);
            groupBox1.Controls.Add(txtPhoneNumber);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(panel1);
            groupBox1.Controls.Add(txtAddress);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(panel4);
            groupBox1.Controls.Add(txtUsername);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(panel2);
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnClear);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(13, 411);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(877, 162);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add Account";
            // 
            // dtpDOB
            // 
            dtpDOB.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDOB.Format = DateTimePickerFormat.Short;
            dtpDOB.Location = new Point(526, 34);
            dtpDOB.Margin = new Padding(2);
            dtpDOB.MinDate = new DateTime(1890, 1, 1, 0, 0, 0, 0);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.Size = new Size(216, 30);
            dtpDOB.TabIndex = 50;
            // 
            // cbRole
            // 
            cbRole.FormattingEnabled = true;
            cbRole.Items.AddRange(new object[] { "ADMIN", "STAFF" });
            cbRole.Location = new Point(315, 36);
            cbRole.Margin = new Padding(2);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(105, 31);
            cbRole.TabIndex = 48;
            // 
            // cbSex
            // 
            cbSex.FormattingEnabled = true;
            cbSex.Items.AddRange(new object[] { "Nam", "Nữ" });
            cbSex.Location = new Point(315, 71);
            cbSex.Margin = new Padding(2);
            cbSex.Name = "cbSex";
            cbSex.Size = new Size(105, 31);
            cbSex.TabIndex = 47;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(441, 37);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(45, 23);
            label9.TabIndex = 46;
            label9.Text = "DOB";
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Location = new Point(527, 99);
            panel7.Margin = new Padding(2);
            panel7.Name = "panel7";
            panel7.Size = new Size(214, 2);
            panel7.TabIndex = 45;
            // 
            // txtFullName
            // 
            txtFullName.BackColor = Color.SeaGreen;
            txtFullName.BorderStyle = BorderStyle.None;
            txtFullName.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtFullName.ForeColor = Color.White;
            txtFullName.Location = new Point(529, 74);
            txtFullName.Margin = new Padding(2);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(214, 23);
            txtFullName.TabIndex = 44;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(438, 74);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(88, 23);
            label8.TabIndex = 43;
            label8.Text = "Full Name";
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Location = new Point(531, 136);
            panel6.Margin = new Padding(2);
            panel6.Name = "panel6";
            panel6.Size = new Size(211, 2);
            panel6.TabIndex = 42;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.BackColor = Color.SeaGreen;
            txtPhoneNumber.BorderStyle = BorderStyle.None;
            txtPhoneNumber.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPhoneNumber.ForeColor = Color.White;
            txtPhoneNumber.Location = new Point(532, 111);
            txtPhoneNumber.Margin = new Padding(2);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(211, 23);
            txtPhoneNumber.TabIndex = 41;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(441, 111);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(63, 23);
            label7.TabIndex = 40;
            label7.Text = "Mobile";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(270, 74);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(37, 23);
            label6.TabIndex = 37;
            label6.Text = "Sex";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(270, 38);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(44, 23);
            label5.TabIndex = 34;
            label5.Text = "Role";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Location = new Point(102, 136);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(316, 2);
            panel1.TabIndex = 33;
            // 
            // txtAddress
            // 
            txtAddress.BackColor = Color.SeaGreen;
            txtAddress.BorderStyle = BorderStyle.None;
            txtAddress.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtAddress.ForeColor = Color.White;
            txtAddress.Location = new Point(103, 111);
            txtAddress.Margin = new Padding(2);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(316, 23);
            txtAddress.TabIndex = 32;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(14, 110);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(70, 23);
            label3.TabIndex = 31;
            label3.Text = "Address";
            // 
            // usUpdateAccount1
            // 
            usUpdateAccount1.BackColor = Color.SeaGreen;
            usUpdateAccount1.Location = new Point(215, 125);
            usUpdateAccount1.Margin = new Padding(1);
            usUpdateAccount1.Name = "usUpdateAccount1";
            usUpdateAccount1.Size = new Size(502, 367);
            usUpdateAccount1.TabIndex = 5;
            // 
            // btn_Checking
            // 
            btn_Checking.BackColor = Color.White;
            btn_Checking.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Checking.ForeColor = Color.SeaGreen;
            btn_Checking.Location = new Point(315, 367);
            btn_Checking.Margin = new Padding(2);
            btn_Checking.Name = "btn_Checking";
            btn_Checking.Size = new Size(272, 40);
            btn_Checking.TabIndex = 21;
            btn_Checking.Text = "Shift Check";
            btn_Checking.UseVisualStyleBackColor = false;
            btn_Checking.Click += btn_Checking_Click;
            // 
            // btn_Regis
            // 
            btn_Regis.BackColor = Color.White;
            btn_Regis.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Regis.ForeColor = Color.SeaGreen;
            btn_Regis.Location = new Point(17, 367);
            btn_Regis.Margin = new Padding(2);
            btn_Regis.Name = "btn_Regis";
            btn_Regis.Size = new Size(272, 40);
            btn_Regis.TabIndex = 21;
            btn_Regis.Text = "Shift Register";
            btn_Regis.UseVisualStyleBackColor = false;
            btn_Regis.Click += btn_Regis_Click;
            // 
            // btn_ShowAllWorkDay
            // 
            btn_ShowAllWorkDay.BackColor = Color.White;
            btn_ShowAllWorkDay.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_ShowAllWorkDay.ForeColor = Color.SeaGreen;
            btn_ShowAllWorkDay.Location = new Point(614, 367);
            btn_ShowAllWorkDay.Margin = new Padding(2);
            btn_ShowAllWorkDay.Name = "btn_ShowAllWorkDay";
            btn_ShowAllWorkDay.Size = new Size(272, 40);
            btn_ShowAllWorkDay.TabIndex = 21;
            btn_ShowAllWorkDay.Text = "Shift List";
            btn_ShowAllWorkDay.UseVisualStyleBackColor = false;
            // 
            // FrmAccount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaGreen;
            ClientSize = new Size(907, 581);
            Controls.Add(usUpdateAccount1);
            Controls.Add(groupBox1);
            Controls.Add(dgvAccounts);
            Controls.Add(label1);
            Controls.Add(btn_ShowAllWorkDay);
            Controls.Add(btn_Regis);
            Controls.Add(btn_Checking);
            Margin = new Padding(2);
            Name = "FrmAccount";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Accounts";
            Load += FrmAccount_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAccounts).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvAccounts;
        private Button btnAdd;
        private Button btnClear;
        private Label label2;
        private TextBox txtPassword;
        private Panel panel2;
        private Label label4;
        private TextBox txtUsername;
        private Panel panel4;
        private GroupBox groupBox1;
        private Label label9;
        private Panel panel7;
        private TextBox txtFullName;
        private Label label8;
        private Panel panel6;
        private TextBox txtPhoneNumber;
        private Label label7;
        private Label label6;
        private Label label5;
        private Panel panel1;
        private TextBox txtAddress;
        private Label label3;
        private ComboBox cbRole;
        private ComboBox cbSex;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DateTimePicker dtpDOB;
        private USUpdateAccount usUpdateAccount1;
        private Button btn_Checking;
        private Button btn_Regis;
        private Button btn_ShowAllWorkDay;
    }
}