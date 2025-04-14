namespace PresentationLayer
{
    partial class Login
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
            Username_txt = new TextBox();
            Password_txt = new TextBox();
            Cancel_btn = new Button();
            Login_btn = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // Username_txt
            // 
            Username_txt.Location = new Point(233, 90);
            Username_txt.Name = "Username_txt";
            Username_txt.Size = new Size(125, 27);
            Username_txt.TabIndex = 0;
            // 
            // Password_txt
            // 
            Password_txt.Location = new Point(233, 123);
            Password_txt.Name = "Password_txt";
            Password_txt.Size = new Size(125, 27);
            Password_txt.TabIndex = 1;
            // 
            // Cancel_btn
            // 
            Cancel_btn.Location = new Point(352, 196);
            Cancel_btn.Name = "Cancel_btn";
            Cancel_btn.Size = new Size(94, 29);
            Cancel_btn.TabIndex = 3;
            Cancel_btn.Text = "cancel";
            Cancel_btn.UseVisualStyleBackColor = true;
            Cancel_btn.Click += Cancel_btn_Click;
            // 
            // Login_btn
            // 
            Login_btn.Location = new Point(233, 196);
            Login_btn.Name = "Login_btn";
            Login_btn.Size = new Size(94, 29);
            Login_btn.TabIndex = 2;
            Login_btn.Text = "Login";
            Login_btn.UseVisualStyleBackColor = true;
            Login_btn.Click += Login_btn_Click;
            // 
            // button1
            // 
            button1.Location = new Point(286, 289);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(Login_btn);
            Controls.Add(Cancel_btn);
            Controls.Add(Password_txt);
            Controls.Add(Username_txt);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Username_txt;
        private TextBox Password_txt;
        private Button Cancel_btn;
        private Button Login_btn;
        private Button button1;
    }
}