using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTCuoiKy
{
    public class KhachHang
    {
        public KhachHang(string maKH, string tenKH, string diaChi, string loaiKH)
        {
            MaKH = maKH;
            TenKH = tenKH;
            DiaChi = diaChi;
            LoaiKH = loaiKH;
        }

        public string MaKH { get; set; }
        public string TenKH { get; set; }
        public string DiaChi { get; set; }
        public string LoaiKH { get; set; }

        public static List<KhachHang> khachHangs = new List<KhachHang>();
    }
}
