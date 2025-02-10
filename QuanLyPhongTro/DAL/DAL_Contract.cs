using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using QuanLyPhongTro.DTO;


namespace QuanLyPhongTro.DAL
{
    internal class DAL_Contract
    {
        DatabaseConnect db = new DatabaseConnect();
        public Contract FindContractByIDRoom(int id)
        {
            Contract ctr =  new Contract();
            string sqlhopdong = string.Format(" select KhachChinh.HoTen as TenKhachChinh, KhachPhu.HoTen as TenKhachPhu,hd.GiaPhong,hd.ID , hd.TrangThai from HopDongThue hd " +
                "inner join KhachThue KhachChinh on KhachChinh.MaKhach = hd.IDKhachChinh " +
                "left join KhachThue KhachPhu on KhachPhu.MaKhach = hd.IDKhachPhu " +
                "where SoPhong = '{0}'", id);

            DataTable dtHopDong = db.Execute(sqlhopdong);

            if (dtHopDong.Rows.Count > 0)
            {
                DataRow row = dtHopDong.Rows[0];

                ctr = new Contract();
                {
                    ctr.Id = row["ID"].ToString();
               
                    ctr.GiaPhong = Convert.ToDecimal(row["GiaPhong"].ToString());
                    
                 
                    ctr.TrangThai = row["TrangThai"].ToString();
                  
                    if (row["TenKhachChinh"].ToString() == null)
                    {
                        ctr.TenKhach1 = "Khong co";
                    }
                    else
                    {
                        ctr.TenKhach1 = row["TenKhachChinh"].ToString();
                    }

                    if (row["TenKhachPhu"].ToString() == null)
                    {
                        ctr.TenKhach1 = "Khong co";
                    }
                    else
                    {
                        ctr.TenKhach2 = row["TenKhachPhu"].ToString();
                    }

                  
                };
            }
            return ctr;
        }
    }
}


//ctr.Id = row["ID"].ToString();
//ctr.NgayThue = Convert.ToDateTime(row["NgayThue"].ToString());
//ctr.HanThue = Convert.ToDateTime(row["HanThue"].ToString());
//ctr.SoPhong = Convert.ToInt32(row["SoPhong"].ToString());
//ctr.GiaPhong = Convert.ToDecimal(row["GiaPhong"].ToString());
//ctr.IdKhachChinh = Convert.ToInt32(row["IDKhachChinh"].ToString());
//ctr.IdKhachPhu = Convert.ToInt32(row["IDKhachPhu"].ToString());
//ctr.TrangThai = row["TrangThai"].ToString();
//ctr.NgayTaoHopDong = Convert.ToDateTime(row["NgayTaoHopDong"].ToString());
//ctr.TenKhach1 = row["TenKhach1"].ToString();
//ctr.TenKhach2 = row["TenKhach2"].ToString();
//                };