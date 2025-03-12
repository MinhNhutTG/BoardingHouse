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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongTro.GUI.Forms
{
    public partial class Bill : Form
    {
        BLL_Bill bllbill = new BLL_Bill();
        BLL_HistoryService bllhistoryService = new BLL_HistoryService();
        BLL_Rooms bllrooom = new BLL_Rooms();
        decimal totalPrice = 0;
        public int currentIndexRoom = -1;
        public Bill()
        {
            InitializeComponent();
            panelDetail.Visible = false;
            btnSave.Location = new Point(490, 470);
            changeID();
        }
        private void ChangeRoom()
        {
            BLL_Rooms bllroom = new BLL_Rooms();
            List<string> listIDRoom = bllroom.GetListIDRoom();
            if (currentIndexRoom < 0)
            {
                currentIndexRoom = 0;
            }
            else if (currentIndexRoom > listIDRoom.Count)
            {
                currentIndexRoom = listIDRoom.Count - 1;
            }
            if (currentIndexRoom >= 0 && currentIndexRoom <= listIDRoom.Count - 1)
            {
                txtMaPhong.Text = listIDRoom[currentIndexRoom];
            }
        }        // Đổi số phòng textbox số phòng
        private void btnCloses_Click(object sender, EventArgs e)
        {
            DialogResult dg = Notify.Message.Show("Bạn có muốn thoát không ?");
            if (dg == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Bill_Load(object sender, EventArgs e)
        {

        }

        private void lblViewDetail_Click(object sender, EventArgs e)
        {
            panelDetail.Visible = !panelDetail.Visible;
            if (!panelDetail.Visible) {
                btnSave.Location = new Point(490, 470);
            }
            else
            {
                btnSave.Location = new Point(490, 600); 
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private string randomID()
        {
            DateTime dt = DateTime.Now;
            string id = "HD";
            id += dt.Day.ToString() + dt.Month.ToString();
            id += txtMaPhong.Text;
            return id;

        } // Tạo id 
        private void changeID()
        {
            string id = "";
            do
            {
                id = randomID();
            }
            while (bllbill.ExistBill(id.ToString()));

            txtMaHoaDon.Text = id.ToString();
        }
        private void btnChangeId_Click(object sender, EventArgs e)
        {
            changeID();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            currentIndexRoom -= 1;
            ChangeRoom();
            changeID();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            currentIndexRoom += 1;
            ChangeRoom();
            changeID();
        }

        private void txtMaPhong_TextChanged(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            string Ki = (now.Month -1 ).ToString() + "-" + now.Year.ToString();
            txtMaDichVu.Text = bllhistoryService.FindIDByKi(txtMaPhong.Text , Ki);
            totalPrice = 0;
            CaculatorBill();
            CaculatorTotalPrice();
        }
        private void CaculatorTotalPrice()
        {
            if (txtTienPhong.Text != null)
            {
                totalPrice += Convert.ToDecimal(txtTienPhong.Text);
            }
            if (txtTienDien.Text != null)
            {
                totalPrice += Convert.ToDecimal(txtTienDien.Text);
            }
            if (txtTienNuoc.Text != null)
            {
                totalPrice += Convert.ToDecimal(txtTienNuoc.Text);
            }
            if (txtPhiKhac.Text != null)
            {
                totalPrice += Convert.ToDecimal(txtPhiKhac.Text);
            }
            if (txtTienMang.Text != null)
            {
                totalPrice += Convert.ToDecimal(txtTienMang.Text);
            }

            txtTongTien.Text = string.Format("{0:n0}",totalPrice);
        }
        public void CaculatorBill()
        {
            HistoryService hs = bllhistoryService.getHistoryServiceByID(Convert.ToInt32(txtMaDichVu.Text));
            decimal giaPhong = bllrooom.GetPriceRoomByID(txtMaPhong.Text);
            int soNuoc = hs.SoNuocMoi - hs.SoNuocCu;
            int soDien = hs.SoDienMoi - hs.SoDienCu;



            txtSoDien.Text = soDien.ToString();
            txtSoNuoc.Text = soNuoc.ToString();
            txtTienDien.Text =  string.Format("{0:n0}", hs.GiaDien * soDien);
            txtTienNuoc.Text =  string.Format("{0:n0}", hs.GiaNuoc * soNuoc);
            txtTienPhong.Text =  string.Format("{0:n0}", giaPhong);
            txtTienMang.Text = string.Format("{0:n0}", hs.TienMang);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (!bllbill.ExistBill(txtMaHoaDon.Text))
            {
                if (bllbill.AddBill(GetBillInput()))
                {
                    Notifi.Show("Tạo hóa đơn thành công", Notifi.typeNotify.success);
                }
                else
                {
                    Notifi.Show("Tạo hóa đơn không thành công", Notifi.typeNotify.error);
                }

            }
        }
        public DTO.Bill GetBillInput()
        {
            DTO.Bill bill = new DTO.Bill();
            bill.IdHoaDon = txtMaHoaDon.Text;
            bill.IdDichVu = Convert.ToInt32(txtMaDichVu.Text);
            bill.SoPhong = txtMaPhong.Text;
            bill.SoDien = Convert.ToDecimal(txtSoDien.Text);
            bill.TienDien = Convert.ToDecimal(txtTienDien.Text);
            bill.SoNuoc = Convert.ToDecimal(txtSoNuoc.Text);
            bill.TienNuoc = Convert.ToDecimal(txtTienNuoc.Text);
            bill.PhiKhac = Convert.ToDecimal(txtPhiKhac.Text);
            bill.TongTien = Convert.ToDecimal(txtTongTien.Text);
            bill.NgayLapHoaDon = Convert.ToDateTime(dtpNgayLap.Text);
            bill.TrangThai = cbBTrangThai.SelectedItem.ToString();
            bill.GhiChu = rtbGhiChu.Text;
            return bill;

        }
      
    }
    
}
