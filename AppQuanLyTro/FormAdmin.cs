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
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
            hideMenu();
            
        }
        private void hideMenu()
        {
            pnChucNang.Visible = false;
            pnChung.Visible = false;
        }
        private void showMenu(Panel panel)
        {
            if (panel.Visible)
            {
                panel.Visible = false;
            }
            else
            {
                hideMenu();
                panel.Visible = true;
            }

        }
        private void pnLeftMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnChung_Click(object sender, EventArgs e)
        {
            showMenu(pnChung);
        }

        private void btnChucNang_Click(object sender, EventArgs e)
        {
            showMenu(pnChucNang);
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {

        }
    }
}
