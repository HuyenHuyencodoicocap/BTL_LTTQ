using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppQuanLyTro.Model
{
    internal class RoomEquipment
    {
        private string maPhong;
        private string maTrangBi;
        private string tenTrangBi;
        private string trangThai;

        public RoomEquipment()
        {
        }

        public RoomEquipment(string maPhong, string maTrangBi, string tenTrangBi, string trangThai)
        {
            this.maPhong = maPhong;
            this.maTrangBi = maTrangBi;
            this.tenTrangBi = tenTrangBi;
            this.trangThai = trangThai;
        }

        public string MaPhong { get => maPhong; set => maPhong = value; }
        public string MaTrangBi { get => maTrangBi; set => maTrangBi = value; }
        public string TenTrangBi { get => tenTrangBi; set => tenTrangBi = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }
    }
}

