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
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            cbShowPass = new CheckBox();
            btnShowAccount = new Button();
            btnLogin = new Button();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label5 = new Label();
            panel1 = new Panel();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft New Tai Lue", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(62, 618);
            label2.Name = "label2";
            label2.Size = new Size(391, 31);
            label2.TabIndex = 1;
            label2.Text = "2151050296 - Trần Lê Hoài Nhân";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Script", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(28, 58);
            label1.Name = "label1";
            label1.Size = new Size(465, 53);
            label1.TabIndex = 1;
            label1.Text = "Café Managament System";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.cat_barista;
            pictureBox1.Location = new Point(75, 157);
            pictureBox1.Margin = new Padding(3, 6, 3, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(358, 339);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLightLight;
            panel2.Controls.Add(cbShowPass);
            panel2.Controls.Add(btnShowAccount);
            panel2.Controls.Add(btnLogin);
            panel2.Controls.Add(txtPassword);
            panel2.Controls.Add(txtUsername);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(500, 2);
            panel2.Margin = new Padding(3, 6, 3, 6);
            panel2.Name = "panel2";
            panel2.Size = new Size(500, 701);
            panel2.TabIndex = 1;
            // 
            // cbShowPass
            // 
            cbShowPass.AutoSize = true;
            cbShowPass.Font = new Font("Segoe UI Semibold", 7.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbShowPass.Location = new Point(46, 410);
            cbShowPass.Name = "cbShowPass";
            cbShowPass.Size = new Size(204, 34);
            cbShowPass.TabIndex = 9;
            cbShowPass.Text = "Show password?";
            cbShowPass.UseVisualStyleBackColor = true;
            cbShowPass.CheckedChanged += cbShowPass_CheckedChanged;
            // 
            // btnShowAccount
            // 
            btnShowAccount.BackColor = Color.DarkSeaGreen;
            btnShowAccount.Font = new Font("Microsoft PhagsPa", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnShowAccount.ForeColor = Color.White;
            btnShowAccount.Location = new Point(78, 483);
            btnShowAccount.Margin = new Padding(3, 6, 3, 6);
            btnShowAccount.Name = "btnShowAccount";
            btnShowAccount.Size = new Size(166, 67);
            btnShowAccount.TabIndex = 8;
            btnShowAccount.Text = "ACCOUNT";
            btnShowAccount.UseVisualStyleBackColor = false;
            btnShowAccount.Click += btnShowAccount_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.SeaGreen;
            btnLogin.Font = new Font("Microsoft PhagsPa", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(263, 483);
            btnLogin.Margin = new Padding(3, 6, 3, 6);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(166, 67);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Microsoft PhagsPa", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(46, 346);
            txtPassword.Margin = new Padding(3, 6, 3, 6);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(410, 38);
            txtPassword.TabIndex = 6;
            txtPassword.Text = "123";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Microsoft PhagsPa", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(46, 246);
            txtUsername.Margin = new Padding(3, 6, 3, 6);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(410, 38);
            txtUsername.TabIndex = 7;
            txtUsername.Text = "admin";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 7.875F, FontStyle.Bold);
            label4.Location = new Point(41, 302);
            label4.Name = "label4";
            label4.Size = new Size(105, 30);
            label4.TabIndex = 4;
            label4.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 7.875F, FontStyle.Bold);
            label3.Location = new Point(41, 205);
            label3.Name = "label3";
            label3.Size = new Size(116, 30);
            label3.TabIndex = 5;
            label3.Text = "Username:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(41, 125);
            label5.Name = "label5";
            label5.Size = new Size(140, 45);
            label5.TabIndex = 1;
            label5.Text = "SIGN IN";
            // 
            // panel1
            // 
            panel1.BackColor = Color.SeaGreen;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 2);
            panel1.Margin = new Padding(3, 6, 3, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(500, 701);
            panel1.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft New Tai Lue", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(91, 560);
            label6.Name = "label6";
            label6.Size = new Size(321, 31);
            label6.TabIndex = 1;
            label6.Text = "2151050209 - Võ Duy Khôi";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(999, 701);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(5, 5, 5, 5);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label label4;
        private Label label3;
        private Label label5;
        private Panel panel1;
        private Button btnLogin;
        private Label label6;
        private Button btnShowAccount;
        private CheckBox cbShowPass;
    }
}