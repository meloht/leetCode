using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0601_0650
{
    public class _639_DecodeWaysIIAlg
    {
        const int MOD = 1000000007;
        public int NumDecodings(string s)
        {
            int n = s.Length;
            long a = 0;
            long b = 1;
            long c = 0;

            for (int i = 1; i <= n; i++)
            {
                c = b * Check1Digit(s[i - 1]) % MOD;
                if (i > 1)
                {
                    c = (c + a * Check2Digit(s[i - 2], s[i - 1])) % MOD;
                }
                a = b;
                b = c;
            }

            return (int)c;
        }

      

        private int Check1Digit(char ch)
        {
            if (ch == '0')
            {
                return 0;
            }
            return ch == '*' ? 9 : 1;
        }

        private int Check2Digit(char ch0, char ch1)
        {
            if (ch0 == '*' && ch1 == '*')
            {
                return 15;
            }
            if (ch0 == '*')
            {
                return ch1 <= '6' ? 2 : 1;
            }
            if (ch1 == '*')
            {
                if (ch0 == '1')
                {
                    return 9;
                }
                if (ch0 == '2')
                {
                    return 6;
                }
                return 0;
            }
            return (ch0 != '0' && (ch0 - '0') * 10 + (ch1 - '0') <= 26) ? 1 : 0;
        }

    }
}
