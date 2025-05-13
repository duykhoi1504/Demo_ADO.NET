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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Suppliers));
            dataGridView1 = new DataGridView();
            AddSupllier = new Button();
            Clear = new Button();
            txt_address = new TextBox();
            txt_name = new TextBox();
            txt_id = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            AddGroupbox = new GroupBox();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            AddGroupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.SeaGreen;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(9, 60);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1178, 327);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // AddSupllier
            // 
            AddSupllier.BackColor = Color.White;
            AddSupllier.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            AddSupllier.ForeColor = Color.DarkGreen;
            AddSupllier.Location = new Point(741, 48);
            AddSupllier.Name = "AddSupllier";
            AddSupllier.Size = new Size(264, 38);
            AddSupllier.TabIndex = 1;
            AddSupllier.Text = "Add";
            AddSupllier.UseVisualStyleBackColor = false;
            AddSupllier.Click += AddSupllier_Click;
            // 
            // Clear
            // 
            Clear.BackColor = Color.White;
            Clear.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Clear.ForeColor = Color.DarkGreen;
            Clear.Location = new Point(741, 95);
            Clear.Name = "Clear";
            Clear.Size = new Size(264, 44);
            Clear.TabIndex = 3;
            Clear.Text = "Clear";
            Clear.UseVisualStyleBackColor = false;
            Clear.Click += Clear_Click;
            // 
            // txt_address
            // 
            txt_address.Location = new Point(389, 138);
            txt_address.Name = "txt_address";
            txt_address.Size = new Size(323, 34);
            txt_address.TabIndex = 6;
            // 
            // txt_name
            // 
            txt_name.Location = new Point(389, 95);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(323, 34);
            txt_name.TabIndex = 6;
            // 
            // txt_id
            // 
            txt_id.Location = new Point(389, 45);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(323, 34);
            txt_id.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(289, 142);
            label3.Name = "label3";
            label3.Size = new Size(92, 28);
            label3.TabIndex = 5;
            label3.Text = "Address:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(289, 95);
            label2.Name = "label2";
            label2.Size = new Size(73, 28);
            label2.TabIndex = 5;
            label2.Text = "Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(289, 48);
            label1.Name = "label1";
            label1.Size = new Size(38, 28);
            label1.TabIndex = 5;
            label1.Text = "ID:";
            // 
            // panel2
            // 
            panel2.Controls.Add(label4);
            panel2.Controls.Add(AddGroupbox);
            panel2.Controls.Add(dataGridView1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1199, 620);
            panel2.TabIndex = 6;
            // 
            // AddGroupbox
            // 
            AddGroupbox.Controls.Add(pictureBox2);
            AddGroupbox.Controls.Add(txt_address);
            AddGroupbox.Controls.Add(label1);
            AddGroupbox.Controls.Add(txt_name);
            AddGroupbox.Controls.Add(AddSupllier);
            AddGroupbox.Controls.Add(txt_id);
            AddGroupbox.Controls.Add(Clear);
            AddGroupbox.Controls.Add(label3);
            AddGroupbox.Controls.Add(label2);
            AddGroupbox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddGroupbox.ForeColor = Color.White;
            AddGroupbox.Location = new Point(9, 393);
            AddGroupbox.Name = "AddGroupbox";
            AddGroupbox.Size = new Size(1178, 227);
            AddGroupbox.TabIndex = 7;
            AddGroupbox.TabStop = false;
            AddGroupbox.Text = "Add Supplier";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(5, 45);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(268, 182);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 32;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(14, 9);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(169, 48);
            label4.TabIndex = 8;
            label4.Text = "Suppliers";
            // 
            // Suppliers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaGreen;
            ClientSize = new Size(1199, 620);
            Controls.Add(panel2);
            MaximumSize = new Size(1217, 667);
            MinimumSize = new Size(1217, 667);
            Name = "Suppliers";
            Text = "Suppliers";
            Load += Suppliers_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            AddGroupbox.ResumeLayout(false);
            AddGroupbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button AddSupllier;
        private Button Clear;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txt_id;
        private TextBox txt_address;
        private TextBox txt_name;
        private Panel panel2;
        private GroupBox AddGroupbox;
        private PictureBox pictureBox2;
        private Label label4;
    }
}