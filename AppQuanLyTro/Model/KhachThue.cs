using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppQuanLyTro.Model
{
    internal class KhachThue
    {
       private string MaKhachThue;
       private string TenKhachThue;
       private string SĐT;
       private string NganySinh;
       private string GioiTinh;
       private string QueQuan;
       private string TrangThaiThue;

        public KhachThue()
        {
        }

        public string MaKhachThue1 { get => MaKhachThue; set => MaKhachThue = value; }
        public string TenKhachThue1 { get => TenKhachThue; set => TenKhachThue = value; }
        //public string TenTaiKhoan1 { get => TenTaiKhoan; set => TenTaiKhoan = value; }
        public string SĐT1 { get => SĐT; set => SĐT = value; }
        public string NganySinh1 { get => NganySinh; set => NganySinh = value; }
        public string GioiTinh1 { get => GioiTinh; set => GioiTinh = value; }
        public string QueQuan1 { get => QueQuan; set => QueQuan = value; }
        //public string TrangThaiThue1 { get => TrangThaiThue; set => TrangThaiThue = value; }
    }
}
