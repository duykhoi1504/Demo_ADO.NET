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
            lb_salary = new TextBox();
            cbStaff = new ComboBox();
            label3 = new Label();
            dt_Date = new DateTimePicker();
            label1 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_Shift).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_CalSalary
            // 
            btn_CalSalary.BackColor = Color.White;
            btn_CalSalary.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btn_CalSalary.ForeColor = Color.DarkGreen;
            btn_CalSalary.Location = new Point(548, 7);
            btn_CalSalary.Name = "btn_CalSalary";
            btn_CalSalary.Size = new Size(216, 80);
            btn_CalSalary.TabIndex = 7;
            btn_CalSalary.Text = "Cal Salary";
            btn_CalSalary.UseVisualStyleBackColor = false;
            btn_CalSalary.Click += btn_CalSalary_Click;
            // 
            // btn_Close
            // 
            btn_Close.BackColor = Color.White;
            btn_Close.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btn_Close.ForeColor = Color.DarkGreen;
            btn_Close.Location = new Point(650, 480);
            btn_Close.Name = "btn_Close";
            btn_Close.Size = new Size(140, 52);
            btn_Close.TabIndex = 8;
            btn_Close.Text = "Close";
            btn_Close.UseVisualStyleBackColor = false;
            btn_Close.Click += btn_SaveShift_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 19.8000011F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(-3, 9);
            label2.Name = "label2";
            label2.Size = new Size(490, 48);
            label2.TabIndex = 4;
            label2.Text = "Confirm and calculate salary";
            // 
            // dgv_Shift
            // 
            dgv_Shift.BackgroundColor = Color.SeaGreen;
            dgv_Shift.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Shift.Location = new Point(-3, 165);
            dgv_Shift.Name = "dgv_Shift";
            dgv_Shift.RowHeadersWidth = 51;
            dgv_Shift.Size = new Size(793, 309);
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
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-3, 60);
            panel1.Name = "panel1";
            panel1.Size = new Size(793, 99);
            panel1.TabIndex = 5;
            // 
            // lb_salary
            // 
            lb_salary.Location = new Point(174, 60);
            lb_salary.Name = "lb_salary";
            lb_salary.ReadOnly = true;
            lb_salary.Size = new Size(368, 27);
            lb_salary.TabIndex = 10;
            // 
            // cbStaff
            // 
            cbStaff.FormattingEnabled = true;
            cbStaff.Location = new Point(289, 13);
            cbStaff.Name = "cbStaff";
            cbStaff.Size = new Size(253, 28);
            cbStaff.TabIndex = 9;
            cbStaff.SelectedIndexChanged += cbStaff_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(59, 64);
            label3.Name = "label3";
            label3.Size = new Size(109, 23);
            label3.TabIndex = 9;
            label3.Text = "Total Salary:";
            // 
            // dt_Date
            // 
            dt_Date.CustomFormat = "MM/yyyy";
            dt_Date.Format = DateTimePickerFormat.Custom;
            dt_Date.Location = new Point(84, 12);
            dt_Date.Name = "dt_Date";
            dt_Date.RightToLeft = RightToLeft.No;
            dt_Date.Size = new Size(102, 27);
            dt_Date.TabIndex = 1;
            dt_Date.ValueChanged += dt_Date_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(15, 13);
            label1.Name = "label1";
            label1.Size = new Size(53, 23);
            label1.TabIndex = 0;
            label1.Text = "Date:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(214, 15);
            label4.Name = "label4";
            label4.Size = new Size(56, 23);
            label4.TabIndex = 0;
            label4.Text = "Staff:";
            // 
            // FrmShiftConfirm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaGreen;
            ClientSize = new Size(791, 538);
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
        private Label label4;
    }
}