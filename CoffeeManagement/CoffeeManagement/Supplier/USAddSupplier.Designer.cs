namespace PresentationLayer
{
    partial class USAddSupplier
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
            txtId = new TextBox();
            txtName = new TextBox();
            txtAdress = new TextBox();
            SaveSupplier = new Button();
            close = new Button();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Location = new Point(71, 43);
            txtId.Name = "txtId";
            txtId.Size = new Size(273, 27);
            txtId.TabIndex = 0;
            // 
            // txtName
            // 
            txtName.Location = new Point(71, 86);
            txtName.Name = "txtName";
            txtName.Size = new Size(273, 27);
            txtName.TabIndex = 0;
            // 
            // txtAdress
            // 
            txtAdress.Location = new Point(71, 141);
            txtAdress.Name = "txtAdress";
            txtAdress.Size = new Size(273, 27);
            txtAdress.TabIndex = 0;
            // 
            // SaveSupplier
            // 
            SaveSupplier.Location = new Point(74, 206);
            SaveSupplier.Name = "SaveSupplier";
            SaveSupplier.Size = new Size(94, 29);
            SaveSupplier.TabIndex = 1;
            SaveSupplier.Text = "save";
            SaveSupplier.UseVisualStyleBackColor = true;
            SaveSupplier.Click += SaveSupplier_Click;
            // 
            // close
            // 
            close.Location = new Point(218, 209);
            close.Name = "close";
            close.Size = new Size(94, 29);
            close.TabIndex = 2;
            close.Text = "close";
            close.UseVisualStyleBackColor = true;
            close.Click += close_Click;
            // 
            // AddSupplier
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(close);
            Controls.Add(SaveSupplier);
            Controls.Add(txtAdress);
            Controls.Add(txtName);
            Controls.Add(txtId);
            MaximumSize = new Size(430, 353);
            MinimumSize = new Size(430, 353);
            Name = "AddSupplier";
            Size = new Size(430, 353);
            Load += AddSupplier_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private TextBox txtName;
        private TextBox txtAdress;
        private Button SaveSupplier;
        private Button close;
    }
}
