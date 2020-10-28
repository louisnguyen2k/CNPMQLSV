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
    public partial class ThongKeDiemTichLuy : Form
    {
        private float yeu;
        private float trung_binh;
        private float kha;
        private float gioi;
        private float Xuat_xac;
        public ThongKeDiemTichLuy()
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
            string query = @"SELECT AVG(((diem_kt*7) + ((diem_tp1 +diem_tp2)/2)*3)/10) FROM SINH_VIEN, DIEM
                            WHERE SINH_VIEN.ma_sv = DIEM.ma_sv
                            GROUP BY SINH_VIEN.ma_sv
                            HAVING AVG(((diem_kt*7) + ((diem_tp1 +diem_tp2)/2)*3)/10) < 5";
            DB.conn.Open();
            SqlCommand cmd = new SqlCommand(query, DB.conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                yeu++;
            }
            DB.conn.Close();
        }
        private void GetDiemTrungBinh()
        {
            string query = @"SELECT AVG(((diem_kt*7) + ((diem_tp1 +diem_tp2)/2)*3)/10) FROM SINH_VIEN, DIEM
                            WHERE SINH_VIEN.ma_sv = DIEM.ma_sv
                            GROUP BY SINH_VIEN.ma_sv
                            HAVING AVG(((diem_kt*7) + ((diem_tp1 +diem_tp2)/2)*3)/10) >= 5
                            AND AVG(((diem_kt*7) + ((diem_tp1 +diem_tp2)/2)*3)/10) < 6.5";
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
            string query = @"SELECT AVG(((diem_kt*7) + ((diem_tp1 +diem_tp2)/2)*3)/10) FROM SINH_VIEN, DIEM
                            WHERE SINH_VIEN.ma_sv = DIEM.ma_sv
                            GROUP BY SINH_VIEN.ma_sv
                            HAVING AVG(((diem_kt*7) + ((diem_tp1 +diem_tp2)/2)*3)/10) >= 6.5
                            AND AVG(((diem_kt*7) + ((diem_tp1 +diem_tp2)/2)*3)/10) < 7.5";
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
            string query = @"SELECT AVG(((diem_kt*7) + ((diem_tp1 +diem_tp2)/2)*3)/10) FROM SINH_VIEN, DIEM
                            WHERE SINH_VIEN.ma_sv = DIEM.ma_sv
                            GROUP BY SINH_VIEN.ma_sv
                            HAVING AVG(((diem_kt*7) + ((diem_tp1 +diem_tp2)/2)*3)/10) >= 7.5
                            AND AVG(((diem_kt*7) + ((diem_tp1 +diem_tp2)/2)*3)/10) < 8.5";
            DB.conn.Open();
            SqlCommand cmd = new SqlCommand(query, DB.conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                gioi++;
            }
            DB.conn.Close();
        }
        private void GetDiemXuatXac()
        {
            string query = @"SELECT AVG(((diem_kt*7) + ((diem_tp1 +diem_tp2)/2)*3)/10) FROM SINH_VIEN, DIEM
                            WHERE SINH_VIEN.ma_sv = DIEM.ma_sv
                            GROUP BY SINH_VIEN.ma_sv
                            HAVING AVG(((diem_kt*7) + ((diem_tp1 +diem_tp2)/2)*3)/10) >=8.5";
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
            float tong = yeu + trung_binh + kha + gioi + Xuat_xac;
            yeu = (yeu / tong) * 100;
            trung_binh = (trung_binh / tong) * 100;
            kha = (kha / tong) * 100;
            gioi = (gioi / tong) * 100;
            Xuat_xac = (Xuat_xac / tong) * 100;
        }
        private void ThongKeDiemTichLuy_Load(object sender, EventArgs e)
        {
            if(yeu != 0) chartTKDTL.Series["SeriesTKDTL"].Points.AddXY(Math.Round(Convert.ToDecimal(yeu), 2) + "% (Yếu)", yeu);
            if (trung_binh != 0) chartTKDTL.Series["SeriesTKDTL"].Points.AddXY(Math.Round(Convert.ToDecimal(trung_binh), 2) + "% (Trung Bình)", trung_binh);
            if (kha != 0) chartTKDTL.Series["SeriesTKDTL"].Points.AddXY(Math.Round(Convert.ToDecimal(kha), 2) + "% (Khá)", kha);
            if (gioi != 0) chartTKDTL.Series["SeriesTKDTL"].Points.AddXY(Math.Round(Convert.ToDecimal(gioi), 2) + "% (Giỏi)", gioi);
            if (Xuat_xac != 0) chartTKDTL.Series["SeriesTKDTL"].Points.AddXY(Math.Round(Convert.ToDecimal(Xuat_xac), 2) + "% (Xuất Xác)", Xuat_xac);
            if(yeu == 0 && trung_binh == 0 && kha == 0 && gioi == 0 && Xuat_xac == 0)
            {
                chartTKDTL.Series["SeriesTKDTL"].Points.AddXY("0% (Yếu)", 100);
                chartTKDTL.Series["SeriesTKDTL"].Points.AddXY("0% (Trung Bình)", 100);
                chartTKDTL.Series["SeriesTKDTL"].Points.AddXY("0% (Khá)", 100);
                chartTKDTL.Series["SeriesTKDTL"].Points.AddXY("0% (Giỏi)", 100);
                chartTKDTL.Series["SeriesTKDTL"].Points.AddXY("0% (Xuất Xác)", 100);
            }
        }
    }
}
