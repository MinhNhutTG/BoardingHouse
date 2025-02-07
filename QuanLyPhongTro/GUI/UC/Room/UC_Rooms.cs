using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyPhongTro.BLL;
using QuanLyPhongTro.DTO;

namespace QuanLyPhongTro.GUI.UC.Room
{
    
    public partial class UC_Rooms : UserControl
    {
        BLL_Rooms bll = new BLL_Rooms();
        public UC_Rooms()
        {
            InitializeComponent();
            LoadRooms();
        }
        private void LoadRooms()
        {
           List<DTO.Room> listroom = bll.getlistRoom();
            foreach (DTO.Room room in listroom) { 
                UC_Room uc = new UC_Room(room.SoPhong,room.TrangThai);
                uc.RoomClicked += this.LoadUCRoomDetail;
                layoutRooms.Controls.Add(uc);
            }
        }
        public void LoadUCRoomDetail(object sender, int id)
        {
            panelDetail.Controls.Clear();
            UserControl uc = new UC_RoomDetail(id);
            panelDetail.Controls.Add(uc);
        }
    }
}
