using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyPhongTro.DTO;
using QuanLyPhongTro.DAL;

namespace QuanLyPhongTro.BLL
{
    internal class BLL_Rooms
    {
        DAL_Rooms dalroom = new DAL_Rooms();
        public List<Room> getlistRoom()
        {
            return dalroom.getListRoom();
        }
        public Room FindRoomByID(int id)
        {
            return dalroom.FindRoomByID(id);
        }
    }
}
