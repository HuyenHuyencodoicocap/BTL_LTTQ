using AppQuanLyTro.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppQuanLyTro.Database_Operations
{
    internal class CustomerInformationBase
    {
        Connection conn= new Connection();  
        public CustomerInformationBase() { }

        String queryKhachHang = "Select TenKhachThue as 'Tên khách thuê',SoDienthoai as SĐT,NgaySinh as 'Ngày Sinh',GioiTinh as 'Giới Tính',QueQuan as 'Quê quán',TenPhong as 'Số Phòng', " +
                                "case " +
                                 "when[TrangThaiThuePhong]=1 then N'Đang thuê phòng' " +
                                 "else N'Dừng thuê phòng' " +
                                 "end as 'Trạng thái thuê phòng' "
                                + "from KhachThue join PhongTro on PhongTro.MaPhong = KhachThue.maPhong ";

        public DataTable ThongTinKhachHang() { 
            return conn.DocBang(queryKhachHang);
        }
    }
}
