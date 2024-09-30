using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppQuanLyTro.Model
{
    internal class Room
    {
        private string maPhong;
        private string tenPhong;
        private string trangThaiThue;
        private int slNguoiOToiDa;
        private int slNguoiOThienTai;
        private string namTaiTang;
        private string maNhaTro;
        private decimal giaPhong;

        public Room()
        {
        }

        public Room(string maPhong, string tenPhong, string trangThaiThue, int slNguoiOToiDa, int slNguoiOThienTai, string namTaiTang, string maNhaTro, decimal giaPhong)
        {
            this.maPhong = maPhong;
            this.tenPhong = tenPhong;
            this.trangThaiThue = trangThaiThue;
            this.slNguoiOToiDa = slNguoiOToiDa;
            this.slNguoiOThienTai = slNguoiOThienTai;
            this.namTaiTang = namTaiTang;
            this.maNhaTro = maNhaTro;
            this.giaPhong = giaPhong;
        }

        public string MaPhong { get => maPhong; set => maPhong = value; }
        public string TenPhong { get => tenPhong; set => tenPhong = value; }
        public string TrangThaiThue { get => trangThaiThue; set => trangThaiThue = value; }
        public int SlNguoiOToiDa { get => slNguoiOToiDa; set => slNguoiOToiDa = value; }
        public int SlNguoiOThienTai { get => slNguoiOThienTai; set => slNguoiOThienTai = value; }
        public string NamTaiTang { get => namTaiTang; set => namTaiTang = value; }
        public string MaNhaTro { get => maNhaTro; set => maNhaTro = value; }
        public decimal GiaPhong { get => giaPhong; set => giaPhong = value; }
    }
}
