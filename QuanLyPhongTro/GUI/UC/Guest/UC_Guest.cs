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
using QuanLyPhongTro.DTO;

namespace QuanLyPhongTro.GUI.UC.Guest
{
    public partial class UC_Guest : UserControl
    {
        BLL_Guest bll = new BLL_Guest();
        public UC_Guest()
        {
            InitializeComponent();
            cbbStatus.SelectedIndex = 0;
            LoadGuests();
        }
        public void LoadGuests()
        {
            List<DTO.Guest> guests = bll.getListGuest();    
            lsvGuest.Items.Clear();
            foreach(DTO.Guest g in guests)
            {
                ListViewItem lvi = new ListViewItem(g.MaKhach);
                lvi.SubItems.Add(g.HoTen);
                lvi.SubItems.Add(g.NgaySinh.ToShortDateString());
                lvi.SubItems.Add(g.CCCD);
                lvi.SubItems.Add(g.SoDienThoai);
                lvi.SubItems.Add(g.QueQuan);
                lvi.SubItems.Add(g.TrangThai);
                lsvGuest.Items.Add(lvi);
            }
        }
      
    }
}
