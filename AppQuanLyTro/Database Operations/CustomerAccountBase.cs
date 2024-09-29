using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using AppQuanLyTro.Database;
using AppQuanLyTro.Model;
using System.Windows.Forms;



namespace AppQuanLyTro.Database_Operations
{
    internal class CustomerAccountBase
    {
        SqlDataAdapter dataAdapter;// truy xuat dl bao datatable
        SqlCommand cmd;
        public CustomerAccountBase()
        {
        }
        public DataTable getAllAccount()
        {
            DataTable dataTable = new DataTable();
            String query = "Select  TenKhachThue,SoDienThoai,QueQuan,TrangThaiThuePhong,TaiKhoan.TenTaiKhoan,MatKhau from KhachThue join TaiKhoan on TaiKhoan.TenTaiKhoan = KhachThue.tenTaiKhoan";
            using (SqlConnection sqlConnection = Connection.GetConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.Fill(dataTable);

                sqlConnection.Close();
            }
            return dataTable;
        }

        //public Account insertAccount(Account account) {
        //    SqlConnection sqlConnection = Connection.GetConnection();
        //    String query = "insert into TaiKhoan values (@tentaiKhoan,@matKhau,@isAdmin)";
            
        //    sqlConnection.Open();
        //    cmd = new SqlCommand(query, sqlConnection);
        //    cmd.Parameters.Add("@tentaiKhoan", SqlDbType.NVarChar).Value = account.TenTaiKhoan1;
        //    cmd.Parameters.Add("@matKhau", SqlDbType.NVarChar).Value = account.MatKhau1;
        //    cmd.Parameters.Add("@tentaiKhoan", SqlDbType.Bit).Value = account.IsAdmin;
        //    cmd.ExecuteNonQuery(); 
        //    finally { sqlConnection.Close(); }


        //    return account;

        //}
    

    }
}
