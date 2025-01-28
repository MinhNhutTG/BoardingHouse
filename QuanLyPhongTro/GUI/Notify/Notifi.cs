using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongTro.GUI.Notify
{
    public partial class Notifi : Form
    {
        public  enum typeNotify { success, warning, error };
        public Notifi()
        {
            InitializeComponent();
        }
        
        public Notifi(int time)
        {
            InitializeComponent();
            Timer timer = new Timer();
            timer.Interval = time;
            
            timer.Tick += (s, e) =>
            {
                timer.Stop();
                this.Close();
            };
            timer.Start();
        }
        public Color getColor(typeNotify type)
        {
            if (type == typeNotify.success)
            {
                return ColorTranslator.FromHtml("#33CC33");
            }
            if (type == typeNotify.warning) {
                return ColorTranslator.FromHtml("#FF9900"); 
            }
            if (type == typeNotify.error)
            {
                return ColorTranslator.FromHtml("#FF3300");
            }
            return Color.White;
        }
        public Image getIcon(typeNotify type)
        {
            if (type == typeNotify.success)
            {
                return Properties.Resources.success;
            }
            if (type == typeNotify.warning)
            {
                return Properties.Resources.warning;
            }
            if (type == typeNotify.error)
            {
                return Properties.Resources.error;
            }
            return Properties.Resources.warning;
        }
        public Point getPointStart()
        {
            Form parents = Form.ActiveForm;
            Point p = new Point(0, 0);
            if (parents != null)
            {
                p.X = parents.Location.X;
                p.Y = parents.Location.Y;
            }
            return p;
        }
        public static void Show(string content , typeNotify type )
        {
            Notifi frm = new Notifi(1200);
            frm.BackColor = frm.getColor(type);
            frm.lblContent.Text = content;
            frm.iconNotifi.Image = frm.getIcon(type);
            frm.Location = frm.getPointStart();
          
            frm.ShowDialog();
            
        }
    }
}
