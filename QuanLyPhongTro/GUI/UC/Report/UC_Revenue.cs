using QuanLyPhongTro.BLL;
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
using System.Windows.Forms.DataVisualization.Charting;

namespace QuanLyPhongTro.GUI.UC.Service
{
    public partial class UC_Revenue : UserControl
    {
        BLL_Rooms bllroom = new BLL_Rooms();
        public UC_Revenue()
        {
            InitializeComponent();
            LoadYearComboBox();
            LoadComboBoxRoom();
        }
        private void LoadComboBoxRoom()
        {
            List<DTO.Room> list = bllroom.getlistRoom();
           
            foreach (DTO.Room room in list) { 
                cbbRooms.Items.Add(room.SoPhong);
            }
            cbbRooms.SelectedIndex = -1;
        }
        private void LoadYearComboBox()
        {
            DateTime dt = DateTime.Now;
            int currentYear = dt.Year;
            for (int i = currentYear; i > 2018; i--) { 
                cbbYear.Items.Add(i.ToString());
            }
            cbbYear.SelectedIndex = 0;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbDoanhThuThang.Checked) {
                
                ChartDoanhThu chart = new ChartDoanhThu("thang", Convert.ToInt32(cbbYear.SelectedItem));
                PanelBg.Controls.Clear();
                PanelBg.Controls.Add(chart);
            }
        }

        private void cbbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rdbDoanhThuThang.Checked)
            {
                ChartDoanhThu chart = new ChartDoanhThu("thang", Convert.ToInt32(cbbYear.SelectedItem));
                PanelBg.Controls.Clear();
                PanelBg.Controls.Add(chart);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (rbdDoanhThuQuy.Checked)
            {
                ChartDoanhThu chart = new ChartDoanhThu("quy", Convert.ToInt32(cbbYear.SelectedItem));
                PanelBg.Controls.Clear();
                PanelBg.Controls.Add(chart);
            }
        }

        private void rdbRooms_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbRooms.Checked)
            {
                ChartDoanhThu chart = new ChartDoanhThu("doanhthutatcaphong");
                PanelBg.Controls.Clear();
                PanelBg.Controls.Add(chart);
            }
        }

        private void cbbRooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            rdbRooms.Checked = false;
            ChartDoanhThu chart = new ChartDoanhThu("doanhthuphong",cbbRooms.SelectedItem.ToString());
            PanelBg.Controls.Clear();
            PanelBg.Controls.Add(chart);
        }
    }
}
