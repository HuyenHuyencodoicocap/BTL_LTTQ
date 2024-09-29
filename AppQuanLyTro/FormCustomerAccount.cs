using AppQuanLyTro.Database_Operations;
using AppQuanLyTro.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace AppQuanLyTro
{
    public partial class FormCustomerAccount : Form
    {
        CustomerAccountBase account;
        Account newAccount;
        public FormCustomerAccount()
        {

            InitializeComponent();
            account = new CustomerAccountBase();
            DataGridView1.DataSource = account.getAllAccount();

        }

        private void FormCustomerAccount_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            String tenTaiKhoan = txtTenTaiKhoan.Text;
            String matKhau = txtMatKhau.Text;
            bool quyenhan = bool.Parse(cmbQuyenHan.Text);
            newAccount = new Account(tenTaiKhoan, matKhau, quyenhan);
        }
    }
}
