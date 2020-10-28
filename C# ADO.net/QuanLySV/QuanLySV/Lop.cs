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
    public partial class Lop : Form
    {
        /* Property */
        // @GiangVienDic: cấu trúc dữ liệu lưu một list dạng key(string)-value(CGiaoVien)
        // @ChuyenNganhDic: cấu trúc dữ liệu lưu một list dạng key(string)-value(CChuyenNganh)
        private Dictionary<string, CGiaoVien> GiangVienDic;
        private Dictionary<string, CChuyenNganh> ChuyenNganhDic;

        public Lop()
        {
            InitializeComponent();
        }

        /* Sự kiện load form */
        private void Lop_Load(object sender, EventArgs e)
        {
            cbbGiaoVien.DisplayMember = "Ten_gv";
            cbbGiaoVien.ValueMember = "Ma_gv";

            cbbChuyenNganh.DisplayMember = "Ten_cn";
            cbbChuyenNganh.ValueMember = "Ma_cn";


            GetData();
            GetCBB_GiangVien();
            GetCBB_ChuyenNganh();
            lbNumRows.Text = getNumRowsDGV();
        }

        /* Sự kiện click vào một dòng trên DGV */
        private void dgvLop_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            tbMaLop.Text = dgvLop.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbTenLop.Text = dgvLop.Rows[e.RowIndex].Cells[2].Value.ToString();
            string MaGV = dgvLop.Rows[e.RowIndex].Cells[3].Value.ToString();
            string MaCN = dgvLop.Rows[e.RowIndex].Cells[4].Value.ToString();

            if (GiangVienDic.ContainsKey(MaGV))
            {
                cbbGiaoVien.SelectedItem = GiangVienDic[MaGV];
            }
            else
            {
                cbbGiaoVien.SelectedIndex = -1;
            }


            if (ChuyenNganhDic.ContainsKey(MaCN))
            {
                cbbChuyenNganh.SelectedItem = ChuyenNganhDic[MaCN];
            }
            else
            {
                cbbChuyenNganh.SelectedIndex = -1;
            }
        }

        /* Sự kiện click button thêm */
        private void btThem_Click(object sender, EventArgs e)
        {
            string ma_lop = tbMaLop.Text;
            string ten_lop = tbTenLop.Text;
            if (ma_lop == string.Empty || ten_lop == string.Empty 
                || cbbGiaoVien.SelectedIndex == -1 || cbbChuyenNganh.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin !", "Warning");
                return;
            }
            string ma_gv = ((CGiaoVien)cbbGiaoVien.SelectedItem).Ma_gv;
            string ma_cn = ((CChuyenNganh)cbbChuyenNganh.SelectedItem).Ma_cn;

            string query = @"INSERT INTO LOP(ma_lop, ten_lop, ma_gv, ma_cn)
                                VALUES('"+ ma_lop + "', N'"+ ten_lop + "', '"+ ma_gv + "', '"+ ma_cn + "')";


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
            string ma_lop = tbMaLop.Text;
            string ten_lop = tbTenLop.Text;
            if (ma_lop == string.Empty || ten_lop == string.Empty
                || cbbGiaoVien.SelectedIndex == -1 || cbbChuyenNganh.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin !", "Warning");
                return;
            }
            string ma_gv = ((CGiaoVien)cbbGiaoVien.SelectedItem).Ma_gv;
            string ma_cn = ((CChuyenNganh)cbbChuyenNganh.SelectedItem).Ma_cn;

            string query = @"UPDATE LOP SET ten_lop = N'"+ ten_lop + "', ma_gv = '"+ ma_gv + "', ma_cn = '"+ ma_cn + "' WHERE ma_lop = '"+ ma_lop +"'";
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
            string ma_lop = tbMaLop.Text;

            if (ma_lop == string.Empty)
            {
                MessageBox.Show("Vui lòng chọn đối tượng xóa !", "Warning");
                return;
            }
            string query = @"DELETE LOP WHERE ma_lop = '"+ ma_lop + "'";
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
            string select_query = @"SELECT ROW_NUMBER() OVER (ORDER BY ma_lop) AS [STT], ma_lop AS N'Mã lớp', ten_lop AS N'Tên lớp', LOP.ma_gv AS N'Giáo viên chủ nhiệm', LOP.ma_cn AS N'Chuyên ngành'
                                    FROM LOP, GIANG_VIEN, CHUYEN_NGANH
                                    WHERE (ma_lop LIKE '%"+ key + "%' OR ten_lop LIKE N'%"+ key + "%' OR LOP.ma_gv LIKE '%"+ key + "%' OR LOP.ma_cn LIKE '%"+ key + "%' OR GIANG_VIEN.ten_gv LIKE N'%"+ key + "%' OR CHUYEN_NGANH.ten_cn LIKE N'%"+ key + "%') AND LOP.ma_gv = GIANG_VIEN.ma_gv AND LOP.ma_cn = CHUYEN_NGANH.ma_cn";
            SqlDataAdapter adapter = new SqlDataAdapter(select_query, DB.conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Lop");
            dgvLop.DataSource = null;
            dgvLop.DataSource = ds.Tables["Lop"];
            lbNumRows.Text = getNumRowsDGV();
        }






        /* --------------------------------------------- */
        /* Hàm load dữ liệu giảng viên lên CBB */
        void GetCBB_GiangVien()
        {
            string query = "SELECT ma_gv, ten_gv FROM GIANG_VIEN";
            DB.conn.Open();
            SqlCommand cmd = new SqlCommand(query, DB.conn);
            SqlDataReader rd = cmd.ExecuteReader();
            GiangVienDic = new Dictionary<string, CGiaoVien>();
            while (rd.Read())
            {
                CGiaoVien gv = new CGiaoVien(rd[0].ToString(), rd[1].ToString());
                cbbGiaoVien.Items.Add(gv);
                GiangVienDic[gv.Ma_gv] = gv;

            }
            DB.conn.Close();
        }

        /* Hàm load dữ liệu chuyên ngành lên CBB */
        void GetCBB_ChuyenNganh()
        {
            string query = "SELECT ma_cn, ten_cn FROM CHUYEN_NGANH";
            DB.conn.Open();
            SqlCommand cmd = new SqlCommand(query, DB.conn);
            SqlDataReader rd = cmd.ExecuteReader();
            ChuyenNganhDic = new Dictionary<string, CChuyenNganh>();
            while (rd.Read())
            {
                CChuyenNganh cn = new CChuyenNganh(rd[0].ToString(), rd[1].ToString());
                cbbChuyenNganh.Items.Add(cn);
                ChuyenNganhDic[cn.Ma_cn] = cn;

            }
            DB.conn.Close();
        }

        /* Hàm load data lên DGV */
        void GetData()
        {
            string select_query = @"SELECT ROW_NUMBER() OVER (ORDER BY ma_lop) AS [STT], ma_lop AS N'Mã lớp', ten_lop AS N'Tên lớp', ma_gv AS N'Giáo viên chủ nhiệm', ma_cn AS N'Chuyên ngành'
                                        FROM LOP";
            SqlDataAdapter adapter = new SqlDataAdapter(select_query, DB.conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Lop");
            dgvLop.DataSource = null;
            dgvLop.DataSource = ds.Tables["Lop"];
        }

        /* Hàm xóa dữ liệu trên textbox và combobox*/
        void ClearData()
        {
            tbMaLop.Text = string.Empty;
            tbTenLop.Text = string.Empty;
            cbbGiaoVien.SelectedIndex = -1;
            cbbChuyenNganh.SelectedIndex = -1;
        }

        /* trả về số dòng hiện tại trong DGV dạng string */
        string getNumRowsDGV()
        {
            return Convert.ToString(dgvLop.Rows.Count - 1);
        }
    }
}
