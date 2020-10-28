using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySV
{
    class CGiaoVien
    {
        private string _ma_gv;
        private string _ten_gv;

        public CGiaoVien(string ma_gv, string ten_gv)
        {
            _ma_gv = ma_gv;
            _ten_gv = ten_gv;
        }

        public string Ma_gv { get => _ma_gv; set => _ma_gv = value; }
        public string Ten_gv { get => _ten_gv; set => _ten_gv = value; }
    }
}
