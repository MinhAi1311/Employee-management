using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFB4;

namespace QuanLyNhanSu
{
    public partial class TaiKhoan : Form
    {
        public TaiKhoan()
        {
            InitializeComponent();
        }
       
        private void CapNhat(string sql)
        {
            TruyXuatCSDL.ThemSuaXoa(sql);
            dgvMain.DataSource = TruyXuatCSDL.Laybang("select * from tblTaiKhoan");
        }
        private void button6_Click(object sender, EventArgs e)
        {
            Main home = new Main("0");
            home.Show();
            this.Close();
        }

        private void dgvMain_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMain.CurrentRow != null)
            {
                txttk.Text = dgvMain.CurrentRow.Cells[0].Value.ToString();
                txtmk.Text = dgvMain.CurrentRow.Cells[1].Value.ToString();
                txtloaitk.Text = dgvMain.CurrentRow.Cells[2].Value.ToString();
            }
        }

        private void frmTaiKhoan_Load(object sender, EventArgs e)
        {
            dgvMain.DataSource = TruyXuatCSDL.Laybang("select * from tblTaiKhoan");
            dgvMain.Columns[0].HeaderText = "Tài khoản ";
            dgvMain.Columns[1].HeaderText = "Mật khẩu ";
            dgvMain.Columns[2].HeaderText = "Loại tài khoản ";

            dgvMain.Columns[0].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.AllCells;
            dgvMain.Columns[1].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.AllCells;
            dgvMain.Columns[2].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "insert into tblTaiKhoan values(N'" + txttk.Text + "', N'" + txtmk.Text + "', " +
               "N'" + txtloaitk.Text + "')";
                CapNhat(sql);
                MessageBox.Show("Đã thêm", "Thông báo",
                  MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm Thất bại", "Thông báo",
                 MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            dgvMain.DataSource = TruyXuatCSDL.Laybang("select * from tblTaiKhoan");
            txttk.ResetText();
            txtmk.ResetText();
            txtloaitk.ResetText();
            txttk.Focus();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "update tblTaiKhoan set Ten_TKhoan=N'" + txttk.Text + "',Mat_Khau=N'"
                 + txtmk.Text + "' where Loai_TKhoan=" + txtloaitk.Text + "";

                CapNhat(sql);
                MessageBox.Show("Đã sửa", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Sửa Thất bại", "Thông báo",
                 MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "delete from tblTaiKhoan   where Loai_TKhoan=" + txtloaitk.Text + "";

                CapNhat(sql);
                MessageBox.Show("Đã xóa", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Xóa Thất bại", "Thông báo",
                 MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
