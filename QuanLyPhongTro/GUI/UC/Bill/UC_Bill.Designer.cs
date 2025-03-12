using System.Drawing;
using System.Windows.Forms;

namespace QuanLyPhongTro.GUI.UC.Bill
{
    partial class UC_Bill
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lsvHoaDon = new System.Windows.Forms.ListView();
            this.IDHoaDon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SoPhong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NgayLapHoaDon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SoDien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SoNuoc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TienDien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TienNuoc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TongTien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TrangThai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.btnAddBillAuto = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.s = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnAddBill = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.IdDichVu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PhiKhac = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GhiChu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lsvHoaDon
            // 
            this.lsvHoaDon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IDHoaDon,
            this.IdDichVu,
            this.SoPhong,
            this.SoDien,
            this.TienDien,
            this.SoNuoc,
            this.TienNuoc,
            this.PhiKhac,
            this.TongTien,
            this.TrangThai,
            this.NgayLapHoaDon,
            this.GhiChu});
            this.lsvHoaDon.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lsvHoaDon.FullRowSelect = true;
            this.lsvHoaDon.GridLines = true;
            this.lsvHoaDon.HideSelection = false;
            this.lsvHoaDon.Location = new System.Drawing.Point(28, 180);
            this.lsvHoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lsvHoaDon.Name = "lsvHoaDon";
            this.lsvHoaDon.Size = new System.Drawing.Size(1375, 644);
            this.lsvHoaDon.SmallImageList = this.imageList;
            this.lsvHoaDon.TabIndex = 0;
            this.lsvHoaDon.UseCompatibleStateImageBehavior = false;
            this.lsvHoaDon.View = System.Windows.Forms.View.Details;
            // 
            // IDHoaDon
            // 
            this.IDHoaDon.Text = "Mã hóa đơn";
            this.IDHoaDon.Width = 100;
            // 
            // SoPhong
            // 
            this.SoPhong.Text = "Số phòng";
            this.SoPhong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SoPhong.Width = 80;
            // 
            // NgayLapHoaDon
            // 
            this.NgayLapHoaDon.Text = "Ngày lập hóa đơn";
            this.NgayLapHoaDon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NgayLapHoaDon.Width = 140;
            // 
            // SoDien
            // 
            this.SoDien.Text = "Số điện";
            this.SoDien.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SoDien.Width = 70;
            // 
            // SoNuoc
            // 
            this.SoNuoc.Text = "Số nước";
            this.SoNuoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SoNuoc.Width = 70;
            // 
            // TienDien
            // 
            this.TienDien.DisplayIndex = 5;
            this.TienDien.Text = "Tiền điện";
            this.TienDien.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TienDien.Width = 100;
            // 
            // TienNuoc
            // 
            this.TienNuoc.DisplayIndex = 7;
            this.TienNuoc.Text = "Tiền nước";
            this.TienNuoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TienNuoc.Width = 100;
            // 
            // TongTien
            // 
            this.TongTien.Text = "Tổng tiền";
            this.TongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TongTien.Width = 140;
            // 
            // TrangThai
            // 
            this.TrangThai.Text = "Trạng Thái";
            this.TrangThai.Width = 100;
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList.ImageSize = new System.Drawing.Size(1, 30);
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btnAddBillAuto
            // 
            this.btnAddBillAuto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(135)))), ((int)(((byte)(84)))));
            this.btnAddBillAuto.FlatAppearance.BorderSize = 0;
            this.btnAddBillAuto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBillAuto.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAddBillAuto.ForeColor = System.Drawing.Color.White;
            this.btnAddBillAuto.Location = new System.Drawing.Point(1420, 180);
            this.btnAddBillAuto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddBillAuto.Name = "btnAddBillAuto";
            this.btnAddBillAuto.Size = new System.Drawing.Size(187, 46);
            this.btnAddBillAuto.TabIndex = 2;
            this.btnAddBillAuto.Text = "Tạo HD tự động";
            this.btnAddBillAuto.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(1420, 331);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(187, 46);
            this.button3.TabIndex = 3;
            this.button3.Text = "Xóa hóa đơn";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // s
            // 
            this.s.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.s.FlatAppearance.BorderSize = 0;
            this.s.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.s.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.s.ForeColor = System.Drawing.Color.White;
            this.s.Location = new System.Drawing.Point(1420, 281);
            this.s.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.s.Name = "s";
            this.s.Size = new System.Drawing.Size(187, 46);
            this.s.TabIndex = 4;
            this.s.Text = "Chỉnh sửa";
            this.s.UseVisualStyleBackColor = false;
            this.s.Click += new System.EventHandler(this.btnAddBill_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(1420, 382);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(187, 46);
            this.button5.TabIndex = 5;
            this.button5.Text = "Xem chi tiết";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // btnAddBill
            // 
            this.btnAddBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(135)))), ((int)(((byte)(84)))));
            this.btnAddBill.FlatAppearance.BorderSize = 0;
            this.btnAddBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBill.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAddBill.ForeColor = System.Drawing.Color.White;
            this.btnAddBill.Location = new System.Drawing.Point(1420, 230);
            this.btnAddBill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddBill.Name = "btnAddBill";
            this.btnAddBill.Size = new System.Drawing.Size(187, 46);
            this.btnAddBill.TabIndex = 6;
            this.btnAddBill.Text = "Tạo hóa đơn";
            this.btnAddBill.UseVisualStyleBackColor = false;
            this.btnAddBill.Click += new System.EventHandler(this.btnAddBill_Click_1);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(185)))), ((int)(((byte)(150)))));
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(1299, 111);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(105, 36);
            this.button7.TabIndex = 9;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSearch.Location = new System.Drawing.Point(881, 111);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(411, 35);
            this.txtSearch.TabIndex = 8;
            // 
            // IdDichVu
            // 
            this.IdDichVu.Text = "Mã dịch vụ";
            this.IdDichVu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.IdDichVu.Width = 100;
            // 
            // PhiKhac
            // 
            this.PhiKhac.Text = "Phí Khác";
            this.PhiKhac.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PhiKhac.Width = 100;
            // 
            // GhiChu
            // 
            this.GhiChu.Text = "Ghi chú";
            this.GhiChu.Width = 200;
            // 
            // UC_Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button7);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnAddBill);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.s);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnAddBillAuto);
            this.Controls.Add(this.lsvHoaDon);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UC_Bill";
            this.Size = new System.Drawing.Size(1641, 876);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lsvHoaDon;
        private System.Windows.Forms.Button btnAddBillAuto;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button s;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnAddBill;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ColumnHeader IDHoaDon;
        private System.Windows.Forms.ColumnHeader SoPhong;
        private System.Windows.Forms.ColumnHeader SoDien;
        private System.Windows.Forms.ColumnHeader SoNuoc;
        private System.Windows.Forms.ColumnHeader TongTien;
        private System.Windows.Forms.ColumnHeader TienDien;
        private System.Windows.Forms.ColumnHeader TienNuoc;
        private System.Windows.Forms.ColumnHeader TrangThai;
        private System.Windows.Forms.ColumnHeader NgayLapHoaDon;
        private ImageList imageList;
        private ColumnHeader IdDichVu;
        private ColumnHeader PhiKhac;
        private ColumnHeader GhiChu;
    }
}
