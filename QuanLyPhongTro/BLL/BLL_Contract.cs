using QuanLyPhongTro.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyPhongTro.DTO;

namespace QuanLyPhongTro.BLL
{
    internal class BLL_Contract
    {
        DAL_Contract dal = new DAL_Contract();
        public decimal FindContractByIDRoom(string id)
        {
            return dal.FindContractByIDRoom(id);
        }
    }
}
