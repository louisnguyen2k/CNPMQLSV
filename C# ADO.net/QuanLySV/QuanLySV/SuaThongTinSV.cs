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
using System.Drawing.Imaging;

namespace QuanLySV
{
    public partial class SuaThongTinSV : Form
    {
        /*PROPERTY*/
        // @NameUser: Tên tài khoản cần sửa.
        // @SinhVien: OBJ đối tượng tương tác với form
        string NameUser;
        private Dictionary<string, CChuyenNganh> ChuyenNganhDic;
        private Dictionary<string, CKhoa> KhoaDic;
        private Dictionary<string, CLop> LopDic;
        private Dictionary<string, CBacDaoTao> BacDaoTaoDic;
        List<string> dantoc = new List<string>(); // Khai báo list để lưu 54 dân tộc
        List<string> tinh = new List<string>();  //Khai báo list để lưu 63 tỉnh thành 
        private CSinhVien SinhVien;
        public int check = 0;
        public SuaThongTinSV(string NameUser)
        {
            InitializeComponent();
            this.NameUser = NameUser;
            LoadCBB();
        }
        /* Sự kiện load form */
        private void SuaThongTinSV_Load_1(object sender, EventArgs e)
        {
            getDataSinhVienFromDB();
            setDataSVToForm();
            getPicture();
        }
        /* Sự kiện click nút lưu thông tin */
        private void bt_Luu_Click(object sender, EventArgs e)
        {
            
            string ngay_vao_truong = dtp_vaotruong.Value.ToString("MM-dd-yyyy");
            string ngay_sinh = dtp_ngaysinh.Value.ToString("MM-dd-yyyy");
            string ngay_cap_CMND = dtp_ngaycapcmnd.Value.ToString("MM-dd-yyyy");
            string ngay_vao_doan = dtp_ngayvaodoan.Value.ToString("MM-dd-yyyy");
            string ngay_vao_dang = dtp_ngayvaodang.Value.ToString("MM-dd-yyyy");
            
            string query_sinhvien = @"UPDATE SINH_VIEN SET trang_thai_hoc =N'" + cbbTrangThai.GetItemText(cbbTrangThai.SelectedItem) + "'/*,ngay_vao_truong_sv='" + ngay_vao_truong + "'*/, khoa_hoc_sv= '" + tbKhoaHoc.Text + "'," +
            "gioitinh_sv= N'" + cbbGioiTinh.Text + "',chuc_vu_sv=N'" + tbChucVu.Text + "',cong_tac_doan=N'" + tbCongTacDoan.Text + "', co_so=N'" + tbCoSo.Text + "'," +
                "ngay_sinh_sv='" + ngay_sinh + "',noi_sinh_sv=N'" + cbbNoiSinh.Text + "',dan_toc_sv=N'" + cbbDanToc.Text + "',ho_khau_sv=N'" + tbHoKhau.Text + "',dia_chi_sv=N'" + tbDiaChiLienHe.Text + "'," +
                "cmnd_sv='" + tbCMND.Text + "',noi_cap_cmnd_sv=N'" + cbbNoiCapCMND.Text + "',ngay_cap_cmnd_sv='" + ngay_cap_CMND + "', ton_giao_sv=N'" + cbbTonGiao.Text + "'," +
                "khu_vuc_sv=N'" + cbbKhuVuc.Text + "',doi_tuong_sv=N'" + cbbDoiTuong.Text + "', dien_chinh_sach_sv=N'" + tbDienChinhSach.Text + "',ngay_vao_doan_sv='" + ngay_vao_doan + "'," +
                "ngay_vao_dang_sv='" + ngay_vao_dang + "',sdt_sv='" + tbSDT.Text + "',email_sv='" + tbEmail.Text + "'" +
                "WHERE ma_sv='" + NameUser + "'";

            string ma_k = ((CKhoa)cbbKhoa.SelectedItem).Ma_khoa;
            string ten_k = ((CKhoa)cbbKhoa.SelectedItem).Ten_khoa;
            string query_khoa = @"UPDATE KHOA SET ma_k='" + ma_k + "',ten_k='" + ten_k + "' WHERE ten_k='" + cbbKhoa.Text + "' ";

            //string ma_bdt = ((CBacDaoTao)cbbBacDaoTao.SelectedItem).Ma_bdt;
            //string loai_hinh_dao_tao = ((CBacDaoTao)cbbBacDaoTao.SelectedItem).Loai_hinh_dao_tao;
            //string thoi_gian_dao_tao = ((CBacDaoTao)cbbBacDaoTao.SelectedItem).Thoi_gian_dao_tao;
            //string query_bacdaotao = @"UPDATE BAC_DAO_TAO SET ten_bdt='" + cbbBacDaoTao.Text + "',ma_bdt='" + ma_bdt + "' " +
            //    "loai_hinh_dao_tao='" + loai_hinh_dao_tao + "', thoi_gian_dao_tao='" + thoi_gian_dao_tao + "'" +
            //    "WHERE ma_sv='" + NameUser + "'";
            //string ma_cn = ((CChuyenNganh)cbbChuyenNganh.SelectedItem).Ma_cn;
            //string query_chuyennganh = @"UPDATE CHUYEN_NGANH SET ten_cn='" + cbbChuyenNganh.Text + "',ma_cn='" + ma_cn + "'" +
            //    "WHERE ma_sv='" + NameUser + "'";
            //string ma_lop = ((CLop)cbbLop.SelectedItem).Ma_lop;
            //string query_lop = @"UPDATE LOP SET ten_lop='" + cbbLop.Text + "',ma_lop='" + ma_lop + "'" +
            //    "WHERE ma_sv='" + NameUser + "' ";//vẫn còn thiếu cái mã giảng viên

            try
            {
                if (Check_fill(ngay_vao_truong, ngay_sinh, ngay_cap_CMND, ngay_vao_doan, ngay_vao_dang) == 1)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin !", "Warning");
                    return;
                }
                savePicture();
                DB.conn.Open();
                SqlCommand cmd = new SqlCommand(query_sinhvien, DB.conn);
                cmd.ExecuteNonQuery();
                //SqlCommand cmd1 = new SqlCommand(query_khoa, DB.conn);
                //cmd1.ExecuteNonQuery();
                MessageBox.Show("Sửa thành công !", "Message");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa thất bại, Exception: " + ex.Message, "Error");
            }
            finally
            {
                DB.conn.Close();
            }
            SuaThongTinSV_Load_1(sender,e);
        }
        /*Load dữ liệu cho textbox và combobox*/ 
        void LoadCBB()
        {
            Get_ngayvaotruong();
            Get_ngaysinh();
            Get_ngaycapCMND();
            Get_NoiSinh(tinh);
            Get_NoiCapCMND(tinh);
            Get_ngayvaodoan();
            Get_ngayvaodang();
            Get_status();
            Get_gioitinh();
            Get_khuvuc();
            Get_tongiao();
            Get_doituong();
            Get_chuyennghanh();
            Get_khoa();
            Get_bacdaotao();
            Get_lop();
            Get_nganh();
            Get_dantoc(dantoc);
        }
        //Lấy dữ liệu cho dateTimePicker ngày vào trường
        void Get_ngayvaotruong()
        {
            string query_vaotruong = @"SELECT ngay_vao_truong_sv FROM SINH_VIEN WHERE ma_sv='" + NameUser + "'";
            DB.conn.Open();
            SqlCommand cmd = new SqlCommand(query_vaotruong, DB.conn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                string ngay_vao_truong = rd[0].ToString();
                if(ngay_vao_truong  != string.Empty)
                    dtp_vaotruong.Value = Convert.ToDateTime(ngay_vao_truong);
            }    
            DB.conn.Close();
        }
        //Lấy dữ liệu cho dateTimePicker ngày sinh
        void Get_ngaysinh()
        {
            string query = @"SELECT ngay_sinh_sv FROM SINH_VIEN WHERE ma_sv='" + NameUser + "'";
            DB.conn.Open();
            SqlCommand cmd = new SqlCommand(query, DB.conn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                string ngay_sinh = rd[0].ToString();
                if(ngay_sinh != string.Empty)
                    dtp_ngaysinh.Value = Convert.ToDateTime(ngay_sinh);
            }
            DB.conn.Close();
        }
        //Lấy dữ liệu cho dateTimePicker ngày cấp CMND
        void Get_ngaycapCMND()
        {
            string query = @"SELECT ngay_cap_cmnd_sv FROM SINH_VIEN WHERE ma_sv='" + NameUser + "'";
            DB.conn.Open();
            SqlCommand cmd = new SqlCommand(query, DB.conn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                string ngay_cap_CMND = rd[0].ToString();
                if(ngay_cap_CMND != string.Empty)
                    dtp_ngaycapcmnd.Value = Convert.ToDateTime(ngay_cap_CMND);
            }
            DB.conn.Close();
        }
        //Add dữ liệu vào list 63 tỉnh thành
        void List_tinh(List<string> tinh)
        {
            tinh.Add("An Giang");
            tinh.Add("Bà Rịa - Vũng Tàu");
            tinh.Add("Bắc Giang");
            tinh.Add("Bắc Kạn");
            tinh.Add("Bạc Liêu");
            tinh.Add("Bắc Ninh");
            tinh.Add("Bến Tre");
            tinh.Add("Bình Định");
            tinh.Add("Bình Dương");
            tinh.Add("Bình Phước");
            tinh.Add("Bình Thuận");
            tinh.Add("Cà Mau");
            tinh.Add("Cao Bằng");
            tinh.Add("Đắk Lắk");
            tinh.Add("Đắk Nông");
            tinh.Add("Điện Biên");
            tinh.Add("Đồng Nai");
            tinh.Add("Đồng Tháp");
            tinh.Add("Gia Lai");
            tinh.Add("Hà Giang");
            tinh.Add("Hà Nam");
            tinh.Add("Hà Tĩnh");
            tinh.Add("Hải Dương");
            tinh.Add("Hậu Giang");
            tinh.Add("Hòa Bình");
            tinh.Add("Hưng Yên");
            tinh.Add("Khánh Hòa");
            tinh.Add("Kiên Giang");
            tinh.Add("Kon Tum");
            tinh.Add("Lai Châu");
            tinh.Add("Lâm Đồng");
            tinh.Add("Lạng Sơn");
            tinh.Add("Lào Cai");
            tinh.Add("Long An");
            tinh.Add("Nam Định");
            tinh.Add("Nghệ An");
            tinh.Add("Ninh Bình");
            tinh.Add("Ninh Thuận");
            tinh.Add("Phú Thọ");
            tinh.Add("Quảng Bình");
            tinh.Add("Quảng Nam");
            tinh.Add("Quảng Ngãi");
            tinh.Add("Quảng Ninh");
            tinh.Add("Quảng Trị");
            tinh.Add("Sóc Trăng");
            tinh.Add("Sơn La");
            tinh.Add("Tây Ninh");
            tinh.Add("Thái Bình");
            tinh.Add("Thái Nguyên");
            tinh.Add("Thanh Hóa");
            tinh.Add("Thừa Thiên Huế");
            tinh.Add("Tiền Giang");
            tinh.Add("Trà Vinh");
            tinh.Add("Tuyên Quang");
            tinh.Add("Vĩnh Long");
            tinh.Add("Vĩnh Phúc");
            tinh.Add("Yên Bái");
            tinh.Add("Phú Yên");
            tinh.Add("Cần Thơ");
            tinh.Add("Đà Nẵng");
            tinh.Add("Hải Phòng");
            tinh.Add("Hà Nội");
            tinh.Add("TP HCM");
        }
        //Lấy dữ liệu cho combobox nơi sinh
        void Get_NoiSinh(List<string> tinh)
        {
            List_tinh(tinh);

            foreach (string item in tinh)
            {
                cbbNoiSinh.Items.Add(item);
            }
        }
        //Add dữ liệu vào list 54 dân tộc
        void List_dantoc(List<string> dantoc)
        {
            dantoc.Add("Kinh");
            dantoc.Add("Tày");
            dantoc.Add("Thái");
            dantoc.Add("Mường");
            dantoc.Add("Khmer");
            dantoc.Add("Hoa");
            dantoc.Add("Nùng");
            dantoc.Add("H'Mông");
            dantoc.Add("Dao");
            dantoc.Add("Gia Rai");
            dantoc.Add("Ê Đê");
            dantoc.Add("Ba Na");
            dantoc.Add("Sán Chay");
            dantoc.Add("Chăm");
            dantoc.Add("Cơ Ho");
            dantoc.Add("Xơ Đăng");
            dantoc.Add("Sán Dìu");
            dantoc.Add("Hrê");
            dantoc.Add("Ra Glai");
            dantoc.Add("Mnông");
            dantoc.Add("Thổ");
            dantoc.Add("Xtiêng");
            dantoc.Add("Khơ mú");
            dantoc.Add("Bru - Vân Kiều");
            dantoc.Add("Cơ Tu");
            dantoc.Add("Giáy");
            dantoc.Add("Tà ôi");
            dantoc.Add("Mạ");
            dantoc.Add("Chơ Ro");
            dantoc.Add("Giẻ-Triêng");
            dantoc.Add("Co");
            dantoc.Add("Xinh Mun");
            dantoc.Add("Hà Nhì");
            dantoc.Add("Chu Ru");
            dantoc.Add("Lào");
            dantoc.Add("La Chí");
            dantoc.Add("Kháng");
            dantoc.Add("Phù Lá");
            dantoc.Add("La Hủ");
            dantoc.Add("La Ha");
            dantoc.Add("Pà Thẻn");
            dantoc.Add("Lự");
            dantoc.Add("Ngái");
            dantoc.Add("Chứt");
            dantoc.Add("Lô Lô");
            dantoc.Add("Mảng ");
            dantoc.Add("Cơ Lao");
            dantoc.Add("Bố Y");
            dantoc.Add("Cống");
            dantoc.Add("Si La");
            dantoc.Add("Pu Péo");
            dantoc.Add("Rơ Măm");
            dantoc.Add("Brâu");
            dantoc.Add("Ơ Đu");
        }
        void Get_dantoc(List<string> dantoc)
        {
            List_dantoc(dantoc);
            foreach (string items in dantoc)
            {
                cbbDanToc.Items.Add(items);
            }
        }
        //Lấy dữ liệu cho combobox nơi cấp CMND
        void Get_NoiCapCMND(List<string> tinh)
        {
            foreach (string item in tinh)
            {
                cbbNoiCapCMND.Items.Add(item);
            }

        }
        //Lấy dữ liệu cho dateTimePicker ngày vào đoàn
        void Get_ngayvaodoan()
        {
            string query = @"SELECT ngay_vao_doan_sv FROM SINH_VIEN WHERE ma_sv='" + NameUser + "'";
            DB.conn.Open();
            SqlCommand cmd = new SqlCommand(query, DB.conn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                string ngay_vao_doan = rd[0].ToString();
                try
                {
                    dtp_ngayvaodoan.Value = Convert.ToDateTime(ngay_vao_doan);
                }
                catch (Exception ex)
                {

                }
            }
            DB.conn.Close();
        }
        //Lấy dữ liệu cho dateTimePicker ngày vào đảng
        void Get_ngayvaodang()
        {
            string query = @"SELECT ngay_vao_dang_sv FROM SINH_VIEN WHERE ma_sv='" + NameUser + "'";
            DB.conn.Open();
            SqlCommand cmd = new SqlCommand(query, DB.conn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                string ngay_vao_dang = rd[0].ToString();
                try
                {
                    dtp_ngayvaodang.Value = Convert.ToDateTime(ngay_vao_dang);
                }catch(Exception ex)
                {

                }
            }
            DB.conn.Close();
        }
        //Lấy dữ liệu cho combobox trạng thái
        void Get_status()
        {
            cbbTrangThai.Items.Add("Đang học");
            cbbTrangThai.Items.Add("Đã nghỉ");
            cbbTrangThai.Items.Add("Đã ra trường");
        }
        //Lấy dữ liệu cho combobox giới tính
        void Get_gioitinh()
        {
            cbbGioiTinh.Items.Add("Nam");
            cbbGioiTinh.Items.Add("Nữ");
        }
        //Lấy dữ liệu cho combobox khu vực
        void Get_khuvuc()
        {
            cbbKhuVuc.Items.Add("1- Khu vực 1");
            cbbKhuVuc.Items.Add("2- Khu vực 2");
            cbbKhuVuc.Items.Add("3- Khu vực 3");
        }
        //Lấy dữ liệu cho combobox tôn giáo
        void Get_tongiao()
        {
            cbbTonGiao.Items.Add("Không");
            cbbTonGiao.Items.Add("Công giáo");
            cbbTonGiao.Items.Add("Phật giáo");
            cbbTonGiao.Items.Add("Hòa Hảo");
            cbbTonGiao.Items.Add("Tin Lành");
            cbbTonGiao.Items.Add("Hồi Giáo");
            cbbTonGiao.Items.Add("Cơ đốc Phục Lâm");
            cbbTonGiao.Items.Add("Cao Đài");
        }
        //Lấy dữ liệu cho combobox đối tượng 
        void Get_doituong()
        {
            cbbDoiTuong.Items.Add("Không");
            cbbDoiTuong.Items.Add("Hộ nghèo");
            cbbDoiTuong.Items.Add("Con thương binh");
        }
        //Lấy dữ liệu cho combobox chuyên ngành
        void Get_chuyennghanh()
        {
            cbbChuyenNganh.DisplayMember = "Ma_cn";
            cbbChuyenNganh.ValueMember = "Ten_cn";
            string query = "SELECT ma_cn,ten_cn FROM CHUYEN_NGANH";
            DB.conn.Open();
            SqlCommand cmd = new SqlCommand(query, DB.conn);
            SqlDataReader rd = cmd.ExecuteReader();
            ChuyenNganhDic = new Dictionary<string, CChuyenNganh>();
            while (rd.Read())
            {
                CChuyenNganh cn2 = new CChuyenNganh(rd[0].ToString(), rd[1].ToString());
                cbbChuyenNganh.Items.Add(cn2.Ten_cn);
                ChuyenNganhDic[cn2.Ma_cn] = cn2;
            }
            DB.conn.Close();
        }
        //Lấy dữ liệu cho combobox khoa
        void Get_khoa()
        {
            cbbKhoa.DisplayMember = "Ten_khoa";
            cbbKhoa.ValueMember = "Ma_khoa";
            string query = "SELECT * FROM KHOA";
            DB.conn.Open();
            SqlCommand cmd = new SqlCommand(query, DB.conn);
            SqlDataReader rd = cmd.ExecuteReader();
            KhoaDic = new Dictionary<string, CKhoa>();
            while (rd.Read())
            {
                CKhoa gt2 = new CKhoa(rd[0].ToString(), rd[1].ToString());
                cbbKhoa.Items.Add(gt2);
                KhoaDic[gt2.Ma_khoa] = gt2;
            }
            DB.conn.Close();
        }
        //Lấy dữ liệu cho combobox bậc đào tạo
        void Get_bacdaotao()
        {
            cbbBacDaoTao.DisplayMember = "Ma_bdt";
            cbbBacDaoTao.ValueMember = "Ten_bdt";
            string query = "SELECT ma_bdt, ten_bdt FROM BAC_DAO_TAO";
            DB.conn.Open();
            SqlCommand cmd = new SqlCommand(query, DB.conn);
            SqlDataReader rd = cmd.ExecuteReader();
            BacDaoTaoDic = new Dictionary<string, CBacDaoTao>();
            while (rd.Read())
            {
                CBacDaoTao dt = new CBacDaoTao(rd[0].ToString(), rd[1].ToString());
                cbbBacDaoTao.Items.Add(dt.Ten_bdt);
                BacDaoTaoDic[dt.Ma_bdt] = dt;
            }
            DB.conn.Close();
        }
        //Lấy dữ liệu cho combobox lớp
        void Get_lop()
        {
            cbbLop.DisplayMember = "Ten_lop";
            cbbLop.ValueMember = "Ma_lop";
            string query = "SELECT ma_lop,ten_lop FROM LOP";
            DB.conn.Open();
            SqlCommand cmd = new SqlCommand(query, DB.conn);
            SqlDataReader rd = cmd.ExecuteReader();
            LopDic = new Dictionary<string, CLop>();
            while (rd.Read())
            {
                CLop gt = new CLop(rd[0].ToString(), rd[1].ToString());
                cbbLop.Items.Add(gt);
                LopDic[gt.Ma_lop] = gt;
            }
            DB.conn.Close();
        }
        //Lấy dữ liệu cho combobox ngành
        void Get_nganh()
        {
            cbbKhoa.DisplayMember = "Ten_khoa";
            cbbKhoa.ValueMember = "Ma_khoa";
            string query = "SELECT * FROM KHOA";
            DB.conn.Open();
            SqlCommand cmd = new SqlCommand(query, DB.conn);
            SqlDataReader rd = cmd.ExecuteReader();
            KhoaDic = new Dictionary<string, CKhoa>();
            while (rd.Read())
            {
                CKhoa gt1 = new CKhoa(rd[0].ToString(), rd[1].ToString());
                cbbNganh.Items.Add(gt1.Ten_khoa);
                KhoaDic[gt1.Ma_khoa] = gt1;
            }
            DB.conn.Close();
        }

