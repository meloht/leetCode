using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1551_1600
{
    public class _1553_MinimumNumberOfDaysToEatNOrangesAlg
    {
       
        public int MinDays(int n)
        {
            Dictionary<int, int> dp = new Dictionary<int, int>();
            return Dfs(n, dp);
        }

        private int Dfs(int n, Dictionary<int, int> dp)
        {
            if (dp.ContainsKey(n))
            {
                return dp[n];
            }
            if (n <= 0)
            {
                return 0;
            }

            int ans = 0;
            if (n % 2 == 0 && n % 3 == 0)
            {
                ans = Math.Min(Dfs(n / 2, dp) + 1, Dfs(n / 3, dp) + 1);
            }
            else if (n % 2 == 0)
            {
                ans = Math.Min(Dfs(n / 2, dp) + 1, Dfs(n - 1, dp) + 1);
            }
            else if (n % 3 == 0)
            {
                ans = Math.Min(Dfs(n / 3, dp) + 1, Dfs(n - 1, dp) + 1);
            }
            else
            {
                ans = Dfs(n - 1, dp) + 1;
            }
            if (!dp.ContainsKey(n))
            {
                dp.Add(n, ans);
            }
            return ans;

        }
    }
}
