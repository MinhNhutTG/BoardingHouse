using QuanLyPhongTro.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyPhongTro.DTO;

namespace QuanLyPhongTro.BLL
{
    internal class BLL_Bill
    {
        DAL_Bill dalbill = new DAL_Bill();
        public List<Bill> getListBill()
        {
            return dalbill.GetListBill();
        }
        public bool ExistBill(string id)
        {
            return dalbill.ExistBill(id);
        }

        public bool AddBill(Bill bill)
        {
            return dalbill.AddBill(bill);
        }

    }
}
