using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0451_0500
{
    public class _481_MagicalStringAlg
    {
        public int MagicalString1(int n)
        {
            int[] s = new int[n + 2];
            s[0] = 1; s[1] = s[2] = 2;
            int c = 2;
            for (int i = 2, j = 3; j < n; ++i)
            {
                c ^= 3; // 1^3=2, 2^3=1，这样就能在 1 和 2 之间转换
                s[j++] = c;
                if (s[i] == 2) s[j++] = c;
            }
            int ans = 0;
            for (int i = 0; i < n; ++i) ans += 2 - s[i]; // 2-1=1，2-2=0，这样就只统计了 1
            return ans;


        }

        public int MagicalString(int n)
        {
            if (n < 4)
            {
                return 1;
            }
            int[] s = new int[n];
            s[0] = 1;
            s[1] = 2;
            s[2] = 2;
            int res = 1;
            int i = 2;
            int j = 3;
            while (j < n)
            {
                int size = s[i];
                int num = 3 - (s[j - 1] );
                while (size > 0 && j < n)
                {
                    s[j] = num;
                    if (num == 1)
                    {
                        ++res;
                    }
                    ++j;
                    --size;
                }
                ++i;
            }
            return res;
        }


    }
}
