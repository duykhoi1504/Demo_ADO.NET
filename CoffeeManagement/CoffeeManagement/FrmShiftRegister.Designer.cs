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
            btn_Add = new Button();
            cb_Staff = new ComboBox();
            lblResult = new Label();
            dt_DateStart = new DateTimePicker();
            label3 = new Label();
            btn_SaveShift = new Button();
            btn_Close = new Button();
            label2 = new Label();
            pn_ShiftItems = new FlowLayoutPanel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(6, 29);
            label1.Name = "label1";
            label1.Size = new Size(103, 23);
            label1.TabIndex = 0;
            label1.Text = "Date Start :";
            // 
            // panel1
            // 
            panel1.BackColor = Color.SeaGreen;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btn_Add);
            panel1.Controls.Add(cb_Staff);
            panel1.Controls.Add(lblResult);
            panel1.Controls.Add(dt_DateStart);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(6, 45);
            panel1.Name = "panel1";
            panel1.Size = new Size(782, 87);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // btn_Add
            // 
            btn_Add.BackColor = Color.White;
            btn_Add.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btn_Add.ForeColor = Color.DarkGreen;
            btn_Add.Location = new Point(259, 26);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(94, 28);
            btn_Add.TabIndex = 3;
            btn_Add.Text = "Add";
            btn_Add.UseVisualStyleBackColor = false;
            btn_Add.Click += btn_Add_Click;
            // 
            // cb_Staff
            // 
            cb_Staff.FormattingEnabled = true;
            cb_Staff.Location = new Point(487, 23);
            cb_Staff.Name = "cb_Staff";
            cb_Staff.Size = new Size(247, 28);
            cb_Staff.TabIndex = 2;
            cb_Staff.SelectedIndexChanged += cb_Staff_SelectedIndexChanged;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblResult.ForeColor = Color.White;
            lblResult.Location = new Point(119, 59);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(134, 23);
            lblResult.TabIndex = 0;
            lblResult.Text = "Đăng ký ca làm";
            // 
            // dt_DateStart
            // 
            dt_DateStart.CustomFormat = "dd/MM/yyyy";
            dt_DateStart.Format = DateTimePickerFormat.Custom;
            dt_DateStart.Location = new Point(115, 26);
            dt_DateStart.Name = "dt_DateStart";
            dt_DateStart.Size = new Size(116, 27);
            dt_DateStart.TabIndex = 1;
            dt_DateStart.ValueChanged += dt_DateStart_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(425, 26);
            label3.Name = "label3";
            label3.Size = new Size(56, 23);
            label3.TabIndex = 0;
            label3.Text = "Staff:";
            // 
            // btn_SaveShift
            // 
            btn_SaveShift.BackColor = Color.White;
            btn_SaveShift.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btn_SaveShift.ForeColor = Color.DarkGreen;
            btn_SaveShift.Location = new Point(75, 501);
            btn_SaveShift.Name = "btn_SaveShift";
            btn_SaveShift.Size = new Size(296, 52);
            btn_SaveShift.TabIndex = 3;
            btn_SaveShift.Text = "Save Shift";
            btn_SaveShift.UseVisualStyleBackColor = false;
            btn_SaveShift.Click += btn_SaveShift_Click;
            // 
            // btn_Close
            // 
            btn_Close.BackColor = Color.White;
            btn_Close.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btn_Close.ForeColor = Color.DarkGreen;
            btn_Close.Location = new Point(431, 501);
            btn_Close.Name = "btn_Close";
            btn_Close.Size = new Size(296, 52);
            btn_Close.TabIndex = 3;
            btn_Close.Text = "Cancel";
            btn_Close.UseVisualStyleBackColor = false;
            btn_Close.Click += btn_Close_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 19.8000011F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(6, -6);
            label2.Name = "label2";
            label2.Size = new Size(317, 48);
            label2.TabIndex = 0;
            label2.Text = "Register Workday";
            // 
            // pn_ShiftItems
            // 
            pn_ShiftItems.BackColor = Color.SeaGreen;
            pn_ShiftItems.BorderStyle = BorderStyle.Fixed3D;
            pn_ShiftItems.Location = new Point(6, 156);
            pn_ShiftItems.Name = "pn_ShiftItems";
            pn_ShiftItems.Size = new Size(782, 296);
            pn_ShiftItems.TabIndex = 4;
            // 
            // FrmShiftRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaGreen;
            ClientSize = new Size(798, 565);
            Controls.Add(pn_ShiftItems);
            Controls.Add(btn_Close);
            Controls.Add(btn_SaveShift);
            Controls.Add(label2);
            Controls.Add(panel1);
            ForeColor = SystemColors.ControlText;
            Name = "FrmShiftRegister";
            Text = "FrmShiftRegister";
            Load += FrmShiftRegister_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Button btn_SaveShift;
        private Button btn_Close;
        private ComboBox cb_Staff;
        private DateTimePicker dt_DateStart;
        private Label label3;
        private Label label2;
        private Button btn_Add;
        private Label lblResult;
        private FlowLayoutPanel pn_ShiftItems;
    }
}