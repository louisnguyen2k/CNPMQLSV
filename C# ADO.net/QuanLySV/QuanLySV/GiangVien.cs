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
    public partial class GiangVien : Form
    {
        public GiangVien()
        {
            InitializeComponent();
        }

        /* Sự kiện load form */
        private void GiangVien_Load(object sender, EventArgs e)
        {
            GetData();
            lbNumRows.Text = getNumRowsDGV();
        }

        /* Sự kiện click vào một dòng trên DGV */
        private void dgvGiangVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            tbMaGiangVien.Text = dgvGiangVien.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbTenGiangVien.Text = dgvGiangVien.Rows[e.RowIndex].Cells[2].Value.ToString();
            tbSDTGiangVien.Text = dgvGiangVien.Rows[e.RowIndex].Cells[3].Value.ToString(); ;
            tbLienHeGiangVien.Text = dgvGiangVien.Rows[e.RowIndex].Cells[4].Value.ToString(); ;
            tbChucVuGiangVien.Text = dgvGiangVien.Rows[e.RowIndex].Cells[5].Value.ToString(); ;
        }

        /* Sự kiện click button thêm */
        private void btThem_Click(object sender, EventArgs e)
        {
            string ma_gv = tbMaGiangVien.Text;
            string ten_gv = tbTenGiangVien.Text;
            string sdt_gv = tbSDTGiangVien.Text;
            string lh_gv = tbLienHeGiangVien.Text;
            string cv_gv = tbChucVuGiangVien.Text;
            if (ma_gv == string.Empty 
                || ten_gv == string.Empty 
                || sdt_gv == string.Empty
                || lh_gv == string.Empty
                || cv_gv == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin !", "Warning");
                return;
            }

            string query = @"INSERT INTO GIANG_VIEN(ma_gv, ten_gv, sdt_gv, thong_tin_lh, chuc_vu)
                                VALUES('"+ ma_gv + "', N'"+ ten_gv + "', '"+ sdt_gv + "', N'"+ lh_gv + "', N'"+ cv_gv + "')";


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
            string ma_gv = tbMaGiangVien.Text;
            string ten_gv = tbTenGiangVien.Text;
            string sdt_gv = tbSDTGiangVien.Text;
            string lh_gv = tbLienHeGiangVien.Text;
            string cv_gv = tbChucVuGiangVien.Text;
            if (ma_gv == string.Empty
                || ten_gv == string.Empty
                || sdt_gv == string.Empty
                || lh_gv == string.Empty
                || cv_gv == string.Empty)
            {
                MessageBox.Show("Vui lòng chọn trường để sửa !", "Warning");
                return;
            }

            string query = @"UPDATE GIANG_VIEN SET ten_gv = N'"+ ten_gv + "', sdt_gv = '"+ sdt_gv + "', thong_tin_lh = N'"+ lh_gv + "', chuc_vu = N'"+ cv_gv + "' WHERE ma_gv = '"+ ma_gv + "'";
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
            string ma_gv = tbMaGiangVien.Text;

            if (ma_gv == string.Empty)
            {
                MessageBox.Show("Vui lòng chọn đối tượng xóa !", "Warning");
                return;
            }
            string query = @"DELETE GIANG_VIEN 
                                WHERE ma_gv = '"+ ma_gv + "'";
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
            string select_query = @"SELECT ROW_NUMBER() OVER (ORDER BY ma_gv) AS [STT], ma_gv AS N'Mã giảng viên', ten_gv AS N'Tên giảng viên', sdt_gv AS N'SĐT', thong_tin_lh AS N'Thông tin liên hệ', chuc_vu AS N'Chức vụ'
	                                  FROM GIANG_VIEN
	                                     WHERE ma_gv LIKE '%" + key + "%'  OR ten_gv LIKE N'%" + key + "%' OR sdt_gv LIKE '%"+ key +"%' OR thong_tin_lh LIKE N'%"+ key +"%' OR chuc_vu LIKE N'%"+ key +"%'";
            SqlDataAdapter adapter = new SqlDataAdapter(select_query, DB.conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "GiangVien");
            dgvGiangVien.DataSource = null;
            dgvGiangVien.DataSource = ds.Tables["GiangVien"];
            lbNumRows.Text = getNumRowsDGV();
        }


        /* Hàm load data lên DGV */
        void GetData()
        {
            string select_query = @"SELECT ROW_NUMBER() OVER (ORDER BY ma_gv) AS [STT], ma_gv AS N'Mã giảng viên', ten_gv AS N'Tên giảng viên', sdt_gv AS N'SĐT', thong_tin_lh AS N'Thông tin liên hệ', chuc_vu AS N'Chức vụ'
                                    FROM GIANG_VIEN";
            SqlDataAdapter adapter = new SqlDataAdapter(select_query, DB.conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "GiangVien");
            dgvGiangVien.DataSource = null;
            dgvGiangVien.DataSource = ds.Tables["GiangVien"];
        }

        /* Hàm xóa dữ liệu trên textbox và combobox*/
        void ClearData()
        {
            tbMaGiangVien.Text = string.Empty;
            tbTenGiangVien.Text = string.Empty;
            tbSDTGiangVien.Text = string.Empty;
            tbChucVuGiangVien.Text = string.Empty;
            tbLienHeGiangVien.Text = string.Empty;
        }

        /* trả về số dòng hiện tại trong DGV dạng string */
        string getNumRowsDGV()
        {
            return Convert.ToString(dgvGiangVien.Rows.Count - 1);
        }
    }
}