        /*Sự kiện click nút huỷ*/
        private void bt_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Hàm lấy dữ liệu trong database đổ vào textbox và combobox

        /* Load data từ DB vào một OBJ */
        void getDataSinhVienFromDB()
        {
            string query = @"SELECT * FROM SINH_VIEN
                            WHERE ma_sv = '" + NameUser + "'";
            DB.conn.Open();
            SqlCommand cmd = new SqlCommand(query, DB.conn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                SinhVien = new CSinhVien(rd[0].ToString(), rd[1].ToString(), rd[2].ToString(), rd[3].ToString(), rd[4].ToString(), rd[5].ToString(), rd[6].ToString(), rd[7].ToString(), rd[8].ToString(), rd[9].ToString(), rd[10].ToString(), rd[11].ToString(), rd[12].ToString(), rd[13].ToString(), rd[14].ToString(), rd[15].ToString(), rd[16].ToString(), rd[17].ToString(), rd[18].ToString(), rd[19].ToString(), rd[20].ToString(), rd[21].ToString(), rd[22].ToString(), rd[23].ToString(), rd[24].ToString(), rd[25].ToString(), rd[26].ToString(), rd[27].ToString(), rd[28].ToString(), rd[29].ToString(), rd[30].ToString(), rd[32].ToString(), rd[33].ToString(), rd[34].ToString(), rd[35].ToString(), rd[36].ToString(), rd[37].ToString(), rd[38].ToString(), rd[39].ToString(), rd[40].ToString(), rd[41].ToString());
            }
            DB.conn.Close();
        }

