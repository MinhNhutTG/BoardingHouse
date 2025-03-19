using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyPhongTro.DTO;


namespace QuanLyPhongTro.DAL
{
    internal class DAL_Contract
    {
        DatabaseConnect db = new DatabaseConnect();
        DAL_Rooms bllroom = new DAL_Rooms();
        public decimal FindContractByIDRoom(string idRoom)
        {
            string sql = string.Format("SELECT HopDongThue.GiaPhong FROM HopDongThue WHERE HopDongThue.SoPhong = '{0}' AND HopDongThue.TrangThai = N'Còn hạn'", idRoom);
            DataTable dt = db.Execute(sql);
            decimal price = 0;
            if (dt.Rows.Count > 0)
            {
                price = Convert.ToDecimal(dt.Rows[0][0].ToString());
            }
            else
            {
               Room r =  bllroom.FindRoomByID(Convert.ToInt32(idRoom));
                price = r.Gia;
            }
            return price;
        }
    }
}


