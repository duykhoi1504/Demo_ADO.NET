namespace PresentationLayer
{
    partial class FrmAllTransaction
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
            btnExport = new Button();
            btnImport = new Button();
            dgvTransaction = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTransaction).BeginInit();
            SuspendLayout();
            // 
            // btnExport
            // 
            btnExport.BackColor = Color.White;
            btnExport.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExport.ForeColor = Color.SeaGreen;
            btnExport.Location = new Point(720, 650);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(130, 60);
            btnExport.TabIndex = 82;
            btnExport.Text = "Export";
            btnExport.UseVisualStyleBackColor = false;
            btnExport.Click += btnExport_Click;
            // 
            // btnImport
            // 
            btnImport.BackColor = Color.White;
            btnImport.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnImport.ForeColor = Color.SeaGreen;
            btnImport.Location = new Point(436, 650);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(137, 60);
            btnImport.TabIndex = 81;
            btnImport.Text = "Import";
            btnImport.UseVisualStyleBackColor = false;
            btnImport.Click += btnImport_Click;
            // 
            // dgvTransaction
            // 
            dgvTransaction.BackgroundColor = Color.SeaGreen;
            dgvTransaction.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransaction.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dgvTransaction.Location = new Point(17, 87);
            dgvTransaction.Name = "dgvTransaction";
            dgvTransaction.RowHeadersWidth = 82;
            dgvTransaction.Size = new Size(1253, 537);
            dgvTransaction.TabIndex = 80;
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
            Column2.DataPropertyName = "ingredientID";
            Column2.HeaderText = "Ingredient ID";
            Column2.MinimumWidth = 10;
            Column2.Name = "Column2";
            Column2.Width = 200;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "quantity";
            Column3.HeaderText = "Quantity";
            Column3.MinimumWidth = 10;
            Column3.Name = "Column3";
            Column3.Width = 200;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "type";
            Column4.HeaderText = "Type";
            Column4.MinimumWidth = 10;
            Column4.Name = "Column4";
            Column4.Width = 200;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "date";
            Column5.HeaderText = "Date";
            Column5.MinimumWidth = 10;
            Column5.Name = "Column5";
            Column5.Width = 200;
            // 
            // Column6
            // 
            Column6.DataPropertyName = "note";
            Column6.HeaderText = "Note";
            Column6.MinimumWidth = 10;
            Column6.Name = "Column6";
            Column6.Width = 200;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(421, 28);
            label1.Name = "label1";
            label1.Size = new Size(419, 45);
            label1.TabIndex = 79;
            label1.Text = "All Inventory Transaction";
            // 
            // FrmAllTransaction
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaGreen;
            ClientSize = new Size(1287, 739);
            Controls.Add(btnExport);
            Controls.Add(btnImport);
            Controls.Add(dgvTransaction);
            Controls.Add(label1);
            Name = "FrmAllTransaction";
            Text = "All Transaction";
            Load += FrmAllTransaction_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTransaction).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExport;
        private Button btnImport;
        private DataGridView dgvTransaction;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private Label label1;
    }
}