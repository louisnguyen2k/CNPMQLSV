using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySV
{
    class CLop
    {
        private string _ma_lop;
        private string _ten_lop;

        public CLop(string ma_lop, string ten_lop)
        {
            _ma_lop = ma_lop;
            _ten_lop = ten_lop;
        }

        public string Ma_lop { get => _ma_lop; set => _ma_lop = value; }
        public string Ten_lop { get => _ten_lop; set => _ten_lop = value; }
    }
}
