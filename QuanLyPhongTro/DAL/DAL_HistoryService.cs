using QuanLyPhongTro.DTO;
using QuanLyPhongTro.GUI.Notify;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongTro.DAL
{
    internal class DAL_HistoryService
    {

        DatabaseConnect db = new DatabaseConnect();
        public bool AddHisSV(HistoryService hs)
        {
            string sql = string.Format("INSERT INTO LichSuDichVu " +
                "VALUES ({0}, '{1}', '{2}', {3}, {4}, {5}, {6},{7},{8}, '{9}' , {10} ,N'{11}')", hs.ID, hs.SoPhong, hs.Ki, hs.SoDienCu, hs.SoDienMoi, hs.SoNuocCu, hs.SoNuocMoi, hs.GiaDien, hs.GiaNuoc, hs.NgayTao,hs.TienMang,hs.TrangThai);
            if (db.ExecuteNonQuery(sql) > 0)
            {
                return true;
            }
            return false;
        }
        public HistoryService FindHistoryServiceByIDRoomAndMonth(string idRoom , string ki)
        {
            string sql = string.Format("select * from LichSuDichVu where SoPhong = '{0}' and Ki = '{1}'",idRoom,ki);
            DataTable dt = db.Execute(sql);
            HistoryService service = new HistoryService();
            foreach (DataRow dr in dt.Rows)
            {
                service.ID = Convert.ToInt32(dr["ID"]);
                service.SoPhong = dr["SoPhong"].ToString();
                service.Ki = dr["Ki"].ToString();
                service.SoDienCu = Convert.ToInt32(dr["SoDienCu"]);
                service.SoDienMoi = Convert.ToInt32(dr["SoDienMoi"]);
                service.SoNuocCu = Convert.ToInt32(dr["SoNuocCu"]);
                service.SoNuocMoi = Convert.ToInt32(dr["SoNuocMoi"]);
                service.GiaDien = Convert.ToDecimal(dr["GiaDien"]);
                service.GiaNuoc = Convert.ToDecimal(dr["GiaNuoc"]);
                service.NgayTao = Convert.ToDateTime(dr["NgayTao"]);
                service.TienMang = Convert.ToDecimal(dr["TienMang"]);
                service.TrangThai = dr["TrangThai"].ToString();
            }
            return service;
        }
        public bool RemoveHisSV(int id)
        {
            string sql = string.Format("DELETE HoaDon WHERE  HoaDon.IDDichVu = {0} \r\nDELETE LichSuDichVu WHERE LichSuDichVu.ID = {0}\r\n ", id);
            if (db.ExecuteNonQuery(sql) > 0)
            {
                return true;
            }
            return false;
        }

        public bool Update(HistoryService hs)
        {

            string sql = string.Format(" UPDATE LichSuDichVu " +
                "SET SoPhong  = '{0}',  Ki = '{1}', SoDienCu = {2}, SoDienMoi = {3}, SoNuocCu = {4}, SoNuocMoi = {5}, GiaDien  = {6}, GiaNuoc   = {7}, NgayTao = '{8}', TienMang= {9} , TrangThai = N'{10}' " +
                "WHERE ID = {11};", hs.SoPhong, hs.Ki, hs.SoDienCu, hs.SoDienMoi, hs.SoNuocCu, hs.SoNuocMoi, hs.GiaDien, hs.GiaNuoc, hs.NgayTao,hs.TienMang,hs.TrangThai, hs.ID);
            if (db.ExecuteNonQuery(sql) > 0)
            {
                return true;
            }
            return false;
        }
        public decimal getPriceInternet(int id)
        {
            string sql = string.Format("select ls.TienMang from LichSuDichVu ls where ls.ID = {0}", id);
            DataTable dt = db.Execute(sql);
            return Convert.ToDecimal(dt.Rows[0][0]);
        }
        public HistoryService getHistoryServiceByID(int id)
        {
            string sql = string.Format("select * from LichSuDichVu where ID= {0}", id);
            DataTable dt = db.Execute(sql);
            HistoryService service = new HistoryService();
            foreach (DataRow dr in dt.Rows)
            {
                service.ID = Convert.ToInt32(dr["ID"]);
                service.SoPhong = dr["SoPhong"].ToString();
                service.Ki = dr["Ki"].ToString();
                service.SoDienCu = Convert.ToInt32(dr["SoDienCu"]);
                service.SoDienMoi = Convert.ToInt32(dr["SoDienMoi"]);
                service.SoNuocCu = Convert.ToInt32(dr["SoNuocCu"]);
                service.SoNuocMoi = Convert.ToInt32(dr["SoNuocMoi"]);
                service.GiaDien = Convert.ToDecimal(dr["GiaDien"]);
                service.GiaNuoc = Convert.ToDecimal(dr["GiaNuoc"]);
                service.NgayTao = Convert.ToDateTime(dr["NgayTao"]);
                service.TienMang = Convert.ToDecimal(dr["TienMang"]);
                service.TrangThai = dr["TrangThai"].ToString();

            }
            return service;
        }
        public List<HistoryService> GetListHistoryService()
        {
            string sql = "select * from LichSuDichVu  ORDER BY KI DESC  ";
            DataTable dt = db.Execute(sql);
            return ChangeDataTableToList(dt);

        }
        public List<HistoryService> GetListHistoryServiceByID(int id)
        {
            string sql = string.Format("select * from LichSuDichVu where SoPhong = {0} ORDER BY KI DESC", id);
            DataTable dt = db.Execute(sql);
            return ChangeDataTableToList(dt);

        }
        public List<int> getValueOldService(string idRoom)
        {
            string sql = string.Format("SELECT TOP 1 * FROM LichSuDichVu WHERE SoPhong = {0} ORDER BY NGAYTAO DESC;", idRoom);
            DataTable dt = db.Execute(sql);
            List<int> List = new List<int>();
            foreach (DataRow dr in dt.Rows)
            {

                int value = Convert.ToInt32(dr["SoDienMoi"]);

                List.Add(value);
                int value2 = Convert.ToInt32(dr["SoNuocMoi"]);
                List.Add(value2);
            }
            return List;
        }
        public bool ExistID(int id)
        {
            string sql = string.Format("select * from LichSuDichVu where ID= {0}", id);
            DataTable dt = db.Execute(sql);
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }


        ///// ////// Sort 
        ///
        public List<HistoryService> SortKI_DESC()
        {
            string sql = "SELECT * FROM LichSuDichVu\r\nORDER BY LichSuDichVu.Ki DESC;";
            DataTable dt = db.Execute(sql);
            List<HistoryService> list = new List<HistoryService>();
            return ChangeDataTableToList(dt);
        }
        public List<HistoryService> SortKI_ASC()
        {
            string sql = "SELECT * FROM LichSuDichVu\r\nORDER BY LichSuDichVu.Ki ASC;";
            DataTable dt = db.Execute(sql);
            return ChangeDataTableToList(dt);
        }

        public List<HistoryService> HistoryServicesByIDRoom(string IDroom)
        {
            string sql = string.Format("select * from LichSuDichVu where SoPhong = '{0}' ORDER BY KI DESC", IDroom);
            DataTable dt = db.Execute(sql);
            return ChangeDataTableToList(dt);
        }
        public List<HistoryService> ChangeDataTableToList(DataTable dt)
        {
            List<HistoryService> list = new List<HistoryService>();
            foreach (DataRow dr in dt.Rows)
            {
                HistoryService service = new HistoryService();
                service.ID = Convert.ToInt32(dr["ID"]);
                service.SoPhong = dr["SoPhong"].ToString();
                service.Ki = dr["Ki"].ToString();
                service.SoDienCu = Convert.ToInt32(dr["SoDienCu"]);
                service.SoDienMoi = Convert.ToInt32(dr["SoDienMoi"]);
                service.SoNuocCu = Convert.ToInt32(dr["SoNuocCu"]);
                service.SoNuocMoi = Convert.ToInt32(dr["SoNuocMoi"]);
                service.GiaDien = Convert.ToDecimal(dr["GiaDien"]);
                service.GiaNuoc = Convert.ToDecimal(dr["GiaNuoc"]);
                service.NgayTao = Convert.ToDateTime(dr["NgayTao"]);
                service.TienMang = Convert.ToDecimal(dr["TienMang"]);
                service.TrangThai = dr["TrangThai"].ToString();
                list.Add(service);
            }
            return list;
        }
        public string FindIDByKi(string soPhong, string ki)
        {
            string sql = string.Format("select ls.ID from LichSuDichVu ls where ls.SoPhong = '{0}' and ls.Ki = '{1}'", soPhong, ki);
            DataTable dt = db.Execute(sql);
           
            return dt.Rows[0][0].ToString();
        }
        public HistoryService getHistoryServiceByStatus(string idRoom)
        {
            string sql = string.Format("select * from LichSuDichVu where LichSuDichVu.TrangThai = N'Chờ Lập Hóa Đơn' and LichSuDichVu.SoPhong = '{0}' ",idRoom);
            DataTable dt = db.Execute(sql);
            HistoryService service = new HistoryService();
            foreach (DataRow dr in dt.Rows)
            {
                service.ID = Convert.ToInt32(dr["ID"]);
                service.SoPhong = dr["SoPhong"].ToString();
                service.Ki = dr["Ki"].ToString();
                service.SoDienCu = Convert.ToInt32(dr["SoDienCu"]);
                service.SoDienMoi = Convert.ToInt32(dr["SoDienMoi"]);
                service.SoNuocCu = Convert.ToInt32(dr["SoNuocCu"]);
                service.SoNuocMoi = Convert.ToInt32(dr["SoNuocMoi"]);
                service.GiaDien = Convert.ToDecimal(dr["GiaDien"]);
                service.GiaNuoc = Convert.ToDecimal(dr["GiaNuoc"]);
                service.NgayTao = Convert.ToDateTime(dr["NgayTao"]);
                service.TienMang = Convert.ToDecimal(dr["TienMang"]);
                service.TrangThai = dr["TrangThai"].ToString();
            }
            return service;
        }
        public List<HistoryService> GetPendingServiceHistory() {
            string sql = "select * from LichSuDichVu where LichSuDichVu.TrangThai = N'Chờ Lập Hóa Đơn' ";
            DataTable dt = db.Execute(sql);
            List<HistoryService> list = new List<HistoryService>();
            return ChangeDataTableToList(dt);
        }
        public bool UpdateStatus(string status, string idLS)
        {
            string sql = string.Format("Update LichSuDichVu SET LichSuDichVu.TrangThai = N'{0}' where LichSuDichVu.ID = '{1}'",status,idLS);
            DataTable dt = db.Execute(sql);
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }
        public List<HistoryService> FillHistoryByStatus(string status)
        {
            string sql = string.Format("select * from LichSuDichVu where LichSuDichVu.TrangThai = N'{0}'",status);
            DataTable dt = db.Execute(sql);
            return ChangeDataTableToList(dt);
        }
    }
}
