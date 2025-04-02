using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0851_0900
{
    public class _869_ReorderedPowerOf2Alg
    {
        public bool ReorderedPowerOf2(int n)
        {
            HashSet<string> set = new HashSet<string>();

            int max = 1000_000_000;
            string ss = GetNum(n);
            int num = 1;
            while (num <= max)
            {
                string s = GetNum(num);
                if (s == ss)
                    return true;
                num = num * 2;
            }
            return false;
        }

        private string GetNum(int n)
        {
            List<char> list = new List<char>();
            while (n > 0)
            {
                int num = n % 10;
                list.Add((char)(num + '0'));
                n = n / 10;
            }
            list.Sort();
            return new string(list.ToArray());
        }
    }
}
