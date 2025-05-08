namespace PresentationLayer
{
    partial class FrmWorkdayList
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
            dgv_Workdays = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgv_Workdays).BeginInit();
            SuspendLayout();
            // 
            // dgv_Workdays
            // 
            dgv_Workdays.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Workdays.Location = new Point(33, 27);
            dgv_Workdays.Name = "dgv_Workdays";
            dgv_Workdays.RowHeadersWidth = 51;
            dgv_Workdays.Size = new Size(738, 295);
            dgv_Workdays.TabIndex = 0;
            // 
            // FrmWorkdayList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgv_Workdays);
            Name = "FrmWorkdayList";
            Text = "FrmWorkdayList";
            Load += FrmWorkdayList_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Workdays).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_Workdays;
    }
}