using QuanLyPhongTro.BLL;
using QuanLyPhongTro.DTO;
using QuanLyPhongTro.GUI.Notify;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongTro.GUI.Forms
{
    public partial class BillDetail : Form
    {
        BLL_Bill bllbill = new BLL_Bill();
        BLL_HistoryService bllhistoryService = new BLL_HistoryService();
        public BillDetail(string id)
        {
            InitializeComponent();
            ShowDetail(id);
            
        }
        
        private void ShowDetail(string id) {
            DTO.Bill bill = bllbill.FindBillByID(id);
            ShowHistoryService(bill.IdDichVu ?? 0);
            lblMaHoaDon.Text = bill.IdHoaDon;
            lblMaDichVu.Text = bill.IdDichVu.ToString();
            lblSoPhong.Text = bill.SoPhong.ToString();
            lblSoDien.Text = string.Format("{0:n0}",bill.SoDien);
            lblSoNuoc.Text = string.Format("{0:n0}",bill.SoNuoc);
            lblTrangThaiHD.Text = string.Format("{0:n0}", bill.TrangThai);
            lblNgayLap.Text = bill.NgayLapHoaDon.ToString();
            lblTienPhong.Text = string.Format("{0:n0}", bill.GiaPhong);
            lblTienDien.Text = string.Format("{0:n0}", bill.TienDien);
            lblTienNuoc.Text = string.Format("{0:n0}", bill.TienNuoc);
            lblTienKhac.Text = string.Format("{0:n0}", bill.PhiKhac);
            lblTongTien.Text = string.Format("{0:n0}", bill.TongTien) + "VND"; 
            rtbGhiChu.Text = bill.GhiChu;
        }
        private void ShowHistoryService(int mals)
        {
            DTO.HistoryService hs = bllhistoryService.getHistoryServiceByID(mals);
            lblTienMang.Text = hs.TienMang.ToString();
            lblSoNuocCu.Text = hs.SoNuocCu.ToString();
            lblSoNuocMoi.Text = hs.SoNuocMoi.ToString();
            lblGiaNuoc.Text = hs.GiaNuoc.ToString();
            lblSoDienCu.Text = hs.SoDienCu.ToString();
            lblSoDienMoi.Text = hs.SoDienMoi.ToString();
            lblGiaDien.Text = hs.GiaDien.ToString();
        }

        private void lblTrangThaiHD_TextChanged(object sender, EventArgs e)
        {
            if (lblTrangThaiHD.Text == "Đã thanh toán")
            {
                lblTrangThaiHD.BackColor = ColorTranslator.FromHtml("25, 135, 84");
                lblTrangThaiHD.ForeColor = Color.White;
            }
            else if (lblTrangThaiHD.Text == "Chưa thanh toán")
            {
                lblTrangThaiHD.BackColor = Color.Red;
                lblTrangThaiHD.ForeColor = Color.White;
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }
    }
    
}
