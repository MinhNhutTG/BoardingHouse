using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongTro.DAL
{
    internal class DAL_Report
    {
        DatabaseConnect db = new DatabaseConnect();
        public DataTable TKDoanhThuThang(int year)
        {
            string sql = string.Format("SELECT FORMAT(NgayLapHoaDon, 'yyyy-MM') AS Thang, SUM(TongTien) AS TongDoanhThu FROM HoaDon WHERE YEAR(NgayLapHoaDon) = {0} GROUP BY FORMAT(NgayLapHoaDon, 'yyyy-MM') ORDER BY Thang;",year);
            DataTable dt = db.Execute(sql);
            return dt;
        }
        public DataTable TKDoanhThuQuy(int year) { 
            string sql = string.Format(
                    "SELECT " +
                     "CONCAT('Q', DATEPART(QUARTER, NgayLapHoaDon)) AS Quy," +
                     "  SUM(TongTien) AS TongDoanhThu FROM HoaDon " +
                     "WHERE YEAR(NgayLapHoaDon) = {0} " +
                     "GROUP BY DATEPART(QUARTER, NgayLapHoaDon) ORDER BY Quy;",year);
            DataTable dt = db.Execute(sql);
            return dt;
        }
        public DataTable TKDoanhThuCacPhong()
        {
            string sql = "SELECT \r\n    SoPhong, \r\n    SUM(TongTien) AS TongDoanhThuTienPhong\r\nFROM HoaDon\r\nwhere HoaDon.TrangThai = N'Đã thanh toán'\r\nGROUP BY SoPhong\r\nORDER BY TongDoanhThuTienPhong DESC;";
            DataTable dt = db.Execute(sql);
            return dt;
        }
        public DataTable TKDoanhThuPhong(string idRoom)
        {
            string sql = string.Format("SELECT hd.SoPhong , SUM(TongTien) as TongDoanhThu from  HoaDon hd  where hd.SoPhong = '{0}' GROUP BY SoPhong",idRoom);
            DataTable dt = db.Execute(sql);
            return dt;
        }
        public DataTable TKSoLuongTinhTrangPhong()
        {
            string sql = "SELECT TrangThai, COUNT(*) AS so_luong\r\nFROM Phong\r\nGROUP BY TrangThai;";
            DataTable dt = db.Execute(sql);
            return dt;
        }
        public int TKTongSoHopDong()
        {
            string sql = "SELECT COUNT(*) AS TongSoHopDong\r\nFROM HopDongThue;";
            DataTable dt = db.Execute(sql);
            return Convert.ToInt32(dt.Rows[0][0].ToString());
        }
        public int TKHopDongConHan()
        {
            string sql = "SELECT COUNT(*) AS TongSoHopDong\r\nFROM HopDongThue\r\nWHERE TrangThai = N'Còn hạn';";
            DataTable dt = db.Execute(sql);
            return Convert.ToInt32(dt.Rows[0][0].ToString());
        }
        public int TKHopDongMoiTrongThang()
        {
            string sql = "SELECT COUNT(*) AS SoHopDongMoiTrongThang\r\nFROM HopDongThue\r\nWHERE MONTH(NgayTaoHopDong) = MONTH(GETDATE()) \r\nAND YEAR(NgayTaoHopDong) = YEAR(GETDATE());\r\n";
            DataTable dt = db.Execute(sql);
            return Convert.ToInt32(dt.Rows[0][0].ToString());
        }
        public DataTable TKTongTienDienTieuThu()
        {
            string sql = "SELECT Ki, SUM(SoDienMoi - SoDienCu) AS TongDienTieuThu\r\nFROM LichSuDichVu\r\nGROUP BY Ki;";
            return  db.Execute(sql);
        }
        public DataTable TKTongTienNuocTieuThu()
        {
            string sql = "SELECT Ki, SUM(SoNuocMoi - SoNuocCu) AS TongDienTieuThu\r\nFROM LichSuDichVu\r\nGROUP BY Ki;";
            return db.Execute(sql);
        }
        public DataTable TongTienDienMoiThang(int year)
        {
            string sql = string.Format("SELECT Ki, SUM((SoDienMoi - SoDienCu) * GiaDien) AS TongTienDien\r\nFROM LichSuDichVu\r\nWHERE Ki LIKE '%-{0}'\r\nGROUP BY Ki\r\nORDER BY Ki;\r\n",year);
            return db.Execute(sql);
        }
        public DataTable TongTienNuocMoiThang(int year)
        {
            string sql = string.Format("SELECT Ki, SUM((SoNuocMoi - SoNuocCu) * GiaNuoc) AS TongTienNuoc\r\nFROM LichSuDichVu\r\nWHERE Ki LIKE '%-{0}'\r\nGROUP BY Ki\r\nORDER BY Ki;\r\n", year);
            return db.Execute(sql);
        }
        public DataTable TongTienMangMoiThang(int year)
        {
            string sql = string.Format("SELECT Ki, SUM(TienMang) AS TongTienMang\r\nFROM LichSuDichVu\r\nWHERE Ki LIKE '%-{0}'\r\nGROUP BY Ki\r\nORDER BY Ki;\r\n", year);
            return db.Execute(sql);
        }
        public DataTable TongDoanhThuDichVuMoiThang(int year)
        {
            string sql = string.Format("SELECT Ki, SUM((SoDienMoi - SoDienCu) * GiaDien + (SoNuocMoi - SoNuocCu) * GiaNuoc + TienMang) AS TongDoanhThu\r\nFROM LichSuDichVu\r\nWHERE Ki LIKE '%-{0}'\r\nGROUP BY Ki\r\nORDER BY Ki;\r\n", year);
            return db.Execute(sql);
        }
        ///////// Room 
        ///
        public List<int> getNumberStatusRoom()
        {
            string sql = "SELECT " +
                "   COUNT(CASE WHEN TrangThai = N'Đang Thuê' THEN 1 END) AS DangThue," +
                "   COUNT(CASE WHEN TrangThai = N'Đang Sửa' THEN 1 END) AS DangSua," +
                "  COUNT(CASE WHEN TrangThai = N'Trống' THEN 1 END) AS Trong " +
                "FROM PHONG;";
            List<int> list = new List<int>();
            DataTable dt = db.Execute(sql);
            if (dt.Rows.Count > 0) 
            {
                DataRow dr = dt.Rows[0]; 
                list.Add(Convert.ToInt32(dr["DangThue"]));  // Lấy giá trị cột "DangThue"
                list.Add(Convert.ToInt32(dr["DangSua"]));   // Lấy giá trị cột "DangSua"
                list.Add(Convert.ToInt32(dr["Trong"]));     // Lấy giá trị cột "Trong"
            }
            return list;
        }
        public List<int> getNumberStatusBill()
        {
            string sql = "SELECT \r\n    COUNT(CASE WHEN TrangThai = N'ĐÃ THANH TOÁN' THEN 1 END) AS DATHANHTOAN,\r\n    COUNT(CASE WHEN TrangThai = N'CHƯA THANH TOÁN' THEN 1 END) AS CHUATHANHTOAN\r\nFROM HoaDon;";
            List<int> list = new List<int>();
            DataTable dt = db.Execute(sql);
            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                list.Add(Convert.ToInt32(dr["DATHANHTOAN"]));  
                list.Add(Convert.ToInt32(dr["CHUATHANHTOAN"]));  
             
            }
            return list;
        }
    }
}
