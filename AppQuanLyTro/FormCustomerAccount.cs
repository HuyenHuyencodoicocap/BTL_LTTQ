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
            refreshGridView();  

        }
        public void refreshGridView()
        {

            account = new CustomerAccountBase();
            DataGridView1.DataSource = account.getAllCustomer();
        }

       


        private void btnThem_Click(object sender, EventArgs e)
        {
            String tenTaiKhoan = txtTenTaiKhoan.Text;
            String matKhau = txtMatKhau.Text;
            if (string.IsNullOrWhiteSpace(tenTaiKhoan))
            {
                MessageBox.Show("Tên tài khoản không được để trống.", "Lỗi");
                return;
            }

            if (string.IsNullOrWhiteSpace(matKhau))
            {
                MessageBox.Show("Mật khẩu không được để trống.", "Lỗi");
                return;
            }

            if (cmbQuyenHan.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn quyền hạn.", "Lỗi");
                return;
            }

            bool quyenHan = Convert.ToBoolean(cmbQuyenHan.SelectedItem);

            List<Account> danhSachTaiKhoan = account.ListAccount();
            if (danhSachTaiKhoan.Any(acc => acc.TenTaiKhoan1 == tenTaiKhoan))
            {
                MessageBox.Show("Tên tài khoản đã tồn tại.", "Lỗi");
                return;
            }
            Account newAccount = new Account(tenTaiKhoan, matKhau, quyenHan);
            account.insertAccount(newAccount);
            refreshGridView();
            danhSachTaiKhoan.Add(newAccount); // Giả sử bạn đang lưu danh sách tài khoản
            DialogResult result = MessageBox.Show("Thêm tài khoản thành công.", "Thông báo");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            String tenTaiKhoan = txtTenTaiKhoan.Text;
            String matKhau = txtMatKhau.Text;
            if (string.IsNullOrWhiteSpace(tenTaiKhoan))
            {
                MessageBox.Show("Tên tài khoản không được để trống.", "Lỗi");
                return;
            }

            if (string.IsNullOrWhiteSpace(matKhau))
            {
                MessageBox.Show("Mật khẩu không được để trống.", "Lỗi");
                return;
            }

            if (cmbQuyenHan.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn quyền hạn.", "Lỗi");
                return;
            }

            bool quyenHan = Convert.ToBoolean(cmbQuyenHan.SelectedItem);
            String oldtenTaiKhoan = DataGridView1.SelectedRows[0].Cells["tentaikhoan"].Value.ToString();

            Account newAccount = new Account(tenTaiKhoan, matKhau, quyenHan);
            account.updateAccount(newAccount, oldtenTaiKhoan);
            refreshGridView();
            DialogResult result = MessageBox.Show("Sửa tài khoản thành công.", "Thông báo");

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            String tenTaiKhoan = DataGridView1.SelectedRows[0].Cells["tentaikhoan"].Value.ToString();
            account.deleteAccount(tenTaiKhoan);
            refreshGridView();
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTenTaiKhoan.Text = DataGridView1.SelectedRows[0].Cells["tentaikhoan"].Value.ToString();
            txtMatKhau.Text = DataGridView1.SelectedRows[0].Cells["matKhau"].Value.ToString();
            cmbQuyenHan.Text = DataGridView1.SelectedRows[0].Cells["isAdmin"].Value.ToString();

        }
    }
}
