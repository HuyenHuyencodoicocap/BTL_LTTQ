using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppQuanLyTro.Model
{
    internal class Notification
    {
        private string maThongBao;
        private string tenThongBao;
        private DateTime thoiGian;
        private string noiDung;
        private string MaTaiKhoan;

        public Notification()
        {
        }

        public Notification(string maThongBao, string tenThongBao, DateTime thoiGian, string noiDung, string MaTaiKhoan)
        {
            this.maThongBao = maThongBao;
            this.tenThongBao = tenThongBao;
            this.thoiGian = thoiGian;
            this.noiDung = noiDung;
            this.MaTaiKhoan = MaTaiKhoan;
        }

        public string MaThongBao { get => maThongBao; set => maThongBao = value; }
        public string TenThongBao { get => tenThongBao; set => tenThongBao = value; }
        public DateTime ThoiGian { get => thoiGian; set => thoiGian = value; }
        public string NoiDung { get => noiDung; set => noiDung = value; }
        public string MaTaiKhoan1 { get => MaTaiKhoan; set => MaTaiKhoan = value; }
    }
}
