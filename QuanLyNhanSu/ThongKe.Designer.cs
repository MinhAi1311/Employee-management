namespace QuanLyNhanSu
{
    partial class ThongKe
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
            this.lblSoluongnv = new System.Windows.Forms.Label();
            this.lblSoluongphongban = new System.Windows.Forms.Label();
            this.lblSoluongduan = new System.Windows.Forms.Label();
            this.lblSoluongtk = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSoluongnv
            // 
            this.lblSoluongnv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoluongnv.Location = new System.Drawing.Point(67, 63);
            this.lblSoluongnv.Name = "lblSoluongnv";
            this.lblSoluongnv.Size = new System.Drawing.Size(342, 72);
            this.lblSoluongnv.TabIndex = 0;
            this.lblSoluongnv.Text = "Số lượng nhân viên : \r\n";
            // 
            // lblSoluongphongban
            // 
            this.lblSoluongphongban.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoluongphongban.Location = new System.Drawing.Point(67, 158);
            this.lblSoluongphongban.Name = "lblSoluongphongban";
            this.lblSoluongphongban.Size = new System.Drawing.Size(342, 69);
            this.lblSoluongphongban.TabIndex = 1;
            this.lblSoluongphongban.Text = "Số lượng phòng ban : \r\n";
            this.lblSoluongphongban.Click += new System.EventHandler(this.lblSoluongphongban_Click);
            // 
            // lblSoluongduan
            // 
            this.lblSoluongduan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoluongduan.Location = new System.Drawing.Point(67, 263);
            this.lblSoluongduan.Name = "lblSoluongduan";
            this.lblSoluongduan.Size = new System.Drawing.Size(342, 59);
            this.lblSoluongduan.TabIndex = 2;
            this.lblSoluongduan.Text = "Số lượng các dự án: \r\n";
            this.lblSoluongduan.Click += new System.EventHandler(this.lblSoluongduan_Click);
            // 
            // lblSoluongtk
            // 
            this.lblSoluongtk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoluongtk.Location = new System.Drawing.Point(453, 63);
            this.lblSoluongtk.Name = "lblSoluongtk";
            this.lblSoluongtk.Size = new System.Drawing.Size(342, 50);
            this.lblSoluongtk.TabIndex = 3;
            this.lblSoluongtk.Text = "Số lượng tài khoản đã cấp : ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSoluongtk);
            this.groupBox1.Controls.Add(this.lblSoluongnv);
            this.groupBox1.Controls.Add(this.lblSoluongphongban);
            this.groupBox1.Controls.Add(this.lblSoluongduan);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(886, 410);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thống kê";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(695, 567);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 13;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmThongke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 639);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmThongke";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê";
            this.Load += new System.EventHandler(this.frmThongke_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSoluongnv;
        private System.Windows.Forms.Label lblSoluongphongban;
        private System.Windows.Forms.Label lblSoluongduan;
        private System.Windows.Forms.Label lblSoluongtk;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
    }
}