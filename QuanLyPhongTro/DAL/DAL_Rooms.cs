using QuanLyPhongTro.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongTro.DAL
{
    internal class DAL_Rooms
    {
        DatabaseConnect db = new DatabaseConnect();
      
        public List<Room> getListRoom()
        {
            string sql = "select * from Phong;";
            List<Room> listroom = new List<Room>();
            DataTable dt =  db.Execute(sql);
            foreach (DataRow row in dt.Rows) {
                Room room = new Room
                {
                    SoPhong = row["SoPhong"].ToString(),
                    TrangThai = row["TrangThai"].ToString(),
                    MaLoai = row["MaLoai"].ToString(),
                    GhiChu = row["GhiChu"].ToString(),
                    SoDien = row["SoDien"].ToString(),
                    SoNuoc = row["SoNuoc"].ToString()
                };
                listroom.Add(room);
            }
            return listroom;
        }
       public Room FindRoomByID(int id)
       {
            string sql = string.Format("select * from Phong , LoaiPhong where Phong.MaLoai = LoaiPhong.MaLoai and Phong.SoPhong = '{0}'",id);
          
            Room room = new Room();
            DataTable dt = db.Execute(sql);
            
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0]; 

                room = new Room
                {
                    SoPhong = row["SoPhong"].ToString(),
                    TrangThai = row["TrangThai"].ToString(),
                    MaLoai = row["MaLoai"].ToString(),
                    GhiChu = row["GhiChu"].ToString(),
                    SoDien = row["SoDien"].ToString(),
                    SoNuoc = row["SoNuoc"].ToString(),
                    Gia = Convert.ToDecimal(row["Gia"]),
                    TenLoai = row["TenLoai"].ToString()
                };
            }
          
            return room;
        }
    }
}
