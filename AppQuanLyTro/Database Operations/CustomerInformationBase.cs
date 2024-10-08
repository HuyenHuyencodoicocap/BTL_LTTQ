using AppQuanLyTro.Database;
using AppQuanLyTro.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppQuanLyTro.Database_Operations
{
    internal class CustomerInformationBase
    {
        Connection conn= new Connection();  
        public CustomerInformationBase() { }

        String queryKhachHang = "Select TenKhachThue as 'Tên khách thuê',SoDienthoai as SĐT,NgaySinh as 'Ngày Sinh',GioiTinh as 'Giới Tính',QueQuan as 'Quê quán',TenPhong as 'Số Phòng', " +
                                "case " +
                                 "when[TrangThaiThuePhong]=1 then N'Đang thuê phòng' " +
                                 "else N'Dừng thuê phòng' " +
                                 "end as 'Trạng thái thuê phòng' "
                                + "from KhachThue join PhongTro on PhongTro.MaPhong = KhachThue.maPhong ";

        public DataTable ThongTinKhachHang() { 
            return conn.DocBang(queryKhachHang);
        }
        //public Account insertAccount(Customer customer)
        //{
        //    SqlConnection sqlConnection = Connection.GetConnection();
        //    String query = "insert into TaiKhoan values (@tentaiKhoan,@isAdmin,@matKhau)";

        //    sqlConnection.Open();
        //    cmd = new SqlCommand(query, sqlConnection);
        //    cmd.Parameters.Add("@tentaiKhoan", SqlDbType.NVarChar).Value = account.TenTaiKhoan1;
        //    cmd.Parameters.Add("@matKhau", SqlDbType.NVarChar).Value = account.MatKhau1;
        //    cmd.Parameters.Add("@isAdmin", SqlDbType.Bit).Value = account.IsAdmin;
        //    cmd.ExecuteNonQuery();
        //    sqlConnection.Close();
        //    //finally { sqlConnection.Close(); }


        //    return account;

        //}
    }
}
