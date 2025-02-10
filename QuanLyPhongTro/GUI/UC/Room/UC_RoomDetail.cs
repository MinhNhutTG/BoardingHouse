using QuanLyPhongTro.BLL;
using QuanLyPhongTro.Handle;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyPhongTro.DTO;
using System.Globalization;

namespace QuanLyPhongTro.GUI.UC.Room
{
    public partial class UC_RoomDetail : UserControl
    {
        BLL_Rooms bllroom = new BLL_Rooms();
        BLL_Contract bllContract = new BLL_Contract();
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
            DTO.Contract ctr = bllContract.FindContractByID(id);

            lblID.Text = room.SoPhong;
            lblRoomStatus.Text = room.TrangThai;
            lblTypeRoom.Text = room.TenLoai;
            lblNote.Text = room.GhiChu;
            lblNumElectric.Text = room.SoDien.ToString();
            lblNumWater.Text = room.SoNuoc.ToString();

            lblPrice.Text = string.Format("{0:n0}", ctr.GiaPhong) + " VND";
            lblGuest1.Text = ctr.TenKhach1;
            lblGuest2.Text = ctr.TenKhach2;
            lblIDContract.Text = ctr.Id;

        }
        private void UC_RoomDetail_Load(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
