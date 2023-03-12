using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai11
{
    public class Solution
    {
        public static bool checkSNT(int n) {
            if (n < 2)
                return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
                if (n % i == 0)
                    return false;
            return true;
        }

        public static string SNT(int n)
        {
            string result = "";
            for (int i = 2; i < n; i++)
                if (checkSNT(i))
                    result += i + " ";
            return result;
        }
    }
}
