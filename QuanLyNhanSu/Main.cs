using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QuanLyNhanSu
{
    public partial class Main : Form
    {
        public Main(String LoaiTKhoan)
        {
            InitializeComponent();
            if(LoaiTKhoan == "0")
            {

            }
            else
            {

            }

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PhongBan phongban = new PhongBan();
            phongban.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();
            nv.Show();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            TimKiem timkiem = new TimKiem();
            timkiem.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ChucVu chucvu = new ChucVu();
            chucvu.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DuAn duan = new DuAn();
            duan.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TaiKhoan tk = new TaiKhoan();
            tk.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ThongKe thongke = new ThongKe();
            thongke.Show();
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DialogResult traloi = MessageBox.Show("bạn có chắc muốn thoát không", "thông báo");
            if (traloi == DialogResult.OK)
            {
                Login lgin = new Login();
                lgin.Show();
                this.Close();
            }
        }
    }
}
