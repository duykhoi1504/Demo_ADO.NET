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
            pnProdItems = new Panel();
            btnTotal = new Button();
            btnAddCustomer = new Button();
            txtCustomePhone = new TextBox();
            txtCustomerName = new TextBox();
            groupBox1.SuspendLayout();
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
            // pnProdItems
            // 
            pnProdItems.AutoScroll = true;
            pnProdItems.Location = new Point(6, 107);
            pnProdItems.Name = "pnProdItems";
            pnProdItems.Size = new Size(391, 462);
            pnProdItems.TabIndex = 3;
            // 
            // btnTotal
            // 
            btnTotal.Location = new Point(68, 575);
            btnTotal.Name = "btnTotal";
            btnTotal.Size = new Size(260, 47);
            btnTotal.TabIndex = 2;
            btnTotal.Text = "0000VND";
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
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1257, 652);
            Controls.Add(groupBox1);
            Controls.Add(pnProduct);
            Controls.Add(pnFilter);
            Controls.Add(label1);
            Name = "FrmMenu";
            Text = "FrmMenu";
            Load += FrmMenu_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
    }
}