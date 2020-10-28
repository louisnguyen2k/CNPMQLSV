using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySV
{
    class CChuyenNganh
    {
        private string _ma_cn;
        private string _ten_cn;

        public CChuyenNganh(string ma_cn, string ten_cn)
        {
            _ma_cn = ma_cn;
            _ten_cn = ten_cn;
        }

        public string Ma_cn { get => _ma_cn; set => _ma_cn = value; }
        public string Ten_cn { get => _ten_cn; set => _ten_cn = value; }
    }
}
