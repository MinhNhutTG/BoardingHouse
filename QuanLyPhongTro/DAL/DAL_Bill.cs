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
              
                bill.IdDichVu = r["IDDichVu"] == DBNull.Value ? 0 : Convert.ToInt32(r["IDDichVu"]);
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
                bill.GiaPhong = Convert.ToDecimal(r["GiaPhong"]);
                list.Add(bill);
            }
            return list;
        }
        public List<Bill> SearchBill(string key)
        {
            string sql = string.Format("select * from HoaDon where   IDDichVu = {0} or SoPhong = '{0}'",key);
             List<Bill> list = new List<Bill>();
            DataTable dt = db.Execute(sql);
            foreach (DataRow r in dt.Rows)
            {
                Bill bill = new Bill();
                bill.IdHoaDon = r["IDHoaDon"].ToString();
                bill.IdDichVu = r["IDDichVu"] == DBNull.Value ? 0 : Convert.ToInt32(r["IDDichVu"]);
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
                bill.GiaPhong = Convert.ToDecimal(r["GiaPhong"]);
                list.Add(bill);
            }
            return list;
        }
        public bool AddBill(Bill b)
        {
            MessageBox.Show(b.IdDichVu.ToString());
            string sql = string.Format("INSERT INTO HoaDon VALUES ('{0}',{1},{2},{3},{4},{5},{6},{7},{8},'{9}',N'{10}',N'{11}',{12});",
                 b.IdHoaDon, b.IdDichVu.HasValue ? b.IdDichVu.ToString() : "NULL", b.SoPhong, b.SoDien, b.TienDien, b.SoNuoc, b.TienNuoc, b.PhiKhac, b.TongTien, b.NgayLapHoaDon, b.TrangThai, b.GhiChu,b.GiaPhong);
            if (db.ExecuteNonQuery(sql) > 0)
            {
                return true;
            }
            return false;
        }
        public bool UpdateBill(Bill b)
        {
            string sql = string.Format("UPDATE HoaDon SET " +"SoPhong = '{0}', SoDien = {1}, TienDien = {2}, SoNuoc = {3}, TienNuoc = {4}, PhiKhac = {5}, TongTien = {6}," +
                " GiaPhong = {7}, TrangThai = N'{8}',NgayLapHoaDon = '{9}', GhiChu = N'{10}' " +
                 "WHERE IDHoaDon = '{11}';",
                 b.SoPhong, b.SoDien, b.TienDien, b.SoNuoc, b.TienNuoc,
                 b.PhiKhac, b.TongTien, b.GiaPhong, b.TrangThai,
                 b.NgayLapHoaDon, b.GhiChu, b.IdHoaDon);
            if (db.ExecuteNonQuery(sql) > 0)
            {
                return true;
            }
            return false;
            
        }
        public bool DeleteBill(string id) {
            string sql = string.Format("DELETE HoaDon  where HoaDon.IDHoaDon = '{0}';", id);
            if (db.ExecuteNonQuery(sql) > 0)
            {
                return true;
            }
            return false;
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
        public Bill FindBillByID(string id)
        {
            string sql = string.Format(" SELECT * FROM HoaDon where HoaDon.IDHoaDon = '{0}'",id);
            Bill bill = new Bill();
            DataTable dt = db.Execute(sql);
            foreach (DataRow r in dt.Rows)
            {
               
                bill.IdHoaDon = r["IDHoaDon"].ToString();
                bill.IdDichVu = r["IDDichVu"] == DBNull.Value ? 0 : Convert.ToInt32(r["IDDichVu"]);
                bill.SoPhong = r["SoPhong"].ToString();
                bill.SoDien = Convert.ToDecimal(r["SoDien"]);
                bill.TienDien = Convert.ToDecimal(r["TienDien"]);
                bill.SoNuoc = Convert.ToDecimal(r["SoNuoc"]);
                bill.TienNuoc = Convert.ToDecimal(r["TienNuoc"]);
                bill.PhiKhac = Convert.ToDecimal(r["PhiKhac"]);
                bill.TongTien = Convert.ToDecimal(r["TongTien"]);
                bill.NgayLapHoaDon = Convert.ToDateTime(r["NgayLapHoaDon"]);
                bill.TrangThai = r["TrangThai"].ToString();
                bill.GhiChu = r["GhiChu"].ToString();
                bill.GiaPhong = Convert.ToDecimal(r["GiaPhong"]);

            }
            return bill;
        }
    }
}
