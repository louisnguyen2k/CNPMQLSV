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
    public partial class MenuSinhVien : Form
    {
        /*PROPERTY*/
        // @LoginStatus: Trạng thái đăng nhập, nhận 1 trong 3 giá trị được MACRO ở trên
        // @NameUser: Tên tài khoản của user đăng nhập thành công.
        // @Date: Thời gian hiện tại của hệ thống
        // @SinhVien: OBJ đối tượng tương tác với form
        // @DiemRenLuyen: OBJ đối tượng tương tác với form
        private Dictionary<string, CMonHoc> MonHocDic;
        private Dictionary<string, CMonHoc> MonHocDic2;
        public int LoginStatus;
        public string NameUser;
        public string Date;
        private CSinhVien SinhVien;
        private CDiemRenLuyen DiemRenLuyen;
        /**/
        public MenuSinhVien(string name)
        {
            LoginStatus = DangNhap.EXIT;
            NameUser = name;
            Date = DateTime.Now.ToString("dd-MM-yyyy");
            InitializeComponent();
        }

        /* ------------- Các sự kiện hệ thống ------------- */

        private void MenuSinhVien_Load(object sender, EventArgs e)
        {
            lbName.Text = this.NameUser;
            lbDate.Text = this.Date;
            getDataSVToForm();
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
        private void btThoat_Click(object sender, EventArgs e)
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
        private void btDangXuat_Click(object sender, EventArgs e)
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
            DoiMatKhau dmk = new DoiMatKhau(NameUser, DangNhap.LOGIN_WITH_SINHVIEN);
            dmk.ShowDialog();
            dmk.Close();
        }
        private void btDoiMK_Click(object sender, EventArgs e)
        {
            DoiMatKhau dmk = new DoiMatKhau(NameUser, DangNhap.LOGIN_WITH_SINHVIEN);
            dmk.ShowDialog();
            dmk.Close();
        }
        /* click chức năng thông tin phần mềm */
        private void thôngTinPhầnMềmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Open_DangPhatTrien();
        }
        /* click chức năng trợ giúp */
        private void trợGiúpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Open_DangPhatTrien();
        }
        private void btTroGiup_Click(object sender, EventArgs e)
        {
            Open_DangPhatTrien();
        }

        /* ------------- Các hàm sử lý sự kiện ------------- */

        /* Load data từ DB vào một OBJ */
        void getDataSinhVienFromDB()
        {
            string query = @"SELECT * FROM SINH_VIEN
                            WHERE ma_sv = '"+ NameUser + "'";
            DB.conn.Open();
            SqlCommand cmd = new SqlCommand(query, DB.conn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                SinhVien = new CSinhVien(rd[0].ToString(), rd[1].ToString(), rd[2].ToString(), rd[3].ToString(), rd[4].ToString(), rd[5].ToString(), rd[6].ToString(), rd[7].ToString(), rd[8].ToString(), rd[9].ToString(), rd[10].ToString(), rd[11].ToString(), rd[12].ToString(), rd[13].ToString(), rd[14].ToString(), rd[15].ToString(), rd[16].ToString(), rd[17].ToString(), rd[18].ToString(), rd[19].ToString(), rd[20].ToString(), rd[21].ToString(), rd[22].ToString(), rd[23].ToString(), rd[24].ToString(), rd[25].ToString(), rd[26].ToString(), rd[27].ToString(), rd[28].ToString(), rd[29].ToString(), rd[30].ToString(), rd[32].ToString(), rd[33].ToString(), rd[34].ToString(), rd[35].ToString(), rd[36].ToString(), rd[37].ToString(), rd[38].ToString(), rd[39].ToString(), rd[40].ToString(), rd[41].ToString());
            }
            DB.conn.Close();
        }
        /* Load ảnh từ DB lên Form*/
        void getPicture()
        {
            string query = "SELECT link_img_sv FROM SINH_VIEN WHERE ma_sv='" + NameUser + "'";
            try
            {
                DB.conn.Open();
                SqlCommand cmd = new SqlCommand(query, DB.conn);
                byte[] link = (byte[] )cmd.ExecuteScalar() ;
                
                MemoryStream stream = new MemoryStream(link.ToArray());
            
                Image image = Image.FromStream(stream);
                if (image == null)
                    return;
                pbImgSV.Image = image;
            }catch(Exception e)
            {
                return;
            }
            finally
            {
                DB.conn.Close();
            }
        }
        /* Load Data từ DB lên Form Môn Học*/
        void getDataMonHocFromDB()
        {
            string query = @"SELECT ROW_NUMBER() OVER (ORDER BY ma_sv) AS [STT],
	                        MON_HOC.ten_mh AS N'Tên môn học',
	                        MON_HOC.so_tc_mh AS N'Số tín chỉ',
	                        MON_HOC.so_tiet_lt_mh AS N'Số tiết lý thuyết',
	                        MON_HOC.so_tiet_th_mh AS N'Số tiết thực hành',
	                        CHI_TIET_MON_HOC.trang_thai_mh AS N'Trạng thái'
                        FROM SINH_VIEN, LOP, CHI_TIET_MON_HOC, MON_HOC
                            WHERE SINH_VIEN.ma_lop = LOP.ma_lop
	                        AND LOP.ma_lop = CHI_TIET_MON_HOC.ma_lop
	                        AND CHI_TIET_MON_HOC.ma_mh = MON_HOC.ma_mh
	                        AND SINH_VIEN.ma_sv = '"+ NameUser + "'";
            DB.conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, DB.conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "MonHoc");
            dgvMonHoc.DataSource = null;
            dgvMonHoc.DataSource = ds.Tables["MonHoc"];
            DB.conn.Close();

            Get_MonHoc();
            Get_status();
        }

        /* Load Data từ DB lên Form Kết quản học tập*/
        void getDataDiem()
        {
            string query = @"SELECT ROW_NUMBER() OVER (ORDER BY MON_HOC.ma_mh) AS [STT],
                                MON_HOC.ten_mh AS N'Tên môn học',
	                            MON_HOC.so_tc_mh AS N'Số tín chỉ',
                                DIEM.diem_tp1 AS N'Điểm thành phần 1',  
	                            DIEM.diem_tp2 AS N'Điểm thành phần 2',
	                            DIEM.diem_kt AS N'Điểm kết thúc',
	                            (((DIEM.diem_tp1 + DIEM.diem_tp2)/2)*3 + (DIEM.diem_kt*7))/10 AS N'Điểm tổng kết'
                            FROM SINH_VIEN, DIEM, MON_HOC
                            WHERE SINH_VIEN.ma_sv = DIEM.ma_sv
                            AND DIEM.ma_mh = MON_HOC.ma_mh
                            AND SINH_VIEN.ma_sv = '" + NameUser+"'";

            DB.conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, DB.conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Diem");
            dgvKetQuaHocTap.DataSource = null;
            dgvKetQuaHocTap.DataSource = ds.Tables["Diem"];
            DB.conn.Close();
            loadSoMonHoc();
        }
        /* Load data sinh viên lên from Sinh Vien */
        void getDataSVToForm()
        {

            getDataSinhVienFromDB();

            getPicture();

            lbTenSV.Text = SinhVien.Ten_sv.ToUpper();
            lbTenSV2.Text = SinhVien.Ten_sv.ToUpper();
            lbTenSV1.Text = SinhVien.Ten_sv.ToUpper();
            lbMaSV.Text = SinhVien.Ma_sv;
            lbTrangThai.Text = SinhVien.Trang_thai_hoc;
            lbNgayVaoTruong.Text = SinhVien.Ngay_vao_truong_sv;
            lbKhoaHoc.Text = SinhVien.Khoa_hoc_sv;
            lbBacDaoTao.Text = SinhVien.getTenBacDaoTao();
            lbNganh.Text = SinhVien.getTenKhoa();
            lbKhoa.Text = SinhVien.getTenKhoa();
            lbChucVu.Text = SinhVien.Chuc_vu_sv;
            lbGioiTinh.Text = SinhVien.Gioitinh_sv;
            lbChuyenNganh.Text = SinhVien.getTenChuyenNganh();
            lbLoaiHinhDaoTao.Text = SinhVien.getLoaiHinhDaoTao();
            lbLop.Text = SinhVien.getTenLop();
            lbCongTacDoan.Text = SinhVien.Cong_tac_doan;
            lbCoSo.Text = SinhVien.Co_so;

            /*---------------------------------------------------*/

            lbNgaySinh.Text = SinhVien.Ngay_sinh_sv;
            lbNoiSinh.Text = SinhVien.Noi_sinh_sv;
            lbDanToc.Text = SinhVien.Dan_toc_sv;
            lbHoKhau.Text = SinhVien.Ho_khau_sv;
            lbDiaChiLienHe.Text = SinhVien.Dia_chi_sv;
            lbCMND.Text = SinhVien.Cmnd_sv;
            lbNgayCapCMND.Text = SinhVien.Ngay_cap_cmnd_sv;
            lbNoiCapCMND.Text = SinhVien.Noi_cap_cmnd_sv;
            lbTonGiao.Text = SinhVien.Ton_giao_sv;
            lbKhuVuc.Text = SinhVien.Khu_vuc_sv;
            lbDoiTuong.Text = SinhVien.Doi_tuong_sv;
            lbDienChinhSach.Text = SinhVien.Dien_chinh_sach;
            lbNgayVaoDoan.Text = SinhVien.Ngay_vao_doan_sv;
            lbNgayVaoDang.Text = SinhVien.Ngay_vao_dang_sv;
            lbSDT.Text = SinhVien.Sdt_sv;
            lbEmail.Text = SinhVien.Email_sv;

            /*---------------------------------------------------*/
            lb_tencha.Text = SinhVien.Ten_cha;
            lb_ngaysinhcha.Text = SinhVien.Ngay_sinh_cha;
            lb_nghenghiepcha.Text = SinhVien.Nghe_nghiep_cha;
            lb_sdtcha.Text = SinhVien.Sdt_cha;
            lb_quoctichcha.Text = SinhVien.Quoc_tich_cha;
            lb_tenme.Text = SinhVien.Ten_me;
            lb_ngaysinhme.Text = SinhVien.Ngay_sinh_me;
            lb_nghenghiepme.Text = SinhVien.Nghe_nghiep_me;
            lb_sdtme.Text = SinhVien.Sdt_me;
            lb_quoctichme.Text = SinhVien.Quoc_tich_me;
        }

        /* ------------- Các hàm mở form mới ------------- */

        /* Mở form đang phát triển */
        void Open_DangPhatTrien()
        {
            FormDangPhatTrien dpt = new FormDangPhatTrien();
            dpt.ShowDialog();
            dpt.Close();
        }

        /* Mở form sửa thông tin sinh viên*/
        private void btSuaThongTinSV_Click(object sender, EventArgs e)
        {
            SuaThongTinSV editSV = new SuaThongTinSV(NameUser);
            editSV.ShowDialog();
            editSV.Close();
            getDataSinhVienFromDB();
            getDataSVToForm();
        }
        /* Mở form sửa thông tin gia đình*/
        private void bt_suathongtingiadinh_Click(object sender, EventArgs e)
        {
            SuaThongTinGD editGD = new SuaThongTinGD(NameUser);
            editGD.ShowDialog();
            editGD.Close();
            getDataSinhVienFromDB();
            getDataSVToForm();
        }
        /* Mở form sửa thông tin sinh viên*/
        private void button2_Click(object sender, EventArgs e)
        {
            SuaThongTinSV editSV = new SuaThongTinSV(NameUser);
            editSV.ShowDialog();
            editSV.Close();
            getDataSinhVienFromDB();
            getDataSVToForm();
        }
        /* Load panel thông tin gia đình*/
        private void btThongTinGiaDinh_Click(object sender, EventArgs e)
        {
            panelGiaDinh.Visible = true;
            panelThongTinSinhVien.Visible = false;
            plDanhSachMonHoc.Visible = false;
            plKetQuaHocTap.Visible = false;
            plDiemRenLuyen.Visible = false;
            plCoVanHocTap.Visible = false;
            getDataSinhVienFromDB();
        }
        /* Load panel thông tin sinh viên*/
        private void btThongTinSV_Click(object sender, EventArgs e)
        {
            panelThongTinSinhVien.Visible = true;
            panelGiaDinh.Visible = false;
            plDanhSachMonHoc.Visible = false;
            plKetQuaHocTap.Visible = false;
            plDiemRenLuyen.Visible = false;
            plCoVanHocTap.Visible = false;
            getDataSinhVienFromDB();
        }
        /* Load panel Môn học sinh viên*/
        private void btChuongTrinhKhung_Click(object sender, EventArgs e)
        {
            panelThongTinSinhVien.Visible = false;
            panelGiaDinh.Visible = false;
            plDanhSachMonHoc.Visible = true;
            plKetQuaHocTap.Visible = false;
            plDiemRenLuyen.Visible = false;
            plCoVanHocTap.Visible = false;
            getDataMonHocFromDB();
        }
        /* Load panel kết quả học tập sinh viên*/
        private void btKetQuaHocTap_Click(object sender, EventArgs e)
        {
            panelGiaDinh.Visible = false;
            panelThongTinSinhVien.Visible = false;
            plDanhSachMonHoc.Visible = false;
            plKetQuaHocTap.Visible = true;
            plDiemRenLuyen.Visible = false;
            plCoVanHocTap.Visible = false;
            getDataDiem();
            Get_MonHocDiem();
        }
        /* Load panel Đánh giá rèn luyện sinh viên*/
        private void btDanhGiaRenLuyen_Click(object sender, EventArgs e)
        {

            panelGiaDinh.Visible = false;
            panelThongTinSinhVien.Visible = false;
            plDanhSachMonHoc.Visible = false;
            plKetQuaHocTap.Visible = false;
            plDiemRenLuyen.Visible = true;
            plCoVanHocTap.Visible = false;
            Get_DiemRenLuyenToForm();
        }
        /* Load panel thông tin cố vấn sinh viên*/
        private void btThongTinCoVanHocTapj_Click(object sender, EventArgs e)
        {
            panelGiaDinh.Visible = false;
            panelThongTinSinhVien.Visible = false;
            plDanhSachMonHoc.Visible = false;
            plKetQuaHocTap.Visible = false;
            plDiemRenLuyen.Visible = false;
            plCoVanHocTap.Visible = true;
            getDataCoVanHocTap();
        }
        /* Tìm kiếm Môn học */
        private void btTimKiemMonHoc_Click(object sender, EventArgs e)
        {
            string key = tbTimKiemMonHoc.Text;
            string select_query = @"SELECT ROW_NUMBER() OVER (ORDER BY ma_sv) AS [STT],
	                        MON_HOC.ten_mh AS N'Tên môn học',
	                        MON_HOC.so_tc_mh AS N'Số tín chỉ',
	                        MON_HOC.so_tiet_lt_mh AS N'Số tiết lý thuyết',
	                        MON_HOC.so_tiet_th_mh AS N'Số tiết thực hành',
	                        CHI_TIET_MON_HOC.trang_thai_mh AS N'Trạng thái'
                        FROM SINH_VIEN, LOP, CHI_TIET_MON_HOC, MON_HOC
                            WHERE SINH_VIEN.ma_lop = LOP.ma_lop
	                        AND LOP.ma_lop = CHI_TIET_MON_HOC.ma_lop
	                        AND CHI_TIET_MON_HOC.ma_mh = MON_HOC.ma_mh
	                        AND ten_mh LIKE N'%" + key + "%'AND SINH_VIEN.ma_sv = '" + NameUser + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(select_query, DB.conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "MonHoc");
            dgvMonHoc.DataSource = null;
            dgvMonHoc.DataSource = ds.Tables["MonHoc"];
        }
        /* Tìm kiếm Điểm */
        private void btTimKiemDiem_Click(object sender, EventArgs e)
        {
            string key = tbTimKiemDiem.Text;
            string select_query = @"SELECT ROW_NUMBER() OVER (ORDER BY MON_HOC.ma_mh) AS [STT],
                                        MON_HOC.ten_mh AS N'Tên môn học',
	                                    MON_HOC.so_tc_mh AS N'Số tín chỉ',
                                        DIEM.diem_tp1 AS N'Điểm thành phần 1',
	                                    DIEM.diem_tp2 AS N'Điểm thành phần 2',
	                                    DIEM.diem_kt AS N'Điểm kết thúc',
	                                    (((DIEM.diem_tp1 + DIEM.diem_tp2)/2)*3 + (DIEM.diem_kt*7))/10 AS N'Điểm tổng kết'
                                    FROM SINH_VIEN, DIEM, MON_HOC
                                    WHERE SINH_VIEN.ma_sv = DIEM.ma_sv
                                    AND DIEM.ma_mh = MON_HOC.ma_mh
                                    AND SINH_VIEN.ma_sv = '" + NameUser+"'AND MON_HOC.ten_mh LIKE N'%"+ key + "%'";
            SqlDataAdapter adapter = new SqlDataAdapter(select_query, DB.conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Diem");
            dgvKetQuaHocTap.DataSource = null;
            dgvKetQuaHocTap.DataSource = ds.Tables["Diem"];
        }
        //Lấy dữ liệu cho combobox trạng thái
        void Get_status()
        {
            cbbTrangThaiMonHoc.Items.Clear();
            //cbbTrangThaiMonHoc.Items.Add("Đang học");
            cbbTrangThaiMonHoc.Items.Add("Đã học");
            cbbTrangThaiMonHoc.Items.Add("Chưa học");
        }
        /* Load cbb Môn học từ DB lên Form*/
        void Get_MonHoc()
        {
            ccbMonHoc.Items.Clear();

            ccbMonHoc.DisplayMember = "Ten_mh";
            ccbMonHoc.ValueMember = "Ma_mh";
            string query = @"SELECT MON_HOC.ma_mh, MON_HOC.ten_mh
                        FROM SINH_VIEN, LOP, CHI_TIET_MON_HOC, MON_HOC
                            WHERE SINH_VIEN.ma_lop = LOP.ma_lop

                            AND LOP.ma_lop = CHI_TIET_MON_HOC.ma_lop

                            AND CHI_TIET_MON_HOC.ma_mh = MON_HOC.ma_mh

                            AND SINH_VIEN.ma_sv = '"+ NameUser + "'";
            DB.conn.Open();
            SqlCommand cmd = new SqlCommand(query, DB.conn);
            SqlDataReader rd = cmd.ExecuteReader();
            MonHocDic = new Dictionary<string, CMonHoc>();
            while (rd.Read())
            {
                CMonHoc gt1 = new CMonHoc(rd[0].ToString(), rd[1].ToString());
                ccbMonHoc.Items.Add(gt1);
                MonHocDic[gt1.Ma_mh] = gt1;
            }
            DB.conn.Close();
        }
        /* Click dgv Môn học*/
        private void dgvMonHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            string ten_mh = dgvMonHoc.Rows[e.RowIndex].Cells[1].Value.ToString();

            foreach (KeyValuePair<string, CMonHoc> item in MonHocDic)
            {
                if( ((CMonHoc)item.Value).Ten_mh == ten_mh)
                {
                    ccbMonHoc.SelectedItem = MonHocDic[((CMonHoc)item.Value).Ma_mh];
                    break;
                }
            }

            //ccbMonHoc.SelectedItem = dgvMonHoc.Rows[e.RowIndex].Cells[1].Value.ToString();
            cbbTrangThaiMonHoc.SelectedItem = dgvMonHoc.Rows[e.RowIndex].Cells[5].Value.ToString();
        }
        /* Click dgv Kết quả học tập*/
        private void dgvKetQuaHocTap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            string ten_mh = dgvKetQuaHocTap.Rows[e.RowIndex].Cells[1].Value.ToString();

            foreach (KeyValuePair<string, CMonHoc> item in MonHocDic2)
            {
                if (((CMonHoc)item.Value).Ten_mh == ten_mh)
                {
                    cbbMonHocDiem.SelectedItem = MonHocDic2[((CMonHoc)item.Value).Ma_mh];
                    break;
                }
            }
            tbDiemTP1.Text = dgvKetQuaHocTap.Rows[e.RowIndex].Cells[3].Value.ToString();
            tbDiemTP2.Text = dgvKetQuaHocTap.Rows[e.RowIndex].Cells[4].Value.ToString();
            tbDiemKetThuc.Text = dgvKetQuaHocTap.Rows[e.RowIndex].Cells[5].Value.ToString();
        }
        /* Lưu Môn học */
        private void btLuuMonHoc_Click(object sender, EventArgs e)
        {
            if (ccbMonHoc.SelectedIndex == -1)
                return;
            string trang_thai = cbbTrangThaiMonHoc.SelectedItem.ToString();
            string ma_mh = ((CMonHoc)ccbMonHoc.SelectedItem).Ma_mh;

            string ma_lop = SinhVien.Ma_lop;
            string query = @"UPDATE CHI_TIET_MON_HOC 
                        SET trang_thai_mh = N'"+trang_thai+"'WHERE ma_mh = '"+ma_mh+"' AND ma_lop = '"+ma_lop+"'";
            DB.conn.Open();
            SqlCommand cmd = new SqlCommand(query, DB.conn);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Lưu thành công!","Message", MessageBoxButtons.OK);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            DB.conn.Close();
            addDataToDiem(ma_mh,trang_thai);
            getDataMonHocFromDB();
        }
        /* Lưu Điểm */
        private void btLuuDiem_Click(object sender, EventArgs e)
        {
            if (cbbMonHocDiem.SelectedIndex == -1)
                return;
            string ma_mh = ((CMonHoc)cbbMonHocDiem.SelectedItem).Ma_mh;

            string diem1 = tbDiemTP1.Text;
            string diem2 = tbDiemTP2.Text;
            string diemtongket = tbDiemKetThuc.Text;

            string query;
            if (diem1 != string.Empty && diem2 != string.Empty && diemtongket != string.Empty)
            {
                query = @"UPDATE DIEM SET diem_tp1 = " + diem1 + ", diem_tp2 =" + diem2 + ", diem_kt = " + diemtongket + " WHERE ma_mh = '" + ma_mh + "' AND ma_sv = '" + NameUser + "'";
            }
            else
            {
                MessageBox.Show("Vui lòng nhập ít nhất một điểm thành phần và điểm kết thúc!", "Warning", MessageBoxButtons.OK);
                return;
            }
            DB.conn.Open();
            SqlCommand cmd = new SqlCommand(query, DB.conn);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Lưu thành công!", "Message", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            DB.conn.Close();
            getDataDiem();
        }
        /* Lưu Điểm rèn luyện */
        private void btLuuRenLuyen_Click(object sender, EventArgs e)
        {
            string renluyen1 = tbDiemRenLuyen1.Text;
            string renluyen2 = tbDiemRenLuyen2.Text;
            string renluyen3 = tbDiemRenLuyen3.Text;
            string renluyen4 = tbDiemRenLuyen4.Text;
            string renluyen5 = tbDiemRenLuyen5.Text;
            string renluyen6 = tbDiemRenLuyen6.Text;
            string renluyen7 = tbDiemRenLuyen7.Text;
            string renluyen8 = tbDiemRenLuyen8.Text;
            string renluyen9 = tbDiemRenLuyen9.Text;

            string query = @"UPDATE DIEM_REN_LUYEN SET ";



            if (renluyen1 != string.Empty)
            {
                query += "diem_ren_luyen_ki_1 = " + renluyen1 + ",";
            }
            if (renluyen2 != string.Empty)
            {
                query += "diem_ren_luyen_ki_2 =" + renluyen2 + ",";
            }
            if (renluyen3 != string.Empty)
            {
                query += "diem_ren_luyen_ki_3 =" + renluyen3 + ",";
            }
            if (renluyen4 != string.Empty)
            {
                query += " diem_ren_luyen_ki_4 =" + renluyen4 + ",";
            }
            if (renluyen5 != string.Empty)
            {
                query += "diem_ren_luyen_ki_5 =" + renluyen5 + ",";
            }
            if (renluyen6 != string.Empty)
            {
                query += "diem_ren_luyen_ki_6 =" + renluyen6 + ",";
            }
            if (renluyen7 != string.Empty)
            {
                query += "diem_ren_luyen_ki_7 =" + renluyen7 + ",";
            }
            if (renluyen8 != string.Empty)
            {
                query += "diem_ren_luyen_ki_8 =" + renluyen8 + ",";
            }
            if (renluyen9 != string.Empty)
            {
                query += "diem_ren_luyen_ki_9 =" + renluyen9 + ",";
            }
            query += " ma_sv = '" + NameUser + "' WHERE ma_sv = '" + NameUser + "'";
            DB.conn.Open();
            SqlCommand cmd = new SqlCommand(query, DB.conn);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Lưu thành công!", "Message", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            DB.conn.Close();
            Get_DiemRenLuyenToForm();
        }
        /* khi trạng thái môn học = đã học thì thêm data ngược lại xóa */
        private void addDataToDiem(string ma_mh, string trang_thai)
        {
            string query = "";
            if(trang_thai == "Đã học")
            {
                query = @"INSERT INTO DIEM(ma_sv, ma_mh)
                            VALUES('"+NameUser+"', '"+ma_mh+"')";
            }
            else
            {
                query = @"DELETE DIEM WHERE ma_sv = '" + NameUser + "' AND ma_mh = '" + ma_mh + "'";
            }
            DB.conn.Open();
            SqlCommand cmd = new SqlCommand(query, DB.conn);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
               
            }
            DB.conn.Close();
        }
        /*Load ccb Môn học sau khi sửa*/
        void Get_MonHocDiem()
        {
            cbbMonHocDiem.Items.Clear();
            cbbMonHocDiem.DisplayMember = "Ten_mh";
            cbbMonHocDiem.ValueMember = "Ma_mh";
            string query = @"SELECT MON_HOC.ma_mh, MON_HOC.ten_mh
                            FROM SINH_VIEN, LOP, CHI_TIET_MON_HOC, MON_HOC
                                WHERE SINH_VIEN.ma_lop = LOP.ma_lop
                                AND LOP.ma_lop = CHI_TIET_MON_HOC.ma_lop

                                AND CHI_TIET_MON_HOC.ma_mh = MON_HOC.ma_mh
	                            AND CHI_TIET_MON_HOC.trang_thai_mh = N'Đã học'
                                AND SINH_VIEN.ma_sv = '" + NameUser + "'";
            DB.conn.Open();
            SqlCommand cmd = new SqlCommand(query, DB.conn);
            SqlDataReader rd = cmd.ExecuteReader();
            MonHocDic2 = new Dictionary<string, CMonHoc>();
            while (rd.Read())
            {
                CMonHoc gt1 = new CMonHoc(rd[0].ToString(), rd[1].ToString());
                cbbMonHocDiem.Items.Add(gt1);
                MonHocDic2[gt1.Ma_mh] = gt1;
            }
            DB.conn.Close();
        }
        /*KeyPress Chỉ cho nhập điểm*/
        private void tbDiemKetThuc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == ".")
                return;
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        private void tbDiemTP1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == ".")
                return;
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        private void tbDiemTP2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == ".")
                return;
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        /*Load số môn học */
        private void loadSoMonHoc()
        {
            string query1 = @"SELECT COUNT(*) FROM SINH_VIEN, LOP, CHI_TIET_MON_HOC
                                WHERE SINH_VIEN.ma_lop = LOP.ma_lop
                                AND CHI_TIET_MON_HOC.ma_lop = LOP.ma_lop
                                AND CHI_TIET_MON_HOC.trang_thai_mh = N'Đã học'
                                AND SINH_VIEN.ma_sv = '"+NameUser+"'";
            DB.conn.Open();
            SqlCommand cmd = new SqlCommand(query1, DB.conn);
            lbTongSomonHoc.Text = cmd.ExecuteScalar().ToString();
            DB.conn.Close();
            string query2 = @"SELECT SUM(MON_HOC.so_tc_mh) FROM SINH_VIEN, LOP, CHI_TIET_MON_HOC, MON_HOC
                                WHERE SINH_VIEN.ma_lop = LOP.ma_lop
                                AND CHI_TIET_MON_HOC.ma_lop = LOP.ma_lop
                                AND CHI_TIET_MON_HOC.ma_mh = MON_HOC.ma_mh
                                AND CHI_TIET_MON_HOC.trang_thai_mh = N'Đã học'
                                AND SINH_VIEN.ma_sv = '" + NameUser + "'";
            DB.conn.Open();
            cmd = new SqlCommand(query2, DB.conn);
            lbSotinchi.Text = cmd.ExecuteScalar().ToString();
            DB.conn.Close();


            string diemtichluy = "";
            string query3 = @"SELECT AVG((((DIEM.diem_tp1 + DIEM.diem_tp2)/2)*3 + (DIEM.diem_kt*7))/10) FROM SINH_VIEN, DIEM
                                WHERE SINH_VIEN.ma_sv = DIEM.ma_sv
                                AND SINH_VIEN.ma_sv = '" + NameUser + "'";
            DB.conn.Open();
            cmd = new SqlCommand(query3, DB.conn);
            diemtichluy += cmd.ExecuteScalar().ToString();
            DB.conn.Close();



            List<float> LDiem = new List<float>();
            List<int> LSoTC = new List<int>();

            string query = @"SELECT (((DIEM.diem_tp1 + DIEM.diem_tp2)/2)*3 + (DIEM.diem_kt*7))/10, MON_HOC.so_tc_mh FROM SINH_VIEN, DIEM,MON_HOC
                                WHERE SINH_VIEN.ma_sv = DIEM.ma_sv
                                AND DIEM.ma_mh = MON_HOC.ma_mh
                                AND SINH_VIEN.ma_sv = '"+NameUser+"'";
            DB.conn.Open();
            cmd = new SqlCommand(query, DB.conn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                string temp = rd[0].ToString() is DBNull ? string.Empty : rd[0].ToString();
                if(temp != string.Empty)
                {
                    LDiem.Add(float.Parse(temp));
                    LSoTC.Add(Convert.ToInt32(rd[1].ToString()));
                }
            }
            DB.conn.Close();

            float sum = 0;
            int tong_tc = 0;
            for(int i = 0; i < LDiem.Count; i++)
            {
                if (LDiem[i] >= 8.5)
                {
                    sum += 4f * LSoTC[i];
                }
                else if (LDiem[i] < 8.5 && LDiem[i] >= 8)
                {
                    sum += 3.5f * LSoTC[i];
                }
                else if (LDiem[i] < 8 && LDiem[i] >= 7)
                {
                    sum += 3f * LSoTC[i];
                }
                else if (LDiem[i] < 7 && LDiem[i] >= 6.5)
                {
                    sum += 2.5f * LSoTC[i];
                }
                else if (LDiem[i] < 6.5 && LDiem[i] >= 5.5)
                {
                    sum += 2f * LSoTC[i];
                }
                else if (LDiem[i] < 5.5 && LDiem[i] >= 5)
                {
                    sum += 1.5f * LSoTC[i];
                }
                else if (LDiem[i] < 5 && LDiem[i] >= 4)
                {
                    sum += 1f * LSoTC[i];
                }
                else
                {
                    sum += 0f;
                }
                tong_tc += LSoTC[i];
            }
            if (tong_tc != 0)
            {
                decimal result1 = Math.Round(Convert.ToDecimal(diemtichluy), 2);
                decimal result2 = Math.Round(Convert.ToDecimal(sum / tong_tc), 2);
                

                string result = result1.ToString() + " - " + result2.ToString();

                lbdiemtbtichluy.Text = result;
            }
        }
       /* Lấy data ren luyện*/
        private void Get_DataDiemRenLuyen()
        {
            string query = @"SELECT * FROM DIEM_REN_LUYEN
                            WHERE ma_sv = '" + NameUser + "'";
            DB.conn.Open();
            SqlCommand cmd = new SqlCommand(query, DB.conn);
            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    string hk1 = rd[1].ToString() is DBNull ? string.Empty : rd[1].ToString();
                    string hk2 = rd[2].ToString() is DBNull ? string.Empty : rd[2].ToString();
                    string hk3 = rd[3].ToString() is DBNull ? string.Empty : rd[3].ToString();
                    string hk4 = rd[4].ToString() is DBNull ? string.Empty : rd[4].ToString();
                    string hk5 = rd[5].ToString() is DBNull ? string.Empty : rd[5].ToString();
                    string hk6 = rd[6].ToString() is DBNull ? string.Empty : rd[6].ToString();
                    string hk7 = rd[7].ToString() is DBNull ? string.Empty : rd[7].ToString();
                    string hk8 = rd[8].ToString() is DBNull ? string.Empty : rd[8].ToString();
                    string hk9 = rd[9].ToString() is DBNull ? string.Empty : rd[9].ToString();
                    DiemRenLuyen = new CDiemRenLuyen(hk1, hk2, hk3, hk4, hk5, hk6, hk7, hk8, hk9);
                }
            }
            catch(Exception ex)
            {

            }
            DB.conn.Close();
        }
        /* Load data ren luyện lên from*/
        private void Get_DiemRenLuyenToForm()
        {
            Get_DataDiemRenLuyen();

            int sum = 0;
            int count = 0;

            if(DiemRenLuyen.DiemRenLuyenHK1 != string.Empty)
            {
                cbHK1.Checked = true;
                tbDiemRenLuyen1.Enabled = true;
                tbDiemRenLuyen1.Text = DiemRenLuyen.DiemRenLuyenHK1;
                lbLoai1.Text = getXepLoai(Convert.ToInt32(DiemRenLuyen.DiemRenLuyenHK1));
                sum += Convert.ToInt32(DiemRenLuyen.DiemRenLuyenHK1);
                count++;
            }
            if (DiemRenLuyen.DiemRenLuyenHK2 != string.Empty)
            {
                cbHK2.Checked = true;
                tbDiemRenLuyen2.Enabled = true;
                tbDiemRenLuyen2.Text = DiemRenLuyen.DiemRenLuyenHK2;
                lbLoai2.Text = getXepLoai(Convert.ToInt32(DiemRenLuyen.DiemRenLuyenHK2));
                sum += Convert.ToInt32(DiemRenLuyen.DiemRenLuyenHK2);
                count++;
            }
            if (DiemRenLuyen.DiemRenLuyenHK3 != string.Empty)
            {
                cbHK3.Checked = true;
                tbDiemRenLuyen3.Enabled = true;
                tbDiemRenLuyen3.Text = DiemRenLuyen.DiemRenLuyenHK3;
                lbLoai3.Text = getXepLoai(Convert.ToInt32(DiemRenLuyen.DiemRenLuyenHK3));
                sum += Convert.ToInt32(DiemRenLuyen.DiemRenLuyenHK3);
                count++;
            }
            if (DiemRenLuyen.DiemRenLuyenHK4 != string.Empty)
            {
                cbHK4.Checked = true;
                tbDiemRenLuyen4.Enabled = true;
                tbDiemRenLuyen4.Text = DiemRenLuyen.DiemRenLuyenHK4;
                lbLoai4.Text = getXepLoai(Convert.ToInt32(DiemRenLuyen.DiemRenLuyenHK4));
                sum += Convert.ToInt32(DiemRenLuyen.DiemRenLuyenHK4);
                count++;
            }
            if (DiemRenLuyen.DiemRenLuyenHK5 != string.Empty)
            {
                cbHK5.Checked = true;
                tbDiemRenLuyen5.Enabled = true;
                tbDiemRenLuyen5.Text = DiemRenLuyen.DiemRenLuyenHK5;
                lbLoai5.Text = getXepLoai(Convert.ToInt32(DiemRenLuyen.DiemRenLuyenHK5));
                sum += Convert.ToInt32(DiemRenLuyen.DiemRenLuyenHK5);
                count++;
            }
            if (DiemRenLuyen.DiemRenLuyenHK6 != string.Empty)
            {
                cbHK6.Checked = true;
                tbDiemRenLuyen6.Enabled = true;
                tbDiemRenLuyen6.Text = DiemRenLuyen.DiemRenLuyenHK6;
                lbLoai6.Text = getXepLoai(Convert.ToInt32(DiemRenLuyen.DiemRenLuyenHK6));
                sum += Convert.ToInt32(DiemRenLuyen.DiemRenLuyenHK6);
                count++;
            }
            if (DiemRenLuyen.DiemRenLuyenHK7 != string.Empty)
            {
                cbHK7.Checked = true;
                tbDiemRenLuyen7.Enabled = true;
                tbDiemRenLuyen7.Text = DiemRenLuyen.DiemRenLuyenHK7;
                lbLoai7.Text = getXepLoai(Convert.ToInt32(DiemRenLuyen.DiemRenLuyenHK7));
                sum += Convert.ToInt32(DiemRenLuyen.DiemRenLuyenHK7);
                count++;
            }
            if (DiemRenLuyen.DiemRenLuyenHK8 != string.Empty)
            {
                cbHK8.Checked = true;
                tbDiemRenLuyen8.Enabled = true;
                tbDiemRenLuyen8.Text = DiemRenLuyen.DiemRenLuyenHK8;
                lbLoai8.Text = getXepLoai(Convert.ToInt32(DiemRenLuyen.DiemRenLuyenHK8));
                sum += Convert.ToInt32(DiemRenLuyen.DiemRenLuyenHK8);
                count++;
            }
            if (DiemRenLuyen.DiemRenLuyenHK9 != string.Empty)
            {
                cbHK9.Checked = true;
                tbDiemRenLuyen9.Enabled = true;
                tbDiemRenLuyen9.Text = DiemRenLuyen.DiemRenLuyenHK9;
                lbLoai9.Text = getXepLoai(Convert.ToInt32(DiemRenLuyen.DiemRenLuyenHK9));
                sum += Convert.ToInt32(DiemRenLuyen.DiemRenLuyenHK9);
                count++;
            }
            /*----------------------------------------------------*/
            if(count == 9)
            {
                lbDiemRenLuyenToanKhoa.Text = Convert.ToInt32(sum / count).ToString();
                lbXepLoaiToanKhoa.Text = getXepLoai(Convert.ToInt32(sum / count));
            }


        }
        /*Kiểm tra xếp loại*/
        private string getXepLoai(int point)
        {
            if(point >= 90)
            {
                return "Xuất sắc";
            }
            else if (point >= 80 && point < 90)
            {
                return "Tốt";
            }
            else if (point >= 70 && point < 80)
            {
                return "Khá";
            }
            else if (point >= 50 && point < 70)
            {
                return "Trung bình";
            }
            else
            {
                return "Yếu";
            }
        }
        /*Kiểm tra checked*/
        private void cbHK1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHK1.Checked)
            {
                tbDiemRenLuyen1.Enabled = true;
            }
            else
            {
                tbDiemRenLuyen1.Enabled = false;
            }
            if (cbHK2.Checked)
            {
                tbDiemRenLuyen2.Enabled = true;
            }
            else
            {
                tbDiemRenLuyen2.Enabled = false;
            }
            if (cbHK3.Checked)
            {
                tbDiemRenLuyen3.Enabled = true;
            }
            else
            {
                tbDiemRenLuyen3.Enabled = false;
            }
            if (cbHK4.Checked)
            {
                tbDiemRenLuyen4.Enabled = true;
            }
            else
            {
                tbDiemRenLuyen4.Enabled = false;
            }
            if (cbHK5.Checked)
            {
                tbDiemRenLuyen5.Enabled = true;
            }
            else
            {
                tbDiemRenLuyen5.Enabled = false;
            }
            if (cbHK6.Checked)
            {
                tbDiemRenLuyen6.Enabled = true;
            }
            else
            {
                tbDiemRenLuyen6.Enabled = false;
            }
            if (cbHK7.Checked)
            {
                tbDiemRenLuyen7.Enabled = true;
            }
            else
            {
                tbDiemRenLuyen7.Enabled = false;
            }
            if (cbHK8.Checked)
            {
                tbDiemRenLuyen8.Enabled = true;
            }
            else
            {
                tbDiemRenLuyen8.Enabled = false;
            }
            if (cbHK9.Checked)
            {
                tbDiemRenLuyen9.Enabled = true;
            }
            else
            {
                tbDiemRenLuyen9.Enabled = false;
            }
        }
        /*Load Data from cố vấn học tập*/
        private void getDataCoVanHocTap()
        {
            string query = @"SELECT LOP.ten_lop, GIANG_VIEN.* FROM SINH_VIEN, LOP, GIANG_VIEN
                            WHERE SINH_VIEN.ma_lop = LOP.ma_lop
                            AND LOP.ma_gv = GIANG_VIEN.ma_gv
                            AND SINH_VIEN.ma_sv = '"+NameUser+"'";
            string Lop = "";
            string MaGv = "";
            string TenGv = "";
            string ChucVu = "";
            string SDT = "";
            string Thongtin = "";
            DB.conn.Open();
            SqlCommand cmd = new SqlCommand(query, DB.conn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                 Lop = rd[0].ToString() is DBNull ? string.Empty : rd[0].ToString();
                 MaGv = rd[1].ToString() is DBNull ? string.Empty : rd[1].ToString();
                 TenGv = rd[2].ToString() is DBNull ? string.Empty : rd[2].ToString();
                 SDT = rd[3].ToString() is DBNull ? string.Empty : rd[3].ToString();
                 Thongtin = rd[4].ToString() is DBNull ? string.Empty : rd[4].ToString();
                 ChucVu = rd[5].ToString() is DBNull ? string.Empty : rd[5].ToString();
            }
            DB.conn.Close();
            lbTenLop.Text = Lop;
            lbMaGV.Text = MaGv;
            lbHovaTen.Text = TenGv;
            lbSoDtCoVan.Text = SDT;
            lbChucvuCoVan.Text = ChucVu;
            lbThongTinLienHeCoVan.Text = Thongtin;
        }
        // logout linklabel
        private void llbLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đăng xuất?", "Message", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                LoginStatus = DangNhap.LOGOUT; // Ghi nhận trạng thái thoát khỏi chương trình
                this.Close();
            }
        }
        //537, 48
        int x = 12, y = 30, a = 1;
        Random rd = new Random();
        // Hàm điều chỉnh location label
        private void myTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                x += a*1;
                labelRun.Location = new Point(x, y);
                if(x > 305)
                {
                    a = -1;
                    labelRun.ForeColor = Color.FromArgb(rd.Next(0, 255), rd.Next(0, 255), rd.Next(0, 255));
                }
                if (x < 12)
                {
                    a = 1;
                    labelRun.ForeColor = Color.FromArgb(rd.Next(0, 255), rd.Next(0, 255), rd.Next(0, 255));
                }
            }
            catch(Exception ex)
            {

            }

        }
    }
}
