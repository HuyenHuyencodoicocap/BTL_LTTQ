using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppQuanLyTro.Model
{
    internal class BillDetails
    {
        private string maChiTietHDDV;
        private string maDichVu;
        private string maHoaDon;
        private int soLuong;

        public BillDetails()
        {
        }

        public BillDetails(string maChiTietHDDV, string maDichVu, string maHoaDon, int soLuong)
        {
            this.maChiTietHDDV = maChiTietHDDV;
            this.maDichVu = maDichVu;
            this.maHoaDon = maHoaDon;
            this.soLuong = soLuong;
        }

        public string MaChiTietHDDV { get => maChiTietHDDV; set => maChiTietHDDV = value; }
        public string MaDichVu { get => maDichVu; set => maDichVu = value; }
        public string MaHoaDon { get => maHoaDon; set => maHoaDon = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
    }
}
