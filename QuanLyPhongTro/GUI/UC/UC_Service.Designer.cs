using System.Drawing;
using System.Windows.Forms;

namespace QuanLyPhongTro.GUI.UC.Service
{
    partial class UC_Service
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
            this.lsvService = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SoPhong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ki = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SoDienCu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SoDienMoi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SoNuocCu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SoNuocMoi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GiaDien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GiaNuoc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NgayTao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TienMang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TrangThai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imaglist = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbbStatus = new System.Windows.Forms.ComboBox();
            this.txtTienMang = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNgayTao = new System.Windows.Forms.DateTimePicker();
            this.btnChangeId = new System.Windows.Forms.PictureBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRoomID = new System.Windows.Forms.TextBox();
            this.txtGiaNuoc = new System.Windows.Forms.TextBox();
            this.txtGiaDien = new System.Windows.Forms.TextBox();
            this.txtKi = new System.Windows.Forms.TextBox();
            this.txtNuocMoi = new System.Windows.Forms.TextBox();
            this.txtSoNuocCu = new System.Windows.Forms.TextBox();
            this.txtDienMoi = new System.Windows.Forms.TextBox();
            this.txtSoDienCu = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbSortKiASC = new System.Windows.Forms.RadioButton();
            this.rdbSortKiDesc = new System.Windows.Forms.RadioButton();
            this.btnPriceService = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbbFillStatus = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnChangeId)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lsvService
            // 
            this.lsvService.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lsvService.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.SoPhong,
            this.Ki,
            this.SoDienCu,
            this.SoDienMoi,
            this.SoNuocCu,
            this.SoNuocMoi,
            this.GiaDien,
            this.GiaNuoc,
            this.NgayTao,
            this.TienMang,
            this.TrangThai});
            this.lsvService.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lsvService.FullRowSelect = true;
            this.lsvService.GridLines = true;
            this.lsvService.HideSelection = false;
            this.lsvService.Location = new System.Drawing.Point(11, 354);
            this.lsvService.Margin = new System.Windows.Forms.Padding(2);
            this.lsvService.Name = "lsvService";
            this.lsvService.Size = new System.Drawing.Size(1128, 357);
            this.lsvService.SmallImageList = this.imaglist;
            this.lsvService.TabIndex = 0;
            this.lsvService.UseCompatibleStateImageBehavior = false;
            this.lsvService.View = System.Windows.Forms.View.Details;
            this.lsvService.SelectedIndexChanged += new System.EventHandler(this.lsvService_SelectedIndexChanged_1);
            // 
            // ID
            // 
            this.ID.Text = "Mã Dịch Vụ";
            this.ID.Width = 100;
            // 
            // SoPhong
            // 
            this.SoPhong.Text = "Số Phòng";
            this.SoPhong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Ki
            // 
            this.Ki.Text = "Kì";
            this.Ki.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Ki.Width = 90;
            // 
            // SoDienCu
            // 
            this.SoDienCu.Text = "Số điện cũ";
            this.SoDienCu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SoDienCu.Width = 100;
            // 
            // SoDienMoi
            // 
            this.SoDienMoi.Text = "Số điện mới";
            this.SoDienMoi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SoDienMoi.Width = 100;
            // 
            // SoNuocCu
            // 
            this.SoNuocCu.Text = "Số nước cũ";
            this.SoNuocCu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SoNuocCu.Width = 100;
            // 
            // SoNuocMoi
            // 
            this.SoNuocMoi.Text = "Số nước mới";
            this.SoNuocMoi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SoNuocMoi.Width = 100;
            // 
            // GiaDien
            // 
            this.GiaDien.Text = "Giá điện";
            this.GiaDien.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.GiaDien.Width = 100;
            // 
            // GiaNuoc
            // 
            this.GiaNuoc.Text = "Giá nước";
            this.GiaNuoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.GiaNuoc.Width = 100;
            // 
            // NgayTao
            // 
            this.NgayTao.DisplayIndex = 11;
            this.NgayTao.Text = "Ngày tạo";
            this.NgayTao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NgayTao.Width = 150;
            // 
            // TienMang
            // 
            this.TienMang.Text = "Tiền mạng";
            this.TienMang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TienMang.Width = 100;
            // 
            // TrangThai
            // 
            this.TrangThai.DisplayIndex = 9;
            this.TrangThai.Text = "Trạng Thái";
            this.TrangThai.Width = 100;
            // 
            // imaglist
            // 
            this.imaglist.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imaglist.ImageSize = new System.Drawing.Size(1, 30);
            this.imaglist.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.cbbStatus);
            this.groupBox1.Controls.Add(this.txtTienMang);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtNgayTao);
            this.groupBox1.Controls.Add(this.btnChangeId);
            this.groupBox1.Controls.Add(this.btnNext);
            this.groupBox1.Controls.Add(this.btnPrevious);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtRoomID);
            this.groupBox1.Controls.Add(this.txtGiaNuoc);
            this.groupBox1.Controls.Add(this.txtGiaDien);
            this.groupBox1.Controls.Add(this.txtKi);
            this.groupBox1.Controls.Add(this.txtNuocMoi);
            this.groupBox1.Controls.Add(this.txtSoNuocCu);
            this.groupBox1.Controls.Add(this.txtDienMoi);
            this.groupBox1.Controls.Add(this.txtSoDienCu);
            this.groupBox1.Controls.Add(this.lblID);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(11, 95);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(1128, 240);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cập nhật dịch vụ cho phòng";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label12.Location = new System.Drawing.Point(626, 197);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 19);
            this.label12.TabIndex = 29;
            this.label12.Text = "Trạng thái :";
            // 
            // cbbStatus
            // 
            this.cbbStatus.FormattingEnabled = true;
            this.cbbStatus.Items.AddRange(new object[] {
            "Chờ Lập Hóa Đơn",
            "Đã Lập Hóa Đơn"});
            this.cbbStatus.Location = new System.Drawing.Point(716, 194);
            this.cbbStatus.Name = "cbbStatus";
            this.cbbStatus.Size = new System.Drawing.Size(152, 27);
            this.cbbStatus.TabIndex = 28;
            // 
            // txtTienMang
            // 
            this.txtTienMang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTienMang.Location = new System.Drawing.Point(154, 188);
            this.txtTienMang.Margin = new System.Windows.Forms.Padding(2);
            this.txtTienMang.Name = "txtTienMang";
            this.txtTienMang.Size = new System.Drawing.Size(157, 26);
            this.txtTienMang.TabIndex = 27;
            this.txtTienMang.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.Location = new System.Drawing.Point(64, 191);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 19);
            this.label11.TabIndex = 26;
            this.label11.Text = "Tiền mạng :";
            // 
            // txtNgayTao
            // 
            this.txtNgayTao.CustomFormat = "dd/MM/yyyy";
            this.txtNgayTao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtNgayTao.Location = new System.Drawing.Point(435, 191);
            this.txtNgayTao.Margin = new System.Windows.Forms.Padding(2);
            this.txtNgayTao.Name = "txtNgayTao";
            this.txtNgayTao.Size = new System.Drawing.Size(157, 26);
            this.txtNgayTao.TabIndex = 25;
            this.txtNgayTao.ValueChanged += new System.EventHandler(this.txtNgayTao_ValueChanged);
            // 
            // btnChangeId
            // 
            this.btnChangeId.Image = global::QuanLyPhongTro.Properties.Resources.reload;
            this.btnChangeId.Location = new System.Drawing.Point(291, 43);
            this.btnChangeId.Margin = new System.Windows.Forms.Padding(2);
            this.btnChangeId.Name = "btnChangeId";
            this.btnChangeId.Size = new System.Drawing.Size(18, 20);
            this.btnChangeId.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnChangeId.TabIndex = 24;
            this.btnChangeId.TabStop = false;
            this.btnChangeId.Click += new System.EventHandler(this.btnChangeId_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.DarkOrange;
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Image = global::QuanLyPhongTro.Properties.Resources.down_24px;
            this.btnNext.Location = new System.Drawing.Point(988, 182);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(122, 43);
            this.btnNext.TabIndex = 21;
            this.btnNext.Text = "Phòng dưới";
            this.btnNext.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.DarkOrange;
            this.btnPrevious.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrevious.FlatAppearance.BorderSize = 0;
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.ForeColor = System.Drawing.Color.White;
            this.btnPrevious.Image = global::QuanLyPhongTro.Properties.Resources.Up_24px;
            this.btnPrevious.Location = new System.Drawing.Point(988, 132);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(122, 43);
            this.btnPrevious.TabIndex = 20;
            this.btnPrevious.Text = "Phòng trên";
            this.btnPrevious.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(346, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số phòng :";
            // 
            // txtRoomID
            // 
            this.txtRoomID.Enabled = false;
            this.txtRoomID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtRoomID.Location = new System.Drawing.Point(435, 43);
            this.txtRoomID.Margin = new System.Windows.Forms.Padding(2);
            this.txtRoomID.Name = "txtRoomID";
            this.txtRoomID.Size = new System.Drawing.Size(125, 26);
            this.txtRoomID.TabIndex = 11;
            this.txtRoomID.Text = "0";
            this.txtRoomID.TextChanged += new System.EventHandler(this.txtRoomID_TextChanged);
            // 
            // txtGiaNuoc
            // 
            this.txtGiaNuoc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtGiaNuoc.Location = new System.Drawing.Point(716, 141);
            this.txtGiaNuoc.Margin = new System.Windows.Forms.Padding(2);
            this.txtGiaNuoc.Name = "txtGiaNuoc";
            this.txtGiaNuoc.Size = new System.Drawing.Size(157, 26);
            this.txtGiaNuoc.TabIndex = 18;
            // 
            // txtGiaDien
            // 
            this.txtGiaDien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtGiaDien.Location = new System.Drawing.Point(716, 87);
            this.txtGiaDien.Margin = new System.Windows.Forms.Padding(2);
            this.txtGiaDien.Name = "txtGiaDien";
            this.txtGiaDien.Size = new System.Drawing.Size(157, 26);
            this.txtGiaDien.TabIndex = 17;
            // 
            // txtKi
            // 
            this.txtKi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtKi.Location = new System.Drawing.Point(716, 43);
            this.txtKi.Margin = new System.Windows.Forms.Padding(2);
            this.txtKi.Name = "txtKi";
            this.txtKi.Size = new System.Drawing.Size(157, 26);
            this.txtKi.TabIndex = 16;
            // 
            // txtNuocMoi
            // 
            this.txtNuocMoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtNuocMoi.Location = new System.Drawing.Point(435, 141);
            this.txtNuocMoi.Margin = new System.Windows.Forms.Padding(2);
            this.txtNuocMoi.Name = "txtNuocMoi";
            this.txtNuocMoi.Size = new System.Drawing.Size(157, 26);
            this.txtNuocMoi.TabIndex = 15;
            this.txtNuocMoi.Text = "0";
            // 
            // txtSoNuocCu
            // 
            this.txtSoNuocCu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSoNuocCu.Location = new System.Drawing.Point(153, 141);
            this.txtSoNuocCu.Margin = new System.Windows.Forms.Padding(2);
            this.txtSoNuocCu.Name = "txtSoNuocCu";
            this.txtSoNuocCu.Size = new System.Drawing.Size(157, 26);
            this.txtSoNuocCu.TabIndex = 14;
            this.txtSoNuocCu.Text = "0";
            // 
            // txtDienMoi
            // 
            this.txtDienMoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtDienMoi.Location = new System.Drawing.Point(435, 87);
            this.txtDienMoi.Margin = new System.Windows.Forms.Padding(2);
            this.txtDienMoi.Name = "txtDienMoi";
            this.txtDienMoi.Size = new System.Drawing.Size(157, 26);
            this.txtDienMoi.TabIndex = 13;
            this.txtDienMoi.Text = "0";
            // 
            // txtSoDienCu
            // 
            this.txtSoDienCu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSoDienCu.Location = new System.Drawing.Point(153, 84);
            this.txtSoDienCu.Margin = new System.Windows.Forms.Padding(2);
            this.txtSoDienCu.Name = "txtSoDienCu";
            this.txtSoDienCu.Size = new System.Drawing.Size(157, 26);
            this.txtSoDienCu.TabIndex = 12;
            this.txtSoDienCu.Text = "0";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblID.ForeColor = System.Drawing.Color.Red;
            this.lblID.Location = new System.Drawing.Point(196, 45);
            this.lblID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(39, 19);
            this.lblID.TabIndex = 10;
            this.lblID.Text = "DV1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.Location = new System.Drawing.Point(352, 191);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 19);
            this.label10.TabIndex = 9;
            this.label10.Text = "Ngày tạo :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(626, 148);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 19);
            this.label9.TabIndex = 8;
            this.label9.Text = "Giá nước :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(627, 93);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 19);
            this.label8.TabIndex = 7;
            this.label8.Text = "Giá điện :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(346, 144);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "Số nước mới :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(64, 147);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Số nước cũ :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(346, 90);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 19);
            this.label6.TabIndex = 4;
            this.label6.Text = "Số điện mới :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(64, 87);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Số điện cũ :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(628, 50);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Kỳ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(62, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sử dụng dịch vụ :";
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnReload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReload.FlatAppearance.BorderSize = 0;
            this.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReload.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnReload.ForeColor = System.Drawing.Color.White;
            this.btnReload.Location = new System.Drawing.Point(825, 48);
            this.btnReload.Margin = new System.Windows.Forms.Padding(2);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(122, 43);
            this.btnReload.TabIndex = 23;
            this.btnReload.Text = "Làm mới";
            this.btnReload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(135)))), ((int)(((byte)(84)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(426, 48);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(122, 43);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Text = "Thêm mới";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(558, 48);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(122, 43);
            this.btnUpdate.TabIndex = 24;
            this.btnUpdate.Text = "Chỉnh sửa";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Location = new System.Drawing.Point(692, 48);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(122, 43);
            this.btnRemove.TabIndex = 25;
            this.btnRemove.Text = "Xóa";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbSortKiASC);
            this.groupBox2.Controls.Add(this.rdbSortKiDesc);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(11, 19);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(141, 72);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sắp xếp";
            // 
            // rdbSortKiASC
            // 
            this.rdbSortKiASC.AutoSize = true;
            this.rdbSortKiASC.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdbSortKiASC.Location = new System.Drawing.Point(16, 45);
            this.rdbSortKiASC.Margin = new System.Windows.Forms.Padding(2);
            this.rdbSortKiASC.Name = "rdbSortKiASC";
            this.rdbSortKiASC.Size = new System.Drawing.Size(89, 23);
            this.rdbSortKiASC.TabIndex = 1;
            this.rdbSortKiASC.TabStop = true;
            this.rdbSortKiASC.Text = "Kì xa nhất";
            this.rdbSortKiASC.UseVisualStyleBackColor = true;
            this.rdbSortKiASC.CheckedChanged += new System.EventHandler(this.rdbSortKiASC_CheckedChanged);
            // 
            // rdbSortKiDesc
            // 
            this.rdbSortKiDesc.AutoSize = true;
            this.rdbSortKiDesc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdbSortKiDesc.Location = new System.Drawing.Point(16, 21);
            this.rdbSortKiDesc.Margin = new System.Windows.Forms.Padding(2);
            this.rdbSortKiDesc.Name = "rdbSortKiDesc";
            this.rdbSortKiDesc.Size = new System.Drawing.Size(96, 23);
            this.rdbSortKiDesc.TabIndex = 0;
            this.rdbSortKiDesc.TabStop = true;
            this.rdbSortKiDesc.Text = "Kì gần nhất";
            this.rdbSortKiDesc.UseVisualStyleBackColor = true;
            this.rdbSortKiDesc.CheckedChanged += new System.EventHandler(this.rdbSortKiDesc_CheckedChanged);
            // 
            // btnPriceService
            // 
            this.btnPriceService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnPriceService.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPriceService.FlatAppearance.BorderSize = 0;
            this.btnPriceService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPriceService.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnPriceService.ForeColor = System.Drawing.Color.White;
            this.btnPriceService.Location = new System.Drawing.Point(985, 48);
            this.btnPriceService.Margin = new System.Windows.Forms.Padding(2);
            this.btnPriceService.Name = "btnPriceService";
            this.btnPriceService.Size = new System.Drawing.Size(154, 43);
            this.btnPriceService.TabIndex = 27;
            this.btnPriceService.Text = "Quản lý giá dịch vụ";
            this.btnPriceService.UseVisualStyleBackColor = false;
            this.btnPriceService.Click += new System.EventHandler(this.btnPriceService_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbbFillStatus);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox3.Location = new System.Drawing.Point(165, 19);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(177, 72);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Trạng Thái";
            // 
            // cbbFillStatus
            // 
            this.cbbFillStatus.FormattingEnabled = true;
            this.cbbFillStatus.Items.AddRange(new object[] {
            "Chờ Lập Hóa Đơn",
            "Đã Lập Hóa Đơn"});
            this.cbbFillStatus.Location = new System.Drawing.Point(26, 29);
            this.cbbFillStatus.Name = "cbbFillStatus";
            this.cbbFillStatus.Size = new System.Drawing.Size(146, 27);
            this.cbbFillStatus.TabIndex = 0;
            this.cbbFillStatus.SelectedIndexChanged += new System.EventHandler(this.cbbFillStatus_SelectedIndexChanged);
            // 
            // UC_Service
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnPriceService);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.lsvService);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UC_Service";
            this.Size = new System.Drawing.Size(1174, 712);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnChangeId)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lsvService;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader SoPhong;
        private System.Windows.Forms.ColumnHeader Ki;
        private System.Windows.Forms.ColumnHeader SoDienCu;
        private System.Windows.Forms.ColumnHeader SoDienMoi;
        private System.Windows.Forms.ColumnHeader SoNuocCu;
        private System.Windows.Forms.ColumnHeader SoNuocMoi;
        private System.Windows.Forms.ColumnHeader GiaDien;
        private System.Windows.Forms.ColumnHeader GiaNuoc;
        private System.Windows.Forms.ColumnHeader NgayTao;
        private ImageList imaglist;
        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private Label label5;
        private Label label6;
        private Label label3;
        private Label label4;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox txtGiaNuoc;
        private TextBox txtGiaDien;
        private TextBox txtKi;
        private TextBox txtNuocMoi;
        private TextBox txtSoNuocCu;
        private TextBox txtDienMoi;
        private TextBox txtSoDienCu;
        private TextBox txtRoomID;
        private Button btnNext;
        private Button btnPrevious;
        private Button btnAdd;
        private Label lblID;
        private Button btnReload;
        private PictureBox btnChangeId;
        private Button btnUpdate;
        private Button btnRemove;
        private DateTimePicker txtNgayTao;
        private GroupBox groupBox2;
        private RadioButton rdbSortKiASC;
        private RadioButton rdbSortKiDesc;
        private Button btnPriceService;
        private ColumnHeader TienMang;
        private TextBox txtTienMang;
        private Label label11;
        private Label label12;
        private ComboBox cbbStatus;
        private ColumnHeader TrangThai;
        private GroupBox groupBox3;
        private ComboBox cbbFillStatus;
    }
}
