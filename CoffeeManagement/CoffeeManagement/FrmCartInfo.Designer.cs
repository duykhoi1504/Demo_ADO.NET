namespace PresentationLayer
{
    partial class FrmCartInfo
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
            label5 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            lbTotalPrice = new Label();
            lbLastTotalPrice = new Label();
            label6 = new Label();
            dgvCart = new DataGridView();
            btnCheckout = new Button();
            btnClose = new Button();
            txtCounterfeit = new TextBox();
            cbPaymentMethod = new ComboBox();
            cbCoupon = new ComboBox();
            groupBox1 = new GroupBox();
            panel1 = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCart).BeginInit();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(57, 30);
            label5.Name = "label5";
            label5.Size = new Size(64, 28);
            label5.TabIndex = 0;
            label5.Text = "Total:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(58, 160);
            label7.Name = "label7";
            label7.Size = new Size(130, 28);
            label7.TabIndex = 0;
            label7.Text = "amount pay:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(58, 202);
            label8.Name = "label8";
            label8.Size = new Size(100, 28);
            label8.TabIndex = 0;
            label8.Text = "Payment:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(58, 72);
            label9.Name = "label9";
            label9.Size = new Size(89, 28);
            label9.TabIndex = 0;
            label9.Text = "Coupon:";
            // 
            // lbTotalPrice
            // 
            lbTotalPrice.Location = new Point(369, 30);
            lbTotalPrice.Name = "lbTotalPrice";
            lbTotalPrice.Size = new Size(351, 34);
            lbTotalPrice.TabIndex = 0;
            lbTotalPrice.Text = "000.000 VND";
            lbTotalPrice.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbLastTotalPrice
            // 
            lbLastTotalPrice.Location = new Point(369, 103);
            lbLastTotalPrice.Name = "lbLastTotalPrice";
            lbLastTotalPrice.Size = new Size(351, 34);
            lbLastTotalPrice.TabIndex = 0;
            lbLastTotalPrice.Text = "000.000 VND";
            lbLastTotalPrice.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(58, 119);
            label6.Name = "label6";
            label6.Size = new Size(106, 28);
            label6.TabIndex = 0;
            label6.Text = "Last total:";
            // 
            // dgvCart
            // 
            dgvCart.BackgroundColor = Color.SeaGreen;
            dgvCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCart.Dock = DockStyle.Fill;
            dgvCart.GridColor = Color.Black;
            dgvCart.Location = new Point(0, 0);
            dgvCart.Name = "dgvCart";
            dgvCart.RowHeadersWidth = 51;
            dgvCart.Size = new Size(726, 243);
            dgvCart.TabIndex = 3;
            dgvCart.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnCheckout
            // 
            btnCheckout.BackColor = Color.White;
            btnCheckout.ForeColor = Color.DarkGreen;
            btnCheckout.Location = new Point(455, 242);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(127, 38);
            btnCheckout.TabIndex = 4;
            btnCheckout.Text = "Checkout";
            btnCheckout.UseVisualStyleBackColor = false;
            btnCheckout.Click += btnCheckout_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.White;
            btnClose.ForeColor = Color.DarkGreen;
            btnClose.Location = new Point(588, 242);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(127, 38);
            btnClose.TabIndex = 4;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // txtCounterfeit
            // 
            txtCounterfeit.Location = new Point(406, 153);
            txtCounterfeit.Name = "txtCounterfeit";
            txtCounterfeit.Size = new Size(303, 34);
            txtCounterfeit.TabIndex = 5;
            txtCounterfeit.TextChanged += txtCounterfeit_TextChanged;
            // 
            // cbPaymentMethod
            // 
            cbPaymentMethod.FormattingEnabled = true;
            cbPaymentMethod.Location = new Point(558, 194);
            cbPaymentMethod.Name = "cbPaymentMethod";
            cbPaymentMethod.Size = new Size(151, 36);
            cbPaymentMethod.TabIndex = 6;
            cbPaymentMethod.SelectedIndexChanged += cbPaymentMethod_SelectedIndexChanged;
            // 
            // cbCoupon
            // 
            cbCoupon.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbCoupon.FormattingEnabled = true;
            cbCoupon.Location = new Point(342, 64);
            cbCoupon.Name = "cbCoupon";
            cbCoupon.Size = new Size(367, 31);
            cbCoupon.TabIndex = 7;
            cbCoupon.SelectedIndexChanged += cbCoupon_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbCoupon);
            groupBox1.Controls.Add(cbPaymentMethod);
            groupBox1.Controls.Add(txtCounterfeit);
            groupBox1.Controls.Add(btnClose);
            groupBox1.Controls.Add(btnCheckout);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(lbLastTotalPrice);
            groupBox1.Controls.Add(lbTotalPrice);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label5);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(12, 294);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(726, 315);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Info";
            // 
            // panel1
            // 
            panel1.Controls.Add(dgvCart);
            panel1.Location = new Point(12, 45);
            panel1.Name = "panel1";
            panel1.Size = new Size(726, 243);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(11, -6);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(155, 48);
            label1.TabIndex = 5;
            label1.Text = "Payment";
            // 
            // FrmCartInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = Color.SeaGreen;
            ClientSize = new Size(751, 609);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FrmCartInfo";
            Text = "FrmCartInfo";
            Load += FrmCartInfo_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCart).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label lbTotalPrice;
        private Label lbLastTotalPrice;
        private Label label6;
        private DataGridView dgvCart;
        private Button btnCheckout;
        private Button btnClose;
        private TextBox txtCounterfeit;
        private ComboBox cbPaymentMethod;
        private ComboBox cbCoupon;
        private GroupBox groupBox1;
        private Panel panel1;
        private Label label1;
    }
}