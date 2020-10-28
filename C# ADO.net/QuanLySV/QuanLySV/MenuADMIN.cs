using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySV
{
    public partial class MenuADMIN : Form
    {

        /*PROPERTY*/
        // @LoginStatus: Trạng thái đăng nhập, nhận 1 trong 3 giá trị được MACRO ở trên
        // @NameUser: Tên tài khoản của user đăng nhập thành công.
        // @Date: Thời gian hiện tại của hệ thống.
        public int LoginStatus;
        public string NameUser;
        public string Date;
        /**/
        public MenuADMIN(string name)
        {
            LoginStatus = DangNhap.EXIT;
            NameUser = name;
            Date = DateTime.Now.ToString("dd-MM-yyyy");
            InitializeComponent();
        }

        /* ------------- Các sự kiện hệ thống ------------- */



        /* Sự kiện load form */
        private void MenuADMIN_Load(object sender, EventArgs e)
        {
            lbName.Text = this.NameUser;
            lbDate.Text = this.Date;
        }

        /* Sự kiện click nút thoát */
        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đóng chương trình?", "Message", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                LoginStatus = DangNhap.EXIT; // Ghi nhận trạng thái thoát khỏi chương trình
                this.Close();
            }
        }

        /* Sự kiện click nút đăng xuất */
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đăng xuất?", "Message", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                LoginStatus = DangNhap.LOGOUT; // Ghi nhận trạng thái thoát khỏi chương trình
                this.Close();
            }
        }

        /*  Sự kiện click label_link tương tự sự kiện click nút Logout(đăng xuất) */
        private void llbLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đăng xuất?", "Message", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                LoginStatus = DangNhap.LOGOUT; // Ghi nhận trạng thái thoát khỏi chương trình
                this.Close();
            }
        }

        /* Sự kiện click button đổi mật khẩu */
        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoiMatKhau dmk = new DoiMatKhau(NameUser, DangNhap.LOGIN_WITH_ADMIN);
            dmk.ShowDialog();
            dmk.Close();
        }

        /* click chức năng thông tin phần mềm */
        private void ThôngtinphầnmềmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Open_DangPhatTrien();
        }

        /* click chức năng trợ giúp */
        private void trợGiúpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Open_DangPhatTrien();
        }

        /* click button bậc đào tạo */
        private void btBacDaoTao_Click(object sender, EventArgs e)
        {
            Open_BacDaoTao();
        }

        /* click chức năng bậc đào tạo*/
        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Open_BacDaoTao();
        }

        /* click chức năng khoa */
        private void KhoaStripMenuItem_Click(object sender, EventArgs e)
        {
            Open_Khoa();
        }

        /* click button khoa */
        private void btKhoa_Click(object sender, EventArgs e)
        {
            Open_Khoa();
        }

        /* click button chuyên ngành */
        private void btChuyenNganh_Click(object sender, EventArgs e)
        {
            Open_ChuyenNganh();
        }

        /* click chức năng chuyên ngành */
        private void ChuyenNganhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Open_ChuyenNganh();
        }

        /* click button giảng viên */
        private void btGiangVien_Click(object sender, EventArgs e)
        {
            Open_GiangVien();
        }

        /* click chức năng giảng viên */
        private void giảngViênToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Open_GiangVien();
        }

        /* click button lớp */
        private void btLop_Click(object sender, EventArgs e)
        {
            Open_Lop();
        }

        /* click chức năng lớp */
        private void LopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Open_Lop();
        }

        /* click button môn học */
        private void btMonHoc_Click(object sender, EventArgs e)
        {
            Open_MonHoc();
        }

        /* click chức năng môn học */
        private void mônHọcToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Open_MonHoc();
        }

        /* click button DK môn học */
        private void btDKMH_Click(object sender, EventArgs e)
        {
            Open_DKMonHoc();
        }

        /* click chức năng DK môn học */
        private void đăngKíMônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Open_DKMonHoc();
        }

        /* click button danh sách sinh viên */
        private void btSinhVien_Click(object sender, EventArgs e)
        {
            Open_DS_SinhVien();
        }

        /* click chức năng danh sách sinh viên */
        private void danhSáchSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Open_DS_SinhVien();
        }

        /* click button thống kê tích lũy sinh viên */
        private void btDiemTichLuy_Click(object sender, EventArgs e)
        {
            Open_TichLuySV();
        }

        /* click chức năng thống kê tích lũy sinh viên */
        private void điểmSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Open_TichLuySV();
        }

        /* click button thống kê điểm rèn luyện sinh viên */
        private void btDiemRenLuyen_Click(object sender, EventArgs e)
        {
            Open_RenLuyenSV();
        }

        /* click chức năng thống kê điểm rèn luyện sinh viên */
        private void điểmRènLuyệnSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Open_RenLuyenSV();
        }




















        /* ------------- Các hàm mở form mới ------------- */

        /* Mở form đang phát triển */
        void Open_DangPhatTrien()
        {
            FormDangPhatTrien dpt = new FormDangPhatTrien();
            dpt.ShowDialog();
            dpt.Close();
        }

        /* Mở form bậc đào tạo */
        void Open_BacDaoTao()
        {
            BacDaoTao bdt = new BacDaoTao();
            bdt.ShowDialog();
            bdt.Close();
        }

        /* Mở form khoa */
        void Open_Khoa()
        {
            Khoa k = new Khoa();
            k.ShowDialog();
            k.Close();
        }

        /* Mở form chuyên ngành */
        void Open_ChuyenNganh()
        {
            ChuyenNganh cn = new ChuyenNganh();
            cn.ShowDialog();
            cn.Close();
        }

        /* Mở form giảng viên */
        void Open_GiangVien()
        {
            GiangVien gv = new GiangVien();
            gv.ShowDialog();
            gv.Close();
        }

        /* Mở form lớp */
        void Open_Lop()
        {
            Lop l = new Lop();
            l.ShowDialog();
            l.Close();
        }

        /* Mở form môn học */
        void Open_MonHoc()
        {
            MonHoc mh = new MonHoc();
            mh.ShowDialog();
            mh.Close();
        }

        /* Mở form DK môn học */
        void Open_DKMonHoc()
        {
            DangKiMonHoc dkmh = new DangKiMonHoc();
            dkmh.ShowDialog();
            dkmh.Close();
        }

        /* Mở form danh sách sinh viên */
        void Open_DS_SinhVien()
        {
            DanhSachSV dssv = new DanhSachSV();
            dssv.ShowDialog();
            dssv.Close();
        }

        /* Mở form thống kê điểm tích lũy sinh viên */
        void Open_TichLuySV()
        {
            ThongKeDiemTichLuy thongKeDiemTichLuy = new ThongKeDiemTichLuy();
            thongKeDiemTichLuy.ShowDialog();
        }

        /* Mở form thống kê điểm rèn luyện sinh viên */
        void Open_RenLuyenSV()
        {
            ThongKeDiemRenLuyen thongKeDiemRenLuyen = new ThongKeDiemRenLuyen();
            thongKeDiemRenLuyen.ShowDialog();
        }







    }
}
