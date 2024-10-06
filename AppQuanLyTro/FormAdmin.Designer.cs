namespace AppQuanLyTro
{
    partial class FormAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            this.pnLeftMenu = new System.Windows.Forms.Panel();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.pnChucNang = new System.Windows.Forms.Panel();
            this.btnKH = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnDichVu = new System.Windows.Forms.Button();
            this.pnChung = new System.Windows.Forms.Panel();
            this.btnCoSoTro = new System.Windows.Forms.Button();
            this.btnThongBao = new System.Windows.Forms.Button();
            this.pnPicture = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pnTitle = new System.Windows.Forms.Panel();
            this.btnTaiKhoan = new System.Windows.Forms.Button();
            this.btnChung = new System.Windows.Forms.Button();
            this.btnChucNang = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.pnLeftMenu.SuspendLayout();
            this.pnChucNang.SuspendLayout();
            this.pnChung.SuspendLayout();
            this.pnPicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnLeftMenu
            // 
            this.pnLeftMenu.AutoScroll = true;
            this.pnLeftMenu.Controls.Add(this.btnDangXuat);
            this.pnLeftMenu.Controls.Add(this.pnChucNang);
            this.pnLeftMenu.Controls.Add(this.btnChucNang);
            this.pnLeftMenu.Controls.Add(this.pnChung);
            this.pnLeftMenu.Controls.Add(this.btnChung);
            this.pnLeftMenu.Controls.Add(this.pnPicture);
            this.pnLeftMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnLeftMenu.Location = new System.Drawing.Point(0, 0);
            this.pnLeftMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnLeftMenu.Name = "pnLeftMenu";
            this.pnLeftMenu.Size = new System.Drawing.Size(318, 734);
            this.pnLeftMenu.TabIndex = 0;
            this.pnLeftMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.pnLeftMenu_Paint);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDangXuat.Image = ((System.Drawing.Image)(resources.GetObject("btnDangXuat.Image")));
            this.btnDangXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangXuat.Location = new System.Drawing.Point(0, 755);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Padding = new System.Windows.Forms.Padding(30, 0, 70, 0);
            this.btnDangXuat.Size = new System.Drawing.Size(297, 80);
            this.btnDangXuat.TabIndex = 9;
            this.btnDangXuat.Text = "Đăng Xuất";
            this.btnDangXuat.UseVisualStyleBackColor = true;
            // 
            // pnChucNang
            // 
            this.pnChucNang.Controls.Add(this.btnThongKe);
            this.pnChucNang.Controls.Add(this.btnThanhToan);
            this.pnChucNang.Controls.Add(this.btnDichVu);
            this.pnChucNang.Controls.Add(this.btnKH);
            this.pnChucNang.Controls.Add(this.btnTaiKhoan);
            this.pnChucNang.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnChucNang.Location = new System.Drawing.Point(0, 449);
            this.pnChucNang.Name = "pnChucNang";
            this.pnChucNang.Size = new System.Drawing.Size(297, 306);
            this.pnChucNang.TabIndex = 8;
            // 
            // btnKH
            // 
            this.btnKH.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKH.Image = ((System.Drawing.Image)(resources.GetObject("btnKH.Image")));
            this.btnKH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKH.Location = new System.Drawing.Point(0, 60);
            this.btnKH.Name = "btnKH";
            this.btnKH.Padding = new System.Windows.Forms.Padding(70, 0, 20, 0);
            this.btnKH.Size = new System.Drawing.Size(297, 60);
            this.btnKH.TabIndex = 5;
            this.btnKH.Text = "Thông Tin Khách Hàng";
            this.btnKH.UseVisualStyleBackColor = true;
            // 
            // btnThongKe
            // 
            this.btnThongKe.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThongKe.Image = ((System.Drawing.Image)(resources.GetObject("btnThongKe.Image")));
            this.btnThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.Location = new System.Drawing.Point(0, 240);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Padding = new System.Windows.Forms.Padding(70, 0, 30, 0);
            this.btnThongKe.Size = new System.Drawing.Size(297, 60);
            this.btnThongKe.TabIndex = 9;
            this.btnThongKe.Text = "Thống Kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThanhToan.Image = ((System.Drawing.Image)(resources.GetObject("btnThanhToan.Image")));
            this.btnThanhToan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThanhToan.Location = new System.Drawing.Point(0, 180);
            this.btnThanhToan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Padding = new System.Windows.Forms.Padding(70, 0, 20, 0);
            this.btnThanhToan.Size = new System.Drawing.Size(297, 60);
            this.btnThanhToan.TabIndex = 8;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            // 
            // btnDichVu
            // 
            this.btnDichVu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDichVu.Image = ((System.Drawing.Image)(resources.GetObject("btnDichVu.Image")));
            this.btnDichVu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDichVu.Location = new System.Drawing.Point(0, 120);
            this.btnDichVu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDichVu.Name = "btnDichVu";
            this.btnDichVu.Padding = new System.Windows.Forms.Padding(70, 0, 50, 0);
            this.btnDichVu.Size = new System.Drawing.Size(297, 60);
            this.btnDichVu.TabIndex = 7;
            this.btnDichVu.Text = "Dịch Vụ ";
            this.btnDichVu.UseVisualStyleBackColor = true;
            // 
            // pnChung
            // 
            this.pnChung.AutoSize = true;
            this.pnChung.Controls.Add(this.btnCoSoTro);
            this.pnChung.Controls.Add(this.btnThongBao);
            this.pnChung.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnChung.Location = new System.Drawing.Point(0, 249);
            this.pnChung.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnChung.Name = "pnChung";
            this.pnChung.Size = new System.Drawing.Size(297, 120);
            this.pnChung.TabIndex = 7;
            // 
            // btnCoSoTro
            // 
            this.btnCoSoTro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCoSoTro.Image = ((System.Drawing.Image)(resources.GetObject("btnCoSoTro.Image")));
            this.btnCoSoTro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCoSoTro.Location = new System.Drawing.Point(0, 60);
            this.btnCoSoTro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCoSoTro.Name = "btnCoSoTro";
            this.btnCoSoTro.Padding = new System.Windows.Forms.Padding(70, 0, 50, 0);
            this.btnCoSoTro.Size = new System.Drawing.Size(297, 60);
            this.btnCoSoTro.TabIndex = 3;
            this.btnCoSoTro.Text = "Cơ Sở Trọ";
            this.btnCoSoTro.UseVisualStyleBackColor = true;
            // 
            // btnThongBao
            // 
            this.btnThongBao.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThongBao.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongBao.Image = ((System.Drawing.Image)(resources.GetObject("btnThongBao.Image")));
            this.btnThongBao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongBao.Location = new System.Drawing.Point(0, 0);
            this.btnThongBao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThongBao.Name = "btnThongBao";
            this.btnThongBao.Padding = new System.Windows.Forms.Padding(70, 0, 50, 0);
            this.btnThongBao.Size = new System.Drawing.Size(297, 60);
            this.btnThongBao.TabIndex = 2;
            this.btnThongBao.Text = "Thông Báo";
            this.btnThongBao.UseVisualStyleBackColor = true;
            // 
            // pnPicture
            // 
            this.pnPicture.Controls.Add(this.picLogo);
            this.pnPicture.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnPicture.Location = new System.Drawing.Point(0, 0);
            this.pnPicture.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnPicture.Name = "pnPicture";
            this.pnPicture.Size = new System.Drawing.Size(297, 169);
            this.pnPicture.TabIndex = 0;
            // 
            // picLogo
            // 
            this.picLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(0, 0);
            this.picLogo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(297, 169);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // pnTitle
            // 
            this.pnTitle.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pnTitle.Controls.Add(this.lblName);
            this.pnTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTitle.Location = new System.Drawing.Point(318, 0);
            this.pnTitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnTitle.Name = "pnTitle";
            this.pnTitle.Size = new System.Drawing.Size(900, 50);
            this.pnTitle.TabIndex = 2;
            // 
            // btnTaiKhoan
            // 
            this.btnTaiKhoan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTaiKhoan.Image = ((System.Drawing.Image)(resources.GetObject("btnTaiKhoan.Image")));
            this.btnTaiKhoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaiKhoan.Location = new System.Drawing.Point(0, 0);
            this.btnTaiKhoan.Name = "btnTaiKhoan";
            this.btnTaiKhoan.Padding = new System.Windows.Forms.Padding(70, 0, 40, 0);
            this.btnTaiKhoan.Size = new System.Drawing.Size(297, 60);
            this.btnTaiKhoan.TabIndex = 6;
            this.btnTaiKhoan.Text = "Thông Tin Tài Khoản";
            this.btnTaiKhoan.UseVisualStyleBackColor = true;
            this.btnTaiKhoan.Click += new System.EventHandler(this.btnTaiKhoan_Click);
            // 
            // btnChung
            // 
            this.btnChung.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChung.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChung.Image = ((System.Drawing.Image)(resources.GetObject("btnChung.Image")));
            this.btnChung.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChung.Location = new System.Drawing.Point(0, 169);
            this.btnChung.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnChung.Name = "btnChung";
            this.btnChung.Padding = new System.Windows.Forms.Padding(30, 0, 110, 0);
            this.btnChung.Size = new System.Drawing.Size(297, 80);
            this.btnChung.TabIndex = 1;
            this.btnChung.Text = "Chung";
            this.btnChung.UseVisualStyleBackColor = true;
            this.btnChung.Click += new System.EventHandler(this.btnChung_Click);
            // 
            // btnChucNang
            // 
            this.btnChucNang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChucNang.Image = ((System.Drawing.Image)(resources.GetObject("btnChucNang.Image")));
            this.btnChucNang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChucNang.Location = new System.Drawing.Point(0, 369);
            this.btnChucNang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnChucNang.Name = "btnChucNang";
            this.btnChucNang.Padding = new System.Windows.Forms.Padding(30, 0, 70, 0);
            this.btnChucNang.Size = new System.Drawing.Size(297, 80);
            this.btnChucNang.TabIndex = 4;
            this.btnChucNang.Text = "Chức Năng";
            this.btnChucNang.UseVisualStyleBackColor = true;
            this.btnChucNang.Click += new System.EventHandler(this.btnChucNang_Click);
            // 
            // lblName
            // 
            this.lblName.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblName.Image = ((System.Drawing.Image)(resources.GetObject("lblName.Image")));
            this.lblName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblName.Location = new System.Drawing.Point(710, 0);
            this.lblName.Name = "lblName";
            this.lblName.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.lblName.Size = new System.Drawing.Size(190, 50);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "ABC";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1218, 734);
            this.Controls.Add(this.pnTitle);
            this.Controls.Add(this.pnLeftMenu);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormAdmin";
            this.Text = "FormAdmin";
            this.pnLeftMenu.ResumeLayout(false);
            this.pnLeftMenu.PerformLayout();
            this.pnChucNang.ResumeLayout(false);
            this.pnChung.ResumeLayout(false);
            this.pnPicture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnTitle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnLeftMenu;
        private System.Windows.Forms.Panel pnPicture;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel pnTitle;
        private System.Windows.Forms.Panel pnChung;
        private System.Windows.Forms.Button btnCoSoTro;
        private System.Windows.Forms.Button btnThongBao;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnDichVu;
        private System.Windows.Forms.Panel pnChucNang;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Button btnKH;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnTaiKhoan;
        private System.Windows.Forms.Button btnChung;
        private System.Windows.Forms.Button btnChucNang;
        private System.Windows.Forms.Label lblName;
    }
}