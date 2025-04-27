namespace PresentationLayer
{
    partial class USCartItem
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
            lbNameProd = new Label();
            lbPrice = new Label();
            lbQuantity = new Label();
            btnPlus = new Button();
            btnMinus = new Button();
            lbTotalPrice = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lbNameProd
            // 
            lbNameProd.AutoSize = true;
            lbNameProd.Location = new Point(3, 25);
            lbNameProd.Name = "lbNameProd";
            lbNameProd.Size = new Size(80, 20);
            lbNameProd.TabIndex = 0;
            lbNameProd.Text = "NameProd";
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Location = new Point(106, 25);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(42, 20);
            lbPrice.TabIndex = 0;
            lbPrice.Text = "price";
            // 
            // lbQuantity
            // 
            lbQuantity.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbQuantity.AutoSize = true;
            lbQuantity.Location = new Point(209, 25);
            lbQuantity.Name = "lbQuantity";
            lbQuantity.Size = new Size(17, 20);
            lbQuantity.TabIndex = 0;
            lbQuantity.Text = "0";
            // 
            // btnPlus
            // 
            btnPlus.Location = new Point(265, 20);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(28, 29);
            btnPlus.TabIndex = 1;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += btnPlus_Click;
            // 
            // btnMinus
            // 
            btnMinus.Location = new Point(175, 20);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(28, 29);
            btnMinus.TabIndex = 1;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += btnMinus_Click;
            // 
            // lbTotalPrice
            // 
            lbTotalPrice.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbTotalPrice.AutoSize = true;
            lbTotalPrice.Location = new Point(313, 25);
            lbTotalPrice.Name = "lbTotalPrice";
            lbTotalPrice.Size = new Size(17, 20);
            lbTotalPrice.TabIndex = 0;
            lbTotalPrice.Text = "0";
            // 
            // panel1
            // 
            panel1.Controls.Add(lbNameProd);
            panel1.Controls.Add(btnMinus);
            panel1.Controls.Add(lbPrice);
            panel1.Controls.Add(btnPlus);
            panel1.Controls.Add(lbQuantity);
            panel1.Controls.Add(lbTotalPrice);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.MaximumSize = new Size(385, 77);
            panel1.MinimumSize = new Size(385, 77);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(0, 1, 0, 1);
            panel1.Size = new Size(385, 77);
            panel1.TabIndex = 2;
            // 
            // USCartItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "USCartItem";
            Size = new Size(385, 77);
            Load += USCartItem_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lbNameProd;
        private Label lbPrice;
        private Label lbQuantity;
        private Button btnPlus;
        private Button btnMinus;
        private Label lbTotalPrice;
        private Panel panel1;
    }
}
