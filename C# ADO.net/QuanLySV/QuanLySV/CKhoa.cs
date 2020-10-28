using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySV
{
    class CKhoa
    {
        private string _ma_khoa;
        private string _ten_khoa;

        public CKhoa(string ma_khoa, string ten_khoa)
        {
            _ma_khoa = ma_khoa;
            _ten_khoa = ten_khoa;
        }

        public string Ma_khoa { get => _ma_khoa; set => _ma_khoa = value; }
        public string Ten_khoa { get => _ten_khoa; set => _ten_khoa = value; }
    }
}
