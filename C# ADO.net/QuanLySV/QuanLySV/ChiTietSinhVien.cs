using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySV
{
    public partial class ChiTietSinhVien : Form
    {
        
        public string NameUser;
        private CSinhVien SinhVien;
        public ChiTietSinhVien(string MaSinhVien)
        {
            NameUser = MaSinhVien;
            InitializeComponent();
        }

        private void ChiTietSinhVien_Load(object sender, EventArgs e)
        {
            getDataSinhVienFromDB();
            getDataSVToForm();
            getPicture();
        }

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
        /* Load ảnh từ DB lên Form*/
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
                pbImgSV.Image = image;
            }
            catch (Exception ex)
            {
                
            }
            finally
            {
                DB.conn.Close();
            }
        }
        /* Load data sinh viên lên panel */
        void getDataSVToForm()
        {
            lbTenSV.Text = SinhVien.Ten_sv.ToUpper();
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
        }

    }
}
