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
    public partial class BacDaoTao : Form
    {
        public BacDaoTao()
        {
            InitializeComponent();
        }

        /* Sự kiện load form */
        private void BacDaoTao_Load(object sender, EventArgs e)
        {
            GetData();
            lbNumRows.Text = getNumRowsDGV();
        }

        /* Sự kiện click button đóng form bậc đào tạo */
        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /* Sự kiện click button thêm */
        private void btThem_Click(object sender, EventArgs e)
        {
            string ma_dt = tbMaBacDaoTao.Text;
            string ten_dt = tbTenBacDaoTao.Text;
            string loai_dt = tbLoaiHinhDaoTao.Text;
            string thoi_gian_dt = tbThoiGianDaoTao.Text;
            if(ma_dt == string.Empty ||
                ten_dt == string.Empty ||
                loai_dt == string.Empty ||
                thoi_gian_dt == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin !", "Warning");
                return;
            }
            string query = @"INSERT INTO BAC_DAO_TAO(ma_bdt, ten_bdt, loai_hinh_dao_tao, thoi_gian_dao_tao)
                                VALUES('"+ ma_dt + "',N'"+ ten_dt + "',N'"+ loai_dt + "',"+ thoi_gian_dt + ")";


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
            string ma_dt = tbMaBacDaoTao.Text;
            string ten_dt = tbTenBacDaoTao.Text;
            string loai_dt = tbLoaiHinhDaoTao.Text;
            string thoi_gian_dt = tbThoiGianDaoTao.Text;

            if (ma_dt == string.Empty)
            {
                MessageBox.Show("Vui lòng chọn trường để sửa !", "Warning");
                return;
            }
            string query = @"UPDATE BAC_DAO_TAO 
                                SET ten_bdt = N'"+ ten_dt + "', loai_hinh_dao_tao = N'"+ loai_dt + "', thoi_gian_dao_tao = "+ thoi_gian_dt + " WHERE ma_bdt ='"+ ma_dt + "'";
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
            string ma_dt = tbMaBacDaoTao.Text;

            if(ma_dt == string.Empty)
            {
                MessageBox.Show("Vui lòng chọn đối tượng xóa !", "Warning");
                return;
            }
            string query = @"DELETE BAC_DAO_TAO 
                                WHERE ma_bdt ='"+ ma_dt + "'";
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
            string select_query = @"SELECT ROW_NUMBER() OVER (ORDER BY ma_bdt) AS [STT], ma_bdt AS N'Mã bậc đào tạo', ten_bdt AS N'Tên bậc đào tạo', loai_hinh_dao_tao AS N'Loại hình đào tạo', thoi_gian_dao_tao AS N'Thời gian đào tạo'
                                    FROM BAC_DAO_TAO WHERE ma_bdt LIKE '%" + key + "%' OR ten_bdt LIKE N'%"+ key + "%' OR loai_hinh_dao_tao LIKE N'%" + key + "%' OR thoi_gian_dao_tao LIKE '%" + key + "%'";
            SqlDataAdapter adapter = new SqlDataAdapter(select_query, DB.conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "GiaoTrinh");
            dgvBacDaoTao.DataSource = null;
            dgvBacDaoTao.DataSource = ds.Tables["GiaoTrinh"];
            lbNumRows.Text = getNumRowsDGV();
        }

        /* Sự kiện click một dòng trong DGV*/
        private void dgvBacDaoTao_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            tbMaBacDaoTao.Text = dgvBacDaoTao.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbTenBacDaoTao.Text = dgvBacDaoTao.Rows[e.RowIndex].Cells[2].Value.ToString();
            tbLoaiHinhDaoTao.Text = dgvBacDaoTao.Rows[e.RowIndex].Cells[3].Value.ToString();
            tbThoiGianDaoTao.Text = dgvBacDaoTao.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        /* Hàm lấy dữ liệu DB đổ lên DGV */
        void GetData()
        {
            string select_query = @"SELECT ROW_NUMBER() OVER (ORDER BY ma_bdt) AS [STT],
                                    ma_bdt AS N'Mã bậc đào tạo',
                                    ten_bdt AS N'Tên bậc đào tạo',
                                    loai_hinh_dao_tao AS N'Loại hình đào tạo',
                                    thoi_gian_dao_tao AS N'Thời gian đào tạo'
                                    FROM BAC_DAO_TAO";
            SqlDataAdapter adapter = new SqlDataAdapter(select_query, DB.conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "BacDaoTao");
            dgvBacDaoTao.DataSource = null;
            dgvBacDaoTao.DataSource = ds.Tables["BacDaoTao"];
        }

        /* Hàm xóa dữ liệu trên tất cả textbox */
        void ClearData()
        {
            tbMaBacDaoTao.Text = string.Empty;
            tbTenBacDaoTao.Text = string.Empty;
            tbLoaiHinhDaoTao.Text = string.Empty;
            tbThoiGianDaoTao.Text = string.Empty;
        }

        /* trả về số dòng hiện tại trong DGV dạng string */
        string getNumRowsDGV()
        {
            return Convert.ToString(dgvBacDaoTao.Rows.Count - 1);
        }
    }
}
