using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppQuanLyTro.Model
{
    internal class RoomService
    {
        private string maDichVu;
        private string tenDichVu;
        private decimal giaDichVu;
        private string donVi;

        public RoomService()
        {
        }

        public RoomService(string maDichVu, string tenDichVu, decimal giaDichVu, string donVi)
        {
            this.maDichVu = maDichVu;
            this.tenDichVu = tenDichVu;
            this.giaDichVu = giaDichVu;
            this.donVi = donVi;
        }

        public string MaDichVu { get => maDichVu; set => maDichVu = value; }
        public string TenDichVu { get => tenDichVu; set => tenDichVu = value; }
        public decimal GiaDichVu { get => giaDichVu; set => giaDichVu = value; }
        public string DonVi { get => donVi; set => donVi = value; }
    }
}
