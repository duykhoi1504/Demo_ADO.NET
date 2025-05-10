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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            plMain = new Panel();
            panel4 = new Panel();
            pictureBox4 = new PictureBox();
            lb_MonthBecome = new Label();
            lb_YearBecome = new Label();
            lb_TodayBecome = new Label();
            label2 = new Label();
            label4 = new Label();
            label6 = new Label();
            panel3 = new Panel();
            pictureBox3 = new PictureBox();
            lb_totalBecome = new Label();
            label3 = new Label();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            lb_StaffCount = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            txt_name = new Label();
            panel2 = new Panel();
            btn_Account = new Button();
            btnStatistic = new Button();
            btnReceipt = new Button();
            btnProduct = new Button();
            btnWareHouse = new Button();
            Home = new Button();
            btn_logOut = new Button();
            btnCoupon = new Button();
            Supplier = new Button();
            plMain.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // plMain
            // 
            plMain.Controls.Add(panel4);
            plMain.Controls.Add(panel3);
            plMain.Controls.Add(panel1);
            plMain.Controls.Add(pictureBox1);
            plMain.Location = new Point(149, 9);
            plMain.Name = "plMain";
            plMain.Size = new Size(1200, 668);
            plMain.TabIndex = 1;
            plMain.Paint += plMain_Paint;
            // 
            // panel4
            // 
            panel4.Controls.Add(pictureBox4);
            panel4.Controls.Add(lb_MonthBecome);
            panel4.Controls.Add(lb_YearBecome);
            panel4.Controls.Add(lb_TodayBecome);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label6);
            panel4.Location = new Point(384, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(375, 231);
            panel4.TabIndex = 1;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = PresentationLayer.Properties.Resources.cat_payment;
            pictureBox4.Location = new Point(3, 18);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(106, 140);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 1;
            pictureBox4.TabStop = false;
            // 
            // lb_MonthBecome
            // 
            lb_MonthBecome.AutoSize = true;
            lb_MonthBecome.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lb_MonthBecome.ForeColor = Color.White;
            lb_MonthBecome.Location = new Point(241, 77);
            lb_MonthBecome.Name = "lb_MonthBecome";
            lb_MonthBecome.Size = new Size(51, 20);
            lb_MonthBecome.TabIndex = 0;
            lb_MonthBecome.Text = "label1";
            // 
            // lb_YearBecome
            // 
            lb_YearBecome.AutoSize = true;
            lb_YearBecome.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lb_YearBecome.ForeColor = Color.White;
            lb_YearBecome.Location = new Point(241, 127);
            lb_YearBecome.Name = "lb_YearBecome";
            lb_YearBecome.Size = new Size(51, 20);
            lb_YearBecome.TabIndex = 0;
            lb_YearBecome.Text = "label1";
            // 
            // lb_TodayBecome
            // 
            lb_TodayBecome.AutoSize = true;
            lb_TodayBecome.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lb_TodayBecome.ForeColor = Color.White;
            lb_TodayBecome.Location = new Point(241, 28);
            lb_TodayBecome.Name = "lb_TodayBecome";
            lb_TodayBecome.Size = new Size(51, 20);
            lb_TodayBecome.TabIndex = 0;
            lb_TodayBecome.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(115, 77);
            label2.Name = "label2";
            label2.Size = new Size(109, 20);
            label2.TabIndex = 0;
            label2.Text = "Year's Become";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(115, 127);
            label4.Name = "label4";
            label4.Size = new Size(109, 20);
            label4.TabIndex = 0;
            label4.Text = "Year's Become";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(115, 28);
            label6.Name = "label6";
            label6.Size = new Size(120, 20);
            label6.TabIndex = 0;
            label6.Text = "Today's become";
            // 
            // panel3
            // 
            panel3.Controls.Add(pictureBox3);
            panel3.Controls.Add(lb_totalBecome);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(783, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(357, 231);
            panel3.TabIndex = 1;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(3, 18);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(185, 140);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // lb_totalBecome
            // 
            lb_totalBecome.AutoSize = true;
            lb_totalBecome.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lb_totalBecome.ForeColor = Color.White;
            lb_totalBecome.Location = new Point(206, 111);
            lb_totalBecome.Name = "lb_totalBecome";
            lb_totalBecome.Size = new Size(79, 31);
            lb_totalBecome.TabIndex = 0;
            lb_totalBecome.Text = "label1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(206, 19);
            label3.Name = "label3";
            label3.Size = new Size(158, 31);
            label3.TabIndex = 0;
            label3.Text = "Total Become";
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(lb_StaffCount);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(357, 231);
            panel1.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 18);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(185, 140);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // lb_StaffCount
            // 
            lb_StaffCount.AutoSize = true;
            lb_StaffCount.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lb_StaffCount.ForeColor = Color.White;
            lb_StaffCount.Location = new Point(206, 111);
            lb_StaffCount.Name = "lb_StaffCount";
            lb_StaffCount.Size = new Size(79, 31);
            lb_StaffCount.TabIndex = 0;
            lb_StaffCount.Text = "label1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(206, 28);
            label1.Name = "label1";
            label1.Size = new Size(124, 31);
            label1.TabIndex = 0;
            label1.Text = "Total Staff";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Dock = DockStyle.Bottom;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 240);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1200, 428);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txt_name
            // 
            txt_name.AutoSize = true;
            txt_name.Cursor = Cursors.Hand;
            txt_name.Font = new Font("Comic Sans MS", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_name.ForeColor = Color.Transparent;
            txt_name.Location = new Point(18, 11);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(102, 48);
            txt_name.TabIndex = 0;
            txt_name.Text = "name";
            txt_name.Click += txt_name_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btn_Account);
            panel2.Controls.Add(txt_name);
            panel2.Controls.Add(btnStatistic);
            panel2.Controls.Add(btnReceipt);
            panel2.Controls.Add(btnProduct);
            panel2.Controls.Add(btnWareHouse);
            panel2.Controls.Add(Home);
            panel2.Controls.Add(btn_logOut);
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
            btn_Account.Cursor = Cursors.Hand;
            btn_Account.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_Account.ForeColor = Color.DarkGreen;
            btn_Account.Location = new Point(0, 282);
            btn_Account.Name = "btn_Account";
            btn_Account.Size = new Size(137, 36);
            btn_Account.TabIndex = 3;
            btn_Account.Text = "Account";
            btn_Account.UseVisualStyleBackColor = false;
            btn_Account.Click += btn_Account_Click;
            // 
            // btnStatistic
            // 
            btnStatistic.BackColor = Color.White;
            btnStatistic.Cursor = Cursors.Hand;
            btnStatistic.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnStatistic.ForeColor = Color.DarkGreen;
            btnStatistic.Location = new Point(0, 240);
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
            btnReceipt.Cursor = Cursors.Hand;
            btnReceipt.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnReceipt.ForeColor = Color.DarkGreen;
            btnReceipt.Location = new Point(0, 198);
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
            btnProduct.Cursor = Cursors.Hand;
            btnProduct.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnProduct.ForeColor = Color.DarkGreen;
            btnProduct.Location = new Point(0, 156);
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
            btnWareHouse.Cursor = Cursors.Hand;
            btnWareHouse.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnWareHouse.ForeColor = Color.DarkGreen;
            btnWareHouse.Location = new Point(0, 114);
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
            Home.Cursor = Cursors.Hand;
            Home.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Home.ForeColor = Color.DarkGreen;
            Home.Location = new Point(0, 72);
            Home.Name = "Home";
            Home.Size = new Size(137, 36);
            Home.TabIndex = 1;
            Home.Text = "Order Menu";
            Home.UseVisualStyleBackColor = false;
            Home.Click += Home_Click;
            // 
            // btn_logOut
            // 
            btn_logOut.BackColor = Color.White;
            btn_logOut.Cursor = Cursors.Hand;
            btn_logOut.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_logOut.ForeColor = Color.DarkGreen;
            btn_logOut.Location = new Point(0, 628);
            btn_logOut.Name = "btn_logOut";
            btn_logOut.Size = new Size(137, 36);
            btn_logOut.TabIndex = 1;
            btn_logOut.Text = "Log out";
            btn_logOut.UseVisualStyleBackColor = false;
            btn_logOut.Click += btn_logOut_Click;
            // 
            // btnCoupon
            // 
            btnCoupon.BackColor = Color.White;
            btnCoupon.Cursor = Cursors.Hand;
            btnCoupon.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCoupon.ForeColor = Color.DarkGreen;
            btnCoupon.Location = new Point(0, 366);
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
            Supplier.Cursor = Cursors.Hand;
            Supplier.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Supplier.ForeColor = Color.DarkGreen;
            Supplier.Location = new Point(0, 324);
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
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel plMain;
        private Panel panel2;
        private Button Home;
        private Button Supplier;
        private PictureBox pictureBox1;
        private Button btnWareHouse;
        private Button btnStatistic;
        private Button btnReceipt;
        private Button btnProduct;
        private Button btn_Account;
        private Button btnCoupon;
        private Label txt_name;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Label lb_StaffCount;
        private Label label1;
        private Panel panel4;
        private PictureBox pictureBox4;
        private Label lb_TodayBecome;
        private Label label6;
        private Panel panel3;
        private PictureBox pictureBox3;
        private Label lb_totalBecome;
        private Label label4;
        private Label lb_MonthBecome;
        private Label lb_YearBecome;
        private Label label2;
        private Label label3;
        private Button btn_logOut;
    }
}
