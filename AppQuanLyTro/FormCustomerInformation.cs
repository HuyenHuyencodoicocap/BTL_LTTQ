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

        private void ViewKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTenKhachThue.Text = ViewKhachHang.SelectedRows[0].Cells["Tên Khách Thuê"].Value.ToString();
            txtSĐT.Text = ViewKhachHang.SelectedRows[0].Cells["SĐT"].Value.ToString();
            txtNgaySinh.Text = ViewKhachHang.SelectedRows[0].Cells["Ngày Sinh"].Value.ToString();
            string gioiTinh = ViewKhachHang.SelectedRows[0].Cells["Giới tính"].Value.ToString();
            if (gioiTinh == "Nam")
            {
                rbNam.Checked = true;
            }
            else if (gioiTinh == "Nữ")
            {
                rbNu.Checked = true;
            }
            txtQueQuan.Text = ViewKhachHang.SelectedRows[0].Cells["Quê quán"].Value.ToString();
            txtSoPhong.Text= ViewKhachHang.SelectedRows[0].Cells["Số phòng"].Value.ToString();

            String TrangThaiThue = ViewKhachHang.SelectedRows[0].Cells["Trạng thái thuê phòng"].Value.ToString();
            if (TrangThaiThue == "true")
            {
                cmbTrangThaiThue.Text = "Đã thuê";
            }
            else if (TrangThaiThue == "false")
            {
                cmbTrangThaiThue.Text = "Dừng thuê";
            }






        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtTenKhachThue.Text)) {
                MessageBox.Show("Tên khách thuê không được bỏ trống", "Thông báo", (MessageBoxButtons)MessageBoxIcon.Warning);
                return;
            }
            if (String.IsNullOrWhiteSpace(txtSĐT.Text))
            {
                MessageBox.Show("SĐT không được bỏ trống", "Thông báo", (MessageBoxButtons)MessageBoxIcon.Warning);
                return;
            }
            if (String.IsNullOrWhiteSpace(txtSoPhong.Text))
            {
                MessageBox.Show("Số phòng không được bỏ trống", "Thông báo", (MessageBoxButtons)MessageBoxIcon.Warning);
                return;
            }
            if (String.IsNullOrWhiteSpace(cmbTrangThaiThue.Text))
            {
                MessageBox.Show("Trạng thái thuê không được bỏ trống", "Thông báo", (MessageBoxButtons)MessageBoxIcon.Warning);
                return;
            }
        }
    }
}
