namespace QuanLyPhongTro.GUI.UC.Room
{
    partial class UC_Room
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
            this.background = new System.Windows.Forms.Panel();
            this.lblID = new System.Windows.Forms.Label();
            this.lblPhong = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.background.SuspendLayout();
            this.SuspendLayout();
            // 
            // background
            // 
            this.background.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(61)))), ((int)(((byte)(158)))));
            this.background.Controls.Add(this.lblID);
            this.background.Controls.Add(this.lblPhong);
            this.background.Location = new System.Drawing.Point(0, 0);
            this.background.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(146, 129);
            this.background.TabIndex = 0;
            this.background.Click += new System.EventHandler(this.background_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblID.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblID.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblID.Location = new System.Drawing.Point(0, 67);
            this.lblID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblID.MinimumSize = new System.Drawing.Size(146, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(146, 40);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "10";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblID.Click += new System.EventHandler(this.lblID_Click);
            // 
            // lblPhong
            // 
            this.lblPhong.AutoSize = true;
            this.lblPhong.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblPhong.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblPhong.Location = new System.Drawing.Point(38, 29);
            this.lblPhong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhong.Name = "lblPhong";
            this.lblPhong.Size = new System.Drawing.Size(77, 26);
            this.lblPhong.TabIndex = 0;
            this.lblPhong.Text = "Phòng";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblStatus.ForeColor = System.Drawing.Color.Gray;
            this.lblStatus.Location = new System.Drawing.Point(0, 140);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.MinimumSize = new System.Drawing.Size(146, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(146, 17);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Còn trống";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UC_Room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.background);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.Name = "UC_Room";
            this.Size = new System.Drawing.Size(144, 165);
            this.Click += new System.EventHandler(this.UC_Room_Click);
            this.background.ResumeLayout(false);
            this.background.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel background;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblPhong;
        private System.Windows.Forms.Label lblStatus;
    }
}
