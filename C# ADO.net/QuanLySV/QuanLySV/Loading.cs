using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace QuanLySV
{
    public partial class MenuLoading : Form
    {
        /*PROPERTY*/
        // @admin: Form ADMIN
        // @sinhvien: Form SINHVIEN
        public MenuADMIN admin = null;
        //public MenuSINHVIEN sinhvien;
        public MenuSinhVien sinhvien = null;
        /*---------------------------------------------------------------------*/
        public MenuLoading()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            Login();
        }
        private void Login()
        {
            this.Hide();
            DangNhap dn = new DangNhap();
            dn.ShowDialog();
            if (dn.LoginResult == DangNhap.LOGIN_FAILED) // CASE-LV1: Ấn nút thoát ở form DangNhap
            {
                this.Close();
            }
            else // CASE-LV1: Đăng nhập thành công
            {
                this.Show(); // Hiển thị form loading hiện tại
                if (dn.LoginResult == DangNhap.LOGIN_WITH_ADMIN) // CASE-LV2: Đăng nhập với tư cách ADMIN
                {
                    MessageBox.Show("Hello " + '"' + dn.NameUser + '"' + ",\nBạn đang đăng nhập với quyền của ADMIN,\nChọn OK để tiếp tục!", "Thông báo");
                    this.Hide();

                    admin = new MenuADMIN(dn.NameUser);
                    admin.ShowDialog();

                    if (admin.LoginStatus == DangNhap.EXIT) // CASE-LV3: Thoát form ADMIN, thoát khỏi chương trình
                    {
                        this.Close();
                    }
                    else // (admin.LoginStatus == DangNhap.LOGOUT) CASE-LV3: Thoát form ADMIN, đăng xuất khỏi chương trình 
                    {
                        admin = null;
                        Login();
                    }
                }
                else // CASE-LV2: Đăng nhập với tư cách SINH_VIEN
                {
                    MessageBox.Show("Hello " + '"' + dn.NameUser + '"' + ",\nBạn đang đăng nhập với quyền của SINHVIEN,\nChọn OK để tiếp tục!", "Thông báo");

                    this.Hide();

                    sinhvien = new MenuSinhVien(dn.NameUser);
                    sinhvien.ShowDialog();

                    if (sinhvien.LoginStatus == DangNhap.EXIT) // CASE-LV3: Thoát form ADMIN, thoát khỏi chương trình
                    {
                        this.Close();
                    }
                    else // (admin.LoginStatus == DangNhap.LOGOUT) CASE-LV3: Thoát form ADMIN, đăng xuất khỏi chương trình 
                    {
                        sinhvien = null;
                        Login();
                    }
                }
            }
        }
    }
}
