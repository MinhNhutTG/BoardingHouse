namespace QuanLyPhongTro.GUI.Notify
{
    partial class Notifi
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
            this.iconNotifi = new System.Windows.Forms.PictureBox();
            this.lblContent = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iconNotifi)).BeginInit();
            this.SuspendLayout();
            // 
            // iconNotifi
            // 
            this.iconNotifi.Image = global::QuanLyPhongTro.Properties.Resources.success;
            this.iconNotifi.InitialImage = null;
            this.iconNotifi.Location = new System.Drawing.Point(12, 12);
            this.iconNotifi.Name = "iconNotifi";
            this.iconNotifi.Size = new System.Drawing.Size(47, 48);
            this.iconNotifi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconNotifi.TabIndex = 0;
            this.iconNotifi.TabStop = false;
            // 
            // lblContent
            // 
            this.lblContent.AutoSize = true;
            this.lblContent.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblContent.ForeColor = System.Drawing.Color.White;
            this.lblContent.Location = new System.Drawing.Point(80, 22);
            this.lblContent.MaximumSize = new System.Drawing.Size(290, 90);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(251, 38);
            this.lblContent.TabIndex = 1;
            this.lblContent.Text = " label1 la  label1 label1 label1 bel1 label1 ";
            // 
            // Notifi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(213)))), ((int)(((byte)(2)))));
            this.ClientSize = new System.Drawing.Size(380, 76);
            this.Controls.Add(this.lblContent);
            this.Controls.Add(this.iconNotifi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Notifi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Notifi";
            ((System.ComponentModel.ISupportInitialize)(this.iconNotifi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox iconNotifi;
        private System.Windows.Forms.Label lblContent;
    }
}