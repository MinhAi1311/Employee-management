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
    public partial class PhongBan : Form
    {
        public PhongBan()
        {
            InitializeComponent();
        }
        private void CapNhat(string sql)
        {
            TruyXuatCSDL.ThemSuaXoa(sql);
            dgvMain.DataSource = TruyXuatCSDL.Laybang("select * from tblPhongBan");
        }

        private void frmPhongBan_Load(object sender, EventArgs e)
        {
            dgvMain.DataSource = TruyXuatCSDL.Laybang("select * from tblPhongBan");
            dgvMain.Columns[0].HeaderText = "id phòng ban";
            dgvMain.Columns[1].HeaderText = "mã phòng ban";
            dgvMain.Columns[2].HeaderText = "tên phòng ban";
            dgvMain.Columns[3].HeaderText = "địa chỉ";
            dgvMain.Columns[4].HeaderText = "ghi chú ";

            dgvMain.Columns[0].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.AllCells;
            dgvMain.Columns[1].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.AllCells;
            dgvMain.Columns[2].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.AllCells;
            dgvMain.Columns[3].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.AllCells;
            dgvMain.Columns[4].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.Fill;
        }

        private void dgvMain_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMain.CurrentRow != null)
            {
                txtidphongban.Text = dgvMain.CurrentRow.Cells[0].Value.ToString();
                txtmaphongban.Text = dgvMain.CurrentRow.Cells[1].Value.ToString();
                txttenphongban.Text = dgvMain.CurrentRow.Cells[2].Value.ToString();
                txtdiachi.Text = dgvMain.CurrentRow.Cells[3].Value.ToString();
                txtghichu.Text = dgvMain.CurrentRow.Cells[4].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main home = new Main("0");
            home.Show();
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "insert into tblPhongBan values(" + txtidphongban.Text + ", N'" + txtmaphongban.Text + "', " +
               "N'" + txttenphongban.Text + "', N'" + txtdiachi.Text + "', N'" + txtghichu.Text + "')";
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

        private void btnReset_Click(object sender, EventArgs e)
        {
            dgvMain.DataSource = TruyXuatCSDL.Laybang("select * from tblPhongBan");
            txtidphongban.ResetText();
            txtmaphongban.ResetText();
            txttenphongban.ResetText();
            txtdiachi.ResetText();
            txtghichu.ResetText();
            txtidphongban.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "update tblPhongBan set Ma_PhongBan=N'" + txtmaphongban.Text + "',Ten_PhongBan=N'"
                 + txttenphongban.Text + "',Dia_Chi=N'" + txtdiachi.Text + "', Ghi_chu=N'" + txtghichu.Text + "' where ID_PhongBan=" + txtidphongban.Text + "";

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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "delete from tblPhongBan where ID_PhongBan=" + txtidphongban.Text + "";

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
