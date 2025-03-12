using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyPhongTro.GUI.Notify;
using QuanLyPhongTro.GUI.UC.Config;
using QuanLyPhongTro.GUI.UC.Guest;
using QuanLyPhongTro.GUI.UC.Room;
using QuanLyPhongTro.GUI.UC.Bill;
using QuanLyPhongTro.GUI.UC.Service;


namespace QuanLyPhongTro.GUI.Forms
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult dg = Notify.Message.Show("Bạn có muốn đóng ứng dụng?");
            if (dg == DialogResult.Yes) {
                Application.Exit();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dg =  Notify.Message.Show("Bạn có muốn thoát ứng dụng?");
            if (dg == DialogResult.Yes) { 
                Application.Exit();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            UC_Config uc = new UC_Config();
            PanelMain.Controls.Clear();
            PanelMain.Controls.Add(uc);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UC_Rooms uc = new UC_Rooms();  
            PanelMain.Controls.Clear();
            PanelMain.Controls.Add(uc);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UC_Guest uc = new UC_Guest();
            PanelMain.Controls.Clear();
            PanelMain.Controls.Add(uc);
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            UC_Bill uc = new UC_Bill();
            PanelMain.Controls.Clear();
            PanelMain.Controls.Add(uc);
        }

        private void btnService_Click(object sender, EventArgs e)
        {
           UC_Service uc = new UC_Service();
            PanelMain.Controls.Clear();
            PanelMain.Dock = uc.Dock;
            PanelMain.Controls.Add(uc);
        }
    }
}
