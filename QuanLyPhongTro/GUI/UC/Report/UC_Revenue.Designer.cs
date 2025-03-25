namespace QuanLyPhongTro.GUI.UC.Service
{
    partial class UC_Revenue
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbYear = new System.Windows.Forms.ComboBox();
            this.rbdDoanhThuQuy = new System.Windows.Forms.RadioButton();
            this.rdbDoanhThuThang = new System.Windows.Forms.RadioButton();
            this.PanelBg = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbRooms = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbRooms = new System.Windows.Forms.ComboBox();
            this.PanelBG2 = new System.Windows.Forms.Panel();
            this.btnDichVu = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDichVu);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1226, 47);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(492, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "BÁO CÁO DOANH THU";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbbYear);
            this.groupBox1.Controls.Add(this.rbdDoanhThuQuy);
            this.groupBox1.Controls.Add(this.rdbDoanhThuThang);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(41, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(523, 93);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doanh Thu Tháng / Quý";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Năm:";
            // 
            // cbbYear
            // 
            this.cbbYear.FormattingEnabled = true;
            this.cbbYear.Location = new System.Drawing.Point(282, 27);
            this.cbbYear.Name = "cbbYear";
            this.cbbYear.Size = new System.Drawing.Size(89, 29);
            this.cbbYear.TabIndex = 2;
            this.cbbYear.SelectedIndexChanged += new System.EventHandler(this.cbbYear_SelectedIndexChanged);
            // 
            // rbdDoanhThuQuy
            // 
            this.rbdDoanhThuQuy.AutoSize = true;
            this.rbdDoanhThuQuy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rbdDoanhThuQuy.Location = new System.Drawing.Point(36, 58);
            this.rbdDoanhThuQuy.Name = "rbdDoanhThuQuy";
            this.rbdDoanhThuQuy.Size = new System.Drawing.Size(159, 23);
            this.rbdDoanhThuQuy.TabIndex = 1;
            this.rbdDoanhThuQuy.TabStop = true;
            this.rbdDoanhThuQuy.Text = "Doanh Thu Theo Quý";
            this.rbdDoanhThuQuy.UseVisualStyleBackColor = true;
            this.rbdDoanhThuQuy.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rdbDoanhThuThang
            // 
            this.rdbDoanhThuThang.AutoSize = true;
            this.rdbDoanhThuThang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdbDoanhThuThang.Location = new System.Drawing.Point(36, 27);
            this.rdbDoanhThuThang.Name = "rdbDoanhThuThang";
            this.rdbDoanhThuThang.Size = new System.Drawing.Size(170, 23);
            this.rdbDoanhThuThang.TabIndex = 0;
            this.rdbDoanhThuThang.TabStop = true;
            this.rdbDoanhThuThang.Text = "Doanh Thu Theo Tháng";
            this.rdbDoanhThuThang.UseVisualStyleBackColor = true;
            this.rdbDoanhThuThang.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // PanelBg
            // 
            this.PanelBg.Location = new System.Drawing.Point(41, 162);
            this.PanelBg.Name = "PanelBg";
            this.PanelBg.Size = new System.Drawing.Size(523, 477);
            this.PanelBg.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbRooms);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cbbRooms);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(655, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(410, 93);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Doanh Thu Phòng";
            // 
            // rdbRooms
            // 
            this.rdbRooms.AutoSize = true;
            this.rdbRooms.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdbRooms.Location = new System.Drawing.Point(36, 34);
            this.rdbRooms.Name = "rdbRooms";
            this.rdbRooms.Size = new System.Drawing.Size(65, 23);
            this.rdbRooms.TabIndex = 4;
            this.rdbRooms.TabStop = true;
            this.rdbRooms.Text = "Tất cả";
            this.rdbRooms.UseVisualStyleBackColor = true;
            this.rdbRooms.CheckedChanged += new System.EventHandler(this.rdbRooms_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(214, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Phòng:";
            // 
            // cbbRooms
            // 
            this.cbbRooms.FormattingEnabled = true;
            this.cbbRooms.Location = new System.Drawing.Point(282, 28);
            this.cbbRooms.Name = "cbbRooms";
            this.cbbRooms.Size = new System.Drawing.Size(92, 29);
            this.cbbRooms.TabIndex = 2;
            this.cbbRooms.SelectedIndexChanged += new System.EventHandler(this.cbbRooms_SelectedIndexChanged);
            // 
            // PanelBG2
            // 
            this.PanelBG2.Location = new System.Drawing.Point(655, 162);
            this.PanelBG2.Name = "PanelBG2";
            this.PanelBG2.Size = new System.Drawing.Size(523, 477);
            this.PanelBG2.TabIndex = 3;
            // 
            // btnDichVu
            // 
            this.btnDichVu.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDichVu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDichVu.FlatAppearance.BorderSize = 0;
            this.btnDichVu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDichVu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDichVu.ForeColor = System.Drawing.Color.White;
            this.btnDichVu.Location = new System.Drawing.Point(979, 2);
            this.btnDichVu.Margin = new System.Windows.Forms.Padding(2);
            this.btnDichVu.Name = "btnDichVu";
            this.btnDichVu.Size = new System.Drawing.Size(189, 43);
            this.btnDichVu.TabIndex = 27;
            this.btnDichVu.Text = "Xuất file báo cáo";
            this.btnDichVu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDichVu.UseVisualStyleBackColor = false;
            // 
            // UC_Revenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.PanelBG2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.PanelBg);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "UC_Revenue";
            this.Size = new System.Drawing.Size(1227, 662);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbdDoanhThuQuy;
        private System.Windows.Forms.RadioButton rdbDoanhThuThang;
        private System.Windows.Forms.ComboBox cbbYear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel PanelBg;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdbRooms;
        private System.Windows.Forms.ComboBox cbbRooms;
        private System.Windows.Forms.Panel PanelBG2;
        private System.Windows.Forms.Button btnDichVu;
    }
}
