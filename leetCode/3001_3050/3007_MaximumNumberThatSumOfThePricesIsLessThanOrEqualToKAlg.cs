using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace leetCode._3001_3050
{
    public class _3007_MaximumNumberThatSumOfThePricesIsLessThanOrEqualToKAlg
    {
        public long FindMaximumNumber1(long k, int x)
        {
            this.x = x;
            // 开区间二分，
            long left = 0;
            long right = (k + 1) << x;
            while (left + 1 < right)
            {
                long mid = (left + right) >>> 1;
                if (countDigitOne(mid) <= k)
                {
                    left = mid;
                }
                else
                {
                    right = mid;
                }
            }
            return left;


        }

        private int x;
        private long num;
        private long[][] memo;

        private long countDigitOne(long num)
        {
            this.num = num;
            int m = 64 - (int)long.LeadingZeroCount(num);
            memo = new long[m][];
            for (int i = 0; i < m; i++)
            {
                memo[i] = new long[m + 1];
                Array.Fill(memo[i], -1);
            }

            return Dfs(m - 1, 0, true);
        }

        private long Dfs(int i, int cnt1, bool isLimit)
        {
            if (i < 0)
            {
                return cnt1;
            }
            if (!isLimit && memo[i][cnt1] != -1)
            {
                return memo[i][cnt1];
            }
            int up = isLimit ? (int)(num >> i & 1) : 1;
            long res = 0;
            for (int d = 0; d <= up; d++)
            { // 枚举要填入的数字 d
                res += Dfs(i - 1, cnt1 + (d == 1 && (i + 1) % x == 0 ? 1 : 0), isLimit && d == up);
            }
            if (!isLimit)
            {
                memo[i][cnt1] = res;
            }
            return res;
        }


        public long FindMaximumNumber(long k, int x)
        {
            long num = 0;
            long pre1 = 0;
           
            for (long i = 63 - long.LeadingZeroCount((k + 1) << x); i >= 0; i--)
            {
                long cnt = (pre1 << (int)i) + (i / x << (int)i >> 1);
                if (cnt > k)
                {
                    continue;
                }
                k -= cnt;
                num |= 1L << (int)i;
                if ((i + 1) % x == 0)
                {
                    pre1++;
                }
            }
            return num - 1;
        }




    }
}
