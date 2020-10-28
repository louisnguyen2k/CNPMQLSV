using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySV
{
    public partial class SuaThongTinGD : Form
    {
        string NameUser;
        public SuaThongTinGD(string NameUser)
        {
            InitializeComponent();
            this.NameUser = NameUser;
        }

        private void SuaThongTinGD_Load(object sender, EventArgs e)
        {
            Get_dataformDB();
        }
        /* Sự kiện load thông tin */
        void Get_dataformDB()
        {
            string query = @" SELECT ten_cha,ngay_sinh_cha,nghe_nghiep_cha,sdt_cha,quoc_tich_cha,
                              ten_me, ngay_sinh_me,nghe_nghiep_me,sdt_me,quoc_tich_me
                            FROM SINH_VIEN
                            WHERE ma_sv='"+NameUser+"'";
            SqlCommand cmd = new SqlCommand(query, DB.conn);
            DB.conn.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                tb_tencha.Text = rd[0].ToString();
                dtp_ngaysinhcha.Value = Convert.ToDateTime(rd[1].ToString());
                tb_nghenghiepcha.Text = rd[2].ToString();
                tb_sdtcha.Text = rd[3].ToString();
                tb_quoctichcha.Text = rd[4].ToString();
                tb_tenme.Text = rd[5].ToString();
                dtp_ngaysinhme.Value = Convert.ToDateTime(rd[6].ToString());
                tb_nghenghiepme.Text = rd[7].ToString();
                tb_sdtme.Text = rd[8].ToString();
                tb_quoctichme.Text = rd[9].ToString();
            }
            DB.conn.Close();
        }
        /*Sự kiện thoát*/
        private void bt_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /*Sự kiện lưu thông tin */
        private void bt_luu_Click(object sender, EventArgs e)
        {
            string ngay_sinh_cha = dtp_ngaysinhcha.Value.ToString();
            string ngay_sinh_me = dtp_ngaysinhme.Value.ToString();
            string query=@" UPDATE SINH_VIEN SET ten_cha=N'"+tb_tencha.Text+ "', ngay_sinh_cha='" + ngay_sinh_cha + "',nghe_nghiep_cha=N'" + tb_nghenghiepcha.Text+"',"+
                "sdt_cha='"+tb_sdtcha.Text+"', quoc_tich_cha=N'"+tb_quoctichcha.Text+"'," +
                "ten_me=N'"+tb_tenme.Text+"',nghe_nghiep_me=N'"+tb_nghenghiepme.Text+"',ngay_sinh_me='"+ ngay_sinh_me + "'," +
                "sdt_me='"+tb_sdtme.Text+"',quoc_tich_me=N'"+tb_quoctichme.Text+"'" +
                "WHERE ma_sv='"+NameUser+"'";
            try
            {
                if(tb_tencha.Text== string.Empty||tb_nghenghiepcha.Text==string.Empty||tb_sdtcha.Text==string.Empty||tb_quoctichcha.Text==string.Empty
                    ||tb_tenme.Text==string.Empty||tb_nghenghiepme.Text==string.Empty||tb_sdtme.Text==string.Empty||tb_quoctichme.Text==string.Empty)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin !", "Warning");
                    return;
                }
                SqlCommand cmd = new SqlCommand(query, DB.conn);
                DB.conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sửa thành công!!","Message");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Sửa thất bại, Exception: " + ex.Message, "Error");
            }
            finally
            {
                DB.conn.Close();
            } 
        }
    }
}
