using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using WFB4;

namespace QuanLyNhanSu
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            lblError.Text = "";
        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            // kiểm tra xem textbox có nhận giá trị đúng hay chưa
            try
            {
                TruyXuatCSDL ac = new TruyXuatCSDL();
                string tk = txtTenTKhoan.Text;
                string mk = txtMatKhau.Text;
                string sql = "select Loai_TKhoan from [tblTaiKhoan] where Ten_TKhoan =N'" + tk + "'and Mat_Khau =N'" + mk + "'";
                object kq = ac.executeScalar(sql);
                if (kq.ToString() == " ")
                {
                    DialogResult dl = MessageBox.Show("Đăng nhập thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (dl == DialogResult.OK)
                    {
                        txtTenTKhoan.SelectAll();
                        txtMatKhau.Clear();
                        txtTenTKhoan.Focus();
                    }
                }
                else if (kq.ToString() == "1")
                {
                    DialogResult dl = MessageBox.Show("Chào mừng user !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dl == DialogResult.OK)
                    {
                        Main main = new Main(kq.ToString());
                        main.Show();
                        this.Hide();
                    }
                }
                else if (kq.ToString() == "0")
                {
                    DialogResult dl = MessageBox.Show("Chào mừng Admin !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dl == DialogResult.OK)
                    {
                        Main main = new Main(kq.ToString());
                        main.Show();
                        this.Hide();
                    }
                }
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

