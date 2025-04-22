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
            panel2 = new Panel();
            Home = new Button();
            Supplier = new Button();
            pictureBox1 = new PictureBox();
            lbPicture = new Label();
            plMain.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            plMain.Size = new Size(866, 583);
            plMain.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(Home);
            panel2.Controls.Add(Supplier);
            panel2.Controls.Add(lbName);
            panel2.Location = new Point(6, 9);
            panel2.Name = "panel2";
            panel2.Size = new Size(97, 567);
            panel2.TabIndex = 2;
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
            // pictureBox1
            // 
            pictureBox1.Location = new Point(271, 93);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(298, 219);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 593);
            Controls.Add(panel2);
            Controls.Add(plMain);
            Name = "Form1";
            Text = " ";
            Load += Form1_Load;
            plMain.ResumeLayout(false);
            plMain.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
    }
}
