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
            pn_Product = new Panel();
            img_prod = new PictureBox();
            lbProdPrice = new Label();
            lbProdName = new Label();
            pn_Product.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)img_prod).BeginInit();
            SuspendLayout();
            // 
            // pn_Product
            // 
            pn_Product.BackColor = Color.Transparent;
            pn_Product.BorderStyle = BorderStyle.Fixed3D;
            pn_Product.Controls.Add(img_prod);
            pn_Product.Controls.Add(lbProdPrice);
            pn_Product.Controls.Add(lbProdName);
            pn_Product.Dock = DockStyle.Fill;
            pn_Product.ForeColor = Color.Transparent;
            pn_Product.Location = new Point(0, 0);
            pn_Product.Name = "pn_Product";
            pn_Product.Size = new Size(173, 140);
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
            img_prod.Location = new Point(3, 3);
            img_prod.Name = "img_prod";
            img_prod.Size = new Size(163, 77);
            img_prod.SizeMode = PictureBoxSizeMode.StretchImage;
            img_prod.TabIndex = 4;
            img_prod.TabStop = false;
            // 
            // lbProdPrice
            // 
            lbProdPrice.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbProdPrice.Location = new Point(3, 103);
            lbProdPrice.Name = "lbProdPrice";
            lbProdPrice.Size = new Size(171, 25);
            lbProdPrice.TabIndex = 6;
            lbProdPrice.Text = "price";
            lbProdPrice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbProdName
            // 
            lbProdName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbProdName.Location = new Point(3, 83);
            lbProdName.Name = "lbProdName";
            lbProdName.Size = new Size(171, 25);
            lbProdName.TabIndex = 6;
            lbProdName.Text = "Name";
            lbProdName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // USProdItem
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.SeaGreen;
            Controls.Add(pn_Product);
            Name = "USProdItem";
            Size = new Size(173, 140);
            Load += USProdItem_Load;
            pn_Product.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)img_prod).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox img_prod;
        private Label lbProdName;
        private Label lbProdPrice;
        private Panel pn_Product;
    }
}
