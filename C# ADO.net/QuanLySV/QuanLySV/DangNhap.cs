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
using System.IO;



namespace QuanLySV
{
    public partial class DangNhap : Form
    {
        /*MACRO*/
        // @LOGIN_FAILED : trạng thái đăng nhập thất bại
        // @LOGIN_WITH_ADMIN : trạng thái đăng nhập với tư cách ADMIN
        // @LOGIN_WITH_SINHVIEN : trạng thái đăng nhập tư cách SINHVIEN
        // @EXIT : Trạng thái thoát khỏi chương trình
        // @LOGOUT : Trạng thái đăng xuất tài khoản
        public static int LOGIN_FAILED = -1;
        public static int LOGIN_WITH_ADMIN = 0;
        public static int LOGIN_WITH_SINHVIEN = 1;
        public static int EXIT = 2;
        public static int LOGOUT = 3;

        /*PROPERTY*/
        // @LoginResult: Trạng thái đăng nhập, nhận 1 trong 3 giá trị được MACRO ở trên
        // @NameUser: Tên tài khoản của user đăng nhập thành công.
        public int LoginResult;
        public string NameUser;
        /*---------------------------------------------------------------------*/
        /* Hàm khởi tạo form */
        public DangNhap()
        {
            LoginResult = LOGIN_FAILED; // Khởi tạo trạng thái đăng nhập là thất bại, chưa đăng nhập (LOGIN_FAILED = -1)
            NameUser = string.Empty; // Khởi tạo tên tài khoản của user đăng nhập bằng EMPTY
            InitializeComponent();
        }

        /* Đăng nhập với tư cách ADMIN */
        void Login_with_ADMIN(string tk, string mk)
        {
            string query = @"SELECT COUNT(*) FROM _ADMIN
                            WHERE tai_khoan ='" + tk + "' AND mat_khau = '" + mk + "'";
            DB.conn.Open();
            SqlCommand cmd = new SqlCommand(query, DB.conn);
            int result = Convert.ToInt32(cmd.ExecuteScalar().ToString());
            DB.conn.Close();
            if (result != 0)
            {
                this.NameUser = tk;
                this.LoginResult = LOGIN_WITH_ADMIN; // Ghi nhận trạng thái đăng nhập với tư cách ADMIN
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
                tbMatKhau.Text = string.Empty;
            }
        }

        /* Đăng nhập với tư cách SINHVIEN */
        void Login_with_SINHVIEN(string tk, string mk)
        {
            string query = @" SELECT COUNT(*) FROM SINH_VIEN
                                WHERE ma_sv ='"+ tk +"' AND password_sv = '"+ mk + "'";
            DB.conn.Open();
            SqlCommand cmd = new SqlCommand(query, DB.conn);
            int result = Convert.ToInt32(cmd.ExecuteScalar().ToString());
            DB.conn.Close();
            if (result != 0)
            {
                this.NameUser = tk;
                this.LoginResult = LOGIN_WITH_SINHVIEN; // Ghi nhận trạng thái đăng nhập với tư cách SINHVIEN
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
                tbMatKhau.Text = string.Empty;
            }
        }

        /* Sự kiện click button đăng nhập */
        private void btDangNhap_Click(object sender, EventArgs e)
        {
            string tk = tbTaiKhoan.Text;
            string mk = tbMatKhau.Text;


            if (tk == string.Empty && mk == string.Empty) // CASE-LV1: Tài khoản và mật khẩu EMPTY
            {
                MessageBox.Show("Vui lòng nhập tài khoản và mật khẩu!");
            }
            else if(tk == string.Empty) //CASE-LV1: Tài khoản EMPTY
            {
                MessageBox.Show("Vui lòng nhập tài khoản!");
            }
            else if (mk == string.Empty) //CASE-LV1: mật khẩu EMPTY
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!");
            }
            else //CASE-LV1: Tài khoản và mật khẩu đầy đủ
            {
                if (rbtAdmin.Checked) // CASE-LV2: Đăng nhập với tư cách ADMIN
                {
                    Login_with_ADMIN(tk, mk); // Gọi hàm query với ADMIN
                    Write_file_RBTResult(); //Ghi nhận trạng thái của RadioButton gần nhất được check là "rbtAdmin"
                }
                else if(rbtSinhVien.Checked) // CASE-LV2: Đăng nhập với tư cách SINHVIEN
                {
                    Login_with_SINHVIEN(tk, mk); // Gọi hàm query với SINHVIEN
                    Write_file_RBTResult(); //Ghi nhận trạng thái của RadioButton gần nhất được check là "rbtSinhVien"
                }
                else // CASE-LV2: Chưa chọn đăng nhập với tư cách gì
                {
                    MessageBox.Show("Vui lòng đăng nhập với tư cách?");
                }
            }

            if (cbLuuTaiKhoan.Checked) // CASE-LV1: Nếu combobox lưu tài khoản được check khi đăng nhập thì ghi file
            {
                Write_file(tbTaiKhoan.Text, tbMatKhau.Text); // Gọi hàm ghi file
            }
            else /* Ngược lại không ghi file */
            {
                Write_file(); // Gọi hàm ghi file không đối số (Ngầm định "", "")
            }
            


            if (this.LoginResult != LOGIN_FAILED) // CASE-LV1: Kiểm tra đăng nhập có thành công không, nếu có thì đóng form đăng nhập lại
            {
                this.Close();
            }

        }

