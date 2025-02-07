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
    public partial class UC_Room : UserControl
    {
        public event EventHandler<int> RoomClicked;
        public UC_Room()
        {
            InitializeComponent();
        }
        public UC_Room(string id , string status)
        {
            InitializeComponent();
            lblID.Text = id;
            lblStatus.Text = status;
        }

        private void UC_Room_Click(object sender, EventArgs e)
        {
           
        }

        private void background_Click(object sender, EventArgs e)
        {
            
        }

        private void lblID_Click(object sender, EventArgs e)
        {
            
            RoomClicked?.Invoke(this,Convert.ToInt32(lblID.Text));
        }
    }
}
