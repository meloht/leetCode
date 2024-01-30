using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0251_0300
{
    public class _258_AddDigitsAlg
    {
        public int AddDigits1(int num)
        {
            string s = num.ToString();
            if (s.Length == 1)
                return num;


            int n = num;
            while (s.Length > 1)
            {
                n = s.Sum(p => p - '0');
                s = n.ToString();

            }

            return n;
        }

        public int AddDigits2(int num) 
        {
            while (num >= 10)
            {
                int n = 0;
                while (num > 0)
                {
                    n += num % 10;
                    num /= 10;
                }
                num = n;
            }
            return num;
        }

        public int AddDigits(int num)
        {
            return (num - 1) % 9 + 1;
        }
    }
}
