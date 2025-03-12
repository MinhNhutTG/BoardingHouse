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
using QuanLyPhongTro.GUI;

namespace QuanLyPhongTro.GUI.UC.Bill
{
    public partial class UC_Bill : UserControl
    {
        BLL_Bill bllBill = new BLL_Bill();  

        public UC_Bill()
        {
            InitializeComponent();
            Loadbills(bllBill.getListBill());
        }
        public void Loadbills(List<DTO.Bill> list)
        {
            lsvHoaDon.Items.Clear();
            foreach (DTO.Bill bill in list) { 
                ListViewItem lvi = new ListViewItem(bill.IdHoaDon);
                lvi.SubItems.Add(bill.IdDichVu.ToString());
                lvi.SubItems.Add(bill.SoPhong);
                lvi.SubItems.Add(bill.SoDien.ToString());
                lvi.SubItems.Add(bill.TienDien.ToString());
                lvi.SubItems.Add(bill.SoNuoc.ToString());
                lvi.SubItems.Add(bill.TienNuoc.ToString());
                lvi.SubItems.Add(bill.PhiKhac.ToString());
                lvi.SubItems.Add(bill.TongTien.ToString() + " VND");
                lvi.SubItems.Add(bill.TrangThai);
                lvi.SubItems.Add(bill.NgayLapHoaDon.ToShortDateString());
                lvi.SubItems.Add(bill.GhiChu);
                lsvHoaDon.Items.Add(lvi);
            }
        }

        private void btnAddBill_Click(object sender, EventArgs e)
        {
             
        }

        private void btnAddBill_Click_1(object sender, EventArgs e)
        {
            Forms.Bill frm = new Forms.Bill();
            frm.ShowDialog();
        }
    }
}