        /* Sự kiện click button thoát */
        private void btThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đóng chương trình?", "Message", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                LoginResult = LOGIN_FAILED; // Ghi nhận trạng thái đăng nhập thất bại
                this.Close();
            }
        }

        /* Đọc tài khoản và mật khẩu từ file (binary) */
        void Read_file(ref string tk, ref string mk)
        {
            BinaryReader br;
            string filePath = "../../file-txt/user-passwork.dat";
            //reading from the file
            try
            {
                br = new BinaryReader(new FileStream(filePath, FileMode.Open));
                tk = br.ReadString(); // Gán string vừa đọc đầu tiên cho tk
                mk = br.ReadString(); // Gán string vừa đọc thứ hai cho mk
            }
            catch (IOException e) // Đọc file thất bại
            {
                tk = string.Empty; // Gán tk = EMPTY
                mk = string.Empty; // Gán mk = EMPTY
                return;
            }
            br.Close();
        }

        /* Ghi tài khoản và mật khẩu xuống file (binary) */
        void Write_file(string tk = "", string mk = "")
        {
            BinaryWriter bw;
            string filePath = "../../file-txt/user-passwork.dat";
            // writing into the file
            try
            {
                bw = new BinaryWriter(new FileStream(filePath, FileMode.OpenOrCreate));
                bw.Write(tk); // Ghi tk xuống file đầu tiên
                bw.Write(mk); // Ghi mk xuống file thứ hai
            }
            catch (IOException e)
            {
                return;
            }
            bw.Close();
        }

        /* Đọc và trả về trạng thái RadioButton ghi gần nhất từ file */
        int Read_file_RBTResult()
        {
            BinaryReader br;
            int result = -1;
            string filePath = "../../file-txt/rbt-status.dat";
            //reading from the file
            try
            {
                br = new BinaryReader(new FileStream(filePath, FileMode.Open));
                result = br.ReadInt32(); // Đọc trạng thái RadioButton ghi gần nhất
            }
            catch (IOException e) // Đọc file thất bại
            {
                return LOGIN_FAILED;// Trả về trạng thái check thất bại (không check RadioButton nào)
            }
            br.Close();
            return result;
        }

        /* Ghi trạng thái RadioButton ghi gần nhất xuống file */
        void Write_file_RBTResult()
        {
            BinaryWriter bw;
            string filePath = "../../file-txt/rbt-status.dat";
            // writing into the file
            try
            {
                bw = new BinaryWriter(new FileStream(filePath, FileMode.OpenOrCreate));
                if (rbtAdmin.Checked) // CASE-LV1: Ghi trạng thái RadioButton đang click là "ADMIN" xuống file
                {
                    bw.Write(LOGIN_WITH_ADMIN);
                }
                else if(rbtSinhVien.Checked) // CASE-LV1: Ghi trạng thái RadioButton đang click là "SINHVIEN" xuống file
                {
                    bw.Write(LOGIN_WITH_SINHVIEN);
                }
                else // CASE-LV1: Ghi trạng thái RadioButton chưa click gì xuống file
                {
                    bw.Write(LOGIN_FAILED);
                }
            }
            catch (IOException e)
            {
                return;
            }
            bw.Close();
        }




        /* Sự kiện click vào checkbox hiển thị mật khẩu */
        private void cbHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHienMatKhau.Checked) // CASE: hiển thị mật khẩu
            {
                tbMatKhau.UseSystemPasswordChar = false;
            }
            else // CASE: Ẩn mật khẩu thành kí tự (*)
            {
                tbMatKhau.UseSystemPasswordChar = true;
            }
        }

        /* Sự kiện form đăng nhập load */
        private void DangNhap_Load(object sender, EventArgs e)
        {
            string tk = "";
            string mk = "";
            /* Đọc tk và mk từ file */
            Read_file(ref tk, ref mk);
            if(tk != string.Empty || mk != string.Empty) //CASE-LV1: Nếu tk và mk được đọc từ file lên ko rỗng (Thành công)
            {
                cbLuuTaiKhoan.Checked = true;
            }
            tbTaiKhoan.Text = tk;
            tbMatKhau.Text = mk;
            /**/
            tbMatKhau.UseSystemPasswordChar = true; // Ẩn mật khẩu thành kí tự (*)
            /* Đọc trạng thái RadioButton từ file */
            int result = Read_file_RBTResult();
            if(result == LOGIN_WITH_ADMIN) // CASE-LV1: Trạng thái gần nhất là đăng nhập với ADMIN (result = 0)
            {
                rbtAdmin.Checked = true;
            }
            else if(result == LOGIN_WITH_SINHVIEN)// CASE-LV1: Trạng thái gần nhất là đăng nhập với SINHVIEN (result = 1)
            { 
                rbtSinhVien.Checked = true;
            }
            else //CASE-LV1: Đọc trạng thái lỗi (result = -1)
            {
                rbtAdmin.Checked = false;
                rbtSinhVien.Checked = false;

            }
        }

        private void llbDangKiTaiKhoan_click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DangKiTaiKhoan dktk = new DangKiTaiKhoan();
            this.Hide();
            dktk.ShowDialog();
            dktk.Close();
            this.Show();
        }
    }
}
