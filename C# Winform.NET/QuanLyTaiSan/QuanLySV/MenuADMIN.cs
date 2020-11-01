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
    public partial class MenuADMIN : Form
    {

        /*PROPERTY*/
        // @NameUser: Tên tài khoản của user đăng nhập thành công.
        // @IdUser: ID tài khoản của user đăng nhập thành công.
        // @Date: Thời gian hiện tại của hệ thống.
        public string NameUser;
        public string IDUser;
        public string Date;
        /**/

        /* ------------- Các sự kiện hệ thống ------------- */

        // Hàm khởi tạo
        public MenuADMIN()
        {
            Date = DateTime.Now.ToString("dd-MM-yyyy");
            InitializeComponent();
        }

        /* Sự kiện load form */
        private void MenuADMIN_Load(object sender, EventArgs e)
        {
            lbDate.Text = this.Date;
            Open_Login();
        }

        /* Sự kiện đổi mật khẩu */
        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Open_Change_Passwork();
        }

        /* Sự kiện click nút thoát */
        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exit();
        }

        /* Sự kiện click nút đăng xuất */
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logout();
        }

        /*  Sự kiện click label_link tương tự sự kiện click nút Logout(đăng xuất) */
        private void llbLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Logout();
        }




        /*------------- Hàm sử lý các sự kiện -------------*/


        /* Hàm sử lý sự kiện đăng xuất */
        void Logout()
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đăng xuất?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Open_Login();
            }
        }

        /* Hàm sử lý sự kiệt thoát(đóng form) */
        void Exit()
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đóng chương trình?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        /* Hàm trả về tên của người dùng theo ID */
        string getName()
        {
            string query = @"SELECT name FROM TaiKhoan
                    WHERE taikhoan = '" + IDUser + "'";
            DB.conn.Open();

            string name = string.Empty;
            try
            {
                SqlCommand cmd = new SqlCommand(query, DB.conn);

                name = cmd.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }

            DB.conn.Close();

            return name;
        }









        /* ------------- Các hàm mở form mới ------------- */

        /* Hàm mở form đăng nhập và lấy id vừa đăng nhập gán cho id của form Menu */
        void Open_Login()
        {
            DangNhap dn = new DangNhap();
            dn.ShowDialog();
            if (dn.LoginResult == DangNhap.LOGIN_FAILED)
            {
                this.Close();
            }
            else
            {
                this.IDUser = dn.IDUser; // gán id login NameUser vừa đăng nhập vào id Menu NameUser
                this.NameUser = getName();
                lbName.Text = this.NameUser;
                dn.Close();
                MessageBox.Show("Hello " + NameUser + "!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /* Hàm mở form đổi mật khẩu */
        void Open_Change_Passwork()
        {
            DoiMatKhau dmk = new DoiMatKhau(IDUser);
            dmk.ShowDialog();
            dmk.Close();
        }







    }
}
