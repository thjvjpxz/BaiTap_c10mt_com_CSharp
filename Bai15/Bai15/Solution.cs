using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai15
{
    public class Solution
    {
        private static string xoaCach(string s)
        {
            while (s.Contains("  "))
                s = s.Replace("  ", " ");

            if (s[0] == ' ')
                s = s.Substring(1, s.Length - 2);
            if (s[s.Length - 1] == ' ')
                s = s.Substring(0, s.Length - 1);
            return s;
        }

        public static string inThuong(string s)
        {
            s = xoaCach(s);
            string result = "";
            foreach (char item in s)
                if (Char.IsUpper(item))
                    result += Char.ToLower(item);
                else
                    result += item;
            return result;
        }

        public static string inHoa(string s)
        {
            s = xoaCach(s);
            string result = "";
            foreach (char item in s)
                if (Char.IsLower(item))
                    result += Char.ToUpper(item);
                else
                    result += item;
            return result;
        }
    }
}
