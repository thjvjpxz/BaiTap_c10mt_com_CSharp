using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    public class Account
    {
        public string TaiKhoan { get; set; }
        public string MatKhau { get; set; }

        public Account(string taiKhoan, string matKhau)
        {
            TaiKhoan = taiKhoan;
            MatKhau = matKhau;
        }
    }
}
