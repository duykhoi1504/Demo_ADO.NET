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
            btnTotal = new Button();
            pnProdItems = new Panel();
            panel1 = new Panel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            Name = new Label();
            groupBox1 = new GroupBox();
            panel5 = new Panel();
            btn_Search = new Button();
            panel6 = new Panel();
            txtSearch = new TextBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 19.8000011F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(18, 9);
            label1.Name = "label1";
            label1.Size = new Size(105, 48);
            label1.TabIndex = 0;
            label1.Text = "Menu";
            // 
            // pnFilter
            // 
            pnFilter.BackColor = Color.SeaGreen;
            pnFilter.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pnFilter.ForeColor = Color.White;
            pnFilter.Location = new Point(12, 60);
            pnFilter.Name = "pnFilter";
            pnFilter.Size = new Size(756, 114);
            pnFilter.TabIndex = 2;
            pnFilter.TabStop = false;
            pnFilter.Text = "Categoty filter";
            // 
            // pnProduct
            // 
            pnProduct.AutoScroll = true;
            pnProduct.BackColor = Color.SeaGreen;
            pnProduct.BorderStyle = BorderStyle.FixedSingle;
            pnProduct.ForeColor = Color.White;
            pnProduct.Location = new Point(12, 180);
            pnProduct.Name = "pnProduct";
            pnProduct.Size = new Size(756, 454);
            pnProduct.TabIndex = 0;
            // 
            // btnTotal
            // 
            btnTotal.BackColor = Color.White;
            btnTotal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnTotal.ForeColor = Color.DarkGreen;
            btnTotal.Location = new Point(9, 575);
            btnTotal.Name = "btnTotal";
            btnTotal.Size = new Size(422, 47);
            btnTotal.TabIndex = 2;
            btnTotal.Text = "Total Price: 0 ";
            btnTotal.UseVisualStyleBackColor = false;
            btnTotal.Click += btnTotal_Click;
            // 
            // pnProdItems
            // 
            pnProdItems.AutoScroll = true;
            pnProdItems.Location = new Point(6, 81);
            pnProdItems.Name = "pnProdItems";
            pnProdItems.Size = new Size(422, 488);
            pnProdItems.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(Name);
            panel1.Location = new Point(6, 26);
            panel1.Name = "panel1";
            panel1.Size = new Size(422, 49);
            panel1.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.ForeColor = Color.DarkGreen;
            label4.Location = new Point(339, 16);
            label4.Name = "label4";
            label4.Size = new Size(44, 20);
            label4.TabIndex = 0;
            label4.Text = "Total";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.ForeColor = Color.DarkGreen;
            label3.Location = new Point(202, 16);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 0;
            label3.Text = "Quantity";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.ForeColor = Color.DarkGreen;
            label2.Location = new Point(105, 16);
            label2.Name = "label2";
            label2.Size = new Size(43, 20);
            label2.TabIndex = 0;
            label2.Text = "Price";
            // 
            // Name
            // 
            Name.AutoSize = true;
            Name.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Name.ForeColor = Color.DarkGreen;
            Name.Location = new Point(3, 16);
            Name.Name = "Name";
            Name.Size = new Size(51, 20);
            Name.TabIndex = 0;
            Name.Text = "Name";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.SeaGreen;
            groupBox1.Controls.Add(panel1);
            groupBox1.Controls.Add(pnProdItems);
            groupBox1.Controls.Add(btnTotal);
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(774, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(434, 628);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "CART";
            // 
            // panel5
            // 
            panel5.Controls.Add(btn_Search);
            panel5.Controls.Add(panel6);
            panel5.Controls.Add(txtSearch);
            panel5.Controls.Add(pictureBox1);
            panel5.Location = new Point(193, 12);
            panel5.Margin = new Padding(2);
            panel5.Name = "panel5";
            panel5.Size = new Size(539, 49);
            panel5.TabIndex = 9;
            // 
            // btn_Search
            // 
            btn_Search.BackColor = Color.White;
            btn_Search.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_Search.ForeColor = Color.DarkGreen;
            btn_Search.Location = new Point(380, 6);
            btn_Search.Name = "btn_Search";
            btn_Search.Size = new Size(156, 36);
            btn_Search.TabIndex = 3;
            btn_Search.Text = "Search";
            btn_Search.UseVisualStyleBackColor = false;
            btn_Search.Click += btn_Search_Click;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Location = new Point(52, 41);
            panel6.Margin = new Padding(2);
            panel6.Name = "panel6";
            panel6.Size = new Size(281, 2);
            panel6.TabIndex = 2;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.White;
            txtSearch.BorderStyle = BorderStyle.None;
            txtSearch.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.ForeColor = Color.Black;
            txtSearch.Location = new Point(52, 10);
            txtSearch.Margin = new Padding(2);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search here ...";
            txtSearch.Size = new Size(323, 23);
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
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaGreen;
            ClientSize = new Size(1217, 652);
            Controls.Add(panel5);
            Controls.Add(groupBox1);
            Controls.Add(pnProduct);
            Controls.Add(pnFilter);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmMenu";
            Load += FrmMenu_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox pnFilter;
        private FlowLayoutPanel pnProduct;
        private Button btnTotal;
        private Panel pnProdItems;
        private Panel panel1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label Name;
        private GroupBox groupBox1;
        private Panel panel5;
        private Panel panel6;
        private TextBox txtSearch;
        private PictureBox pictureBox1;
        private Button btn_Search;
    }
}