using QuanLyPhongTro.GUI.UC.Report.Chart;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongTro.GUI.UC.Report
{
    public partial class UC_ReportService : UserControl
    {
        public UC_ReportService()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            ChartDoanhThu chart = new ChartDoanhThu("TongDienNuocTieuThu");
            PanelBg.Controls.Clear();
            PanelBg.Controls.Add(chart);
         
        }
    }
}
