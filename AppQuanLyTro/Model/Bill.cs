using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppQuanLyTro.Model
{
    internal class Bill
    {
        private string maHoaDon;
        private string tinhTrangHoaDon;
        private DateTime ngayTao;

        public Bill()
        {
        }

        public Bill(string maHoaDon, string tinhTrangHoaDon, DateTime ngayTao)
        {
            this.maHoaDon = maHoaDon;
            this.tinhTrangHoaDon = tinhTrangHoaDon;
            this.ngayTao = ngayTao;
        }

        public string MaHoaDon { get => maHoaDon; set => maHoaDon = value; }
        public string TinhTrangHoaDon { get => tinhTrangHoaDon; set => tinhTrangHoaDon = value; }
        public DateTime NgayTao { get => ngayTao; set => ngayTao = value; }
    }
}
