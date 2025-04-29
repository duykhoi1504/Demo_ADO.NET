namespace PresentationLayer
{
    partial class FrmOrderInfo
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
            panel1 = new Panel();
            lbCreateDate = new Label();
            label13 = new Label();
            label4 = new Label();
            lbCoupon = new Label();
            lbStaff = new Label();
            label3 = new Label();
            lbPaymentMethod = new Label();
            label2 = new Label();
            panel2 = new Panel();
            dgvItems = new DataGridView();
            label8 = new Label();
            lbTotalPrice = new Label();
            label10 = new Label();
            label11 = new Label();
            lbcounterFeit = new Label();
            panel3 = new Panel();
            btnClose = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 14);
            label1.Name = "label1";
            label1.Size = new Size(115, 20);
            label1.TabIndex = 0;
            label1.Text = "Chi tiết hóa đơn";
            // 
            // panel1
            // 
            panel1.Controls.Add(lbCreateDate);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(lbCoupon);
            panel1.Controls.Add(lbStaff);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lbPaymentMethod);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(29, 52);
            panel1.Name = "panel1";
            panel1.Size = new Size(674, 158);
            panel1.TabIndex = 1;
            // 
            // lbCreateDate
            // 
            lbCreateDate.AutoSize = true;
            lbCreateDate.Location = new Point(369, 114);
            lbCreateDate.Name = "lbCreateDate";
            lbCreateDate.Size = new Size(50, 20);
            lbCreateDate.TabIndex = 0;
            lbCreateDate.Text = "label1";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(19, 85);
            label13.Name = "label13";
            label13.Size = new Size(86, 20);
            label13.TabIndex = 0;
            label13.Text = "Khuyến mãi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 114);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 0;
            label4.Text = "Ngày tạo";
            // 
            // lbCoupon
            // 
            lbCoupon.AutoSize = true;
            lbCoupon.Location = new Point(369, 85);
            lbCoupon.Name = "lbCoupon";
            lbCoupon.Size = new Size(50, 20);
            lbCoupon.TabIndex = 0;
            lbCoupon.Text = "label1";
            // 
            // lbStaff
            // 
            lbStaff.AutoSize = true;
            lbStaff.Location = new Point(369, 53);
            lbStaff.Name = "lbStaff";
            lbStaff.Size = new Size(50, 20);
            lbStaff.TabIndex = 0;
            lbStaff.Text = "label1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 53);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 0;
            label3.Text = "nhân viên";
            // 
            // lbPaymentMethod
            // 
            lbPaymentMethod.AutoSize = true;
            lbPaymentMethod.Location = new Point(369, 22);
            lbPaymentMethod.Name = "lbPaymentMethod";
            lbPaymentMethod.Size = new Size(50, 20);
            lbPaymentMethod.TabIndex = 0;
            lbPaymentMethod.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 22);
            label2.Name = "label2";
            label2.Size = new Size(169, 20);
            label2.TabIndex = 0;
            label2.Text = "phương thức thanh toán";
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvItems);
            panel2.Location = new Point(29, 216);
            panel2.Name = "panel2";
            panel2.Size = new Size(674, 216);
            panel2.TabIndex = 1;
            // 
            // dgvItems
            // 
            dgvItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItems.Dock = DockStyle.Fill;
            dgvItems.Location = new Point(0, 0);
            dgvItems.Name = "dgvItems";
            dgvItems.RowHeadersWidth = 51;
            dgvItems.Size = new Size(674, 216);
            dgvItems.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(19, 16);
            label8.Name = "label8";
            label8.Size = new Size(72, 20);
            label8.TabIndex = 0;
            label8.Text = "Tổng tiền";
            // 
            // lbTotalPrice
            // 
            lbTotalPrice.AutoSize = true;
            lbTotalPrice.Location = new Point(587, 16);
            lbTotalPrice.Name = "lbTotalPrice";
            lbTotalPrice.Size = new Size(50, 20);
            lbTotalPrice.TabIndex = 0;
            lbTotalPrice.Text = "label1";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(0, 47);
            label10.Name = "label10";
            label10.Size = new Size(675, 20);
            label10.TabIndex = 0;
            label10.Text = "_______________________________________________________________________________________________________________";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(19, 83);
            label11.Name = "label11";
            label11.Size = new Size(130, 20);
            label11.TabIndex = 0;
            label11.Text = "Số tiền thanh toán";
            // 
            // lbcounterFeit
            // 
            lbcounterFeit.AutoSize = true;
            lbcounterFeit.Location = new Point(587, 83);
            lbcounterFeit.Name = "lbcounterFeit";
            lbcounterFeit.Size = new Size(50, 20);
            lbcounterFeit.TabIndex = 0;
            lbcounterFeit.Text = "label1";
            // 
            // panel3
            // 
            panel3.Controls.Add(lbTotalPrice);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(lbcounterFeit);
            panel3.Location = new Point(29, 438);
            panel3.Name = "panel3";
            panel3.Size = new Size(674, 125);
            panel3.TabIndex = 1;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(598, 569);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 2;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // FrmOrderInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(737, 599);
            Controls.Add(btnClose);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "FrmOrderInfo";
            Text = "FrmOrderInfo";
            Load += FrmOrderInfo_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvItems).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Panel panel2;
        private Label lbCreateDate;
        private Label lbStaff;
        private Label lbPaymentMethod;
        private Label label8;
        private Label lbTotalPrice;
        private Label label10;
        private Label label11;
        private Label lbcounterFeit;
        private Label label13;
        private Label lbCoupon;
        private DataGridView dgvItems;
        private Panel panel3;
        private Button btnClose;
    }
}