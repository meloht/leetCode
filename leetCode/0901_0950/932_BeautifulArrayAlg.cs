using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0901_0950
{
    public class _932_BeautifulArrayAlg
    {
        Dictionary<int, int[]> memo;
        public int[] BeautifulArray(int n)
        {
            memo = new Dictionary<int, int[]>();
            return Fun(n);
        }

        private int[] Fun(int n)
        {
            if (memo.ContainsKey(n))
            {
                return memo[n];
            }

            int[] ans = new int[n];
            if (n == 1)
            {
                ans[0] = 1;
            }
            else
            {
                int t = 0;
                int[] arr = Fun((n + 1) / 2);
                foreach (var item in arr)
                {
                    ans[t++] = 2 * item - 1;
                }
                int[] arr2 = Fun(n / 2);
                foreach (var item in arr2)
                {
                    ans[t++] = 2 * item;
                }
            }

            memo.Add(n, ans);

            return ans;
        }
    }
}
