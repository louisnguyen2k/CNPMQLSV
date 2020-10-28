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
    public partial class sv : Form
    {
        public sv()
        {
            InitializeComponent();
        }

        private void DSSinhVien_Load(object sender, EventArgs e)
        {
            GetData();
            lbNumRows.Text = getNumRowsDGV();
        }




        /*-----------------------------------*/
        /* Hàm load data lên DGV */
        void GetData()
        {
            string select_query = @"SELECT ROW_NUMBER() OVER (ORDER BY ma_sv) AS [STT],
	                                ma_sv AS N'Mã sinh viên',
	                                ten_sv AS N'Tên sinh viên',
	                                gioitinh_sv AS N'Giới tính',
	                                sdt_sv AS N'SĐT',
	                                email_sv AS N'Email',
	                                ngay_sinh_sv AS N'Ngày sinh',
	                                cmnd_sv AS N'CMND',
	                                dia_chi_sv AS N'Địa chỉ'
                                FROM SINH_VIEN";
            SqlDataAdapter adapter = new SqlDataAdapter(select_query, DB.conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "DSSinhVien");
            dgvDSSinhVien.DataSource = null;
            dgvDSSinhVien.DataSource = ds.Tables["DSSinhVien"];
        }

        /* trả về số dòng hiện tại trong DGV dạng string */
        string getNumRowsDGV()
        {
            return Convert.ToString(dgvDSSinhVien.Rows.Count - 1);
        }
    }
}
