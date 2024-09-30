using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppQuanLyTro.Model
{
    internal class RentedHouse
    {
        private string maNhaTro;
        private string slPhong;
        private string tinhThanhPho;
        private string quanHuyen;
        private string phuongXa;
        private string soNha;
        private string soTang;

        public RentedHouse()
        {
        }

        public RentedHouse(string maNhaTro, string slPhong, string tinhThanhPho, string quanHuyen, string phuongXa, string soNha, string soTang)
        {
            this.maNhaTro = maNhaTro;
            this.slPhong = slPhong;
            this.tinhThanhPho = tinhThanhPho;
            this.quanHuyen = quanHuyen;
            this.phuongXa = phuongXa;
            this.soNha = soNha;
            this.soTang = soTang;
        }

        public string MaNhaTro { get => maNhaTro; set => maNhaTro = value; }
        public string SLPhong { get => slPhong; set => slPhong = value; }
        public string TinhThanhPho { get => tinhThanhPho; set => tinhThanhPho = value; }
        public string QuanHuyen { get => quanHuyen; set => quanHuyen = value; }
        public string PhuongXa { get => phuongXa; set => phuongXa = value; }
        public string SoNha { get => soNha; set => soNha = value; }
        public string SoTang { get => soTang; set => soTang = value; }
    }
}
