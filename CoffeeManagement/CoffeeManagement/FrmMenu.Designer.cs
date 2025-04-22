namespace PresentationLayer
{
    partial class FrmMenu
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
            label1 = new Label();
            pnFilter = new GroupBox();
            pnProduct = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 15);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 0;
            label1.Text = "Menu";
            // 
            // pnFilter
            // 
            pnFilter.Location = new Point(12, 49);
            pnFilter.Name = "pnFilter";
            pnFilter.Size = new Size(824, 125);
            pnFilter.TabIndex = 2;
            pnFilter.TabStop = false;
            pnFilter.Text = "Phân loại";
            // 
            // pnProduct
            // 
            pnProduct.BackColor = SystemColors.ActiveCaption;
            pnProduct.Location = new Point(12, 180);
            pnProduct.Name = "pnProduct";
            pnProduct.Size = new Size(824, 322);
            pnProduct.TabIndex = 0;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(848, 536);
            Controls.Add(pnProduct);
            Controls.Add(pnFilter);
            Controls.Add(label1);
            Name = "FrmMenu";
            Text = "FrmMenu";
            Load += FrmMenu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox pnFilter;
        private FlowLayoutPanel pnProduct;
    }
}