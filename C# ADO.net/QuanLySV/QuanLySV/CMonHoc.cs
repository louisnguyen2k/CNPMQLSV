using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySV
{
    class CMonHoc
    {
        private string _ma_mh;
        private string _ten_mh;

        public CMonHoc(string ma_mh, string ten_mh)
        {
            _ma_mh = ma_mh;
            _ten_mh = ten_mh;
        }

        public string Ma_mh { get => _ma_mh; set => _ma_mh = value; }
        public string Ten_mh { get => _ten_mh; set => _ten_mh = value; }
    }
}
