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
    }
}
