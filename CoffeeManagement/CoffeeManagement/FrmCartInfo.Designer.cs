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
            groupBox1 = new GroupBox();
            cbCoupon = new ComboBox();
            cbPaymentMethod = new ComboBox();
            txtCounterfeit = new TextBox();
            btnClose = new Button();
            btnCheckout = new Button();
            dgvCart = new DataGridView();
            label6 = new Label();
            lbLastTotalPrice = new Label();
            lbTotalPrice = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label5 = new Label();
            panel1 = new Panel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCart).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbCoupon);
            groupBox1.Controls.Add(cbPaymentMethod);
            groupBox1.Controls.Add(txtCounterfeit);
            groupBox1.Controls.Add(btnClose);
            groupBox1.Controls.Add(btnCheckout);
            groupBox1.Controls.Add(dgvCart);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(lbLastTotalPrice);
            groupBox1.Controls.Add(lbTotalPrice);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(panel1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(713, 623);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin thanh toán";
            // 
            // cbCoupon
            // 
            cbCoupon.FormattingEnabled = true;
            cbCoupon.Location = new Point(539, 509);
            cbCoupon.Name = "cbCoupon";
            cbCoupon.Size = new Size(151, 28);
            cbCoupon.TabIndex = 7;
            cbCoupon.SelectedIndexChanged += cbCoupon_SelectedIndexChanged;
            // 
            // cbPaymentMethod
            // 
            cbPaymentMethod.FormattingEnabled = true;
            cbPaymentMethod.Location = new Point(540, 543);
            cbPaymentMethod.Name = "cbPaymentMethod";
            cbPaymentMethod.Size = new Size(151, 28);
            cbPaymentMethod.TabIndex = 6;
            cbPaymentMethod.SelectedIndexChanged += cbPaymentMethod_SelectedIndexChanged;
            // 
            // txtCounterfeit
            // 
            txtCounterfeit.Location = new Point(565, 472);
            txtCounterfeit.Name = "txtCounterfeit";
            txtCounterfeit.Size = new Size(125, 27);
            txtCounterfeit.TabIndex = 5;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(603, 591);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 4;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnCheckout
            // 
            btnCheckout.Location = new Point(494, 591);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(94, 29);
            btnCheckout.TabIndex = 4;
            btnCheckout.Text = "Checkout";
            btnCheckout.UseVisualStyleBackColor = true;
            btnCheckout.Click += btnCheckout_Click;
            // 
            // dgvCart
            // 
            dgvCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCart.Location = new Point(20, 100);
            dgvCart.Name = "dgvCart";
            dgvCart.RowHeadersWidth = 51;
            dgvCart.Size = new Size(682, 302);
            dgvCart.TabIndex = 3;
            dgvCart.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(39, 445);
            label6.Name = "label6";
            label6.Size = new Size(142, 20);
            label6.TabIndex = 0;
            label6.Text = "Số tiêng thanh toán:";
            // 
            // lbLastTotalPrice
            // 
            lbLastTotalPrice.AutoSize = true;
            lbLastTotalPrice.Location = new Point(596, 445);
            lbLastTotalPrice.Name = "lbLastTotalPrice";
            lbLastTotalPrice.Size = new Size(95, 20);
            lbLastTotalPrice.TabIndex = 0;
            lbLastTotalPrice.Text = "000.000 VND";
            // 
            // lbTotalPrice
            // 
            lbTotalPrice.AutoSize = true;
            lbTotalPrice.Location = new Point(596, 406);
            lbTotalPrice.Name = "lbTotalPrice";
            lbTotalPrice.Size = new Size(95, 20);
            lbTotalPrice.TabIndex = 0;
            lbTotalPrice.Text = "000.000 VND";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(39, 510);
            label9.Name = "label9";
            label9.Size = new Size(86, 20);
            label9.TabIndex = 0;
            label9.Text = "Khuyến mãi";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(39, 546);
            label8.Name = "label8";
            label8.Size = new Size(168, 20);
            label8.TabIndex = 0;
            label8.Text = "Phương thức thanh toán";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(39, 479);
            label7.Name = "label7";
            label7.Size = new Size(101, 20);
            label7.TabIndex = 0;
            label7.Text = "tiền khách trả:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(39, 406);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 0;
            label5.Text = "Tổng tiền:";
            // 
            // panel1
            // 
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(20, 40);
            panel1.Name = "panel1";
            panel1.Size = new Size(682, 54);
            panel1.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(576, 16);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 0;
            label4.Text = "tổng giá";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(368, 16);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 0;
            label3.Text = "số lượng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(183, 16);
            label2.Name = "label2";
            label2.Size = new Size(30, 20);
            label2.TabIndex = 0;
            label2.Text = "giá";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 16);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên sản phẩm";
            // 
            // FrmCartInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            ClientSize = new Size(737, 647);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FrmCartInfo";
            Text = "FrmCartInfo";
            Load += FrmCartInfo_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCart).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Panel panel1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dgvCart;
        private Label label6;
        private Label lbTotalPrice;
        private Label label5;
        private Button btnClose;
        private Button btnCheckout;
        private Label lbLastTotalPrice;
        private TextBox txtCounterfeit;
        private Label label7;
        private ComboBox cbPaymentMethod;
        private Label label8;
        private ComboBox cbCoupon;
        private Label label9;
    }
}