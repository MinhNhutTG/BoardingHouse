using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyPhongTro.DTO;

namespace QuanLyPhongTro.DAL
{
    
    internal class DAL_Guest
    {
        DatabaseConnect db = new DatabaseConnect();
        public List<Guest> getListGuest()
        {
            string sql = "select * from KhachThue";
            DataTable dt = db.Execute(sql);
            List<Guest> list = new List<Guest>();
            foreach (DataRow r in dt.Rows)
            {
                Guest guest = new Guest();
                guest.MaKhach = r["MaKhach"].ToString();
                guest.HoTen = r["HoTen"].ToString();
                guest.NgaySinh = Convert.ToDateTime(r["NgaySinh"]);
                guest.CCCD = r["CCCD"].ToString();
                guest.SoDienThoai = r["SoDienThoai"].ToString();
                guest.QueQuan = r["QueQuan"].ToString();
                guest.TrangThai = r["TrangThai"].ToString();
                list.Add(guest);
            }
            return list;
        }
    }
}
