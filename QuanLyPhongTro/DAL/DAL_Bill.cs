using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyPhongTro.DTO;

namespace QuanLyPhongTro.DAL
{
    internal class DAL_Bill
    {
        DatabaseConnect db = new DatabaseConnect();
        
        public List<Bill> GetListBill()
        {
            string sql = "select * from HoaDon";
            List<Bill> list = new List<Bill>();
            DataTable dt = db.Execute(sql);
            foreach (DataRow r in dt.Rows)
            {
                Bill bill = new Bill();
                bill.IdHoaDon = r["IDHoaDon"].ToString();
                bill.IdDichVu = Convert.ToInt32(r["IDDichVu"]);
                bill.SoPhong = r["SoPhong"].ToString();
                bill.SoDien = Convert.ToDecimal(r["SoDien"]);
                bill.TienDien = Convert.ToDecimal(r["TienDien"]);
                bill.SoNuoc = Convert.ToDecimal(r["SoNuoc"]);
                bill.TienNuoc = Convert.ToDecimal(r["TienNuoc"]);
                bill.PhiKhac = Convert.ToDecimal(r["PhiKhac"]);
                bill.TongTien = Convert.ToDecimal(r["TongTien"]);
                bill.NgayLapHoaDon = Convert.ToDateTime(r["NgayLapHoaDon"]);
                bill.TrangThai = r["TrangThai"].ToString();
                bill.GhiChu = r["GhiChu"].ToString() ;
                list.Add(bill);
            }
            return list;
        }
        public bool AddBill(Bill b)
        {
            string sql = string.Format("INSERT INTO HoaDon VALUES ('{0}',{1},{2},{3},{4},{5},{6},{7},{8},'{9}',N'{10}',N'{11}');",
                 b.IdHoaDon, b.IdDichVu, b.SoPhong, b.SoDien, b.TienDien, b.SoNuoc, b.TienNuoc, b.PhiKhac, b.TongTien, b.NgayLapHoaDon, b.TrangThai, b.GhiChu);
            if (db.ExecuteNonQuery(sql) > 0)
            {
                return true;
            }
            return false;
        }
        public bool UpdateBill()
        {
            string sql = string.Format("update HoaDon \r\nset SoPhong = 102,SoDien = 11 , SoNuoc = 4 , TongTien = 2.000  , DonGiaDien = 11111 , DonGiaNuoc = 22222 , TrangThai = N'Đã thanh toán',NgayLapHoaDon = 9/3/2025 , TienMang = 4000\r\nwhere IDHoaDon = 'HD0803101';");
            return true;
        }
        public bool DeleteBill() {
            return true;
        }
        public bool ExistBill(string id)
        {
            string sql = string.Format("select * from HoaDon where IDHoaDon = '{0}'", id);
            DataTable dt = db.Execute(sql);
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }
    }
}
