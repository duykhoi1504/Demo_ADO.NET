namespace PresentationLayer.Payment
{
    partial class FrmVietQr
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
            btn_genQR = new Button();
            cb_nganHang = new ComboBox();
            label1 = new Label();
            txt_SoTaiKhoan = new TextBox();
            cb_Template = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            txtSoTien = new NumericUpDown();
            label4 = new Label();
            label5 = new Label();
            txtTenTaiKhoan = new TextBox();
            label6 = new Label();
            txtInfo = new TextBox();
            pic_QR = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)txtSoTien).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_QR).BeginInit();
            SuspendLayout();
            // 
            // btn_genQR
            // 
            btn_genQR.Location = new Point(424, 645);
            btn_genQR.Margin = new Padding(5, 5, 5, 5);
            btn_genQR.Name = "btn_genQR";
            btn_genQR.Size = new Size(153, 46);
            btn_genQR.TabIndex = 0;
            btn_genQR.Text = "GenQr";
            btn_genQR.UseVisualStyleBackColor = true;
            btn_genQR.Click += btn_genQR_Click;
            // 
            // cb_nganHang
            // 
            cb_nganHang.FormattingEnabled = true;
            cb_nganHang.Location = new Point(34, 101);
            cb_nganHang.Margin = new Padding(5, 5, 5, 5);
            cb_nganHang.Name = "cb_nganHang";
            cb_nganHang.Size = new Size(305, 40);
            cb_nganHang.TabIndex = 1;
            cb_nganHang.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(96, 43);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(174, 32);
            label1.TabIndex = 2;
            label1.Text = "Tên ngân hàng";
            label1.Visible = false;
            label1.Click += label1_Click;
            // 
            // txt_SoTaiKhoan
            // 
            txt_SoTaiKhoan.Location = new Point(377, 102);
            txt_SoTaiKhoan.Margin = new Padding(5, 5, 5, 5);
            txt_SoTaiKhoan.Name = "txt_SoTaiKhoan";
            txt_SoTaiKhoan.Size = new Size(362, 39);
            txt_SoTaiKhoan.TabIndex = 3;
            txt_SoTaiKhoan.Text = "113366668888";
            txt_SoTaiKhoan.Visible = false;
            // 
            // cb_Template
            // 
            cb_Template.FormattingEnabled = true;
            cb_Template.Items.AddRange(new object[] { "compact", "compact2", "qr_only", "print" });
            cb_Template.Location = new Point(788, 102);
            cb_Template.Margin = new Padding(5, 5, 5, 5);
            cb_Template.Name = "cb_Template";
            cb_Template.Size = new Size(381, 40);
            cb_Template.TabIndex = 4;
            cb_Template.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(455, 43);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(144, 32);
            label2.TabIndex = 2;
            label2.Text = "số tài khoan";
            label2.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(788, 43);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(109, 32);
            label3.TabIndex = 2;
            label3.Text = "template";
            label3.Visible = false;
            // 
            // txtSoTien
            // 
            txtSoTien.Location = new Point(83, 262);
            txtSoTien.Margin = new Padding(5, 5, 5, 5);
            txtSoTien.Name = "txtSoTien";
            txtSoTien.Size = new Size(244, 39);
            txtSoTien.TabIndex = 5;
            txtSoTien.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(83, 210);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(86, 32);
            label4.TabIndex = 2;
            label4.Text = "so tien";
            label4.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(455, 210);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(155, 32);
            label5.TabIndex = 2;
            label5.Text = "ten tai khoan";
            label5.Visible = false;
            // 
            // txtTenTaiKhoan
            // 
            txtTenTaiKhoan.Location = new Point(377, 269);
            txtTenTaiKhoan.Margin = new Padding(5, 5, 5, 5);
            txtTenTaiKhoan.Name = "txtTenTaiKhoan";
            txtTenTaiKhoan.Size = new Size(362, 39);
            txtTenTaiKhoan.TabIndex = 3;
            txtTenTaiKhoan.Text = "QUY VAC XIN PHONG CHONG COVID";
            txtTenTaiKhoan.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(863, 210);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(176, 32);
            label6.TabIndex = 2;
            label6.Text = "thong tin them";
            label6.Visible = false;
            // 
            // txtInfo
            // 
            txtInfo.Location = new Point(785, 269);
            txtInfo.Margin = new Padding(5, 5, 5, 5);
            txtInfo.Name = "txtInfo";
            txtInfo.Size = new Size(362, 39);
            txtInfo.TabIndex = 3;
            txtInfo.Text = "DONATE FOR US";
            txtInfo.Visible = false;
            // 
            // pic_QR
            // 
            pic_QR.Location = new Point(320, 43);
            pic_QR.Margin = new Padding(5, 5, 5, 5);
            pic_QR.Name = "pic_QR";
            pic_QR.Size = new Size(694, 555);
            pic_QR.SizeMode = PictureBoxSizeMode.Zoom;
            pic_QR.TabIndex = 6;
            pic_QR.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(720, 645);
            button1.Margin = new Padding(5, 5, 5, 5);
            button1.Name = "button1";
            button1.Size = new Size(153, 46);
            button1.TabIndex = 0;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FrmVietQr
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1263, 760);
            Controls.Add(pic_QR);
            Controls.Add(txtSoTien);
            Controls.Add(cb_Template);
            Controls.Add(txtInfo);
            Controls.Add(txtTenTaiKhoan);
            Controls.Add(txt_SoTaiKhoan);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cb_nganHang);
            Controls.Add(button1);
            Controls.Add(btn_genQR);
            Margin = new Padding(5, 5, 5, 5);
            Name = "FrmVietQr";
            Text = "FrmVietQr";
            Load += FrmVietQr_Load;
            ((System.ComponentModel.ISupportInitialize)txtSoTien).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_QR).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_genQR;
        private ComboBox cb_nganHang;
        private Label label1;
        private TextBox txt_SoTaiKhoan;
        private ComboBox cb_Template;
        private Label label2;
        private Label label3;
        private NumericUpDown txtSoTien;
        private Label label4;
        private Label label5;
        private TextBox txtTenTaiKhoan;
        private Label label6;
        private TextBox txtInfo;
        private PictureBox pic_QR;
        private Button button1;
    }
}