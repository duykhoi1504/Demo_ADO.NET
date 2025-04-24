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
            picProd = new PictureBox();
            lbProdPrice = new Label();
            lbProdName = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picProd).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonShadow;
            panel1.Controls.Add(picProd);
            panel1.Controls.Add(lbProdPrice);
            panel1.Controls.Add(lbProdName);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.MaximumSize = new Size(160, 140);
            panel1.MinimumSize = new Size(160, 140);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(1);
            panel1.Size = new Size(160, 140);
            panel1.TabIndex = 0;
            panel1.Click += panel1_Click;
            // 
            // picProd
            // 
            picProd.BackColor = SystemColors.ActiveCaption;
            picProd.Location = new Point(6, 4);
            picProd.Name = "picProd";
            picProd.Size = new Size(148, 69);
            picProd.TabIndex = 4;
            picProd.TabStop = false;
            // 
            // lbProdPrice
            // 
            lbProdPrice.AutoSize = true;
            lbProdPrice.Location = new Point(51, 107);
            lbProdPrice.Name = "lbProdPrice";
            lbProdPrice.Size = new Size(42, 20);
            lbProdPrice.TabIndex = 5;
            lbProdPrice.Text = "price";
            // 
            // lbProdName
            // 
            lbProdName.AutoSize = true;
            lbProdName.Location = new Point(51, 87);
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
            ((System.ComponentModel.ISupportInitialize)picProd).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox picProd;
        private Label lbProdPrice;
        private Label lbProdName;
    }
}
