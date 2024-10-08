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
        public DataTable getAllCustomer()
        {
            DataTable dataTable = new DataTable();
            String query = "Select  * from KhachThue";
            using (SqlConnection sqlConnection = Connection.GetConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.Fill(dataTable);

                sqlConnection.Close();
            }
            return dataTable;
        }
        public DataTable getAllAccount()
        {
            DataTable dataTable = new DataTable();
            String query = "Select  * from TaiKhoan";
            using (SqlConnection sqlConnection = Connection.GetConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.Fill(dataTable);

                sqlConnection.Close();
            }
            return dataTable;
        }
        public List<Account> ListAccount()
        {
            List<Account> danhSachTaiKhoan = new List<Account>(); 
            String query = "SELECT * FROM TaiKhoan";

            using (SqlConnection sqlConnection = Connection.GetConnection())
            {
                sqlConnection.Open();
                using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            String tenTaiKhoan = reader[0].ToString();
                            String matKhau = reader[2].ToString();
                            bool quyenHan = Convert.ToBoolean(reader[1]);
                            Account account = new Account(tenTaiKhoan, matKhau, quyenHan);
                            danhSachTaiKhoan.Add(account);
                        }
                    }
                }

                sqlConnection.Close();
            }

            return danhSachTaiKhoan;
        }


        public Account insertAccount(Account account)
        {
            SqlConnection sqlConnection = Connection.GetConnection();
            String query = "insert into TaiKhoan values (@tentaiKhoan,@isAdmin,@matKhau)";

            sqlConnection.Open();
            cmd = new SqlCommand(query, sqlConnection);
            cmd.Parameters.Add("@tentaiKhoan", SqlDbType.NVarChar).Value = account.TenTaiKhoan1;
            cmd.Parameters.Add("@matKhau", SqlDbType.NVarChar).Value = account.MatKhau1;
            cmd.Parameters.Add("@isAdmin", SqlDbType.Bit).Value = account.IsAdmin;
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
            //finally { sqlConnection.Close(); }


            return account;

        }
        public Account updateAccount(Account account,String oldtentaikhoan)
        {
            SqlConnection sqlConnection = Connection.GetConnection();
            String query = "update TaiKhoan set tentaikhoan=@tentaikhoan, isAdmin= @isAdmin, matkhau=@matKhau  where tentaikhoan= @oldtentaiKhoan";

            sqlConnection.Open();
            cmd = new SqlCommand(query, sqlConnection);
            cmd.Parameters.Add("@oldtentaiKhoan", SqlDbType.NVarChar).Value = oldtentaikhoan;
            cmd.Parameters.Add("@tentaikhoan", SqlDbType.NVarChar).Value = account.TenTaiKhoan1;
            cmd.Parameters.Add("@matKhau", SqlDbType.NVarChar).Value = account.MatKhau1;
            cmd.Parameters.Add("@isAdmin", SqlDbType.Bit).Value = account.IsAdmin;
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
            //finally { sqlConnection.Close(); }


            return account;

        }
        public void deleteAccount(String tenTaiKhoan)
        {
            SqlConnection sqlConnection = Connection.GetConnection();
            String query = "DELETE FROM TaiKhoan WHERE tentaikhoan=@tentk";

            sqlConnection.Open();
            cmd = new SqlCommand(query, sqlConnection);
            cmd.Parameters.Add("@tentk", SqlDbType.NVarChar).Value =tenTaiKhoan ;
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
            //finally { sqlConnection.Close(); }



        }


    }
}
