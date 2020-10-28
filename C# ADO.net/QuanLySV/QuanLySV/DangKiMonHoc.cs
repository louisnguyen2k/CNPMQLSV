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
    public partial class DangKiMonHoc : Form
    {
        /* Property */
        // @MonHocDic: cấu trúc dữ liệu lưu một list dạng key(string)-value(CMonHoc)
        // @LopDic: cấu trúc dữ liệu lưu một list dạng key(string)-value(CLop)
        private Dictionary<string, CMonHoc> MonHocDic;
        private Dictionary<string, CLop> LopDic;

        public DangKiMonHoc()
        {
            InitializeComponent();
        }

        /* Sự kiện load form */
        private void DangKiMonHoc_Load(object sender, EventArgs e)
        {
            cbbMonHoc.DisplayMember = "Ten_mh";
            cbbMonHoc.ValueMember = "Ma_mh";

            cbbLop.DisplayMember = "Ten_lop";
            cbbLop.ValueMember = "Ma_lop";


            GetData();
            GetCBB_MonHoc();
            GetCBB_Lop();
            lbNumRows.Text = getNumRowsDGV();
        }

        /* Sự kiện click vào một dòng trên DGV */
        private void dgvDKMH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            string MaMH = dgvDKMH.Rows[e.RowIndex].Cells[1].Value.ToString();
            string MaLop = dgvDKMH.Rows[e.RowIndex].Cells[2].Value.ToString();
            tbKiHoc.Text = dgvDKMH.Rows[e.RowIndex].Cells[3].Value.ToString();
            tbTrangThaiMH.Text = dgvDKMH.Rows[e.RowIndex].Cells[4].Value.ToString();

            if (MonHocDic.ContainsKey(MaMH))
            {
                cbbMonHoc.SelectedItem = MonHocDic[MaMH];
            }
            else
            {
                cbbMonHoc.SelectedIndex = -1;
            }


            if (LopDic.ContainsKey(MaLop))
            {
                cbbLop.SelectedItem = LopDic[MaLop];
            }
            else
            {
                cbbLop.SelectedIndex = -1;
            }
        }

        /* Sự kiện click button thêm */
        private void btThem_Click(object sender, EventArgs e)
        {
            string ki_hoc = tbKiHoc.Text;
            string trang_thai_mh = tbTrangThaiMH.Text;
            if (ki_hoc == string.Empty || trang_thai_mh == string.Empty
                || cbbMonHoc.SelectedIndex == -1 || cbbLop.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin !", "Warning");
                return;
            }
            string ma_mh = ((CMonHoc)cbbMonHoc.SelectedItem).Ma_mh;
            string ma_lop = ((CLop)cbbLop.SelectedItem).Ma_lop;

            string query = @"INSERT INTO CHI_TIET_MON_HOC(ma_mh, ma_lop, ki_hoc, trang_thai_mh)
                            VALUES('"+ ma_mh + "', '"+ ma_lop + "', "+ ki_hoc + ", N'"+ trang_thai_mh + "')";


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
            string ki_hoc = tbKiHoc.Text;
            string trang_thai_mh = tbTrangThaiMH.Text;
            if (ki_hoc == string.Empty || trang_thai_mh == string.Empty
                || cbbMonHoc.SelectedIndex == -1 || cbbLop.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin !", "Warning");
                return;
            }
            string ma_mh = ((CMonHoc)cbbMonHoc.SelectedItem).Ma_mh;
            string ma_lop = ((CLop)cbbLop.SelectedItem).Ma_lop;

            string query = @"UPDATE CHI_TIET_MON_HOC SET  ki_hoc = "+ ki_hoc + ", trang_thai_mh = '"+ trang_thai_mh + "' WHERE ma_mh = '"+ ma_mh + "' AND ma_lop = '"+ ma_lop + "'";
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
            string ki_hoc = tbKiHoc.Text;
            string trang_thai_mh = tbTrangThaiMH.Text;
            if (ki_hoc == string.Empty || trang_thai_mh == string.Empty ||
                cbbMonHoc.SelectedIndex == -1 || cbbLop.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn đối tượng xóa !", "Warning");
                return;
            }

            string ma_mh = ((CMonHoc)cbbMonHoc.SelectedItem).Ma_mh;
            string ma_lop = ((CLop)cbbLop.SelectedItem).Ma_lop;

            string query = @"DELETE CHI_TIET_MON_HOC WHERE ma_mh = '"+ ma_mh + "' AND  ma_lop = '"+ ma_lop + "'";
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
            string select_query = @"SELECT ROW_NUMBER() OVER (ORDER BY CTMH.ma_mh, CTMH.ma_lop) AS [STT],
	                                    CTMH.ma_mh AS N'Mã môn học',
	                                    CTMH.ma_lop AS N'Mã lớp',
	                                    ki_hoc AS N'Kì học',
	                                    trang_thai_mh AS N'Trạng thái môn học'
                                    FROM CHI_TIET_MON_HOC AS CTMH,
	                                    MON_HOC AS MH,
	                                    LOP AS L
	                                    WHERE CTMH.ma_mh = MH.ma_mh
                                    AND CTMH.ma_lop = L.ma_lop
                                    AND(CTMH.ma_mh LIKE '%"+ key + "%' OR MH.ten_mh LIKE N'%"+ key + "%' OR CTMH.ma_lop LIKE '%"+ key + "%' OR L.ten_lop LIKE N'%"+ key + "%' OR trang_thai_mh LIKE N'%"+ key + "%')";
            SqlDataAdapter adapter = new SqlDataAdapter(select_query, DB.conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "DKMH");
            dgvDKMH.DataSource = null;
            dgvDKMH.DataSource = ds.Tables["DKMH"];
            lbNumRows.Text = getNumRowsDGV();
        }





        /* Hàm load dữ liệu môn học lên CBB */
        void GetCBB_MonHoc()
        {
            string query = "SELECT ma_mh, ten_mh FROM MON_HOC";
            DB.conn.Open();
            SqlCommand cmd = new SqlCommand(query, DB.conn);
            SqlDataReader rd = cmd.ExecuteReader();
            MonHocDic = new Dictionary<string, CMonHoc>();
            while (rd.Read())
            {
                CMonHoc mh = new CMonHoc(rd[0].ToString(), rd[1].ToString());
                cbbMonHoc.Items.Add(mh);
                MonHocDic[mh.Ma_mh] = mh;

            }
            DB.conn.Close();
        }

        /* Hàm load dữ liệu lớp lên CBB */
        void GetCBB_Lop()
        {
            string query = "SELECT ma_lop, ten_lop FROM LOP";
            DB.conn.Open();
            SqlCommand cmd = new SqlCommand(query, DB.conn);
            SqlDataReader rd = cmd.ExecuteReader();
            LopDic = new Dictionary<string, CLop>();
            while (rd.Read())
            {
                CLop l = new CLop(rd[0].ToString(), rd[1].ToString());
                cbbLop.Items.Add(l);
                LopDic[l.Ma_lop] = l;

            }
            DB.conn.Close();
        }

        /* Hàm load data lên DGV */
        void GetData()
        {
            string select_query = @"SELECT ROW_NUMBER() OVER (ORDER BY CHI_TIET_MON_HOC.ma_mh, CHI_TIET_MON_HOC.ma_lop) AS [STT],
                                        ma_mh AS N'Mã môn học',
                                        ma_lop AS N'Mã lớp',
                                        ki_hoc AS N'Kì học',
                                        trang_thai_mh AS N'Trạng thái môn học'
                                        FROM CHI_TIET_MON_HOC";
            SqlDataAdapter adapter = new SqlDataAdapter(select_query, DB.conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "DKMH");
            dgvDKMH.DataSource = null;
            dgvDKMH.DataSource = ds.Tables["DKMH"];
        }

        /* Hàm xóa dữ liệu trên textbox và combobox*/
        void ClearData()
        {
            cbbMonHoc.SelectedIndex = -1;
            cbbLop.SelectedIndex = -1;
            tbKiHoc.Text = string.Empty;
            tbTrangThaiMH.Text = string.Empty;
        }

        /* trả về số dòng hiện tại trong DGV dạng string */
        string getNumRowsDGV()
        {
            return Convert.ToString(dgvDKMH.Rows.Count - 1);
        }
    }
}
