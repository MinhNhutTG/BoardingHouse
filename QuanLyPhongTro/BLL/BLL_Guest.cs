using QuanLyPhongTro.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyPhongTro.DAL;

namespace QuanLyPhongTro.BLL
{
    internal class BLL_Guest
    {
        DAL_Guest dal = new DAL_Guest();
        public List<Guest> getListGuest()
        {
            return dal.getListGuest();
        }
    }
}
