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
    public partial class DangKiTaiKhoan : Form
    {
        public DangKiTaiKhoan()
        {
            InitializeComponent();
        }
        void clearMK()
        {
            tbMK1.Text = string.Empty;
            tbMK2.Text = string.Empty;
        }
        void clearTB()
        {
            tbMaSV.Text = string.Empty;
            tbTenSV.Text = string.Empty;
            clearMK();
        }
        private void btHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btDangKi_Click_1(object sender, EventArgs e)
        {
            string masv = tbMaSV.Text;
            string tensv = tbTenSV.Text;
            string mk1 = tbMK1.Text;
            string mk2 = tbMK2.Text;
            if (masv == string.Empty ||
                tensv == string.Empty ||
                mk1 == string.Empty ||
                mk2 == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Wanning!", MessageBoxButtons.OK);
                return;
            }


            if (mk1 != mk2)
            {
                MessageBox.Show("Hai mật khẩu không trùng nhau!", "Wanning!", MessageBoxButtons.OK);
                clearMK();
                return;
            }



            string query = @"INSERT SINH_VIEN(ma_sv,ten_sv,password_sv) 
                            VALUES ('" + masv + "',N'" + tensv + "','" + mk1 + "')";

            bool status = true;
            try
            {
                DB.conn.Open();
                SqlCommand cmd = new SqlCommand(query, DB.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Đăng kí tài khoản thành công!", "Message!", MessageBoxButtons.OK);
                clearTB();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mã sinh viên này đã có người dùng, vui lòng dùng mã khác!" + ex.Message, "Error", MessageBoxButtons.OK);
                status = false;
            }
            finally
            {
                DB.conn.Close();
            }

            if (status)
            {
                try
                {
                    DB.conn.Open();
                    string insertDiemRenLuyen = @"INSERT DIEM_REN_LUYEN(ma_sv) 
                                                   VALUES ('" + masv + "')";
                    SqlCommand cmd = new SqlCommand(insertDiemRenLuyen, DB.conn);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                }
                finally
                {
                    DB.conn.Close();
                }
            }
        }
    }
}
