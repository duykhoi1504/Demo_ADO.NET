namespace PresentationLayer
{
    partial class USUpdateCoupon
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
            btnCancel = new Button();
            btnClear = new Button();
            btnConfirm = new Button();
            label1 = new Label();
            txtID = new TextBox();
            label4 = new Label();
            panel2 = new Panel();
            txtValue = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            txtDes = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.White;
            btnCancel.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.SeaGreen;
            btnCancel.Location = new Point(674, 285);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(166, 59);
            btnCancel.TabIndex = 17;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.White;
            btnClear.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.SeaGreen;
            btnClear.Location = new Point(425, 285);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(166, 59);
            btnClear.TabIndex = 18;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.White;
            btnConfirm.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirm.ForeColor = Color.SeaGreen;
            btnConfirm.Location = new Point(180, 285);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(166, 59);
            btnConfirm.TabIndex = 16;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(378, 21);
            label1.Name = "label1";
            label1.Size = new Size(265, 45);
            label1.TabIndex = 19;
            label1.Text = "Update Coupon";
            // 
            // txtID
            // 
            txtID.BackColor = Color.SeaGreen;
            txtID.BorderStyle = BorderStyle.None;
            txtID.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtID.ForeColor = Color.White;
            txtID.Location = new Point(164, 98);
            txtID.Name = "txtID";
            txtID.Size = new Size(228, 36);
            txtID.TabIndex = 24;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(43, 98);
            label4.Name = "label4";
            label4.Size = new Size(44, 37);
            label4.TabIndex = 23;
            label4.Text = "ID";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(162, 227);
            panel2.Name = "panel2";
            panel2.Size = new Size(228, 3);
            panel2.TabIndex = 22;
            // 
            // txtValue
            // 
            txtValue.BackColor = Color.SeaGreen;
            txtValue.BorderStyle = BorderStyle.None;
            txtValue.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtValue.ForeColor = Color.White;
            txtValue.Location = new Point(164, 187);
            txtValue.Name = "txtValue";
            txtValue.Size = new Size(228, 36);
            txtValue.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(43, 187);
            label2.Name = "label2";
            label2.Size = new Size(83, 37);
            label2.TabIndex = 20;
            label2.Text = "Value";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Location = new Point(162, 140);
            panel1.Name = "panel1";
            panel1.Size = new Size(228, 3);
            panel1.TabIndex = 25;
            // 
            // txtDes
            // 
            txtDes.BackColor = Color.SeaGreen;
            txtDes.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDes.ForeColor = Color.White;
            txtDes.Location = new Point(617, 98);
            txtDes.Multiline = true;
            txtDes.Name = "txtDes";
            txtDes.Size = new Size(356, 132);
            txtDes.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(435, 98);
            label3.Name = "label3";
            label3.Size = new Size(157, 37);
            label3.TabIndex = 26;
            label3.Text = "Description";
            // 
            // USUpdateCoupon
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaGreen;
            Controls.Add(txtDes);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(txtID);
            Controls.Add(label4);
            Controls.Add(panel2);
            Controls.Add(txtValue);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnClear);
            Controls.Add(btnConfirm);
            Name = "USUpdateCoupon";
            Size = new Size(1020, 384);
            Load += USUpdateCoupon_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnClear;
        private Button btnConfirm;
        private Label label1;
        private TextBox txtID;
        private Label label4;
        private Panel panel2;
        private TextBox txtValue;
        private Label label2;
        private Panel panel1;
        private TextBox txtDes;
        private Label label3;
    }
}
