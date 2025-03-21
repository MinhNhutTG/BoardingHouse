using QuanLyPhongTro.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongTro.BLL
{
    internal class BLL_Report
    {
        DAL_Report dalreport = new DAL_Report();
        public DataTable TKDoanhThuThang(int year)
        {
            return dalreport.TKDoanhThuThang(year);
        }
        public DataTable TKDoanhThuQuy(int year)
        {
            return dalreport.TKDoanhThuQuy(year);
        }
        public DataTable TKDoanhThuCacPhong()
        {
            return dalreport.TKDoanhThuCacPhong();
        }
        public DataTable TKDoanhThuPhong(string idRoom)
        {
            return dalreport.TKDoanhThuPhong(idRoom);
        }
        public DataTable TKSoLuongTinhTrangPhong()
        {
            return dalreport.TKSoLuongTinhTrangPhong();
        }
        public int TKTongSoHopDong()
        {
            return dalreport.TKTongSoHopDong();
        }
        public int TKHopDongConHan()
        {
            return dalreport.TKHopDongConHan();
        }
        public int TKHopDongMoiTrongThang() {
            return dalreport.TKHopDongMoiTrongThang();
        }
       public DataTable TKTongTienDienTieuThu()
        {
            return dalreport.TKTongTienDienTieuThu();
        }
        public DataTable TKTongTienNuocTieuThu()
        {
            return dalreport.TKTongTienNuocTieuThu();
        }
    }
}
