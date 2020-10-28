using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySV
{
    class CBacDaoTao
    {
        private string _ma_bdt;
        private string _ten_bdt;
        private string _loai_hinh_dao_tao;
        private string _thoi_gian_dao_tao;

        public CBacDaoTao(string ma_bdt,string ten_bdt)
        {
            _ma_bdt = ma_bdt;
            _ten_bdt = ten_bdt;    
        }
        public string Ma_bdt { get => _ma_bdt; set => _ma_bdt = value; }
        public string Ten_bdt { get => _ten_bdt; set => _ten_bdt = value; }
        public string Loai_hinh_dao_tao { get => _loai_hinh_dao_tao; set => _loai_hinh_dao_tao = value; }
        public string Thoi_gian_dao_tao { get => _thoi_gian_dao_tao; set => _thoi_gian_dao_tao = value; }
    }
}
