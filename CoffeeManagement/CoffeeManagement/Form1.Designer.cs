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
            lbPicture = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            btnSetting = new Button();
            btnStatistic = new Button();
            btnReceipt = new Button();
            btnProduct = new Button();
            btnWareHouse = new Button();
            Home = new Button();
            Supplier = new Button();
            plMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(6, 13);
            lbName.Name = "lbName";
            lbName.Size = new Size(75, 20);
            lbName.TabIndex = 0;
            lbName.Text = "Xin Chao: ";
            // 
            // plMain
            // 
            plMain.Controls.Add(lbPicture);
            plMain.Controls.Add(pictureBox1);
            plMain.Location = new Point(109, 9);
            plMain.Name = "plMain";
            plMain.Size = new Size(1275, 699);
            plMain.TabIndex = 1;
            // 
            // lbPicture
            // 
            lbPicture.AutoSize = true;
            lbPicture.Location = new Point(399, 329);
            lbPicture.Name = "lbPicture";
            lbPicture.Size = new Size(67, 20);
            lbPicture.TabIndex = 1;
            lbPicture.Text = "lbPicture";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlDark;
            pictureBox1.Location = new Point(217, 93);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(442, 219);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnSetting);
            panel2.Controls.Add(btnStatistic);
            panel2.Controls.Add(btnReceipt);
            panel2.Controls.Add(btnProduct);
            panel2.Controls.Add(btnWareHouse);
            panel2.Controls.Add(Home);
            panel2.Controls.Add(Supplier);
            panel2.Controls.Add(lbName);
            panel2.Location = new Point(6, 9);
            panel2.Name = "panel2";
            panel2.Size = new Size(97, 567);
            panel2.TabIndex = 2;
            // 
            // btnSetting
            // 
            btnSetting.Location = new Point(0, 246);
            btnSetting.Name = "btnSetting";
            btnSetting.Size = new Size(94, 29);
            btnSetting.TabIndex = 2;
            btnSetting.Text = "Setting";
            btnSetting.UseVisualStyleBackColor = true;
            // 
            // btnStatistic
            // 
            btnStatistic.Location = new Point(0, 211);
            btnStatistic.Name = "btnStatistic";
            btnStatistic.Size = new Size(94, 29);
            btnStatistic.TabIndex = 2;
            btnStatistic.Text = "Statistic";
            btnStatistic.UseVisualStyleBackColor = true;
            // 
            // btnReceipt
            // 
            btnReceipt.Location = new Point(0, 176);
            btnReceipt.Name = "btnReceipt";
            btnReceipt.Size = new Size(94, 29);
            btnReceipt.TabIndex = 2;
            btnReceipt.Text = "Receipt";
            btnReceipt.UseVisualStyleBackColor = true;
            // 
            // btnProduct
            // 
            btnProduct.Location = new Point(0, 141);
            btnProduct.Name = "btnProduct";
            btnProduct.Size = new Size(94, 29);
            btnProduct.TabIndex = 2;
            btnProduct.Text = "Product";
            btnProduct.UseVisualStyleBackColor = true;
            // 
            // btnWareHouse
            // 
            btnWareHouse.Location = new Point(0, 106);
            btnWareHouse.Name = "btnWareHouse";
            btnWareHouse.Size = new Size(94, 29);
            btnWareHouse.TabIndex = 2;
            btnWareHouse.Text = "WareHouse";
            btnWareHouse.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            Home.Location = new Point(0, 36);
            Home.Name = "Home";
            Home.Size = new Size(94, 29);
            Home.TabIndex = 1;
            Home.Text = "Home";
            Home.UseVisualStyleBackColor = true;
            Home.Click += Home_Click;
            // 
            // Supplier
            // 
            Supplier.Location = new Point(0, 71);
            Supplier.Name = "Supplier";
            Supplier.Size = new Size(94, 29);
            Supplier.TabIndex = 1;
            Supplier.Text = "Supplier";
            Supplier.UseVisualStyleBackColor = true;
            Supplier.Click += Supplier_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1499, 685);
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
        private Label lbPicture;
        private PictureBox pictureBox1;
        private Button btnWareHouse;
        private Button btnSetting;
        private Button btnStatistic;
        private Button btnReceipt;
        private Button btnProduct;
    }
}
