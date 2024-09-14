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
    public partial class DuAn : Form
    {
        public DuAn()
        {
            InitializeComponent();
        }
        private void CapNhat(string sql)
        {
            TruyXuatCSDL.ThemSuaXoa(sql);
            dgvMain.DataSource = TruyXuatCSDL.Laybang("select * from tblDuAn");
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
                txtidduan.Text = dgvMain.CurrentRow.Cells[0].Value.ToString();
                txttenduan.Text = dgvMain.CurrentRow.Cells[1].Value.ToString();
                txtsonhanvien.Text = dgvMain.CurrentRow.Cells[2].Value.ToString();
                txtmotada.Text = dgvMain.CurrentRow.Cells[3].Value.ToString();
            }
        }

        private void frmDuAn_Load(object sender, EventArgs e)
        {
            dgvMain.DataSource = TruyXuatCSDL.Laybang("select * from tblDuAn");
            dgvMain.Columns[0].HeaderText = "id dự án ";
            dgvMain.Columns[1].HeaderText = "tên dự án ";
            dgvMain.Columns[2].HeaderText = "số nhân viên ";
            dgvMain.Columns[3].HeaderText = "mô tả dự án";

            dgvMain.Columns[0].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.AllCells;
            dgvMain.Columns[1].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.AllCells;
            dgvMain.Columns[2].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.AllCells;
            dgvMain.Columns[3].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "insert into tblDuAn values(N'" + txtidduan.Text + "', N'" + txttenduan.Text + "', " +
               "N'" + txtsonhanvien.Text + "', N'" + txtmotada.Text + "')";
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
            dgvMain.DataSource = TruyXuatCSDL.Laybang("select * from tblDuAn");
            txtidduan.ResetText();
            txttenduan.ResetText();
            txtsonhanvien.ResetText();
            txtmotada.ResetText();
            txtidduan.Focus();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            try
            {

                string sql = "update tblDuAn set name_Da=N'" + txttenduan.Text + "',sonv_Da="+ txtsonhanvien.Text + ", mota_Da=N'" + txtmotada.Text + "' where id_Da=N'" + txtidduan.Text + "'";

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
                string sql = "delete from tblDuAn  where id_Da=N'" + txtidduan.Text + "'";

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
