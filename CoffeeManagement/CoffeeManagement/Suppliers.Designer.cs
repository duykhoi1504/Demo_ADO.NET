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
            usp_addSupplier = new AddSupplier();
            Delete = new Button();
            btn_update = new Button();
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
            AddSupllier.Location = new Point(46, 251);
            AddSupllier.Name = "AddSupllier";
            AddSupllier.Size = new Size(94, 29);
            AddSupllier.TabIndex = 1;
            AddSupllier.Text = "add";
            AddSupllier.UseVisualStyleBackColor = true;
            AddSupllier.Click += AddSupllier_Click;
            // 
            // usp_addSupplier
            // 
            usp_addSupplier.BackColor = SystemColors.ActiveCaption;
            usp_addSupplier.Location = new Point(355, 216);
            usp_addSupplier.Name = "usp_addSupplier";
            usp_addSupplier.Size = new Size(420, 244);
            usp_addSupplier.TabIndex = 2;
            usp_addSupplier.Load += usp_addSupplier_Load;
            // 
            // Delete
            // 
            Delete.Location = new Point(146, 251);
            Delete.Name = "Delete";
            Delete.Size = new Size(94, 29);
            Delete.TabIndex = 3;
            Delete.Text = "Clear";
            Delete.UseVisualStyleBackColor = true;
            Delete.Click += Delete_Click;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(255, 251);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(94, 29);
            btn_update.TabIndex = 4;
            btn_update.Text = "update";
            btn_update.UseCompatibleTextRendering = true;
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // Suppliers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(822, 491);
            Controls.Add(btn_update);
            Controls.Add(Delete);
            Controls.Add(usp_addSupplier);
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
        private AddSupplier usp_addSupplier;
        private Button Delete;
        private Button btn_update;
    }
}