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
    public partial class ChuyenNganh : Form
    {

        /* Property */
        // @KhoaDic: cấu trúc dữ liệu lưu một list dạng key(string)-value(CKhoa)
        private Dictionary<string, CKhoa> KhoaDic;
        public ChuyenNganh()
        {
            InitializeComponent();
        }

        /* Sự kiện load form */
        private void ChuyenNganh_Load(object sender, EventArgs e)
        {
            cbbKhoa.DisplayMember = "Ten_khoa";
            cbbKhoa.ValueMember = "Ma_khoa";
            GetData();
            GetCBB();
            lbNumRows.Text = getNumRowsDGV();
        }

        /* Sự kiện click vào một dòng trên DGV */
        private void dgvChuyenNganh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            tbMaChuyenNganh.Text = dgvChuyenNganh.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbTenChuyenNganh.Text = dgvChuyenNganh.Rows[e.RowIndex].Cells[2].Value.ToString();
            string MaKhoa = dgvChuyenNganh.Rows[e.RowIndex].Cells[3].Value.ToString();

            if (KhoaDic.ContainsKey(MaKhoa))
            {
                cbbKhoa.SelectedItem = KhoaDic[MaKhoa];
            }
            else
            {
                cbbKhoa.SelectedIndex = -1;
            }
        }

        /* Sự kiện click button thêm */
        private void btThem_Click(object sender, EventArgs e)
        {
            string ma_cn = tbMaChuyenNganh.Text;
            string ten_cn = tbTenChuyenNganh.Text;
            if(ma_cn == string.Empty || ten_cn == string.Empty || cbbKhoa.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin !", "Warning");
                return;
            }
            string ma_k = ((CKhoa)cbbKhoa.SelectedItem).Ma_khoa;

            string query = @"INSERT INTO CHUYEN_NGANH(ma_cn, ten_cn, ma_k)
                                VALUES('"+ ma_cn + "',N'"+ ten_cn + "','"+ ma_k + "')";


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
            string ma_cn = tbMaChuyenNganh.Text;
            string ten_cn = tbTenChuyenNganh.Text;
            if (ma_cn == string.Empty || ten_cn == string.Empty || cbbKhoa.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin !", "Warning");
                return;
            }
            string ma_k = ((CKhoa)cbbKhoa.SelectedItem).Ma_khoa;

            string query = @"UPDATE CHUYEN_NGANH SET ten_cn = N'"+ ten_cn + "', ma_k = '"+ ma_k + "' WHERE ma_cn = '"+ ma_cn + "'";
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
            string ma_cn = tbMaChuyenNganh.Text;

            if (ma_cn == string.Empty)
            {
                MessageBox.Show("Vui lòng chọn đối tượng xóa !", "Warning");
                return;
            }
            string query = @"DELETE CHUYEN_NGANH WHERE ma_cn = '"+ ma_cn + "'";
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
            string select_query = @"SELECT ROW_NUMBER() OVER (ORDER BY ma_cn) AS [STT], ma_cn AS N'Mã chuyên ngành', ten_cn AS N'Tên chuyên ngành', CHUYEN_NGANH.ma_k AS N'Khoa'
	                                    FROM CHUYEN_NGANH , KHOA
	                                    WHERE (ma_cn LIKE '%" + key + "%' OR ten_cn LIKE N'%"+ key + "%' OR CHUYEN_NGANH.ma_k LIKE '%"+ key + "%' OR KHOA.ten_k LIKE N'%" + key + "%') AND CHUYEN_NGANH.ma_k = KHOA.ma_k";
            SqlDataAdapter adapter = new SqlDataAdapter(select_query, DB.conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "ChuyenNganh");
            dgvChuyenNganh.DataSource = null;
            dgvChuyenNganh.DataSource = ds.Tables["ChuyenNganh"];
            lbNumRows.Text = getNumRowsDGV();
        }

        /* Hàm load dữ liệu khoa lên CBB */
        void GetCBB()
        {
            string query = "SELECT * FROM KHOA";
            DB.conn.Open();
            SqlCommand cmd = new SqlCommand(query, DB.conn);
            SqlDataReader rd = cmd.ExecuteReader();
            KhoaDic = new Dictionary<string, CKhoa>();
            while (rd.Read())
            {
                CKhoa gt2 = new CKhoa(rd[0].ToString(), rd[1].ToString());
                cbbKhoa.Items.Add(gt2);
                KhoaDic[gt2.Ma_khoa] = gt2;

            }
            DB.conn.Close();
        }

        /* Hàm load data lên DGV */
        void GetData()
        {
            string select_query = @"SELECT ROW_NUMBER() OVER (ORDER BY ma_cn) AS [STT], ma_cn AS N'Mã chuyên ngành', ten_cn AS N'Tên chuyên ngành', ma_k AS N'Khoa'
                                    FROM CHUYEN_NGANH";
            SqlDataAdapter adapter = new SqlDataAdapter(select_query, DB.conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "ChuyenNganh");
            dgvChuyenNganh.DataSource = null;
            dgvChuyenNganh.DataSource = ds.Tables["ChuyenNganh"];
        }

        /* Hàm xóa dữ liệu trên textbox và combobox*/
        void ClearData()
        {
            tbMaChuyenNganh.Text = string.Empty;
            tbTenChuyenNganh.Text = string.Empty;
            cbbKhoa.SelectedIndex = -1;
        }

        /* trả về số dòng hiện tại trong DGV dạng string */
        string getNumRowsDGV()
        {
            return Convert.ToString(dgvChuyenNganh.Rows.Count - 1);
        }
    }
}
