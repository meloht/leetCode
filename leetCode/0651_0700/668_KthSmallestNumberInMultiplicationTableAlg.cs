using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace leetCode._0651_0700
{
    public class _668_KthSmallestNumberInMultiplicationTableAlg
    {
        public int FindKthNumber(int m, int n, int k)
        {
            int left = 0;
            int right = m * n;

            while (left + 1 < right)
            {
                int mid = (left + right) >> 1;
                if (check(mid, m, n, k))
                {
                    right = mid;
                }
                else
                {
                    left = mid;
                }
            }

            return right;
        }
        private bool check(int x, int m, int n, int k)
        {
            int cnt = 0;
            for (int i = 1; i <= m; i++)
            {
                cnt += Math.Min(x / i, n);
            }
            return cnt >= k;
        }
    }
}
