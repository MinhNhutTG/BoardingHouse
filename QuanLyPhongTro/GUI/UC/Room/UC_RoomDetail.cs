using QuanLyPhongTro.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongTro.GUI.UC.Room
{
    public partial class UC_RoomDetail : UserControl
    {
        BLL_Rooms bllroom = new BLL_Rooms();
        public UC_RoomDetail()
        {
            InitializeComponent();
        }
        public UC_RoomDetail(int id)
        {
            InitializeComponent();
            LoadRoomDetail(id);
        }
        public void LoadRoomDetail(int id)
        {
            DTO.Room room = bllroom.FindRoomByID(id);
            lblID.Text = room.SoPhong;
            lblRoomStatus.Text = room.TrangThai;
            lblTypeRoom.Text = room.TenLoai;
            lblPrice.Text = room.Gia.ToString() +  " VND";
            lblNote.Text = room.GhiChu;
            lblNumElectric.Text = room.SoDien.ToString();
            lblNumWater.Text = room.SoNuoc.ToString();
        }
        private void UC_RoomDetail_Load(object sender, EventArgs e)
        {

        }
    }
}
