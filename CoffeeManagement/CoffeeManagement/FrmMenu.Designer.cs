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
            groupBox1 = new GroupBox();
            panel1 = new Panel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            Name = new Label();
            pnProdItems = new Panel();
            btnTotal = new Button();
            btnAddCustomer = new Button();
            txtCustomePhone = new TextBox();
            txtCustomerName = new TextBox();
            btnShowAllProduct = new Button();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
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
            pnFilter.BackColor = SystemColors.ButtonFace;
            pnFilter.Location = new Point(12, 49);
            pnFilter.Name = "pnFilter";
            pnFilter.Size = new Size(824, 125);
            pnFilter.TabIndex = 2;
            pnFilter.TabStop = false;
            pnFilter.Text = "Phân loại";
            // 
            // pnProduct
            // 
            pnProduct.BackColor = SystemColors.Control;
            pnProduct.Location = new Point(12, 180);
            pnProduct.Name = "pnProduct";
            pnProduct.Size = new Size(824, 322);
            pnProduct.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Control;
            groupBox1.Controls.Add(panel1);
            groupBox1.Controls.Add(pnProdItems);
            groupBox1.Controls.Add(btnTotal);
            groupBox1.Controls.Add(btnAddCustomer);
            groupBox1.Controls.Add(txtCustomePhone);
            groupBox1.Controls.Add(txtCustomerName);
            groupBox1.Location = new Point(842, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(403, 628);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "CART";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(Name);
            panel1.Location = new Point(6, 113);
            panel1.Name = "panel1";
            panel1.Size = new Size(391, 49);
            panel1.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(339, 16);
            label4.Name = "label4";
            label4.Size = new Size(42, 20);
            label4.TabIndex = 0;
            label4.Text = "Total";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(202, 16);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 0;
            label3.Text = "Quantity";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(87, 16);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 0;
            label2.Text = "Price";
            // 
            // Name
            // 
            Name.AutoSize = true;
            Name.Location = new Point(3, 16);
            Name.Name = "Name";
            Name.Size = new Size(49, 20);
            Name.TabIndex = 0;
            Name.Text = "Name";
            // 
            // pnProdItems
            // 
            pnProdItems.AutoScroll = true;
            pnProdItems.Location = new Point(6, 168);
            pnProdItems.Name = "pnProdItems";
            pnProdItems.Size = new Size(391, 401);
            pnProdItems.TabIndex = 3;
            // 
            // btnTotal
            // 
            btnTotal.Location = new Point(68, 575);
            btnTotal.Name = "btnTotal";
            btnTotal.Size = new Size(260, 47);
            btnTotal.TabIndex = 2;
            btnTotal.Text = "Total Price: 0 ";
            btnTotal.UseVisualStyleBackColor = true;
            btnTotal.Click += btnTotal_Click;
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.Location = new Point(246, 26);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Size = new Size(70, 55);
            btnAddCustomer.TabIndex = 1;
            btnAddCustomer.Text = "Check";
            btnAddCustomer.UseVisualStyleBackColor = true;
            btnAddCustomer.Click += btnAddCustomer_Click_1;
            // 
            // txtCustomePhone
            // 
            txtCustomePhone.Location = new Point(6, 74);
            txtCustomePhone.Name = "txtCustomePhone";
            txtCustomePhone.Size = new Size(206, 27);
            txtCustomePhone.TabIndex = 0;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(6, 26);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(206, 27);
            txtCustomerName.TabIndex = 0;
            // 
            // btnShowAllProduct
            // 
            btnShowAllProduct.Location = new Point(12, 508);
            btnShowAllProduct.Name = "btnShowAllProduct";
            btnShowAllProduct.Size = new Size(182, 42);
            btnShowAllProduct.TabIndex = 4;
            btnShowAllProduct.Text = "All Product";
            btnShowAllProduct.UseVisualStyleBackColor = true;
            btnShowAllProduct.Click += btnShowAllProduct_Click;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1257, 652);
            Controls.Add(btnShowAllProduct);
            Controls.Add(groupBox1);
            Controls.Add(pnProduct);
            Controls.Add(pnFilter);
            Controls.Add(label1);
            Text = "FrmMenu";
            Load += FrmMenu_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox pnFilter;
        private FlowLayoutPanel pnProduct;
        private GroupBox groupBox1;
        private Panel pnProdItems;
        private Button btnTotal;
        private Button btnAddCustomer;
        private TextBox txtCustomePhone;
        private TextBox txtCustomerName;
        private Panel panel1;
        private Label Name;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnShowAllProduct;
    }
}