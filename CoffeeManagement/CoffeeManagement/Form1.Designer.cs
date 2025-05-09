namespace CoffeeManagement
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbName = new Label();
            plMain = new Panel();
            pictureBox1 = new PictureBox();
            txt_name = new Label();
            panel2 = new Panel();
            btn_Account = new Button();
            btnSetting = new Button();
            btnStatistic = new Button();
            btnReceipt = new Button();
            btnProduct = new Button();
            btnWareHouse = new Button();
            Home = new Button();
            btnCoupon = new Button();
            Supplier = new Button();
            plMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Font = new Font("Comic Sans MS", 19.8000011F, FontStyle.Bold);
            lbName.ForeColor = Color.Transparent;
            lbName.Location = new Point(477, 515);
            lbName.Name = "lbName";
            lbName.Size = new Size(196, 48);
            lbName.TabIndex = 0;
            lbName.Text = "Xin Chao: ";
            // 
            // plMain
            // 
            plMain.Controls.Add(pictureBox1);
            plMain.Controls.Add(lbName);
            plMain.Location = new Point(149, 9);
            plMain.Name = "plMain";
            plMain.Size = new Size(1200, 668);
            plMain.TabIndex = 1;
            plMain.Paint += plMain_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = PresentationLayer.Properties.Resources.cat_barista;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1200, 512);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txt_name
            // 
            txt_name.AutoSize = true;
            txt_name.Font = new Font("Comic Sans MS", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_name.ForeColor = Color.Transparent;
            txt_name.Location = new Point(18, 11);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(102, 48);
            txt_name.TabIndex = 0;
            txt_name.Text = "name";
            // 
            // panel2
            // 
            panel2.Controls.Add(btn_Account);
            panel2.Controls.Add(txt_name);
            panel2.Controls.Add(btnSetting);
            panel2.Controls.Add(btnStatistic);
            panel2.Controls.Add(btnReceipt);
            panel2.Controls.Add(btnProduct);
            panel2.Controls.Add(btnWareHouse);
            panel2.Controls.Add(Home);
            panel2.Controls.Add(btnCoupon);
            panel2.Controls.Add(Supplier);
            panel2.Location = new Point(6, 9);
            panel2.Name = "panel2";
            panel2.Size = new Size(137, 668);
            panel2.TabIndex = 2;
            // 
            // btn_Account
            // 
            btn_Account.BackColor = Color.White;
            btn_Account.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_Account.ForeColor = Color.DarkGreen;
            btn_Account.Location = new Point(0, 282);
            btn_Account.Name = "btn_Account";
            btn_Account.Size = new Size(137, 36);
            btn_Account.TabIndex = 3;
            btn_Account.Text = "Accout";
            btn_Account.UseVisualStyleBackColor = false;
            btn_Account.Click += btn_Account_Click;
            // 
            // btnSetting
            // 
            btnSetting.BackColor = Color.White;
            btnSetting.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSetting.ForeColor = Color.DarkGreen;
            btnSetting.Location = new Point(0, 247);
            btnSetting.Name = "btnSetting";
            btnSetting.Size = new Size(137, 36);
            btnSetting.TabIndex = 2;
            btnSetting.Text = "Setting";
            btnSetting.UseVisualStyleBackColor = false;
            // 
            // btnStatistic
            // 
            btnStatistic.BackColor = Color.White;
            btnStatistic.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnStatistic.ForeColor = Color.DarkGreen;
            btnStatistic.Location = new Point(0, 212);
            btnStatistic.Name = "btnStatistic";
            btnStatistic.Size = new Size(137, 36);
            btnStatistic.TabIndex = 2;
            btnStatistic.Text = "Statistic";
            btnStatistic.UseVisualStyleBackColor = false;
            btnStatistic.Click += btnStatistic_Click;
            // 
            // btnReceipt
            // 
            btnReceipt.BackColor = Color.White;
            btnReceipt.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnReceipt.ForeColor = Color.DarkGreen;
            btnReceipt.Location = new Point(0, 177);
            btnReceipt.Name = "btnReceipt";
            btnReceipt.Size = new Size(137, 36);
            btnReceipt.TabIndex = 2;
            btnReceipt.Text = "Receipt";
            btnReceipt.UseVisualStyleBackColor = false;
            btnReceipt.Click += btnReceipt_Click;
            // 
            // btnProduct
            // 
            btnProduct.BackColor = Color.White;
            btnProduct.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnProduct.ForeColor = Color.DarkGreen;
            btnProduct.Location = new Point(0, 142);
            btnProduct.Name = "btnProduct";
            btnProduct.Size = new Size(137, 36);
            btnProduct.TabIndex = 2;
            btnProduct.Text = "Product";
            btnProduct.UseVisualStyleBackColor = false;
            btnProduct.Click += btnProduct_Click;
            // 
            // btnWareHouse
            // 
            btnWareHouse.BackColor = Color.White;
            btnWareHouse.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnWareHouse.ForeColor = Color.DarkGreen;
            btnWareHouse.Location = new Point(0, 107);
            btnWareHouse.Name = "btnWareHouse";
            btnWareHouse.Size = new Size(137, 36);
            btnWareHouse.TabIndex = 2;
            btnWareHouse.Text = "WareHouse";
            btnWareHouse.UseVisualStyleBackColor = false;
            btnWareHouse.Click += btnWareHouse_Click;
            // 
            // Home
            // 
            Home.BackColor = Color.White;
            Home.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Home.ForeColor = Color.DarkGreen;
            Home.Location = new Point(0, 72);
            Home.Name = "Home";
            Home.Size = new Size(137, 36);
            Home.TabIndex = 1;
            Home.Text = "Home";
            Home.UseVisualStyleBackColor = false;
            Home.Click += Home_Click;
            // 
            // btnCoupon
            // 
            btnCoupon.BackColor = Color.White;
            btnCoupon.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCoupon.ForeColor = Color.DarkGreen;
            btnCoupon.Location = new Point(0, 352);
            btnCoupon.Name = "btnCoupon";
            btnCoupon.Size = new Size(137, 36);
            btnCoupon.TabIndex = 1;
            btnCoupon.Text = "Coupon";
            btnCoupon.UseVisualStyleBackColor = false;
            btnCoupon.Click += btnCoupon_Click;
            // 
            // Supplier
            // 
            Supplier.BackColor = Color.White;
            Supplier.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Supplier.ForeColor = Color.DarkGreen;
            Supplier.Location = new Point(0, 317);
            Supplier.Name = "Supplier";
            Supplier.Size = new Size(137, 36);
            Supplier.TabIndex = 1;
            Supplier.Text = "Supplier";
            Supplier.UseVisualStyleBackColor = false;
            Supplier.Click += Supplier_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaGreen;
            ClientSize = new Size(1354, 685);
            Controls.Add(panel2);
            Controls.Add(plMain);
            Name = "Form1";
            Text = " ";
            Load += Form1_Load;
            plMain.ResumeLayout(false);
            plMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lbName;
        private Panel plMain;
        private Panel panel2;
        private Button Home;
        private Button Supplier;
        private PictureBox pictureBox1;
        private Button btnWareHouse;
        private Button btnSetting;
        private Button btnStatistic;
        private Button btnReceipt;
        private Button btnProduct;
        private Button btn_Account;
        private Button btnCoupon;
        private Label txt_name;
    }
}
