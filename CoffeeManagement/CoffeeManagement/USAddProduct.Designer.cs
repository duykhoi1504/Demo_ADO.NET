namespace PresentationLayer
{
    partial class USAddProduct
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
            lbTitle = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtPID = new TextBox();
            txtPName = new TextBox();
            txtPPrice = new TextBox();
            txtPDiscount = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            label6 = new Label();
            label7 = new Label();
            btnSelectImage = new Button();
            btnConfirm = new Button();
            btnClear = new Button();
            btnCancel = new Button();
            panel5 = new Panel();
            pictProduct = new PictureBox();
            label8 = new Label();
            cboCategory = new ComboBox();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictProduct).BeginInit();
            SuspendLayout();
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTitle.ForeColor = Color.White;
            lbTitle.Location = new Point(237, 15);
            lbTitle.Margin = new Padding(2, 0, 2, 0);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(138, 28);
            lbTitle.TabIndex = 0;
            lbTitle.Text = "Add Product";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(28, 57);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(27, 23);
            label2.TabIndex = 1;
            label2.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(28, 98);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(56, 23);
            label3.TabIndex = 2;
            label3.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(28, 138);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(47, 23);
            label4.TabIndex = 1;
            label4.Text = "Price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(28, 179);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(77, 23);
            label5.TabIndex = 2;
            label5.Text = "Discount";
            // 
            // txtPID
            // 
            txtPID.BackColor = Color.SeaGreen;
            txtPID.BorderStyle = BorderStyle.None;
            txtPID.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPID.ForeColor = Color.White;
            txtPID.Location = new Point(118, 58);
            txtPID.Margin = new Padding(2);
            txtPID.Name = "txtPID";
            txtPID.Size = new Size(103, 23);
            txtPID.TabIndex = 3;
            // 
            // txtPName
            // 
            txtPName.BackColor = Color.SeaGreen;
            txtPName.BorderStyle = BorderStyle.None;
            txtPName.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPName.ForeColor = Color.White;
            txtPName.Location = new Point(118, 96);
            txtPName.Margin = new Padding(2);
            txtPName.Name = "txtPName";
            txtPName.Size = new Size(238, 23);
            txtPName.TabIndex = 4;
            // 
            // txtPPrice
            // 
            txtPPrice.BackColor = Color.SeaGreen;
            txtPPrice.BorderStyle = BorderStyle.None;
            txtPPrice.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPPrice.ForeColor = Color.White;
            txtPPrice.Location = new Point(118, 136);
            txtPPrice.Margin = new Padding(2);
            txtPPrice.Name = "txtPPrice";
            txtPPrice.Size = new Size(104, 23);
            txtPPrice.TabIndex = 5;
            txtPPrice.KeyPress += txtPPrice_KeyPress;
            // 
            // txtPDiscount
            // 
            txtPDiscount.BackColor = Color.SeaGreen;
            txtPDiscount.BorderStyle = BorderStyle.None;
            txtPDiscount.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPDiscount.ForeColor = Color.White;
            txtPDiscount.Location = new Point(118, 178);
            txtPDiscount.Margin = new Padding(2);
            txtPDiscount.Name = "txtPDiscount";
            txtPDiscount.Size = new Size(104, 23);
            txtPDiscount.TabIndex = 6;
            txtPDiscount.KeyPress += txtPDiscount_KeyPress;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Location = new Point(118, 82);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(104, 2);
            panel1.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(118, 161);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(104, 2);
            panel2.TabIndex = 8;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Location = new Point(118, 202);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(104, 2);
            panel3.TabIndex = 9;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Location = new Point(118, 121);
            panel4.Margin = new Padding(2);
            panel4.Name = "panel4";
            panel4.Size = new Size(240, 2);
            panel4.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(237, 138);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(46, 23);
            label6.TabIndex = 1;
            label6.Text = "VND";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(237, 179);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(46, 23);
            label7.TabIndex = 2;
            label7.Text = "VND";
            // 
            // btnSelectImage
            // 
            btnSelectImage.BackColor = Color.White;
            btnSelectImage.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSelectImage.ForeColor = Color.SeaGreen;
            btnSelectImage.Location = new Point(447, 209);
            btnSelectImage.Margin = new Padding(2);
            btnSelectImage.Name = "btnSelectImage";
            btnSelectImage.Size = new Size(145, 28);
            btnSelectImage.TabIndex = 11;
            btnSelectImage.Text = "Select image";
            btnSelectImage.UseVisualStyleBackColor = false;
            btnSelectImage.Click += btnSelectImage_Click;
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.White;
            btnConfirm.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirm.ForeColor = Color.SeaGreen;
            btnConfirm.Location = new Point(113, 278);
            btnConfirm.Margin = new Padding(2);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(102, 37);
            btnConfirm.TabIndex = 13;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.White;
            btnClear.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.SeaGreen;
            btnClear.Location = new Point(263, 278);
            btnClear.Margin = new Padding(2);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(102, 37);
            btnClear.TabIndex = 14;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.White;
            btnCancel.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.SeaGreen;
            btnCancel.Location = new Point(417, 278);
            btnCancel.Margin = new Padding(2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(102, 37);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(pictProduct);
            panel5.Location = new Point(447, 62);
            panel5.Margin = new Padding(2);
            panel5.Name = "panel5";
            panel5.Size = new Size(148, 138);
            panel5.TabIndex = 15;
            // 
            // pictProduct
            // 
            pictProduct.Location = new Point(10, 3);
            pictProduct.Margin = new Padding(2);
            pictProduct.Name = "pictProduct";
            pictProduct.Size = new Size(129, 131);
            pictProduct.SizeMode = PictureBoxSizeMode.Zoom;
            pictProduct.TabIndex = 0;
            pictProduct.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(30, 219);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(81, 23);
            label8.TabIndex = 16;
            label8.Text = "Category";
            // 
            // cboCategory
            // 
            cboCategory.BackColor = Color.SeaGreen;
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(118, 220);
            cboCategory.Margin = new Padding(2);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(242, 28);
            cboCategory.TabIndex = 17;
            // 
            // USAddProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaGreen;
            Controls.Add(cboCategory);
            Controls.Add(label8);
            Controls.Add(panel5);
            Controls.Add(btnCancel);
            Controls.Add(btnClear);
            Controls.Add(btnConfirm);
            Controls.Add(btnSelectImage);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(txtPDiscount);
            Controls.Add(txtPPrice);
            Controls.Add(txtPName);
            Controls.Add(txtPID);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lbTitle);
            Margin = new Padding(2);
            Name = "USAddProduct";
            Size = new Size(628, 336);
            Load += AddProduct_Load;
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictProduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTitle;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtPID;
        private TextBox txtPName;
        private TextBox txtPPrice;
        private TextBox txtPDiscount;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label label6;
        private Label label7;
        private Button btnSelectImage;
        private Button btnConfirm;
        private Button btnClear;
        private Button btnCancel;
        private Panel panel5;
        private Label label8;
        private ComboBox cboCategory;
        private PictureBox pictProduct;
    }
}
