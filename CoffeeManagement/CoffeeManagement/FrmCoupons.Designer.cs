namespace PresentationLayer
{
    partial class FrmCoupons
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
            dgvCoupons = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            pnAddCoupon = new Panel();
            pictureBox1 = new PictureBox();
            panel4 = new Panel();
            txtID = new TextBox();
            label4 = new Label();
            txtDes = new TextBox();
            label3 = new Label();
            panel2 = new Panel();
            txtValue = new TextBox();
            label2 = new Label();
            btnClear = new Button();
            btnAdd = new Button();
            usUpdateCoupon1 = new USUpdateCoupon();
            ((System.ComponentModel.ISupportInitialize)dgvCoupons).BeginInit();
            pnAddCoupon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(24, 23);
            label1.Name = "label1";
            label1.Size = new Size(231, 74);
            label1.TabIndex = 1;
            label1.Text = "Coupons";
            // 
            // dgvCoupons
            // 
            dgvCoupons.BackgroundColor = Color.SeaGreen;
            dgvCoupons.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCoupons.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dgvCoupons.Location = new Point(24, 113);
            dgvCoupons.Name = "dgvCoupons";
            dgvCoupons.RowHeadersWidth = 82;
            dgvCoupons.Size = new Size(1425, 510);
            dgvCoupons.TabIndex = 2;
            dgvCoupons.CellContentClick += dgvCoupons_CellContentClick;
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
            Column2.DataPropertyName = "description";
            Column2.HeaderText = "Description";
            Column2.MinimumWidth = 10;
            Column2.Name = "Column2";
            Column2.Width = 200;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "value";
            Column3.HeaderText = "Value";
            Column3.MinimumWidth = 10;
            Column3.Name = "Column3";
            Column3.Width = 200;
            // 
            // pnAddCoupon
            // 
            pnAddCoupon.Controls.Add(pictureBox1);
            pnAddCoupon.Controls.Add(panel4);
            pnAddCoupon.Controls.Add(txtID);
            pnAddCoupon.Controls.Add(label4);
            pnAddCoupon.Controls.Add(txtDes);
            pnAddCoupon.Controls.Add(label3);
            pnAddCoupon.Controls.Add(panel2);
            pnAddCoupon.Controls.Add(txtValue);
            pnAddCoupon.Controls.Add(label2);
            pnAddCoupon.Controls.Add(btnClear);
            pnAddCoupon.Controls.Add(btnAdd);
            pnAddCoupon.Location = new Point(24, 639);
            pnAddCoupon.Name = "pnAddCoupon";
            pnAddCoupon.Size = new Size(1425, 263);
            pnAddCoupon.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.cat_coupon;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(286, 257);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Location = new Point(425, 102);
            panel4.Name = "panel4";
            panel4.Size = new Size(228, 3);
            panel4.TabIndex = 19;
            // 
            // txtID
            // 
            txtID.BackColor = Color.SeaGreen;
            txtID.BorderStyle = BorderStyle.None;
            txtID.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtID.ForeColor = Color.White;
            txtID.Location = new Point(427, 63);
            txtID.Name = "txtID";
            txtID.Size = new Size(228, 36);
            txtID.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(306, 63);
            label4.Name = "label4";
            label4.Size = new Size(44, 37);
            label4.TabIndex = 17;
            label4.Text = "ID";
            // 
            // txtDes
            // 
            txtDes.BackColor = Color.SeaGreen;
            txtDes.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDes.ForeColor = Color.White;
            txtDes.Location = new Point(857, 60);
            txtDes.Multiline = true;
            txtDes.Name = "txtDes";
            txtDes.Size = new Size(356, 132);
            txtDes.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(675, 60);
            label3.Name = "label3";
            label3.Size = new Size(157, 37);
            label3.TabIndex = 14;
            label3.Text = "Description";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(425, 192);
            panel2.Name = "panel2";
            panel2.Size = new Size(228, 3);
            panel2.TabIndex = 13;
            // 
            // txtValue
            // 
            txtValue.BackColor = Color.SeaGreen;
            txtValue.BorderStyle = BorderStyle.None;
            txtValue.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtValue.ForeColor = Color.White;
            txtValue.Location = new Point(427, 152);
            txtValue.Name = "txtValue";
            txtValue.Size = new Size(228, 36);
            txtValue.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(306, 152);
            label2.Name = "label2";
            label2.Size = new Size(83, 37);
            label2.TabIndex = 11;
            label2.Text = "Value";
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.White;
            btnClear.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.SeaGreen;
            btnClear.Location = new Point(1244, 150);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(147, 64);
            btnClear.TabIndex = 1;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.White;
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.SeaGreen;
            btnAdd.Location = new Point(1244, 44);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(147, 64);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // usUpdateCoupon1
            // 
            usUpdateCoupon1.BackColor = Color.SeaGreen;
            usUpdateCoupon1.BorderStyle = BorderStyle.Fixed3D;
            usUpdateCoupon1.Location = new Point(208, 156);
            usUpdateCoupon1.Name = "usUpdateCoupon1";
            usUpdateCoupon1.Size = new Size(1020, 537);
            usUpdateCoupon1.TabIndex = 4;
            // 
            // FrmCoupons
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaGreen;
            ClientSize = new Size(1474, 929);
            Controls.Add(usUpdateCoupon1);
            Controls.Add(pnAddCoupon);
            Controls.Add(dgvCoupons);
            Controls.Add(label1);
            Name = "FrmCoupons";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Coupons";
            Load += FrmCoupons_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCoupons).EndInit();
            pnAddCoupon.ResumeLayout(false);
            pnAddCoupon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvCoupons;
        private Panel pnAddCoupon;
        private Button btnAdd;
        private Button btnClear;
        private Panel panel4;
        private TextBox txtID;
        private Label label4;
        private TextBox txtDes;
        private Label label3;
        private Panel panel2;
        private TextBox txtValue;
        private Label label2;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private USUpdateCoupon usUpdateCoupon1;
    }
}