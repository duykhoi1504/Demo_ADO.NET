namespace PresentationLayer
{
    partial class CategoryButton
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
            btnCategory = new Button();
            SuspendLayout();
            // 
            // btnCategory
            // 
            btnCategory.AutoSize = true;
            btnCategory.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCategory.BackColor = Color.White;
            btnCategory.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCategory.ForeColor = Color.SeaGreen;
            btnCategory.Location = new Point(0, 0);
            btnCategory.Name = "btnCategory";
            btnCategory.Size = new Size(6, 6);
            btnCategory.TabIndex = 0;
            btnCategory.UseVisualStyleBackColor = false;
            // 
            // CategoryButton
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Controls.Add(btnCategory);
            Name = "CategoryButton";
            Size = new Size(9, 9);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCategory;
    }
}
