namespace PresentationLayer
{
    partial class USShiftItem
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
            lb_Day = new Label();
            lb_DateTime = new Label();
            cb_Shift = new ComboBox();
            btn_Delete = new Button();
            SuspendLayout();
            // 
            // lb_Day
            // 
            lb_Day.AutoSize = true;
            lb_Day.BackColor = Color.White;
            lb_Day.Location = new Point(3, 17);
            lb_Day.Name = "lb_Day";
            lb_Day.Size = new Size(34, 20);
            lb_Day.TabIndex = 0;
            lb_Day.Text = "Thứ";
            // 
            // lb_DateTime
            // 
            lb_DateTime.AutoSize = true;
            lb_DateTime.BackColor = Color.White;
            lb_DateTime.Location = new Point(132, 18);
            lb_DateTime.Name = "lb_DateTime";
            lb_DateTime.Size = new Size(44, 20);
            lb_DateTime.TabIndex = 0;
            lb_DateTime.Text = "Ngày";
            // 
            // cb_Shift
            // 
            cb_Shift.FormattingEnabled = true;
            cb_Shift.Location = new Point(404, 14);
            cb_Shift.Name = "cb_Shift";
            cb_Shift.Size = new Size(289, 28);
            cb_Shift.TabIndex = 1;
            cb_Shift.SelectedIndexChanged += cb_Shift_SelectedIndexChanged;
            // 
            // btn_Delete
            // 
            btn_Delete.Location = new Point(720, 14);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(35, 29);
            btn_Delete.TabIndex = 2;
            btn_Delete.Text = "X";
            btn_Delete.UseVisualStyleBackColor = true;
            btn_Delete.Click += btn_Delete_Click;
            // 
            // USShiftItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            BorderStyle = BorderStyle.Fixed3D;
            Controls.Add(btn_Delete);
            Controls.Add(cb_Shift);
            Controls.Add(lb_DateTime);
            Controls.Add(lb_Day);
            MaximumSize = new Size(777, 61);
            MinimumSize = new Size(777, 61);
            Name = "USShiftItem";
            Size = new Size(773, 57);
            Load += USShiftItem_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_Day;
        private Label lb_DateTime;
        private ComboBox cb_Shift;
        private Button btn_Delete;
    }
}
