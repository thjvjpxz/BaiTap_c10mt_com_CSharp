using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai12
{
    public class Solution
    {
        private static int GCD(int a, int b)
        {
            int x = Math.Max(a, b);
            int y = Math.Min(a, b);

            while (y != 0)
            {
                int r = x % y;
                x = y;
                y = r;
            }
            return x;
        }

        private static int LCM(int a, int b)
        {
            return (a * b) / GCD(a, b);
        }

        private static void RutGon(ref int tsr, ref int msr)
        {
            int gcd = GCD(tsr, msr);
            tsr /= gcd;
            msr /= gcd;
        }

        public static void CongPS(int ts1, int ts2, int ms1, int ms2, out int tsr, out int msr)
        {
            int mauChung = LCM(ms1, ms2);
            msr = mauChung;
            if (mauChung == ms1)
            {
                int so = mauChung / ms2;
                tsr = ts1 + (ts2 * so);
            }
            else if (mauChung == ms2)
            {
                int so = mauChung / ms1;
                tsr = ts2 + (ts1 * so);
            }
            else
            {
                int so1 = mauChung / ms1;
                int so2 = mauChung / ms2;
                tsr = (ts1 * so1) + (ts2 * so2);
            }

            RutGon(ref tsr, ref msr);
        }

        public static void TruPS(int ts1, int ts2, int ms1, int ms2, out int tsr, out int msr)
        {
            int mauChung = LCM(ms1, ms2);
            msr = mauChung;
            if (mauChung == ms1)
            {
                int so = mauChung / ms2;
                tsr = ts1 - (ts2 * so);
            }
            else if (mauChung == ms2)
            {
                int so = mauChung / ms1;
                tsr = (ts1 * so) - ts2;
            }
            else
            {
                int so1 = mauChung / ms1;
                int so2 = mauChung / ms2;
                tsr = (ts1 * so1) - (ts2 * so2);
            }

            RutGon(ref tsr, ref msr);
        }

        public static void NhanPS(int ts1, int ts2, int ms1, int ms2, out int tsr, out int msr)
        {
            tsr = ts1 * ts2;
            msr = ms1 * ms2;

            RutGon(ref tsr, ref msr);
        }
    }
}
