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
            label4 = new Label();
            SuspendLayout();
            // 
            // close
            // 
            close.BackColor = Color.White;
            close.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            close.Location = new Point(256, 218);
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
            SaveSupplier.Location = new Point(112, 215);
            SaveSupplier.Name = "SaveSupplier";
            SaveSupplier.Size = new Size(94, 29);
            SaveSupplier.TabIndex = 6;
            SaveSupplier.Text = "save";
            SaveSupplier.UseVisualStyleBackColor = false;
            SaveSupplier.Click += SaveSupplier_Click;
            // 
            // txtAdress
            // 
            txtAdress.Location = new Point(109, 150);
            txtAdress.Name = "txtAdress";
            txtAdress.Size = new Size(273, 27);
            txtAdress.TabIndex = 3;
            // 
            // txtName
            // 
            txtName.Location = new Point(109, 95);
            txtName.Name = "txtName";
            txtName.Size = new Size(273, 27);
            txtName.TabIndex = 4;
            // 
            // txtId
            // 
            txtId.Location = new Point(109, 52);
            txtId.Name = "txtId";
            txtId.Size = new Size(273, 27);
            txtId.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(24, 154);
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
            label2.Location = new Point(41, 99);
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
            label1.Location = new Point(65, 56);
            label1.Name = "label1";
            label1.Size = new Size(33, 23);
            label1.TabIndex = 10;
            label1.Text = "ID:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(-4, -3);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(235, 39);
            label4.TabIndex = 11;
            label4.Text = "Update Supplier";
            label4.Click += label4_Click;
            // 
            // FrmAddSupplier
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaGreen;
            ClientSize = new Size(470, 279);
            Controls.Add(label4);
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
        private Label label4;
    }
}