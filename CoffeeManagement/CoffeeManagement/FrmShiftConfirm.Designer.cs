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
            btn_PrintPDF = new Button();
            btn_SaveShift = new Button();
            label2 = new Label();
            dgv_Shift = new DataGridView();
            panel1 = new Panel();
            cbStaff = new ComboBox();
            dt_DateStart = new DateTimePicker();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_Shift).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_PrintPDF
            // 
            btn_PrintPDF.Location = new Point(437, 458);
            btn_PrintPDF.Name = "btn_PrintPDF";
            btn_PrintPDF.Size = new Size(296, 52);
            btn_PrintPDF.TabIndex = 7;
            btn_PrintPDF.Text = "Print";
            btn_PrintPDF.UseVisualStyleBackColor = true;
            // 
            // btn_SaveShift
            // 
            btn_SaveShift.Location = new Point(81, 458);
            btn_SaveShift.Name = "btn_SaveShift";
            btn_SaveShift.Size = new Size(296, 52);
            btn_SaveShift.TabIndex = 8;
            btn_SaveShift.Text = "Confirm";
            btn_SaveShift.UseVisualStyleBackColor = true;
            btn_SaveShift.Click += btn_SaveShift_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(173, 20);
            label2.TabIndex = 4;
            label2.Text = "Xác Nhận hoàn thành ca ";
            // 
            // dgv_Shift
            // 
            dgv_Shift.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Shift.Location = new Point(6, 130);
            dgv_Shift.Name = "dgv_Shift";
            dgv_Shift.RowHeadersWidth = 51;
            dgv_Shift.Size = new Size(782, 309);
            dgv_Shift.TabIndex = 6;
            dgv_Shift.CellContentClick += dgv_Shift_CellContentClick;
            // 
            // panel1
            // 
            panel1.Controls.Add(cbStaff);
            panel1.Controls.Add(dt_DateStart);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(6, 45);
            panel1.Name = "panel1";
            panel1.Size = new Size(782, 79);
            panel1.TabIndex = 5;
            // 
            // cbStaff
            // 
            cbStaff.FormattingEnabled = true;
            cbStaff.Location = new Point(622, 30);
            cbStaff.Name = "cbStaff";
            cbStaff.Size = new Size(151, 28);
            cbStaff.TabIndex = 9;
            cbStaff.SelectedIndexChanged += cbStaff_SelectedIndexChanged;
            // 
            // dt_DateStart
            // 
            dt_DateStart.Location = new Point(230, 31);
            dt_DateStart.Name = "dt_DateStart";
            dt_DateStart.Size = new Size(250, 27);
            dt_DateStart.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 33);
            label1.Name = "label1";
            label1.Size = new Size(218, 20);
            label1.TabIndex = 0;
            label1.Text = "Xác nhận hoàn thành ca - Ngày:";
            // 
            // FrmShiftConfirm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(791, 518);
            Controls.Add(btn_PrintPDF);
            Controls.Add(btn_SaveShift);
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

        private Button btn_PrintPDF;
        private Button btn_SaveShift;
        private Label label2;
        private DataGridView dgv_Shift;
        private Panel panel1;
        private DateTimePicker dt_DateStart;
        private Label label1;
        private ComboBox cbStaff;
    }
}