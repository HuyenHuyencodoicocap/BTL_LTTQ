using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppQuanLyTro.Database
{
    internal class Connection
    {
        private static String stringConnection = @"Data Source=MSI\HUYENHUYEN;Initial Catalog=QuanLyPhongTro;Integrated Security=True;";
        SqlConnection sqlConnect = null;

        public static SqlConnection GetConnection() { 
            return new SqlConnection(stringConnection);
        }
        //Hàm mở kết nối
        public void KetNoiCSDL()
        {
            sqlConnect = new SqlConnection(stringConnection);
            if (sqlConnect.State != ConnectionState.Open)
                sqlConnect.Open();
        }
        //Hàm đóng kết nối
        public void DongKetNoiCSDL()
        {
            if (sqlConnect.State != ConnectionState.Closed)
                sqlConnect.Close();
            sqlConnect.Dispose();
        }
        //Hàm thực thi câu lệnh dạng Select trả về một DataTable
        public DataTable DocBang(string sql)
        {
            if (sql == "") return new DataTable();
            DataTable dtBang = new DataTable();
            KetNoiCSDL();
            SqlDataAdapter sqldataAdapte = new SqlDataAdapter(sql, sqlConnect);
            sqldataAdapte.Fill(dtBang);
            DongKetNoiCSDL();
            return dtBang;
        }
    }
}
