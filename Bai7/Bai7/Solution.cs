using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6
{
    public class Solution
    {
        public static int GCD(int a, int b)
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

        public static int LCM(int a, int b)
        {
            return (a * b) / GCD(a, b);
        }
    }
}
