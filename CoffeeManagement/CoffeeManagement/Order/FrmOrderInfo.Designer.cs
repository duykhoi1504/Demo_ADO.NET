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
            lbLastTotal = new Label();
            label5 = new Label();
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
            label1.Font = new Font("Comic Sans MS", 19.8000011F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 1);
            label1.Name = "label1";
            label1.Size = new Size(249, 48);
            label1.TabIndex = 0;
            label1.Text = "Receipt detail";
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
            lbCreateDate.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lbCreateDate.ForeColor = Color.White;
            lbCreateDate.Location = new Point(369, 114);
            lbCreateDate.Name = "lbCreateDate";
            lbCreateDate.Size = new Size(59, 23);
            lbCreateDate.TabIndex = 0;
            lbCreateDate.Text = "label1";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label13.ForeColor = Color.White;
            label13.Location = new Point(155, 85);
            label13.Name = "label13";
            label13.Size = new Size(77, 23);
            label13.TabIndex = 0;
            label13.Text = "Coupon:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(124, 114);
            label4.Name = "label4";
            label4.Size = new Size(108, 23);
            label4.TabIndex = 0;
            label4.Text = "Create date:";
            // 
            // lbCoupon
            // 
            lbCoupon.AutoSize = true;
            lbCoupon.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lbCoupon.ForeColor = Color.White;
            lbCoupon.Location = new Point(369, 85);
            lbCoupon.Name = "lbCoupon";
            lbCoupon.Size = new Size(59, 23);
            lbCoupon.TabIndex = 0;
            lbCoupon.Text = "label1";
            // 
            // lbStaff
            // 
            lbStaff.AutoSize = true;
            lbStaff.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lbStaff.ForeColor = Color.White;
            lbStaff.Location = new Point(369, 53);
            lbStaff.Name = "lbStaff";
            lbStaff.Size = new Size(59, 23);
            lbStaff.TabIndex = 0;
            lbStaff.Text = "label1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(176, 53);
            label3.Name = "label3";
            label3.Size = new Size(56, 23);
            label3.TabIndex = 0;
            label3.Text = "Staff:";
            // 
            // lbPaymentMethod
            // 
            lbPaymentMethod.AutoSize = true;
            lbPaymentMethod.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lbPaymentMethod.ForeColor = Color.White;
            lbPaymentMethod.Location = new Point(369, 22);
            lbPaymentMethod.Name = "lbPaymentMethod";
            lbPaymentMethod.Size = new Size(59, 23);
            lbPaymentMethod.TabIndex = 0;
            lbPaymentMethod.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(79, 22);
            label2.Name = "label2";
            label2.Size = new Size(153, 23);
            label2.TabIndex = 0;
            label2.Text = "Payment method:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
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
            dgvItems.BackgroundColor = Color.SeaGreen;
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
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label8.ForeColor = Color.White;
            label8.Location = new Point(19, 16);
            label8.Name = "label8";
            label8.Size = new Size(54, 23);
            label8.TabIndex = 0;
            label8.Text = "Total:";
            // 
            // lbTotalPrice
            // 
            lbTotalPrice.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lbTotalPrice.ForeColor = Color.White;
            lbTotalPrice.Location = new Point(335, 16);
            lbTotalPrice.Name = "lbTotalPrice";
            lbTotalPrice.Size = new Size(322, 23);
            lbTotalPrice.TabIndex = 0;
            lbTotalPrice.Text = "label1";
            lbTotalPrice.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(-1, 39);
            label10.Name = "label10";
            label10.Size = new Size(675, 20);
            label10.TabIndex = 0;
            label10.Text = "_______________________________________________________________________________________________________________";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label11.ForeColor = Color.White;
            label11.Location = new Point(19, 103);
            label11.Name = "label11";
            label11.Size = new Size(128, 23);
            label11.TabIndex = 0;
            label11.Text = "Cash Recieved:";
            // 
            // lbcounterFeit
            // 
            lbcounterFeit.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lbcounterFeit.ForeColor = Color.White;
            lbcounterFeit.Location = new Point(335, 103);
            lbcounterFeit.Name = "lbcounterFeit";
            lbcounterFeit.Size = new Size(322, 23);
            lbcounterFeit.TabIndex = 0;
            lbcounterFeit.Text = "label1";
            lbcounterFeit.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel3
            // 
            panel3.Controls.Add(lbTotalPrice);
            panel3.Controls.Add(lbLastTotal);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(lbcounterFeit);
            panel3.Location = new Point(29, 438);
            panel3.Name = "panel3";
            panel3.Size = new Size(674, 133);
            panel3.TabIndex = 1;
            // 
            // lbLastTotal
            // 
            lbLastTotal.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lbLastTotal.ForeColor = Color.White;
            lbLastTotal.Location = new Point(340, 59);
            lbLastTotal.Name = "lbLastTotal";
            lbLastTotal.Size = new Size(317, 23);
            lbLastTotal.TabIndex = 0;
            lbLastTotal.Text = "label";
            lbLastTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(19, 59);
            label5.Name = "label5";
            label5.Size = new Size(199, 23);
            label5.TabIndex = 0;
            label5.Text = "Total(included coupon):";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.White;
            btnClose.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnClose.ForeColor = Color.DarkGreen;
            btnClose.Location = new Point(534, 569);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(170, 44);
            btnClose.TabIndex = 2;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // FrmOrderInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaGreen;
            ClientSize = new Size(737, 624);
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
        private Label lbLastTotal;
        private Label label5;
    }
}