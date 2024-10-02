using AppQuanLyTro.Database;
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
    public partial class FormCustomerInformation : Form
    {
        CustomerInformationBase customerBase;
        Customer Customer=new Customer();
        public FormCustomerInformation()
        {

            InitializeComponent();
            refreshGridView();  

        }
        public void refreshGridView()
        {

            customerBase = new CustomerInformationBase();
            ViewKhachHang.DataSource = customerBase.ThongTinKhachHang();
            txtTenKhachThue.Text    = "";
            txtSĐT.Text = "";
            txtNgaySinh.Text = "";
            rbNam.Enabled = false;
            rbNam.Enabled=false;
            txtQueQuan.Text = "";
            txtSoPhong.Text = "";
            cmbTrangThaiThue.SelectedIndex = 0;

        }

       


        //private void btnThem_Click(object sender, EventArgs e)
        //{
        //    String tenTaiKhoan = txtTenKhachThue.Text;
        //    String matKhau = txtSĐT.Text;
        //    if (string.IsNullOrWhiteSpace(tenTaiKhoan))
        //    {
        //        MessageBox.Show("Tên tài khoản không được để trống.", "Lỗi");
        //        return;
        //    }

        //    if (string.IsNullOrWhiteSpace(matKhau))
        //    {
        //        MessageBox.Show("Mật khẩu không được để trống.", "Lỗi");
        //        return;
        //    }

        //    List<Account> danhSachTaiKhoan = account.ListAccount();
        //    if (danhSachTaiKhoan.Any(acc => acc.TenTaiKhoan1 == tenTaiKhoan))
        //    {
        //        MessageBox.Show("Tên tài khoản đã tồn tại.", "Lỗi");
        //        return;
        //    }
        //    //Account newAccount = new Account(tenTaiKhoan, matKhau, quyenHan);
        //    account.insertAccount(newAccount);
        //    refreshGridView();
        //    danhSachTaiKhoan.Add(newAccount); // Giả sử bạn đang lưu danh sách tài khoản
        //    DialogResult result = MessageBox.Show("Thêm tài khoản thành công.", "Thông báo");
        //}

        //private void btnSua_Click(object sender, EventArgs e)
        //{
        //    String tenTaiKhoan = txtTenKhachThue.Text;
        //    String matKhau = txtSĐT.Text;
        //    if (string.IsNullOrWhiteSpace(tenTaiKhoan))
        //    {
        //        MessageBox.Show("Tên tài khoản không được để trống.", "Lỗi");
        //        return;
        //    }

        //    if (string.IsNullOrWhiteSpace(matKhau))
        //    {
        //        MessageBox.Show("Mật khẩu không được để trống.", "Lỗi");
        //        return;
        //    }

        //    //if (cmbQuyenHan.SelectedItem == null)
        //    //{
        //    //    MessageBox.Show("Vui lòng chọn quyền hạn.", "Lỗi");
        //    //    return;
        //    //}

        //    //bool quyenHan = Convert.ToBoolean(cmbQuyenHan.SelectedItem);
        //    String oldtenTaiKhoan = ViewKhachHang.SelectedRows[0].Cells["tentaikhoan"].Value.ToString();

        //    //Account newAccount = new Account(tenTaiKhoan, matKhau, quyenHan);
        //    account.updateAccount(newAccount, oldtenTaiKhoan);
        //    refreshGridView();
        //    DialogResult result = MessageBox.Show("Sửa tài khoản thành công.", "Thông báo");

        //}

        //private void btnXoa_Click(object sender, EventArgs e)
        //{
        //    String tenTaiKhoan = ViewKhachHang.SelectedRows[0].Cells["tenTaiKhoan"].Value.ToString();
        //    account.deleteAccount(tenTaiKhoan);
        //    refreshGridView();
        //    DialogResult result = MessageBox.Show("Xóa tài khoản thành công.", "Thông báo");

        //}

        //private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    txtTenKhachThue.Text = ViewKhachHang.SelectedRows[0].Cells["tentaikhoan"].Value.ToString();
        //    txtSĐT.Text = ViewKhachHang.SelectedRows[0].Cells["matKhau"].Value.ToString();
        //    //cmbQuyenHan.Text = DataGridView1.SelectedRows[0].Cells["isAdmin"].Value.ToString();

        //}

        

        private void ViewKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
