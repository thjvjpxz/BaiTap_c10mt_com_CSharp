using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai14
{
    public class Solution
    {
        public static void HinhVuong(double a, out double chuVi, out double dienTich)
        {
            chuVi = a * 4;
            dienTich = a * a;
        }
        public static void HinhChuNhat(double a, double b, out double chuVi, out double dienTich)
        {
            chuVi = (a + b) * 2;
            dienTich = a * b;
        }

        public static void HinhTron(double a, out double chuVi, out double dienTich)
        {
            chuVi = Math.Round(2 * Math.PI * a, 3);
            dienTich = Math.Round(Math.PI * Math.Pow(a, 2), 3);
        }

        private static bool pitago(double a, double b, double c) 
        {
            return Math.Round((Math.Pow(c, 2)), 2) == Math.Round((Math.Pow(a, 2) + (Math.Pow(b, 2))), 2);
        }

        public static string checkTamGiac(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                return "-1";
            if (a + b > c && b + c > a && a + c > b)
            {
                if (a == b && b == c)
                    return "Tam Giác Đều";
                else if (a == b || b == c || c == a)
                    return "Tam Giác Cân";
                else if ((pitago(a, b, c)) || (pitago(a, c, b)) || (pitago(c, b, a)))
                    return "Tam Giác Vuông";
                else
                    return "Tam Giác Thường";
            }
            else
                return "-1";
        }

        public static void HinhTamGiac(double a, double b, double c, out double chuVi, out double dienTich)
        {
            chuVi = a + b + c;
            double p = chuVi / 2;
            dienTich = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}
