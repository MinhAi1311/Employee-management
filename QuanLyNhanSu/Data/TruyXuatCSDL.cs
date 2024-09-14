using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Collections;
using Microsoft.ReportingServices.Diagnostics.Internal;
using System.Windows.Forms;

namespace WFB4
{
    internal class TruyXuatCSDL
    {
        
        private static string DuongDan = @"Data Source=AI;Initial Catalog=QLNhanSu;Integrated Security=True";
        private static SqlConnection TaoKetNoi()
        {   
                return new SqlConnection(DuongDan);
        }

        // viết phương thức lấy 1 bảng
        public static DataTable Laybang(string sql)
        {
            SqlConnection KetNoi = TaoKetNoi();
            KetNoi.Open();
            SqlDataAdapter MayLayDL = new SqlDataAdapter(sql, KetNoi);
            DataTable kq = new DataTable();
            MayLayDL.Fill(kq);
            KetNoi.Close();
            MayLayDL.Dispose();
            return kq;
        }
        // phương thức thêm sửa xóa
        public static void ThemSuaXoa(string sql)
        {
            SqlConnection KetNoi = TaoKetNoi();
            KetNoi.Open();
            SqlCommand Lenh = new SqlCommand(sql, KetNoi);
            Lenh.ExecuteNonQuery();
            KetNoi.Close();
            Lenh.Dispose();
        }
        // lấy một giá trị dữ liệu ra 
        public object executeScalar(string sql)
        {
            SqlConnection KetNoi = TaoKetNoi();
            KetNoi.Open();
            SqlCommand Lenh = new SqlCommand(sql, KetNoi);
            object kq = Lenh.ExecuteScalar();
            KetNoi.Close();
            if (kq != null)
            {
                return kq.ToString();
            }
            else return "";

        }
        // sử dụng để tìm kiếm giá trị
        public static ArrayList LayDanhSach(string sql)
        {
            DataTable b = Laybang(sql);
            ArrayList l = new ArrayList();
            l.Add("All");
            for (int i = 0; i < b.Rows.Count; i++)
            {
                l.Add(b.Rows[i][0].ToString());
            }
            return l;
        }

    }
}
