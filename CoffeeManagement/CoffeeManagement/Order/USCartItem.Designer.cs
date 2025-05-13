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
            lbNameProd.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbNameProd.ForeColor = Color.DarkGreen;
            lbNameProd.Location = new Point(3, 25);
            lbNameProd.MaximumSize = new Size(103, 50);
            lbNameProd.Name = "lbNameProd";
            lbNameProd.Size = new Size(103, 50);
            lbNameProd.TabIndex = 0;
            lbNameProd.Text = "NameProd";
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbPrice.ForeColor = Color.DarkGreen;
            lbPrice.Location = new Point(118, 25);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(43, 20);
            lbPrice.TabIndex = 0;
            lbPrice.Text = "price";
            // 
            // lbQuantity
            // 
            lbQuantity.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbQuantity.AutoSize = true;
            lbQuantity.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbQuantity.ForeColor = Color.DarkGreen;
            lbQuantity.Location = new Point(231, 25);
            lbQuantity.Name = "lbQuantity";
            lbQuantity.Size = new Size(18, 20);
            lbQuantity.TabIndex = 0;
            lbQuantity.Text = "0";
            // 
            // btnPlus
            // 
            btnPlus.BackColor = Color.FromArgb(224, 224, 224);
            btnPlus.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnPlus.ForeColor = Color.Black;
            btnPlus.Location = new Point(265, 20);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(28, 29);
            btnPlus.TabIndex = 1;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = false;
            btnPlus.Click += btnPlus_Click;
            // 
            // btnMinus
            // 
            btnMinus.BackColor = Color.FromArgb(224, 224, 224);
            btnMinus.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnMinus.ForeColor = Color.Black;
            btnMinus.Location = new Point(188, 20);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(28, 29);
            btnMinus.TabIndex = 1;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = false;
            btnMinus.Click += btnMinus_Click;
            // 
            // lbTotalPrice
            // 
            lbTotalPrice.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbTotalPrice.AutoSize = true;
            lbTotalPrice.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbTotalPrice.ForeColor = Color.DarkGreen;
            lbTotalPrice.Location = new Point(313, 25);
            lbTotalPrice.Name = "lbTotalPrice";
            lbTotalPrice.Size = new Size(18, 20);
            lbTotalPrice.TabIndex = 0;
            lbTotalPrice.Text = "0";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(lbNameProd);
            panel1.Controls.Add(btnMinus);
            panel1.Controls.Add(lbPrice);
            panel1.Controls.Add(btnPlus);
            panel1.Controls.Add(lbQuantity);
            panel1.Controls.Add(lbTotalPrice);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.MaximumSize = new Size(450, 77);
            panel1.MinimumSize = new Size(450, 77);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(0, 1, 0, 1);
            panel1.Size = new Size(450, 77);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // USCartItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            MaximumSize = new Size(450, 77);
            MinimumSize = new Size(450, 77);
            Name = "USCartItem";
            Size = new Size(450, 77);
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
