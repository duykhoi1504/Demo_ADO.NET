namespace PresentationLayer
{
    partial class FrmShiftRegister
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
            label1 = new Label();
            panel1 = new Panel();
            cb_Staff = new ComboBox();
            dt_DateStart = new DateTimePicker();
            label3 = new Label();
            dgv_Shift = new DataGridView();
            btn_SaveShift = new Button();
            btn_Close = new Button();
            label2 = new Label();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewComboBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Shift).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 29);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 0;
            label1.Text = "Date Start :";
            // 
            // panel1
            // 
            panel1.Controls.Add(cb_Staff);
            panel1.Controls.Add(dt_DateStart);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(6, 45);
            panel1.Name = "panel1";
            panel1.Size = new Size(782, 79);
            panel1.TabIndex = 1;
            // 
            // cb_Staff
            // 
            cb_Staff.FormattingEnabled = true;
            cb_Staff.Location = new Point(585, 29);
            cb_Staff.Name = "cb_Staff";
            cb_Staff.Size = new Size(151, 28);
            cb_Staff.TabIndex = 2;
            // 
            // dt_DateStart
            // 
            dt_DateStart.Location = new Point(95, 27);
            dt_DateStart.Name = "dt_DateStart";
            dt_DateStart.Size = new Size(250, 27);
            dt_DateStart.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(515, 32);
            label3.Name = "label3";
            label3.Size = new Size(43, 20);
            label3.TabIndex = 0;
            label3.Text = "Staff:";
            // 
            // dgv_Shift
            // 
            dgv_Shift.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Shift.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dgv_Shift.Location = new Point(6, 130);
            dgv_Shift.Name = "dgv_Shift";
            dgv_Shift.RowHeadersWidth = 51;
            dgv_Shift.Size = new Size(782, 309);
            dgv_Shift.TabIndex = 2;
            // 
            // btn_SaveShift
            // 
            btn_SaveShift.Location = new Point(81, 458);
            btn_SaveShift.Name = "btn_SaveShift";
            btn_SaveShift.Size = new Size(296, 52);
            btn_SaveShift.TabIndex = 3;
            btn_SaveShift.Text = "Save Shift";
            btn_SaveShift.UseVisualStyleBackColor = true;
            // 
            // btn_Close
            // 
            btn_Close.Location = new Point(437, 458);
            btn_Close.Name = "btn_Close";
            btn_Close.Size = new Size(296, 52);
            btn_Close.TabIndex = 3;
            btn_Close.Text = "Cancel";
            btn_Close.UseVisualStyleBackColor = true;
            btn_Close.Click += btn_Close_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(111, 20);
            label2.TabIndex = 0;
            label2.Text = "Đăng ký ca làm";
            // 
            // Column1
            // 
            Column1.HeaderText = "Thứ";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "ngày";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Ca làm";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // FrmShiftRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(798, 565);
            Controls.Add(btn_Close);
            Controls.Add(btn_SaveShift);
            Controls.Add(label2);
            Controls.Add(dgv_Shift);
            Controls.Add(panel1);
            Name = "FrmShiftRegister";
            Text = "FrmShiftRegister";
            Load += FrmShiftRegister_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Shift).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private DataGridView dgv_Shift;
        private Button btn_SaveShift;
        private Button btn_Close;
        private ComboBox cb_Staff;
        private DateTimePicker dt_DateStart;
        private Label label3;
        private Label label2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewComboBoxColumn Column3;
    }
}