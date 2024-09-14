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
using WFB4;

namespace QuanLyNhanSu
{
    public partial class ChucVu : Form
    {

       
        public ChucVu()
        {
            InitializeComponent();
            
        }
        private void CapNhat(string sql)
        {
            TruyXuatCSDL.ThemSuaXoa(sql);
            dgvMain.DataSource = TruyXuatCSDL.Laybang("select * from tblChuVu");
        }

        private void dgvMain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
         
        private void dgvMain_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            // clic chuột hiển thị dữ liệu nên txt
            if (dgvMain.CurrentRow != null)
            {
                txtidchucvu.Text = dgvMain.CurrentRow.Cells[0].Value.ToString();
                txtmachucvu.Text = dgvMain.CurrentRow.Cells[1].Value.ToString();
                txttenchucvu.Text = dgvMain.CurrentRow.Cells[2].Value.ToString();
                txtghichu.Text = dgvMain.CurrentRow.Cells[3].Value.ToString(); 
            }
        }

        private void frmChucVu_Load(object sender, EventArgs e)
        {
            dgvMain.DataSource = TruyXuatCSDL.Laybang("select * from tblChuVu");
            dgvMain.Columns[0].HeaderText = "id chức vụ";
            dgvMain.Columns[1].HeaderText = "mã chức vụ";
            dgvMain.Columns[2].HeaderText = "tên chức vụ  ";
            dgvMain.Columns[3].HeaderText = "ghi chú ";

            dgvMain.Columns[0].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.AllCells;
            dgvMain.Columns[1].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.AllCells;
            dgvMain.Columns[2].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.AllCells;
            dgvMain.Columns[3].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.Fill;
            cbhoten.DataSource =
               TruyXuatCSDL.LayDanhSach("select distinct Ten_ChuVu from tblChuVu");
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
                string sql = "insert into tblChuVu values(N'" + txtidchucvu.Text + "', N'" + txtmachucvu.Text + "', " +
               "N'" + txttenchucvu.Text + "', N'" + txtghichu.Text + "')";
                CapNhat(sql);
                MessageBox.Show("Đã thêm", "Thông báo",
                  MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch( Exception   )
            {
                MessageBox.Show("Thêm Thất bại", "Thông báo",
                 MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dgvMain.DataSource = TruyXuatCSDL.Laybang("select * from tblChuVu");
            txtidchucvu.ResetText();
            txtmachucvu.ResetText();
            txttenchucvu.ResetText();
            txtghichu.ResetText();
            txtidchucvu.Focus();
           
        }

        private void cbhoten_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbhoten.Text == "All")
            {
                dgvMain.DataSource =
                  TruyXuatCSDL.Laybang("select * from tblChuVu");
            }
            else
            {
                dgvMain.DataSource =
                TruyXuatCSDL.Laybang("select * from tblChuVu  where Ten_ChuVu = N'" +
                    cbhoten.Text + "'");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            
            try
            {
                string sql = "update tblChuVu set Ma_ChucVu=N'" + txtmachucvu.Text + "',Ten_ChuVu=N'"
                 + txttenchucvu.Text + "', Ghi_Chu=N'" + txtghichu.Text + "' where ID_ChucVu=" + txtidchucvu.Text + "";

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
                string sql = "delete from tblChuVu where ID_ChucVu=" + txtidchucvu.Text + "";

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

        private void txtghichu_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }