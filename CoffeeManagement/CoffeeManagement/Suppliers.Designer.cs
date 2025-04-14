namespace PresentationLayer
{
    partial class Suppliers
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
            dataGridView1 = new DataGridView();
            AddSupllier = new Button();
            addSupplier1 = new AddSupplier();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(1, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(787, 211);
            dataGridView1.TabIndex = 0;
            // 
            // AddSupllier
            // 
            AddSupllier.Location = new Point(47, 284);
            AddSupllier.Name = "AddSupllier";
            AddSupllier.Size = new Size(94, 29);
            AddSupllier.TabIndex = 1;
            AddSupllier.Text = "add";
            AddSupllier.UseVisualStyleBackColor = true;
            AddSupllier.Click += AddSupllier_Click;
            // 
            // addSupplier1
            // 
            addSupplier1.Location = new Point(179, 95);
            addSupplier1.Name = "addSupplier1";
            addSupplier1.Size = new Size(463, 250);
            addSupplier1.TabIndex = 2;
            // 
            // Suppliers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(addSupplier1);
            Controls.Add(AddSupllier);
            Controls.Add(dataGridView1);
            Name = "Suppliers";
            Text = "Suppliers";
            Load += Suppliers_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button AddSupllier;
        private AddSupplier addSupplier1;
    }
}