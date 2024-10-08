using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppQuanLyTro
{
    public partial class FormUser : Form
    {
        public FormUser()
        {
            InitializeComponent();
            hideMenu();
          btnLogOut.Visible = false;
        }
        private void hideMenu()
        {
            pnHomePage.Visible = false;
            pnChucNang.Visible = false;
            pnCaiDat.Visible = false;

        }
        private void showMenu(Panel panel)
        {
            if (panel.Visible)
            {
                panel.Visible = false;
            }
            else
            {
                hideMenu();//dong het cac panel 
                  panel.Visible = true;
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnChucNang_Click(object sender, EventArgs e)
        {
            showMenu(pnChucNang);
                
        }

        private void btnCaiDat_Click(object sender, EventArgs e)
        {
            showMenu(pnCaiDat);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDichVu_Click(object sender, EventArgs e)
        {
            
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {

        }

        private void btnTroGiup_Click(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            showMenu(pnHomePage);
        }

        private void btnCoSo_Click(object sender, EventArgs e)
        {

        }

        private void btnHomePage_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FormUser_Load(object sender, EventArgs e)
        {

        }

        private void lblTenNguoiDung_Click(object sender, EventArgs e)
        {
            if (btnLogOut.Visible)
            {
                btnLogOut.Visible = false;
            }
            else
            {
                btnLogOut.Visible=true;
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {

        }
    }
}
