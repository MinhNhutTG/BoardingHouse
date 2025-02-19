namespace QuanLyPhongTro.GUI.Forms
{
    partial class ModifyRoom
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
            this.btnResetTextBox = new System.Windows.Forms.PictureBox();
            this.btnAddRoom = new System.Windows.Forms.PictureBox();
            this.btnCloses = new System.Windows.Forms.PictureBox();
            this.panelMain = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rtbNote = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbbTypeRoom = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbStatus3 = new System.Windows.Forms.RadioButton();
            this.rdbStatus2 = new System.Windows.Forms.RadioButton();
            this.rdbStatus1 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtIDRoom = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnResetTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloses)).BeginInit();
            this.panelMain.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel2.Controls.Add(this.btnResetTextBox);
            this.panel2.Controls.Add(this.btnAddRoom);
            this.panel2.Controls.Add(this.btnCloses);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(943, 53);
            this.panel2.TabIndex = 5;
            // 
            // btnResetTextBox
            // 
            this.btnResetTextBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResetTextBox.Image = global::QuanLyPhongTro.Properties.Resources.reload;
            this.btnResetTextBox.Location = new System.Drawing.Point(822, 12);
            this.btnResetTextBox.Name = "btnResetTextBox";
            this.btnResetTextBox.Size = new System.Drawing.Size(32, 33);
            this.btnResetTextBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnResetTextBox.TabIndex = 4;
            this.btnResetTextBox.TabStop = false;
            this.btnResetTextBox.Click += new System.EventHandler(this.btnResetTextBox_Click);
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddRoom.Image = global::QuanLyPhongTro.Properties.Resources.floppy_disk;
            this.btnAddRoom.Location = new System.Drawing.Point(768, 12);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(32, 33);
            this.btnAddRoom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAddRoom.TabIndex = 3;
            this.btnAddRoom.TabStop = false;
            // 
            // btnCloses
            // 
            this.btnCloses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloses.Image = global::QuanLyPhongTro.Properties.Resources.cancel;
            this.btnCloses.Location = new System.Drawing.Point(881, 12);
            this.btnCloses.Name = "btnCloses";
            this.btnCloses.Size = new System.Drawing.Size(38, 33);
            this.btnCloses.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCloses.TabIndex = 2;
            this.btnCloses.TabStop = false;
            this.btnCloses.Click += new System.EventHandler(this.btnCloses_Click);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelMain.Controls.Add(this.groupBox4);
            this.panelMain.Controls.Add(this.groupBox3);
            this.panelMain.Controls.Add(this.groupBox2);
            this.panelMain.Controls.Add(this.groupBox1);
            this.panelMain.Location = new System.Drawing.Point(0, 53);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(935, 620);
            this.panelMain.TabIndex = 6;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rtbNote);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox4.ForeColor = System.Drawing.Color.Black;
            this.groupBox4.Location = new System.Drawing.Point(33, 386);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(866, 147);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ghi chú";
            // 
            // rtbNote
            // 
            this.rtbNote.Location = new System.Drawing.Point(18, 29);
            this.rtbNote.Name = "rtbNote";
            this.rtbNote.Size = new System.Drawing.Size(830, 102);
            this.rtbNote.TabIndex = 0;
            this.rtbNote.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbbTypeRoom);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(33, 116);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(313, 69);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Loại Phòng";
            // 
            // cbbTypeRoom
            // 
            this.cbbTypeRoom.FormattingEnabled = true;
            this.cbbTypeRoom.Location = new System.Drawing.Point(27, 29);
            this.cbbTypeRoom.Name = "cbbTypeRoom";
            this.cbbTypeRoom.Size = new System.Drawing.Size(280, 30);
            this.cbbTypeRoom.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbStatus3);
            this.groupBox2.Controls.Add(this.rdbStatus2);
            this.groupBox2.Controls.Add(this.rdbStatus1);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(33, 201);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(504, 161);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Trạng thái";
            // 
            // rdbStatus3
            // 
            this.rdbStatus3.AutoSize = true;
            this.rdbStatus3.Location = new System.Drawing.Point(58, 111);
            this.rdbStatus3.Name = "rdbStatus3";
            this.rdbStatus3.Size = new System.Drawing.Size(148, 26);
            this.rdbStatus3.TabIndex = 2;
            this.rdbStatus3.TabStop = true;
            this.rdbStatus3.Text = "Đang sửa chữa";
            this.rdbStatus3.UseVisualStyleBackColor = true;
            // 
            // rdbStatus2
            // 
            this.rdbStatus2.AutoSize = true;
            this.rdbStatus2.Location = new System.Drawing.Point(58, 70);
            this.rdbStatus2.Name = "rdbStatus2";
            this.rdbStatus2.Size = new System.Drawing.Size(109, 26);
            this.rdbStatus2.TabIndex = 1;
            this.rdbStatus2.TabStop = true;
            this.rdbStatus2.Text = "Đang thuê";
            this.rdbStatus2.UseVisualStyleBackColor = true;
            // 
            // rdbStatus1
            // 
            this.rdbStatus1.AutoSize = true;
            this.rdbStatus1.Location = new System.Drawing.Point(58, 29);
            this.rdbStatus1.Name = "rdbStatus1";
            this.rdbStatus1.Size = new System.Drawing.Size(77, 26);
            this.rdbStatus1.TabIndex = 0;
            this.rdbStatus1.TabStop = true;
            this.rdbStatus1.Text = "Trống";
            this.rdbStatus1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtIDRoom);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(33, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 58);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Số phòng";
            // 
            // txtIDRoom
            // 
            this.txtIDRoom.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtIDRoom.Location = new System.Drawing.Point(27, 21);
            this.txtIDRoom.Name = "txtIDRoom";
            this.txtIDRoom.Size = new System.Drawing.Size(280, 28);
            this.txtIDRoom.TabIndex = 0;
            this.txtIDRoom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIDRoom_KeyPress);
            // 
            // ModifyRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 666);
            this.ControlBox = false;
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ModifyRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModifyRoom";
            this.TransparencyKey = System.Drawing.Color.Blue;
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnResetTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloses)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox btnCloses;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.PictureBox btnAddRoom;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtIDRoom;
        private System.Windows.Forms.RadioButton rdbStatus2;
        private System.Windows.Forms.RadioButton rdbStatus1;
        private System.Windows.Forms.RadioButton rdbStatus3;
        private System.Windows.Forms.ComboBox cbbTypeRoom;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RichTextBox rtbNote;
        private System.Windows.Forms.PictureBox btnResetTextBox;
    }
}