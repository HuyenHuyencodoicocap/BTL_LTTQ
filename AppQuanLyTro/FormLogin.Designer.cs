namespace AppQuanLyTro
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.pnLogo = new System.Windows.Forms.Panel();
            this.pnPage = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblDangNhap = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblRepeatPass = new System.Windows.Forms.Label();
            this.picuser = new System.Windows.Forms.PictureBox();
            this.picPass = new System.Windows.Forms.PictureBox();
            this.picRepeatPass = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Button();
            this.picNhinPass = new System.Windows.Forms.PictureBox();
            this.picDongPass = new System.Windows.Forms.PictureBox();
            this.lblDangKy = new System.Windows.Forms.Label();
            this.lblPassWord = new System.Windows.Forms.Label();
            this.pnLogo.SuspendLayout();
            this.pnPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picuser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRepeatPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNhinPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDongPass)).BeginInit();
            this.SuspendLayout();
            // 
            // pnLogo
            // 
            this.pnLogo.Controls.Add(this.picLogo);
            this.pnLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnLogo.Location = new System.Drawing.Point(0, 0);
            this.pnLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnLogo.Name = "pnLogo";
            this.pnLogo.Size = new System.Drawing.Size(394, 722);
            this.pnLogo.TabIndex = 0;
            // 
            // pnPage
            // 
            this.pnPage.Controls.Add(this.lblPassWord);
            this.pnPage.Controls.Add(this.lblDangKy);
            this.pnPage.Controls.Add(this.picDongPass);
            this.pnPage.Controls.Add(this.picNhinPass);
            this.pnPage.Controls.Add(this.lblLogin);
            this.pnPage.Controls.Add(this.panel3);
            this.pnPage.Controls.Add(this.panel2);
            this.pnPage.Controls.Add(this.panel1);
            this.pnPage.Controls.Add(this.lblDangNhap);
            this.pnPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnPage.Location = new System.Drawing.Point(394, 0);
            this.pnPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnPage.Name = "pnPage";
            this.pnPage.Size = new System.Drawing.Size(818, 722);
            this.pnPage.TabIndex = 1;
            // 
            // picLogo
            // 
            this.picLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(0, 0);
            this.picLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(394, 722);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // lblDangNhap
            // 
            this.lblDangNhap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDangNhap.Location = new System.Drawing.Point(303, 169);
            this.lblDangNhap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDangNhap.Name = "lblDangNhap";
            this.lblDangNhap.Size = new System.Drawing.Size(212, 39);
            this.lblDangNhap.TabIndex = 0;
            this.lblDangNhap.Text = "Đăng Nhập";
            this.lblDangNhap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDangNhap.Click += new System.EventHandler(this.lblDangNhap_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.picuser);
            this.panel1.Controls.Add(this.lblUserName);
            this.panel1.Location = new System.Drawing.Point(127, 243);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(564, 53);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.picPass);
            this.panel2.Controls.Add(this.lblPass);
            this.panel2.Location = new System.Drawing.Point(127, 337);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(564, 53);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.Controls.Add(this.textBox3);
            this.panel3.Controls.Add(this.picRepeatPass);
            this.panel3.Controls.Add(this.lblRepeatPass);
            this.panel3.Location = new System.Drawing.Point(127, 427);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(564, 53);
            this.panel3.TabIndex = 3;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(58, 12);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(125, 20);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "Tên Đăng Nhập";
            this.lblUserName.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(58, 10);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(82, 20);
            this.lblPass.TabIndex = 0;
            this.lblPass.Text = "Mật Khẩu";
            this.lblPass.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblRepeatPass
            // 
            this.lblRepeatPass.AutoSize = true;
            this.lblRepeatPass.Location = new System.Drawing.Point(58, 14);
            this.lblRepeatPass.Name = "lblRepeatPass";
            this.lblRepeatPass.Size = new System.Drawing.Size(126, 20);
            this.lblRepeatPass.TabIndex = 0;
            this.lblRepeatPass.Text = "Nhập Mật Khẩu";
            // 
            // picuser
            // 
            this.picuser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picuser.Image = ((System.Drawing.Image)(resources.GetObject("picuser.Image")));
            this.picuser.Location = new System.Drawing.Point(13, 11);
            this.picuser.Name = "picuser";
            this.picuser.Size = new System.Drawing.Size(29, 28);
            this.picuser.TabIndex = 1;
            this.picuser.TabStop = false;
            // 
            // picPass
            // 
            this.picPass.Image = ((System.Drawing.Image)(resources.GetObject("picPass.Image")));
            this.picPass.Location = new System.Drawing.Point(13, 11);
            this.picPass.Name = "picPass";
            this.picPass.Size = new System.Drawing.Size(29, 29);
            this.picPass.TabIndex = 1;
            this.picPass.TabStop = false;
            // 
            // picRepeatPass
            // 
            this.picRepeatPass.Image = ((System.Drawing.Image)(resources.GetObject("picRepeatPass.Image")));
            this.picRepeatPass.Location = new System.Drawing.Point(13, 14);
            this.picRepeatPass.Name = "picRepeatPass";
            this.picRepeatPass.Size = new System.Drawing.Size(29, 29);
            this.picRepeatPass.TabIndex = 1;
            this.picRepeatPass.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(215, 11);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(311, 28);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(215, 20);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(311, 28);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(215, 14);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.PasswordChar = '*';
            this.textBox3.Size = new System.Drawing.Size(311, 28);
            this.textBox3.TabIndex = 2;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // lblLogin
            // 
            this.lblLogin.Location = new System.Drawing.Point(331, 514);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(184, 46);
            this.lblLogin.TabIndex = 4;
            this.lblLogin.Text = "Đăng Nhập";
            this.lblLogin.UseVisualStyleBackColor = true;
            // 
            // picNhinPass
            // 
            this.picNhinPass.Image = ((System.Drawing.Image)(resources.GetObject("picNhinPass.Image")));
            this.picNhinPass.Location = new System.Drawing.Point(648, 499);
            this.picNhinPass.Name = "picNhinPass";
            this.picNhinPass.Size = new System.Drawing.Size(29, 25);
            this.picNhinPass.TabIndex = 5;
            this.picNhinPass.TabStop = false;
            // 
            // picDongPass
            // 
            this.picDongPass.Image = ((System.Drawing.Image)(resources.GetObject("picDongPass.Image")));
            this.picDongPass.Location = new System.Drawing.Point(648, 514);
            this.picDongPass.Name = "picDongPass";
            this.picDongPass.Size = new System.Drawing.Size(24, 23);
            this.picDongPass.TabIndex = 6;
            this.picDongPass.TabStop = false;
            // 
            // lblDangKy
            // 
            this.lblDangKy.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDangKy.Location = new System.Drawing.Point(507, 598);
            this.lblDangKy.Name = "lblDangKy";
            this.lblDangKy.Size = new System.Drawing.Size(184, 47);
            this.lblDangKy.TabIndex = 7;
            this.lblDangKy.Text = "Bạn chưa có tài khoản?\r\nNhấn vào đây để đăng kí";
            // 
            // lblPassWord
            // 
            this.lblPassWord.AutoSize = true;
            this.lblPassWord.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassWord.Location = new System.Drawing.Point(571, 566);
            this.lblPassWord.Name = "lblPassWord";
            this.lblPassWord.Size = new System.Drawing.Size(120, 20);
            this.lblPassWord.TabIndex = 8;
            this.lblPassWord.Text = "Quên mật khẩu";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 722);
            this.Controls.Add(this.pnPage);
            this.Controls.Add(this.pnLogo);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLogin";
            this.pnLogo.ResumeLayout(false);
            this.pnPage.ResumeLayout(false);
            this.pnPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picuser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRepeatPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNhinPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDongPass)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnLogo;
        private System.Windows.Forms.Panel pnPage;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblDangNhap;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblRepeatPass;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.PictureBox picRepeatPass;
        private System.Windows.Forms.PictureBox picPass;
        private System.Windows.Forms.PictureBox picuser;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button lblLogin;
        private System.Windows.Forms.PictureBox picDongPass;
        private System.Windows.Forms.PictureBox picNhinPass;
        private System.Windows.Forms.Label lblPassWord;
        private System.Windows.Forms.Label lblDangKy;
    }
}