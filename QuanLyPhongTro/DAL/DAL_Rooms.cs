using QuanLyPhongTro.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongTro.DAL
{
    internal class DAL_Rooms
    {
        DatabaseConnect db = new DatabaseConnect();
        //////////////////
        ///////
        public List<Room> getListRoom()
        {
            string sql = "select *\r\nfrom Phong p \r\ninner join  LoaiPhong lp on p.MaLoai = lp.MaLoai;";
            List<Room> listroom = new List<Room>();
            DataTable dt =  db.Execute(sql);
            foreach (DataRow row in dt.Rows) {
                Room room = new Room
                {
                    SoPhong = row["SoPhong"].ToString(),
                    TrangThai = row["TrangThai"].ToString(),
                    MaLoai = row["MaLoai"].ToString(),
                    GhiChu = row["GhiChu"].ToString(),
                    Gia = Convert.ToDecimal(row["Gia"]),
                    TenLoai = row["TenLoai"].ToString()
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
                  
                    Gia = Convert.ToDecimal(row["Gia"]),
                    TenLoai = row["TenLoai"].ToString()
                };
            }
          
            return room;
        }
        public DataTable GetTypeRoom()
        {
            string sql = "select  * from LoaiPhong";
            DataTable dt = db.Execute(sql);
            return dt;
        }
        public List<Room> fillerTypeRoom(string maLoai)
        {
            List<Room> listroom = new List<Room>();
            string sql = string.Format("select p.SoPhong , p.TrangThai , p.MaLoai , p.GhiChu , lp.TenLoai , lp.Gia " +
                "from Phong p " +
                "inner join LoaiPhong lp on lp.MaLoai = p.MaLoai " +
                "where p.MaLoai = '{0}'",maLoai);

            DataTable dt = db.Execute(sql);
            foreach (DataRow row in dt.Rows)
            {
               Room room = new Room
               {
                   SoPhong = row["SoPhong"].ToString(),
                   TrangThai = row["TrangThai"].ToString(),
                   MaLoai = row["MaLoai"].ToString(),
                   GhiChu = row["GhiChu"].ToString(),
                   TenLoai = row["TenLoai"].ToString(),
                   Gia = Convert.ToDecimal(row["Gia"])
               };
               listroom.Add(room);
            }

            return listroom;
        }

        public List<Room> fillerStatusRoom(string trangThai)
        {
            List<Room> listroom = new List<Room>();
            string sql = string.Format("select p.SoPhong , p.TrangThai , p.MaLoai , p.GhiChu , lp.TenLoai , lp.Gia " +
                "from Phong p " +
                "inner join LoaiPhong lp on lp.MaLoai = p.MaLoai " +
                "where p.TrangThai = N'{0}'", trangThai);

            DataTable dt = db.Execute(sql);
            foreach (DataRow row in dt.Rows)
            {
                Room room = new Room
                {
                    SoPhong = row["SoPhong"].ToString(),
                    TrangThai = row["TrangThai"].ToString(),
                    MaLoai = row["MaLoai"].ToString(),
                    GhiChu = row["GhiChu"].ToString(),
                    TenLoai = row["TenLoai"].ToString(),
                    Gia = Convert.ToDecimal(row["Gia"])
                };
                listroom.Add(room);
            }

            return listroom;
        }
        public List<Room> fillerStatusAndType(string maLoai,string trangThai)
        {
            List<Room> listroom = new List<Room>();
            string sql = string.Format(" select p.SoPhong , p.TrangThai , p.MaLoai , p.GhiChu , lp.TenLoai , lp.Gia " +
                "from Phong p " +
                "inner join LoaiPhong lp on lp.MaLoai = p.MaLoai " +
                "where p.TrangThai = N'{0}' and p.MaLoai = '{1}'" , trangThai, maLoai);

            DataTable dt = db.Execute(sql);
            foreach (DataRow row in dt.Rows)
            {
                Room room = new Room
                {
                    SoPhong = row["SoPhong"].ToString(),
                    TrangThai = row["TrangThai"].ToString(),
                    MaLoai = row["MaLoai"].ToString(),
                    GhiChu = row["GhiChu"].ToString(),
                    TenLoai = row["TenLoai"].ToString(),
                    Gia = Convert.ToDecimal(row["Gia"])
                };
                listroom.Add(room);
            }

            return listroom;
        }
        /////////////////////
        ////
        public bool UpdateRoom(Room r)
        {
             string sql = string.Format("update Phong set  Phong.MaLoai = '{0}' , Phong.TrangThai = N'{1}' , Phong.GhiChu = N'{2}' where Phong.SoPhong = '{3}'", r.MaLoai, r.TrangThai, r.GhiChu, r.SoPhong);
             if (db.ExecuteNonQuery(sql) > 0)
             {
                return true;
             }
             return false;
        }
        public bool AddRoom(Room r)
        {
            string sql = string.Format("insert  into   Phong values ( '{0}',N'{1}','{2}','{3}')", r.SoPhong, r.TrangThai, r.MaLoai, r.GhiChu);
            if (db.ExecuteNonQuery(sql) > 0)
            {
                return true;
            }
            return false;
        }
        public bool RemoveRoom(string sophong)
        {
            string sql = string.Format("delete Phong where Phong.SoPhong = '{0}'",sophong);
            if (db.ExecuteNonQuery(sql) > 0)
            {
                return true;
            }
            return false;
        }
        public bool RoomExist(string id)
        {
            string sql = string.Format("select * \r\nfrom Phong \r\nwhere Phong.SoPhong = '{0}'", id);
            DataTable dt  = db.Execute(sql);
            if (dt.Rows.Count == 1)
            {
                return true;
            }
            return false;
        }

        ///////////////////
        ///
        public DataTable getDataTypeRoom()
        {
            DataTable dt = new DataTable();
            string sql = "select * from LoaiPhong where LoaiPhong.MaLoai != 'L'";
            dt = db.Execute(sql);
            return dt;
        }
        public bool AddTypeRoom(string  maLoai, string tenLoai , string gia)
        {
            string sql = string.Format("insert into LoaiPhong  values ('{0}',N'{1}',{2})", maLoai, tenLoai, gia);
            if (db.ExecuteNonQuery(sql) > 0)
            {
                return true;
            }
            return false ;
        }
        public bool RemoveTypeRoom(string maLoai) {
            string sql = string.Format("delete LoaiPhong from LoaiPhong where LoaiPhong.MaLoai = '{0}'",maLoai);
            if (db.ExecuteNonQuery(sql) > 0)
            {
                return true;
            }
            return false;
        }
        public bool ModifyRoom(string maLoai, string tenLoai,string gia)
        {
            decimal Gia = Convert.ToDecimal(gia);
            string sql = string.Format("update LoaiPhong set TenLoai = N'{0}',Gia = {1} where MaLoai = '{2}'",tenLoai, Gia, maLoai);
            if (db.ExecuteNonQuery(sql) > 0)
            {
                return true;
            }
            return false;
        }
        public bool TypeRoomExist(string maLoai)
        {
            string sql =  string.Format("select * from LoaiPhong where LoaiPhong.MaLoai = '{0}'",maLoai);

            if (db.Execute(sql).Rows.Count >  0)
            {
                return true;
            }
            return false;
        }

    }
}
