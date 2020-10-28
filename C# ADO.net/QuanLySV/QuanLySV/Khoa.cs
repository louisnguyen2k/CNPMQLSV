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
    public partial class Khoa : Form
    {
        public Khoa()
        {
            InitializeComponent();
        }

        /* Sự kiện load form */
        private void Khoa_Load(object sender, EventArgs e)
        {
            GetData();
            lbNumRows.Text = getNumRowsDGV();
        }

        /* Sự kiện click button thêm */
        private void btThem_Click(object sender, EventArgs e)
        {
            string ma_k = tbMaKhoa.Text;
            string ten_k = tbTenKhoa.Text;
            if(ma_k == string.Empty || ten_k == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin !", "Warning");
                return;
            }

            string query = @"INSERT INTO KHOA(ma_k, ten_k)
                                        VALUES('"+ ma_k + "',N'"+ ten_k + "')";


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
            string ma_k = tbMaKhoa.Text;
            string ten_k = tbTenKhoa.Text;
            if (ma_k == string.Empty || ten_k == string.Empty)
            {
                MessageBox.Show("Vui lòng chọn trường để sửa !", "Warning");
                return;
            }

            string query = @"UPDATE KHOA SET ten_k = N'"+ ten_k + "' WHERE ma_k = '"+ ma_k + "'";
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
            string ma_k = tbMaKhoa.Text;

            if (ma_k == string.Empty)
            {
                MessageBox.Show("Vui lòng chọn đối tượng xóa !", "Warning");
                return;
            }
            string query = @"DELETE KHOA 
                                WHERE ma_k = '"+ ma_k + "'";
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
            string select_query = @"SELECT ROW_NUMBER() OVER (ORDER BY ma_k) AS [STT], ma_k AS N'Mã khoa', ten_k AS N'Tên khoa'
                                    FROM KHOA WHERE ma_k LIKE '%" + key + "%' OR ten_k LIKE N'%"+ key + "%'";
            SqlDataAdapter adapter = new SqlDataAdapter(select_query, DB.conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Khoa");
            dgvKhoa.DataSource = null;
            dgvKhoa.DataSource = ds.Tables["Khoa"];
            lbNumRows.Text = getNumRowsDGV();
        }

        /* Sự kiện click một dòng trên DGV */
        private void dgvKhoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            tbMaKhoa.Text = dgvKhoa.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbTenKhoa.Text = dgvKhoa.Rows[e.RowIndex].Cells[2].Value.ToString();
        }


        /* Hàm load data lên DGV */
        void GetData()
        {
            string select_query = @"SELECT ROW_NUMBER() OVER (ORDER BY ma_k) AS [STT], ma_k AS N'Mã khoa', ten_k AS N'Tên khoa'
                                        FROM KHOA";
            SqlDataAdapter adapter = new SqlDataAdapter(select_query, DB.conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Khoa");
            dgvKhoa.DataSource = null;
            dgvKhoa.DataSource = ds.Tables["Khoa"];
        }

        /* Hàm xóa dữ liệu trên textbox */
        void ClearData()
        {
            tbMaKhoa.Text = string.Empty;
            tbTenKhoa.Text = string.Empty;
        }

        /* trả về số dòng hiện tại trong DGV dạng string */
        string getNumRowsDGV()
        {
            return Convert.ToString(dgvKhoa.Rows.Count - 1);
        }
    }
}
