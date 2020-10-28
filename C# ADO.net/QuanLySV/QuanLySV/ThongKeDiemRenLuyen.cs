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
    public partial class ThongKeDiemRenLuyen : Form
    {
        private float kem;
        private float trung_binh;
        private float kha;
        private float tot;
        private float Xuat_xac;
        public ThongKeDiemRenLuyen()
        {
            InitializeComponent();
            GetDiemYeu();
            GetDiemTrungBinh();
            GetDiemKha();
            GetDiemGioi();
            GetDiemXuatXac();
            TinhPhanTram();
        }
        private void GetDiemYeu()
        {
            string query = @"SELECT (diem_ren_luyen_ki_1+diem_ren_luyen_ki_2+diem_ren_luyen_ki_3
		                            +diem_ren_luyen_ki_4+diem_ren_luyen_ki_5+diem_ren_luyen_ki_6
		                            +diem_ren_luyen_ki_7+diem_ren_luyen_ki_8+diem_ren_luyen_ki_9)/9 
                            FROM DIEM_REN_LUYEN,SINH_VIEN
                            WHERE SINH_VIEN.ma_sv = DIEM_REN_LUYEN.ma_sv
                            AND (diem_ren_luyen_ki_1+diem_ren_luyen_ki_2+diem_ren_luyen_ki_3
		                            +diem_ren_luyen_ki_4+diem_ren_luyen_ki_5+diem_ren_luyen_ki_6
		                            +diem_ren_luyen_ki_7+diem_ren_luyen_ki_8+diem_ren_luyen_ki_9)/9 < 50";
            DB.conn.Open();
            SqlCommand cmd = new SqlCommand(query, DB.conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                kem++;
            }
            DB.conn.Close();
        }
        private void GetDiemTrungBinh()
        {
            string query = @"SELECT (diem_ren_luyen_ki_1+diem_ren_luyen_ki_2+diem_ren_luyen_ki_3
		                    +diem_ren_luyen_ki_4+diem_ren_luyen_ki_5+diem_ren_luyen_ki_6
		                    +diem_ren_luyen_ki_7+diem_ren_luyen_ki_8+diem_ren_luyen_ki_9)/9 
                    FROM DIEM_REN_LUYEN,SINH_VIEN
                    WHERE SINH_VIEN.ma_sv = DIEM_REN_LUYEN.ma_sv
                    AND (diem_ren_luyen_ki_1+diem_ren_luyen_ki_2+diem_ren_luyen_ki_3
		                    +diem_ren_luyen_ki_4+diem_ren_luyen_ki_5+diem_ren_luyen_ki_6
		                    +diem_ren_luyen_ki_7+diem_ren_luyen_ki_8+diem_ren_luyen_ki_9)/9 >=50
                    AND (diem_ren_luyen_ki_1+diem_ren_luyen_ki_2+diem_ren_luyen_ki_3
		                    +diem_ren_luyen_ki_4+diem_ren_luyen_ki_5+diem_ren_luyen_ki_6
		                    +diem_ren_luyen_ki_7+diem_ren_luyen_ki_8+diem_ren_luyen_ki_9)/9 <65";
            DB.conn.Open();
            SqlCommand cmd = new SqlCommand(query, DB.conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                trung_binh++;
            }
            DB.conn.Close();
        }
        private void GetDiemKha()
        {
            string query = @"SELECT (diem_ren_luyen_ki_1+diem_ren_luyen_ki_2+diem_ren_luyen_ki_3
		                    +diem_ren_luyen_ki_4+diem_ren_luyen_ki_5+diem_ren_luyen_ki_6
		                    +diem_ren_luyen_ki_7+diem_ren_luyen_ki_8+diem_ren_luyen_ki_9)/9 
                    FROM DIEM_REN_LUYEN,SINH_VIEN
                    WHERE SINH_VIEN.ma_sv = DIEM_REN_LUYEN.ma_sv
                    AND (diem_ren_luyen_ki_1+diem_ren_luyen_ki_2+diem_ren_luyen_ki_3
		                    +diem_ren_luyen_ki_4+diem_ren_luyen_ki_5+diem_ren_luyen_ki_6
		                    +diem_ren_luyen_ki_7+diem_ren_luyen_ki_8+diem_ren_luyen_ki_9)/9 >=65
                    AND (diem_ren_luyen_ki_1+diem_ren_luyen_ki_2+diem_ren_luyen_ki_3
		                    +diem_ren_luyen_ki_4+diem_ren_luyen_ki_5+diem_ren_luyen_ki_6
		                    +diem_ren_luyen_ki_7+diem_ren_luyen_ki_8+diem_ren_luyen_ki_9)/9 <80";
            DB.conn.Open();
            SqlCommand cmd = new SqlCommand(query, DB.conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                kha++;
            }
            DB.conn.Close();
        }
        private void GetDiemGioi()
        {
            string query = @"SELECT (diem_ren_luyen_ki_1+diem_ren_luyen_ki_2+diem_ren_luyen_ki_3
		                    +diem_ren_luyen_ki_4+diem_ren_luyen_ki_5+diem_ren_luyen_ki_6
		                    +diem_ren_luyen_ki_7+diem_ren_luyen_ki_8+diem_ren_luyen_ki_9)/9 
                    FROM DIEM_REN_LUYEN,SINH_VIEN
                    WHERE SINH_VIEN.ma_sv = DIEM_REN_LUYEN.ma_sv
                    AND (diem_ren_luyen_ki_1+diem_ren_luyen_ki_2+diem_ren_luyen_ki_3
		                    +diem_ren_luyen_ki_4+diem_ren_luyen_ki_5+diem_ren_luyen_ki_6
		                    +diem_ren_luyen_ki_7+diem_ren_luyen_ki_8+diem_ren_luyen_ki_9)/9 >=80
                    AND (diem_ren_luyen_ki_1+diem_ren_luyen_ki_2+diem_ren_luyen_ki_3
		                    +diem_ren_luyen_ki_4+diem_ren_luyen_ki_5+diem_ren_luyen_ki_6
		                    +diem_ren_luyen_ki_7+diem_ren_luyen_ki_8+diem_ren_luyen_ki_9)/9 <90";
            DB.conn.Open();
            SqlCommand cmd = new SqlCommand(query, DB.conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                tot++;
            }
            DB.conn.Close();
        }
        private void GetDiemXuatXac()
        {
            string query = @"SELECT (diem_ren_luyen_ki_1+diem_ren_luyen_ki_2+diem_ren_luyen_ki_3
		                            +diem_ren_luyen_ki_4+diem_ren_luyen_ki_5+diem_ren_luyen_ki_6
		                            +diem_ren_luyen_ki_7+diem_ren_luyen_ki_8+diem_ren_luyen_ki_9)/9 
                            FROM DIEM_REN_LUYEN,SINH_VIEN
                            WHERE SINH_VIEN.ma_sv = DIEM_REN_LUYEN.ma_sv
                            AND (diem_ren_luyen_ki_1+diem_ren_luyen_ki_2+diem_ren_luyen_ki_3
		                            +diem_ren_luyen_ki_4+diem_ren_luyen_ki_5+diem_ren_luyen_ki_6
		                            +diem_ren_luyen_ki_7+diem_ren_luyen_ki_8+diem_ren_luyen_ki_9)/9 >=90";
            DB.conn.Open();
            SqlCommand cmd = new SqlCommand(query, DB.conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Xuat_xac++;
            }
            DB.conn.Close();
        }
        private void TinhPhanTram()
        {
            float tong = kem + trung_binh + kha + tot + Xuat_xac;
            kem = (kem / tong) * 100;
            trung_binh = (trung_binh / tong) * 100;
            kha = (kha / tong) * 100;
            tot = (tot / tong) * 100;
            Xuat_xac = (Xuat_xac / tong) * 100;
        }
        private void ThongKeDiemRenLuyen_Load(object sender, EventArgs e)
        {
            if (kem != 0) chartTKDRL.Series["SeriesTKDTL"].Points.AddXY(Math.Round(Convert.ToDecimal(kem), 2) + "% (Yếu)", kem);
            if (trung_binh != 0) chartTKDRL.Series["SeriesTKDTL"].Points.AddXY(Math.Round(Convert.ToDecimal(trung_binh), 2) + "% (Trung Bình)", trung_binh);
            if (kha != 0) chartTKDRL.Series["SeriesTKDTL"].Points.AddXY(Math.Round(Convert.ToDecimal(kha), 2) + "% (Khá)", kha);
            if (tot != 0) chartTKDRL.Series["SeriesTKDTL"].Points.AddXY(Math.Round(Convert.ToDecimal(tot), 2) + "% (Giỏi)", tot);
            if (Xuat_xac != 0) chartTKDRL.Series["SeriesTKDTL"].Points.AddXY(Math.Round(Convert.ToDecimal(Xuat_xac), 2) + "% (Xuất Xác)", Xuat_xac);
            if (kem == 0 && trung_binh == 0 && kha == 0 && tot == 0 && Xuat_xac == 0)
            {
                chartTKDRL.Series["SeriesTKDTL"].Points.AddXY("0% (Yếu)", 100);
                chartTKDRL.Series["SeriesTKDTL"].Points.AddXY("0% (Trung Bình)", 100);
                chartTKDRL.Series["SeriesTKDTL"].Points.AddXY("0% (Khá)", 100);
                chartTKDRL.Series["SeriesTKDTL"].Points.AddXY("0% (Giỏi)", 100);
                chartTKDRL.Series["SeriesTKDTL"].Points.AddXY("0% (Xuất Xác)", 100);
            }
        }
    }
}