        /* Load data lên form*/
        void setDataSVToForm()
        {
            if (SinhVien == null)
                return;
            tbKhoaHoc.Text = SinhVien.Khoa_hoc_sv;
            tbChucVu.Text = SinhVien.Chuc_vu_sv;
            tbCongTacDoan.Text = SinhVien.Cong_tac_doan;
            tbCoSo.Text = SinhVien.Co_so;
            tbCMND.Text = SinhVien.Cmnd_sv;
            tbDienChinhSach.Text = SinhVien.Dien_chinh_sach;
            tbHoKhau.Text = SinhVien.Ho_khau_sv;
            tbDiaChiLienHe.Text = SinhVien.Dia_chi_sv;
            tbSDT.Text = SinhVien.Sdt_sv;
            tbEmail.Text = SinhVien.Email_sv;
            cbbTrangThai.Text = SinhVien.Trang_thai_hoc;
            cbbNganh.Text = SinhVien.getTenKhoa();
            cbbKhoa.Text = SinhVien.getTenKhoa();
            cbbBacDaoTao.Text = SinhVien.getTenBacDaoTao();
            cbbChuyenNganh.Text = SinhVien.getTenChuyenNganh();
            cbbLop.Text = SinhVien.getTenLop();
            cbbNoiSinh.Text = SinhVien.Noi_sinh_sv;
            cbbDanToc.Text = SinhVien.Dan_toc_sv;
            cbbNoiCapCMND.Text = SinhVien.Noi_cap_cmnd_sv;
            cbbTonGiao.Text = SinhVien.Ton_giao_sv;
            cbbKhuVuc.Text = SinhVien.Ton_giao_sv;
            cbbDoiTuong.Text = SinhVien.Doi_tuong_sv;
            cbbGioiTinh.Text = SinhVien.Gioitinh_sv;
        }    
        
