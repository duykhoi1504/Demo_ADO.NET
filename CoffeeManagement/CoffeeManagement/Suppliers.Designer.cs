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
            Clear = new Button();
            panel1 = new Panel();
            txt_address = new TextBox();
            txt_name = new TextBox();
            txt_id = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(9, 6);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(714, 219);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // AddSupllier
            // 
            AddSupllier.Location = new Point(437, 9);
            AddSupllier.Name = "AddSupllier";
            AddSupllier.Size = new Size(264, 38);
            AddSupllier.TabIndex = 1;
            AddSupllier.Text = "add";
            AddSupllier.UseVisualStyleBackColor = true;
            AddSupllier.Click += AddSupllier_Click;
            // 
            // Clear
            // 
            Clear.Location = new Point(437, 56);
            Clear.Name = "Clear";
            Clear.Size = new Size(264, 44);
            Clear.TabIndex = 3;
            Clear.Text = "Clear";
            Clear.UseVisualStyleBackColor = true;
            Clear.Click += Clear_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(txt_address);
            panel1.Controls.Add(txt_name);
            panel1.Controls.Add(txt_id);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(Clear);
            panel1.Controls.Add(AddSupllier);
            panel1.Location = new Point(3, 231);
            panel1.Name = "panel1";
            panel1.Size = new Size(720, 254);
            panel1.TabIndex = 5;
            // 
            // txt_address
            // 
            txt_address.Location = new Point(85, 99);
            txt_address.Name = "txt_address";
            txt_address.Size = new Size(323, 27);
            txt_address.TabIndex = 6;
            // 
            // txt_name
            // 
            txt_name.Location = new Point(85, 56);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(323, 27);
            txt_name.TabIndex = 6;
            // 
            // txt_id
            // 
            txt_id.Location = new Point(85, 6);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(323, 27);
            txt_id.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 103);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 5;
            label3.Text = "Address:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 56);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 5;
            label2.Text = "Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 9);
            label1.Name = "label1";
            label1.Size = new Size(27, 20);
            label1.TabIndex = 5;
            label1.Text = "ID:";
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(panel1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(731, 488);
            panel2.TabIndex = 6;
            // 
            // Suppliers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(731, 488);
            Controls.Add(panel2);
            Name = "Suppliers";
            Text = "Suppliers";
            Load += Suppliers_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button AddSupllier;
        private Button Clear;
        private Panel panel1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txt_id;
        private TextBox txt_address;
        private TextBox txt_name;
        private Panel panel2;
    }
}