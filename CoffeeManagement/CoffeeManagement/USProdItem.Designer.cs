namespace PresentationLayer
{
    partial class USProdItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            lbProdPrice = new Label();
            pn_Product = new Panel();
            img_prod = new PictureBox();
            lbProdName = new Label();
            panel1.SuspendLayout();
            pn_Product.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)img_prod).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGreen;
            panel1.Controls.Add(lbProdPrice);
            panel1.Controls.Add(pn_Product);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.MaximumSize = new Size(160, 140);
            panel1.MinimumSize = new Size(160, 140);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(1);
            panel1.Size = new Size(160, 140);
            panel1.TabIndex = 0;
            // 
            // lbProdPrice
            // 
            lbProdPrice.AutoSize = true;
            lbProdPrice.Enabled = false;
            lbProdPrice.Location = new Point(51, 108);
            lbProdPrice.Name = "lbProdPrice";
            lbProdPrice.Size = new Size(42, 20);
            lbProdPrice.TabIndex = 5;
            lbProdPrice.Text = "price";
            // 
            // pn_Product
            // 
            pn_Product.Controls.Add(img_prod);
            pn_Product.Controls.Add(lbProdName);
            pn_Product.Dock = DockStyle.Fill;
            pn_Product.Location = new Point(1, 1);
            pn_Product.Name = "pn_Product";
            pn_Product.Size = new Size(158, 138);
            pn_Product.TabIndex = 0;
            pn_Product.Click += pn_Product_Click;
            pn_Product.MouseEnter += pn_Product_MouseEnter;
            pn_Product.MouseLeave += pn_Product_MouseLeave;
            pn_Product.MouseHover += pn_Product_MouseHover;
            // 
            // img_prod
            // 
            img_prod.BackColor = SystemColors.ButtonHighlight;
            img_prod.Enabled = false;
            img_prod.Location = new Point(17, 3);
            img_prod.Name = "img_prod";
            img_prod.Size = new Size(118, 81);
            img_prod.SizeMode = PictureBoxSizeMode.StretchImage;
            img_prod.TabIndex = 4;
            img_prod.TabStop = false;
            // 
            // lbProdName
            // 
            lbProdName.AutoSize = true;
            lbProdName.Enabled = false;
            lbProdName.Location = new Point(50, 87);
            lbProdName.Name = "lbProdName";
            lbProdName.Size = new Size(49, 20);
            lbProdName.TabIndex = 3;
            lbProdName.Text = "Name";
            // 
            // USProdItem
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(panel1);
            Name = "USProdItem";
            Size = new Size(160, 140);
            Load += USProdItem_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pn_Product.ResumeLayout(false);
            pn_Product.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)img_prod).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox img_prod;
        private Label lbProdPrice;
        private Label lbProdName;
        private Panel pn_Product;
    }
}
