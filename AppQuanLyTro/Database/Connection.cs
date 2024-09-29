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
        public static SqlConnection GetConnection() { 
            return new SqlConnection(stringConnection);
        }
    }
}
