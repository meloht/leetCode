using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0651_0700
{
    public class _693_BinaryNumberWithAlternatingBitsAlg
    {
        public bool HasAlternatingBits1(int n)
        {
            string s = Convert.ToString(n, 2);
            bool bl = s[0] == '1';
            for (int i = 1; i < s.Length; i++)
            {
                if (bl)
                {
                    if (s[i] == '0')
                    {
                        bl = false;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    if (s[i] == '1')
                    {
                        bl = true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public bool HasAlternatingBits2(int n)
        {
            int prev = 2;
            while (n != 0)
            {
                int cur = n % 2;
                if (cur == prev)
                {
                    return false;
                }
                prev = cur;
                n /= 2;
            }
            return true;
        }

        public bool HasAlternatingBits(int n)
        {
            int a = n ^ (n >> 1);
            return (a & (a + 1)) == 0;
        }



    }
}
