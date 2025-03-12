namespace QuanLyPhongTro.GUI.Forms
{
    partial class PriceService
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCloses = new System.Windows.Forms.PictureBox();
            this.lsvService = new System.Windows.Forms.ListView();
            this.nameService = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloses)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnReload)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel2.Controls.Add(this.btnCloses);
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(821, 53);
            this.panel2.TabIndex = 7;
            // 
            // btnCloses
            // 
            this.btnCloses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloses.Image = global::QuanLyPhongTro.Properties.Resources.cancel;
            this.btnCloses.Location = new System.Drawing.Point(736, 10);
            this.btnCloses.Name = "btnCloses";
            this.btnCloses.Size = new System.Drawing.Size(38, 33);
            this.btnCloses.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCloses.TabIndex = 2;
            this.btnCloses.TabStop = false;
            this.btnCloses.Click += new System.EventHandler(this.btnCloses_Click);
            // 
            // lsvService
            // 
            this.lsvService.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameService,
            this.price});
            this.lsvService.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lsvService.FullRowSelect = true;
            this.lsvService.GridLines = true;
            this.lsvService.HideSelection = false;
            this.lsvService.Location = new System.Drawing.Point(15, 113);
            this.lsvService.Name = "lsvService";
            this.lsvService.Size = new System.Drawing.Size(346, 397);
            this.lsvService.TabIndex = 8;
            this.lsvService.UseCompatibleStateImageBehavior = false;
            this.lsvService.View = System.Windows.Forms.View.Details;
            this.lsvService.SelectedIndexChanged += new System.EventHandler(this.lsvService_SelectedIndexChanged);
            // 
            // nameService
            // 
            this.nameService.Text = "Tên dịch vụ";
            this.nameService.Width = 130;
            // 
            // price
            // 
            this.price.Text = "Giá dịch vụ";
            this.price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.price.Width = 130;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(15, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(345, 36);
            this.panel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1, 1);
            this.label1.MinimumSize = new System.Drawing.Size(345, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Giá dịch vụ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtname);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Location = new System.Drawing.Point(399, 142);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 60);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tên dịch vụ";
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtname.Location = new System.Drawing.Point(18, 23);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(333, 30);
            this.txtname.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtprice);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox2.Location = new System.Drawing.Point(399, 224);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(357, 62);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Giá dịch vụ";
            // 
            // txtprice
            // 
            this.txtprice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtprice.Location = new System.Drawing.Point(18, 21);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(333, 30);
            this.txtprice.TabIndex = 1;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Location = new System.Drawing.Point(603, 316);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(76, 47);
            this.btnRemove.TabIndex = 14;
            this.btnRemove.Text = "Xóa";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnReload
            // 
            this.btnReload.Image = global::QuanLyPhongTro.Properties.Resources.reload;
            this.btnReload.Location = new System.Drawing.Point(694, 322);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(30, 30);
            this.btnReload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnReload.TabIndex = 13;
            this.btnReload.TabStop = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(449, 316);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(138, 47);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // PriceService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 561);
            this.ControlBox = false;
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lsvService);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PriceService";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PriceService";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnCloses)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnReload)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox btnCloses;
        private System.Windows.Forms.ListView lsvService;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader nameService;
        private System.Windows.Forms.ColumnHeader price;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.PictureBox btnReload;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtprice;
    }
}