        /* Kiểm tra điền đầy đủ thông tin hay chưa?*/
        int Check_fill(string ngay_vao_truong,string ngay_sinh,string ngay_cap_CMND,string ngay_vao_doan,string ngay_vao_dang)
        {

            if (cbbTrangThai.Text == string.Empty || ngay_vao_truong == string.Empty || tbKhoaHoc.Text == string.Empty || cbbGioiTinh.Text == string.Empty ||
                cbbNganh.Text == string.Empty || cbbKhoa.Text == string.Empty || cbbBacDaoTao.Text == string.Empty || cbbChuyenNganh.Text == string.Empty || cbbLop.Text == string.Empty ||
                ngay_sinh == string.Empty || cbbNoiSinh.Text == string.Empty || cbbDanToc.Text == string.Empty || tbHoKhau.Text == string.Empty ||
                tbDiaChiLienHe.Text == string.Empty || tbCMND.Text == string.Empty || ngay_cap_CMND == string.Empty ||
                cbbNoiCapCMND.Text == string.Empty || cbbTonGiao.Text == string.Empty || cbbKhuVuc.Text == string.Empty || ngay_vao_doan == string.Empty ||
                tbSDT.Text == string.Empty || tbEmail.Text == string.Empty)
                {
                    return 1;
                }
            return 0;  
        }
        private string nameFile; // Lưu tên file được chọn 
        /*Sự kiện chọn ảnh để thay đổi*/
        private void btSuaAnh_Click(object sender, EventArgs e)
        {
           
            OpenFileDialog openFile = new OpenFileDialog();
            //openFile.InitialDirectory = "D:\\Users\\HP\\Pictures\\Saved Pictures";
            if(openFile.ShowDialog()== DialogResult.OK)
            {
                nameFile = openFile.FileName;
                if (string.IsNullOrEmpty(nameFile))
                    return;
                Image myImage = Image.FromFile(nameFile);
                pictureBox1.Image = myImage;
            }
        }
        /*Query save picture*/
        void savePicture()
        {

            byte[] img = ImageTobByArray(pictureBox1.Image);
            DB.conn.Open();
            SqlCommand cmd = new SqlCommand(" UPDATE SINH_VIEN SET link_img_sv= @img WHERE ma_sv=@nameUser", DB.conn);
            cmd.Parameters.AddWithValue("@img", img);
            cmd.Parameters.AddWithValue("@nameUser", NameUser);
            cmd.ExecuteNonQuery();
            DB.conn.Close();
        }
        /*Chuyển ảnh thành byte*/
        byte[] ImageTobByArray(Image img)
        {
            MemoryStream stream = new MemoryStream();
            img.Save(stream, ImageFormat.Jpeg);
            return stream.ToArray();
        }
        /*Load ảnh lên từ DB*/
        void getPicture()
        {
            string query = "SELECT link_img_sv FROM SINH_VIEN WHERE ma_sv='" + NameUser + "'";
            
            try
            {
                DB.conn.Open();
                SqlCommand cmd = new SqlCommand(query, DB.conn);
                byte[] link = (byte[])cmd.ExecuteScalar();
                MemoryStream stream = new MemoryStream(link.ToArray());
                Image image = Image.FromStream(stream);
                if (image == null)
                    return;
                pictureBox1.Image = image;
            }
            catch (Exception ex)
            {
                return;
            }
            finally
            {

                DB.conn.Close();
            }
        }
    }
}
