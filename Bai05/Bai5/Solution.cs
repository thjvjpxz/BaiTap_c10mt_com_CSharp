using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5
{
    public class Solution
    {
        public static double phuongTrinhBac1(double a, double b)
        {
            return -b / a;
        }

        public static bool phuongTrinhBac2(double a, double b, double c,
            out double? res1, out double? res2)
        {
            double denta = b * b - (4 * a * c);
            if (denta < 0)
            {
                res1 = null;
                res2 = null;
                return false;
            }
            else if (denta == 0)
            {
                double res = -b / (2 * a);
                res1 = res;
                res2 = res;
            }
            else
            {
                res1 = (-b - Math.Sqrt(denta)) / (2 * a);
                res2 = (-b + Math.Sqrt(denta)) / (2 * a);
            }
            return true;
        }

    }
}
