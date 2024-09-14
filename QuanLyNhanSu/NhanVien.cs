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
    public partial class NhanVien : Form
    {
        public NhanVien()
        {
            InitializeComponent();
        }
        TruyXuatCSDL truyxuat = new TruyXuatCSDL();
        private void CapNhat(string sql)
        {
            TruyXuatCSDL.ThemSuaXoa(sql);
            dgvMain.DataSource = TruyXuatCSDL.Laybang("select * from tblNhanVien");
        }
        private void btnreset_Click(object sender, EventArgs e)
        {
            dgvMain.DataSource = TruyXuatCSDL.Laybang("select * from tblNhanVien");
            txtidnhanvien.ResetText();
            cbmachuvu.ResetText();
            cbtenphonban.ResetText();
            txthoten.ResetText();
            dtpngaysinh.ResetText();
            txtgioitinh.ResetText();
            txtquequan.ResetText();
            txtsocmt.ResetText();
            txtluong.ResetText();
            txtsodienthoai.ResetText();
            txtsotk.ResetText();
            dtpngaytao.ResetText();
            txtidnhanvien.Focus();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Main home = new Main("0");
            home.Show();
            this.Close();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            dgvMain.DataSource = TruyXuatCSDL.Laybang("select * from tblNhanVien");
        }

        private void dgvMain_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMain.CurrentRow != null)
            {
                txtidnhanvien.Text = dgvMain.CurrentRow.Cells[0].Value.ToString();
                cbmachuvu.Text = dgvMain.CurrentRow.Cells[1].Value.ToString();
                cbtenphonban.Text = dgvMain.CurrentRow.Cells[2].Value.ToString();
                txthoten.Text = dgvMain.CurrentRow.Cells[3].Value.ToString();
                dtpngaysinh.Text = dgvMain.CurrentRow.Cells[4].Value.ToString();
                txtgioitinh.Text = dgvMain.CurrentRow.Cells[5].Value.ToString();
                txtquequan.Text = dgvMain.CurrentRow.Cells[6].Value.ToString();
                txtsocmt.Text = dgvMain.CurrentRow.Cells[7].Value.ToString();
                txtluong.Text = dgvMain.CurrentRow.Cells[8].Value.ToString();
                txtsodienthoai.Text = dgvMain.CurrentRow.Cells[9].Value.ToString();
                txtsotk.Text = dgvMain.CurrentRow.Cells[10].Value.ToString();
                dtpngaytao.Text = dgvMain.CurrentRow.Cells[11].Value.ToString();
                // chuyền 2 phương thức cho combobox
                cbmachuvu.DataSource = machuvu();
                cbmachuvu.DisplayMember = "Ma_ChucVu";
                cbtenphonban.DataSource = tenphongban();
                cbtenphonban.DisplayMember = "Ten_PhongBan";
            }
        }
       
      
        // phương thức lấy mã chức vũ 
        public static DataTable machuvu()
        {
            String sql = "Select Ma_ChucVu from tblChuVu ";
            DataTable dt;
            dt = TruyXuatCSDL.Laybang(sql);
            return dt;
        }

        // phương thức lấy tên phòng bàn cho combobox
        public static DataTable tenphongban()
        {
          string sql = "Select Ten_PhongBan from tblPhongBan ";
            DataTable dt;
            dt = TruyXuatCSDL.Laybang(sql);
            return dt;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            // lấy mã chức vụ
            string chuvu = "Select Ten_ChuVu from tblChuVu where Ma_ChucVu='" + cbmachuvu.Text.ToString() + "'";
           // string ma_chucvu = Convert.ToString(truyxuat.executeScalar(chuvu));
            // lấy tên phòng ban
            string phongban = "Select Ma_PhongBan from tblPhongBan where Ten_PhongBan='" + cbtenphonban.Text.ToString() + "'";
            //string ten_phongban = Convert.ToString(truyxuat.executeScalar(phongban));
            // câu lệnh truy vấn sql 
        

            try
            {
                string sql = "insert into tblNhanVien values(" + txtidnhanvien.Text + ",N'" + cbmachuvu.Text + "',N'" + cbtenphonban.Text + "',N'" + txthoten.Text + "'," +
                    "N'" + dtpngaysinh.Text + "',N'" + txtgioitinh.Text + "',N'" + txtquequan.Text + "',N'" + txtsocmt.Text + "'," + txtluong.Text + ",N'" + txtsodienthoai.
                    Text + "',N'" + txtsotk.Text + "',N'" + dtpngaytao.Text + "')";
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

        private void fontChữToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog dl = new FontDialog();
            DialogResult rs = dl.ShowDialog();
            if (rs == DialogResult.OK)
            {
                
                dgvMain.Font = dl.Font;

            }
        }

        private void màuChữToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dl = new ColorDialog();
            DialogResult rs = dl.ShowDialog();
            if (rs == DialogResult.OK)
            {
                dgvMain.ForeColor = dl.Color;
                txtidnhanvien.ForeColor = dl.Color;
                cbmachuvu.ForeColor = dl.Color;
                cbtenphonban.ForeColor = dl.Color;
                txthoten.ForeColor = dl.Color;
                dtpngaysinh.ForeColor = dl.Color;
                txtgioitinh.ForeColor = dl.Color;
                txtquequan.ForeColor = dl.Color;
                txtsocmt.ForeColor = dl.Color;
                txtluong.ForeColor = dl.Color;
                txtsodienthoai.ForeColor = dl.Color;
                txtsotk.ForeColor = dl.Color;
                dtpngaytao.ForeColor = dl.Color;
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            // lấy mã chức vụ
            string chuvu = "Select Ten_ChuVu from tblChuVu where Ma_ChucVu='" + cbmachuvu.Text.ToString() + "'";
           
            // lấy tên phòng ban
            string phongban = "Select Ma_PhongBan from tblPhongBan where Ten_PhongBan='" + cbtenphonban.Text.ToString() + "'";
            try
            {
                string sql = "update tblNhanVien set Ma_ChucVu=N'" + cbmachuvu.Text + "',Ten_PhongBan=N'"+ cbtenphonban.Text +"', Ho_Ten=N'"+ txthoten.Text +"'" +
                    ",Ngay_Sinh=N'"+dtpngaysinh.Text+"',Gioi_Tinh=N'"+txtgioitinh.Text+"',Que_Quan=N'"+txtquequan.Text+"',So_CMT=N'"+txtsocmt.Text+"'," +
                    "Luong="+txtluong.Text+",So_DienThoai=N'"+txtsodienthoai.Text+"',So_TK=N'"+txtsotk.Text+"',Ngay_Tao=N'"+dtpngaytao.Text+"' where ID_NhanVien=" +txtidnhanvien.Text+"";
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
                string sql = "delete from tblNhanVien  where ID_NhanVien=" + txtidnhanvien.Text + "";

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

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
