using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QuanLySV
{
    class CSinhVien
    {
        string ma_sv;
        string ten_sv;
        string gioitinh_sv;
        string sdt_sv;
        string email_sv;
        string ngay_sinh_sv;
        string noi_sinh_sv;
        string dan_toc_sv;
        string ton_giao_sv;
        string khu_vuc_sv;
        string cmnd_sv;
        string ngay_cap_cmnd_sv;
        string noi_cap_cmnd_sv;
        string ho_khau_sv;
        string dia_chi_sv;
        string ngay_vao_truong_sv;
        string chuc_vu_sv;
        string link_img_sv;
        string alt_img_sv;
        string ten_cha;
        string ngay_sinh_cha;
        string nghe_nghiep_cha;
        string sdt_cha;
        string quoc_tich_cha;
        string con_song_cha;
        string ten_me;
        string ngay_sinh_me;
        string nghe_nghiep_me;
        string sdt_me;
        string quoc_tich_me;
        string con_song_me;
        string ma_lop;
        string ma_bdt;
        string trang_thai_hoc;
        string khoa_hoc_sv;
        string cong_tac_doan;
        string co_so;
        string doi_tuong_sv;
        string dien_chinh_sach;
        string ngay_vao_doan_sv;
        string ngay_vao_dang_sv;

        public CSinhVien(string ma_sv, string ten_sv, string gioitinh_sv, string sdt_sv, string email_sv, string ngay_sinh_sv, string noi_sinh_sv, string dan_toc_sv, string ton_giao_sv, string khu_vuc_sv, string cmnd_sv, string ngay_cap_cmnd_sv, string noi_cap_cmnd_sv, string ho_khau_sv, string dia_chi_sv, string ngay_vao_truong_sv, string chuc_vu_sv, string link_img_sv, string alt_img_sv, string ten_cha, string ngay_sinh_cha, string nghe_nghiep_cha, string sdt_cha, string quoc_tich_cha, string con_song_cha, string ten_me, string ngay_sinh_me, string nghe_nghiep_me, string sdt_me, string quoc_tich_me, string con_song_me, string ma_lop, string ma_bdt, string trang_thai_hoc, string khoa_hoc_sv, string cong_tac_doan, string co_so, string doi_tuong_sv, string dien_chinh_sach, string ngay_vao_doan_sv, string ngay_vao_dang_sv)
        {
            this.ma_sv = ma_sv;
            this.ten_sv = ten_sv;
            this.gioitinh_sv = gioitinh_sv;
            this.sdt_sv = sdt_sv;
            this.email_sv = email_sv;
            
            this.noi_sinh_sv = noi_sinh_sv;
            this.dan_toc_sv = dan_toc_sv;
            this.ton_giao_sv = ton_giao_sv;
            this.khu_vuc_sv = khu_vuc_sv;
            this.cmnd_sv = cmnd_sv;
            
            this.noi_cap_cmnd_sv = noi_cap_cmnd_sv;
            this.ho_khau_sv = ho_khau_sv;
            this.dia_chi_sv = dia_chi_sv;
            
            this.chuc_vu_sv = chuc_vu_sv;
            this.link_img_sv = link_img_sv;
            this.alt_img_sv = alt_img_sv;
            this.ten_cha = ten_cha;
            
            this.nghe_nghiep_cha = nghe_nghiep_cha;
            this.sdt_cha = sdt_cha;
            this.quoc_tich_cha = quoc_tich_cha;
            this.con_song_cha = con_song_cha;
            this.ten_me = ten_me;
            
            this.nghe_nghiep_me = nghe_nghiep_me;
            this.sdt_me = sdt_me;
            this.quoc_tich_me = quoc_tich_me;
            this.con_song_me = con_song_me;
            this.ma_lop = ma_lop;
            this.ma_bdt = ma_bdt;
            this.trang_thai_hoc = trang_thai_hoc;
            this.khoa_hoc_sv = khoa_hoc_sv;
            this.cong_tac_doan = cong_tac_doan;
            this.co_so = co_so;
            this.doi_tuong_sv = doi_tuong_sv;
            this.dien_chinh_sach = dien_chinh_sach;
            try
            {
                this.ngay_sinh_sv = ngay_sinh_sv.Substring(0, 9);
            }catch(Exception ex)
            {
                this.ngay_sinh_sv = string.Empty;
            }
            try
            {
                this.ngay_cap_cmnd_sv = ngay_cap_cmnd_sv.Substring(0, 9);
            }
            catch (Exception ex)
            {
                this.ngay_cap_cmnd_sv = string.Empty;
            }
            try
            {
                this.ngay_vao_truong_sv = ngay_vao_truong_sv.Substring(0, 9);
            }
            catch (Exception ex)
            {
                this.ngay_vao_truong_sv = string.Empty;
            }
            try
            {
                this.ngay_sinh_cha = ngay_sinh_cha.Substring(0, 10);
            }
            catch (Exception ex)
            {
                this.ngay_sinh_cha = string.Empty;
            }
            try
            {
                this.ngay_sinh_me = ngay_sinh_me.Substring(0, 10);
            }
            catch (Exception ex)
            {
                this.ngay_sinh_me = string.Empty;
            }
            try
            {
                this.ngay_vao_doan_sv = ngay_vao_doan_sv.Substring(0, 9);
            }
            catch (Exception ex)
            {
                this.ngay_vao_doan_sv = string.Empty;
            }
            try
            {
                this.ngay_vao_dang_sv = ngay_vao_dang_sv.Substring(0, 9);
            }
            catch (Exception ex)
            {
                this.ngay_vao_dang_sv = string.Empty;
            }

        }

        public string Ma_sv { get => ma_sv; set => ma_sv = value; }
        public string Ten_sv { get => ten_sv; set => ten_sv = value; }
        public string Gioitinh_sv { get => gioitinh_sv; set => gioitinh_sv = value; }
        public string Sdt_sv { get => sdt_sv; set => sdt_sv = value; }
        public string Email_sv { get => email_sv; set => email_sv = value; }
        public string Ngay_sinh_sv { get => ngay_sinh_sv; set => ngay_sinh_sv = value; }
        public string Noi_sinh_sv { get => noi_sinh_sv; set => noi_sinh_sv = value; }
        public string Dan_toc_sv { get => dan_toc_sv; set => dan_toc_sv = value; }
        public string Ton_giao_sv { get => ton_giao_sv; set => ton_giao_sv = value; }
        public string Khu_vuc_sv { get => khu_vuc_sv; set => khu_vuc_sv = value; }
        public string Cmnd_sv { get => cmnd_sv; set => cmnd_sv = value; }
        public string Ngay_cap_cmnd_sv { get => ngay_cap_cmnd_sv; set => ngay_cap_cmnd_sv = value; }
        public string Noi_cap_cmnd_sv { get => noi_cap_cmnd_sv; set => noi_cap_cmnd_sv = value; }
        public string Ho_khau_sv { get => ho_khau_sv; set => ho_khau_sv = value; }
        public string Dia_chi_sv { get => dia_chi_sv; set => dia_chi_sv = value; }
        public string Ngay_vao_truong_sv { get => ngay_vao_truong_sv; set => ngay_vao_truong_sv = value; }
        public string Chuc_vu_sv { get => chuc_vu_sv; set => chuc_vu_sv = value; }
        public string Link_img_sv { get => link_img_sv; set => link_img_sv = value; }
        public string Alt_img_sv { get => alt_img_sv; set => alt_img_sv = value; }
        public string Ten_cha { get => ten_cha; set => ten_cha = value; }
        public string Ngay_sinh_cha { get => ngay_sinh_cha; set => ngay_sinh_cha = value; }
        public string Nghe_nghiep_cha { get => nghe_nghiep_cha; set => nghe_nghiep_cha = value; }
        public string Sdt_cha { get => sdt_cha; set => sdt_cha = value; }
        public string Quoc_tich_cha { get => quoc_tich_cha; set => quoc_tich_cha = value; }
        public string Con_song_cha { get => con_song_cha; set => con_song_cha = value; }
        public string Ten_me { get => ten_me; set => ten_me = value; }
        public string Ngay_sinh_me { get => ngay_sinh_me; set => ngay_sinh_me = value; }
        public string Nghe_nghiep_me { get => nghe_nghiep_me; set => nghe_nghiep_me = value; }
        public string Sdt_me { get => sdt_me; set => sdt_me = value; }
        public string Quoc_tich_me { get => quoc_tich_me; set => quoc_tich_me = value; }
        public string Con_song_me { get => con_song_me; set => con_song_me = value; }
        public string Ma_lop { get => ma_lop; set => ma_lop = value; }
        public string Ma_bdt { get => ma_bdt; set => ma_bdt = value; }
        public string Trang_thai_hoc { get => trang_thai_hoc; set => trang_thai_hoc = value; }
        public string Khoa_hoc_sv { get => khoa_hoc_sv; set => khoa_hoc_sv = value; }
        public string Cong_tac_doan { get => cong_tac_doan; set => cong_tac_doan = value; }
        public string Co_so { get => co_so; set => co_so = value; }
        public string Doi_tuong_sv { get => doi_tuong_sv; set => doi_tuong_sv = value; }
        public string Dien_chinh_sach { get => dien_chinh_sach; set => dien_chinh_sach = value; }
        public string Ngay_vao_doan_sv { get => ngay_vao_doan_sv; set => ngay_vao_doan_sv = value; }
        public string Ngay_vao_dang_sv { get => ngay_vao_dang_sv; set => ngay_vao_dang_sv = value; }

        public string getTenBacDaoTao()
        {
            if(this.ma_bdt == string.Empty)
            {
                return string.Empty;
            }
            string result = string.Empty;
            string query = @"SELECT ten_bdt FROM BAC_DAO_TAO
                                WHERE ma_bdt = '"+ this.ma_bdt +"'";
            try
            {
                DB.conn.Open();
                SqlCommand cmd = new SqlCommand(query, DB.conn);
                result = cmd.ExecuteScalar().ToString();
            }
            catch(Exception ex)
            {

            }
            finally
            {
                DB.conn.Close();
            }
            return result;
        }

        public string getLoaiHinhDaoTao()
        {
            if(this.ma_bdt == string.Empty)
            {
                return string.Empty;
            }
            string query = @"SELECT loai_hinh_dao_tao FROM BAC_DAO_TAO
                                WHERE ma_bdt = '" + this.ma_bdt + "'";
            DB.conn.Open();
            SqlCommand cmd = new SqlCommand(query, DB.conn);
            string result = cmd.ExecuteScalar().ToString();
            DB.conn.Close();
            return result;
        }

        public string getTenKhoa()
        {
            if(this.ma_lop == string.Empty)
            {
                return string.Empty;
            }
            string query = @"SELECT KHOA.ten_k FROM LOP, CHUYEN_NGANH, KHOA
                                WHERE LOP.ma_cn = CHUYEN_NGANH.ma_cn
                                AND KHOA.ma_k = CHUYEN_NGANH.ma_k
                                AND LOP.ma_lop = '" + this.ma_lop + "'";

            DB.conn.Open();
            SqlCommand cmd = new SqlCommand(query, DB.conn);
            string result = cmd.ExecuteScalar().ToString();
            DB.conn.Close();
            return result;
        }

        public string getTenChuyenNganh()
        {
            if(this.ma_lop == string.Empty)
            {
                return string.Empty;
            }
            string query = @"SELECT CHUYEN_NGANH.ten_cn FROM LOP, CHUYEN_NGANH
                                WHERE LOP.ma_cn = CHUYEN_NGANH.ma_cn
                                AND LOP.ma_lop = '"+ this.ma_lop +"'";

            DB.conn.Open();
            SqlCommand cmd = new SqlCommand(query, DB.conn);
            string result = cmd.ExecuteScalar().ToString();
            DB.conn.Close();
            return result;
        }

        public string getTenLop()
        {
            string result = khoa_hoc_sv + ma_lop;
            return result;
        }
    }
}
