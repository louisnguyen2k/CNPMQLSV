using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLySV
{
    public partial class MonHoc : Form
    {
        public MonHoc()
        {
            InitializeComponent();
        }

        /* Sự kiện load form */
        private void MonHoc_Load(object sender, EventArgs e)
        {
            GetData();
            lbNumRows.Text = getNumRowsDGV();
        }

        /* Sự kiện click vào một dòng trên DGV */
        private void dgvLop_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            tbMaMH.Text = dgvMonHoc.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbTenMH.Text = dgvMonHoc.Rows[e.RowIndex].Cells[2].Value.ToString();
            tbSoTinChi.Text = dgvMonHoc.Rows[e.RowIndex].Cells[3].Value.ToString();
            tbSoTietLyThuyet.Text = dgvMonHoc.Rows[e.RowIndex].Cells[4].Value.ToString();
            tbSoTietThucHanh.Text = dgvMonHoc.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        /* Sự kiện click button thêm */
        private void btThem_Click(object sender, EventArgs e)
        {
            string ma_mh = tbMaMH.Text;
            string ten_mh = tbTenMH.Text;
            string so_tc = tbSoTinChi.Text;
            string tiet_lt = tbSoTietLyThuyet.Text;
            string tiet_th = tbSoTietThucHanh.Text;
            if (ma_mh == string.Empty || ten_mh == string.Empty ||
                so_tc == string.Empty || tiet_lt == string.Empty ||
                    tiet_th == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin !", "Warning");
                return;
            }

            string query = @"INSERT INTO MON_HOC(ma_mh, ten_mh, so_tc_mh, so_tiet_lt_mh, so_tiet_th_mh)
                                VALUES('"+ ma_mh + "', N'"+ ten_mh + "', "+ so_tc + ", "+ tiet_lt + ", "+ tiet_th + ")";


            DB.conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand(query, DB.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công !", "Message");
                GetData();
                ClearData();
                lbNumRows.Text = getNumRowsDGV();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm thất bại, Exception: " + ex.Message, "Error");
            }
            finally
            {
                DB.conn.Close();
            }
        }

        /* Sự kiện click button sửa */
        private void btSua_Click(object sender, EventArgs e)
        {
            string ma_mh = tbMaMH.Text;
            string ten_mh = tbTenMH.Text;
            string so_tc = tbSoTinChi.Text;
            string tiet_lt = tbSoTietLyThuyet.Text;
            string tiet_th = tbSoTietThucHanh.Text;
            if (ma_mh == string.Empty || ten_mh == string.Empty ||
                so_tc == string.Empty || tiet_lt == string.Empty ||
                    tiet_th == string.Empty)
            {
                MessageBox.Show("Vui lòng chọn trường để sửa !", "Warning");
                return;
            }

            string query = @"UPDATE MON_HOC 
                            SET ten_mh = N'"+ ten_mh + "', so_tc_mh = "+ so_tc + ", so_tiet_lt_mh = "+ tiet_lt + ", so_tiet_th_mh = "+ tiet_th + " WHERE ma_mh = '"+ ma_mh + "'";
            DB.conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand(query, DB.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sửa thành công !", "Message");
                GetData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa thất bại, Exception: " + ex.Message, "Error");
            }
            finally
            {
                DB.conn.Close();
            }
        }

        /* Sự kiện click button xóa */
        private void btXoa_Click(object sender, EventArgs e)
        {
            string ma_mh = tbMaMH.Text;

            if (ma_mh == string.Empty)
            {
                MessageBox.Show("Vui lòng chọn đối tượng xóa !", "Warning");
                return;
            }
            string query = @"DELETE MON_HOC 
                                WHERE ma_mh = '"+ ma_mh + "'";
            DB.conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand(query, DB.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công !", "Message");
                GetData();
                ClearData();
                lbNumRows.Text = getNumRowsDGV();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa thất bại, Exception: " + ex.Message, "Error");
            }
            finally
            {
                DB.conn.Close();
            }
        }

        /* Sự kiện click button tìm kiếm */
        private void btTimKiem_Click(object sender, EventArgs e)
        {
            string key = tbTimKiem.Text;
            string select_query = @"SELECT ROW_NUMBER() OVER (ORDER BY ma_mh) AS [STT],
                                        ma_mh AS N'Mã môn học',
                                        ten_mh AS N'Tên môn học',
                                        so_tc_mh AS N'Số tín chỉ',
                                        so_tiet_lt_mh AS N'Số tiết lý thuyết',
                                        so_tiet_th_mh AS N'Số tiết thực hành'
                                        FROM MON_HOC
                                        WHERE ma_mh LIKE '%"+ key + "%' OR ten_mh LIKE N'%" + key + "%'";
            SqlDataAdapter adapter = new SqlDataAdapter(select_query, DB.conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "MonHoc");
            dgvMonHoc.DataSource = null;
            dgvMonHoc.DataSource = ds.Tables["MonHoc"];
            lbNumRows.Text = getNumRowsDGV();
        }






        /*-----------------------------------*/
        /* Hàm load data lên DGV */
        void GetData()
        {
            string select_query = @"SELECT ROW_NUMBER() OVER (ORDER BY ma_mh) AS [STT],
                                    ma_mh AS N'Mã môn học',
                                    ten_mh AS N'Tên môn học',
                                    so_tc_mh AS N'Số tín chỉ',
                                    so_tiet_lt_mh AS N'Số tiết lý thuyết',
                                    so_tiet_th_mh AS N'Số tiết thực hành'
                                    FROM MON_HOC";
            SqlDataAdapter adapter = new SqlDataAdapter(select_query, DB.conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "MonHoc");
            dgvMonHoc.DataSource = null;
            dgvMonHoc.DataSource = ds.Tables["MonHoc"];
        }

        /* Hàm xóa dữ liệu trên textbox */
        void ClearData()
        {
            tbMaMH.Text = string.Empty;
            tbTenMH.Text = string.Empty;
            tbSoTinChi.Text = string.Empty;
            tbSoTietLyThuyet.Text = string.Empty;
            tbSoTietThucHanh.Text = string.Empty;
        }

        /* trả về số dòng hiện tại trong DGV dạng string */
        string getNumRowsDGV()
        {
            return Convert.ToString(dgvMonHoc.Rows.Count - 1);
        }

    }
}
