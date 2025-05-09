namespace PresentationLayer
{
    partial class FrmAddSupplier
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
            close = new Button();
            SaveSupplier = new Button();
            txtAdress = new TextBox();
            txtName = new TextBox();
            txtId = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // close
            // 
            close.BackColor = Color.White;
            close.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            close.Location = new Point(246, 196);
            close.Name = "close";
            close.Size = new Size(94, 29);
            close.TabIndex = 7;
            close.Text = "close";
            close.UseVisualStyleBackColor = false;
            close.Click += close_Click;
            // 
            // SaveSupplier
            // 
            SaveSupplier.BackColor = Color.White;
            SaveSupplier.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            SaveSupplier.Location = new Point(102, 193);
            SaveSupplier.Name = "SaveSupplier";
            SaveSupplier.Size = new Size(94, 29);
            SaveSupplier.TabIndex = 6;
            SaveSupplier.Text = "save";
            SaveSupplier.UseVisualStyleBackColor = false;
            SaveSupplier.Click += SaveSupplier_Click;
            // 
            // txtAdress
            // 
            txtAdress.Location = new Point(99, 128);
            txtAdress.Name = "txtAdress";
            txtAdress.Size = new Size(273, 27);
            txtAdress.TabIndex = 3;
            // 
            // txtName
            // 
            txtName.Location = new Point(99, 73);
            txtName.Name = "txtName";
            txtName.Size = new Size(273, 27);
            txtName.TabIndex = 4;
            // 
            // txtId
            // 
            txtId.Location = new Point(99, 30);
            txtId.Name = "txtId";
            txtId.Size = new Size(273, 27);
            txtId.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(14, 132);
            label3.Name = "label3";
            label3.Size = new Size(79, 23);
            label3.TabIndex = 8;
            label3.Text = "Address:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(31, 77);
            label2.Name = "label2";
            label2.Size = new Size(62, 23);
            label2.TabIndex = 9;
            label2.Text = "Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(55, 34);
            label1.Name = "label1";
            label1.Size = new Size(33, 23);
            label1.TabIndex = 10;
            label1.Text = "ID:";
            // 
            // FrmAddSupplier
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaGreen;
            ClientSize = new Size(470, 255);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(close);
            Controls.Add(SaveSupplier);
            Controls.Add(txtAdress);
            Controls.Add(txtName);
            Controls.Add(txtId);
            Name = "FrmAddSupplier";
            Text = "FrmAddSupplier";
            Load += FrmAddSupplier_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button close;
        private Button SaveSupplier;
        private TextBox txtAdress;
        private TextBox txtName;
        private TextBox txtId;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}