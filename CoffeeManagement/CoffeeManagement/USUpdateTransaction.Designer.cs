namespace PresentationLayer
{
    partial class USUpdateTransaction
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
            label1 = new Label();
            label5 = new Label();
            txtNote = new TextBox();
            label6 = new Label();
            panel3 = new Panel();
            txtQuantity = new TextBox();
            label7 = new Label();
            btnCreate = new Button();
            btnCancel = new Button();
            btnClear = new Button();
            panel2 = new Panel();
            txtType = new TextBox();
            label2 = new Label();
            label3 = new Label();
            dtpDate = new DateTimePicker();
            cbIngredient = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(252, 31);
            label1.Name = "label1";
            label1.Size = new Size(284, 45);
            label1.TabIndex = 71;
            label1.Text = "New Transaction";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(41, 91);
            label5.Name = "label5";
            label5.Size = new Size(144, 37);
            label5.TabIndex = 77;
            label5.Text = "Ingredient";
            // 
            // txtNote
            // 
            txtNote.BackColor = Color.SeaGreen;
            txtNote.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNote.ForeColor = Color.White;
            txtNote.Location = new Point(191, 225);
            txtNote.Multiline = true;
            txtNote.Name = "txtNote";
            txtNote.Size = new Size(555, 77);
            txtNote.TabIndex = 76;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(41, 225);
            label6.Name = "label6";
            label6.Size = new Size(78, 37);
            label6.TabIndex = 75;
            label6.Text = "Note";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Location = new Point(189, 199);
            panel3.Name = "panel3";
            panel3.Size = new Size(228, 3);
            panel3.TabIndex = 74;
            // 
            // txtQuantity
            // 
            txtQuantity.BackColor = Color.SeaGreen;
            txtQuantity.BorderStyle = BorderStyle.None;
            txtQuantity.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtQuantity.ForeColor = Color.White;
            txtQuantity.Location = new Point(191, 159);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(228, 36);
            txtQuantity.TabIndex = 73;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(41, 158);
            label7.Name = "label7";
            label7.Size = new Size(124, 37);
            label7.TabIndex = 72;
            label7.Text = "Quantity";
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.White;
            btnCreate.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreate.ForeColor = Color.SeaGreen;
            btnCreate.Location = new Point(148, 333);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(134, 61);
            btnCreate.TabIndex = 80;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.White;
            btnCancel.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.SeaGreen;
            btnCancel.Location = new Point(506, 333);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(134, 61);
            btnCancel.TabIndex = 81;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.White;
            btnClear.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.SeaGreen;
            btnClear.Location = new Point(328, 333);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(134, 61);
            btnClear.TabIndex = 82;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(518, 130);
            panel2.Name = "panel2";
            panel2.Size = new Size(228, 3);
            panel2.TabIndex = 85;
            // 
            // txtType
            // 
            txtType.BackColor = Color.SeaGreen;
            txtType.BorderStyle = BorderStyle.None;
            txtType.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtType.ForeColor = Color.White;
            txtType.Location = new Point(520, 91);
            txtType.Name = "txtType";
            txtType.Size = new Size(228, 36);
            txtType.TabIndex = 84;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(439, 90);
            label2.Name = "label2";
            label2.Size = new Size(75, 37);
            label2.TabIndex = 83;
            label2.Text = "Type";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(439, 159);
            label3.Name = "label3";
            label3.Size = new Size(74, 37);
            label3.TabIndex = 86;
            label3.Text = "Date";
            // 
            // dtpDate
            // 
            dtpDate.Format = DateTimePickerFormat.Short;
            dtpDate.Location = new Point(518, 157);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(230, 39);
            dtpDate.TabIndex = 87;
            // 
            // cbIngredient
            // 
            cbIngredient.FormattingEnabled = true;
            cbIngredient.Location = new Point(189, 91);
            cbIngredient.Name = "cbIngredient";
            cbIngredient.Size = new Size(232, 40);
            cbIngredient.TabIndex = 88;
            // 
            // USUpdateTransaction
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaGreen;
            Controls.Add(cbIngredient);
            Controls.Add(dtpDate);
            Controls.Add(label3);
            Controls.Add(panel2);
            Controls.Add(txtType);
            Controls.Add(label2);
            Controls.Add(btnClear);
            Controls.Add(btnCancel);
            Controls.Add(btnCreate);
            Controls.Add(label5);
            Controls.Add(txtNote);
            Controls.Add(label6);
            Controls.Add(panel3);
            Controls.Add(txtQuantity);
            Controls.Add(label7);
            Controls.Add(label1);
            Name = "USUpdateTransaction";
            Size = new Size(788, 425);
            Load += USUpdateTransaction_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label5;
        private TextBox txtNote;
        private Label label6;
        private Panel panel3;
        private TextBox txtQuantity;
        private Label label7;
        private Button btnCreate;
        private Button btnCancel;
        private Button btnClear;
        private Panel panel2;
        private TextBox txtType;
        private Label label2;
        private Label label3;
        private DateTimePicker dtpDate;
        private ComboBox cbIngredient;
    }
}
