using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppQuanLyTro.Model
{
    internal class Account
    {
        private string MaTaiKhoan;
        private string TenTaiKhoan ;
        private string MatKhau;
        private bool isAdmin;

        public Account()
        {
        }

        public Account(string tenTaiKhoan, string matKhau, bool isAdmin)
        {
            TenTaiKhoan = tenTaiKhoan;
            MatKhau = matKhau;
            this.isAdmin = isAdmin;
        }

        public string TenTaiKhoan1 { get => TenTaiKhoan; set => TenTaiKhoan = value; }
        public string MatKhau1 { get => MatKhau; set => MatKhau = value; }
        public bool IsAdmin { get => isAdmin; set => isAdmin = value; }
        public string MaTaiKhoan1 { get => MaTaiKhoan; set => MaTaiKhoan = value; }



    }
}
