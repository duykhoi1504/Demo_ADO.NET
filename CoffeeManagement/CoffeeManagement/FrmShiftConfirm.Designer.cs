namespace PresentationLayer
{
    partial class FrmShiftConfirm
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
            btn_CalSalary = new Button();
            btn_Close = new Button();
            label2 = new Label();
            dgv_Shift = new DataGridView();
            panel1 = new Panel();
            cbStaff = new ComboBox();
            dt_Date = new DateTimePicker();
            label1 = new Label();
            label3 = new Label();
            lb_salary = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgv_Shift).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_CalSalary
            // 
            btn_CalSalary.Location = new Point(557, 3);
            btn_CalSalary.Name = "btn_CalSalary";
            btn_CalSalary.Size = new Size(216, 92);
            btn_CalSalary.TabIndex = 7;
            btn_CalSalary.Text = "Cal Salary";
            btn_CalSalary.UseVisualStyleBackColor = true;
            btn_CalSalary.Click += btn_CalSalary_Click;
            // 
            // btn_Close
            // 
            btn_Close.Location = new Point(639, 465);
            btn_Close.Name = "btn_Close";
            btn_Close.Size = new Size(140, 52);
            btn_Close.TabIndex = 8;
            btn_Close.Text = "Close";
            btn_Close.UseVisualStyleBackColor = true;
            btn_Close.Click += btn_SaveShift_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(257, 20);
            label2.TabIndex = 4;
            label2.Text = "Xác nhận hoàn thành ca và tính lương";
            // 
            // dgv_Shift
            // 
            dgv_Shift.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Shift.Location = new Point(6, 150);
            dgv_Shift.Name = "dgv_Shift";
            dgv_Shift.RowHeadersWidth = 51;
            dgv_Shift.Size = new Size(782, 309);
            dgv_Shift.TabIndex = 6;
            dgv_Shift.CellContentClick += dgv_Shift_CellContentClick;
            // 
            // panel1
            // 
            panel1.Controls.Add(lb_salary);
            panel1.Controls.Add(cbStaff);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(dt_Date);
            panel1.Controls.Add(btn_CalSalary);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(6, 45);
            panel1.Name = "panel1";
            panel1.Size = new Size(782, 99);
            panel1.TabIndex = 5;
            // 
            // cbStaff
            // 
            cbStaff.FormattingEnabled = true;
            cbStaff.Location = new Point(269, 13);
            cbStaff.Name = "cbStaff";
            cbStaff.Size = new Size(262, 28);
            cbStaff.TabIndex = 9;
            cbStaff.SelectedIndexChanged += cbStaff_SelectedIndexChanged;
            // 
            // dt_Date
            // 
            dt_Date.CustomFormat = "MM/yyyy";
            dt_Date.Format = DateTimePickerFormat.Custom;
            dt_Date.Location = new Point(94, 11);
            dt_Date.Name = "dt_Date";
            dt_Date.RightToLeft = RightToLeft.No;
            dt_Date.Size = new Size(139, 27);
            dt_Date.TabIndex = 1;
            dt_Date.ValueChanged += dt_Date_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 11);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 0;
            label1.Text = "Chọn ngày:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 60);
            label3.Name = "label3";
            label3.Size = new Size(128, 20);
            label3.TabIndex = 9;
            label3.Text = "Lương nhận được:";
            // 
            // lb_salary
            // 
            lb_salary.Location = new Point(145, 60);
            lb_salary.Name = "lb_salary";
            lb_salary.ReadOnly = true;
            lb_salary.Size = new Size(319, 27);
            lb_salary.TabIndex = 10;
            // 
            // FrmShiftConfirm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(791, 518);
            Controls.Add(btn_Close);
            Controls.Add(label2);
            Controls.Add(dgv_Shift);
            Controls.Add(panel1);
            Name = "FrmShiftConfirm";
            Text = "FrmShiftConfirm";
            Load += FrmShiftConfirm_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Shift).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_CalSalary;
        private Button btn_Close;
        private Label label2;
        private DataGridView dgv_Shift;
        private Panel panel1;
        private DateTimePicker dt_Date;
        private Label label1;
        private ComboBox cbStaff;
        private Label label3;
        private TextBox lb_salary;
    }
}