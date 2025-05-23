﻿namespace PresentationLayer
{
    partial class FrmProducts
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
            panel1 = new Panel();
            panel2 = new Panel();
            txtSearch = new TextBox();
            pictureBox1 = new PictureBox();
            btnAddProduct = new Button();
            dgvProducts = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewImageColumn();
            pnlLoadCats = new Panel();
            btnAllProds = new Button();
            usAddProduct1 = new USAddProduct();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(16, 14);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(105, 48);
            label1.TabIndex = 0;
            label1.Text = "Menu";
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(190, 14);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(338, 52);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(52, 41);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(281, 2);
            panel2.TabIndex = 2;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.SeaGreen;
            txtSearch.BorderStyle = BorderStyle.None;
            txtSearch.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.ForeColor = SystemColors.Window;
            txtSearch.Location = new Point(52, 10);
            txtSearch.Margin = new Padding(2);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search here ...";
            txtSearch.Size = new Size(281, 23);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.search;
            pictureBox1.Location = new Point(2, 7);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(41, 39);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnAddProduct
            // 
            btnAddProduct.BackColor = Color.White;
            btnAddProduct.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddProduct.ForeColor = Color.SeaGreen;
            btnAddProduct.Location = new Point(705, 21);
            btnAddProduct.Margin = new Padding(2);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(97, 41);
            btnAddProduct.TabIndex = 3;
            btnAddProduct.Text = "Add";
            btnAddProduct.UseVisualStyleBackColor = false;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // dgvProducts
            // 
            dgvProducts.BackgroundColor = Color.SeaGreen;
            dgvProducts.BorderStyle = BorderStyle.None;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dgvProducts.Location = new Point(16, 122);
            dgvProducts.Margin = new Padding(2);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowHeadersWidth = 82;
            dgvProducts.Size = new Size(1172, 472);
            dgvProducts.TabIndex = 4;
            dgvProducts.CellContentClick += dgvProducts_CellContentClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "id";
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 10;
            Column1.Name = "Column1";
            Column1.Width = 200;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "name";
            Column2.HeaderText = "Name";
            Column2.MinimumWidth = 10;
            Column2.Name = "Column2";
            Column2.Width = 200;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "price";
            Column3.HeaderText = "Price (VND)";
            Column3.MinimumWidth = 10;
            Column3.Name = "Column3";
            Column3.Width = 200;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "discount";
            Column4.HeaderText = "Discount (VND)";
            Column4.MinimumWidth = 10;
            Column4.Name = "Column4";
            Column4.Width = 200;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "categoryID";
            Column5.HeaderText = "CategoryID";
            Column5.MinimumWidth = 10;
            Column5.Name = "Column5";
            Column5.Width = 200;
            // 
            // Column6
            // 
            Column6.DataPropertyName = "image";
            Column6.HeaderText = "Image";
            Column6.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Column6.MinimumWidth = 10;
            Column6.Name = "Column6";
            Column6.Width = 200;
            // 
            // pnlLoadCats
            // 
            pnlLoadCats.Location = new Point(16, 78);
            pnlLoadCats.Margin = new Padding(2);
            pnlLoadCats.Name = "pnlLoadCats";
            pnlLoadCats.Size = new Size(1172, 40);
            pnlLoadCats.TabIndex = 5;
            // 
            // btnAllProds
            // 
            btnAllProds.BackColor = Color.White;
            btnAllProds.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAllProds.ForeColor = Color.SeaGreen;
            btnAllProds.Location = new Point(551, 21);
            btnAllProds.Margin = new Padding(2);
            btnAllProds.Name = "btnAllProds";
            btnAllProds.Size = new Size(141, 41);
            btnAllProds.TabIndex = 7;
            btnAllProds.Text = "All Products";
            btnAllProds.UseVisualStyleBackColor = false;
            btnAllProds.Click += btnAllProds_Click;
            // 
            // usAddProduct1
            // 
            usAddProduct1.BackColor = Color.SeaGreen;
            usAddProduct1.Location = new Point(154, 125);
            usAddProduct1.Margin = new Padding(1);
            usAddProduct1.Name = "usAddProduct1";
            usAddProduct1.Size = new Size(628, 336);
            usAddProduct1.TabIndex = 6;
            // 
            // FrmProducts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaGreen;
            ClientSize = new Size(1199, 605);
            Controls.Add(btnAllProds);
            Controls.Add(usAddProduct1);
            Controls.Add(pnlLoadCats);
            Controls.Add(dgvProducts);
            Controls.Add(btnAddProduct);
            Controls.Add(panel1);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "FrmProducts";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Products";
            Load += Products_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private TextBox txtSearch;
        private Button btnAddProduct;
        private DataGridView dgvProducts;
        private Panel pnlLoadCats;
        private USAddProduct usAddProduct1;
        private Button btnAllProds;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewImageColumn Column6;
    }
}