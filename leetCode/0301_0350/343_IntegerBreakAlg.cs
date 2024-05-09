using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0301_0350
{
    public class _343_IntegerBreakAlg
    {
        public int IntegerBreak(int n)
        {
            if (n < 7)
            {
                switch (n)
                {
                    case 2:
                        return 1;
                    case 3:
                        return 2;
                    case 4:
                        return 4;
                    case 5:
                        return 6;
                    case 6:
                        return 9;
                    default:
                        return 0;
                }
            }
            int[] dp = new int[n];
            dp[0] = 1;
            dp[1] = 1;
            dp[2] = 2;
            dp[3] = 4;
            dp[4] = 6;
            dp[5] = 9;

            for (int i = 6; i < n; i++)
            {
                dp[i] = Math.Max(dp[i - 2] * 2, dp[i - 3] * 3);

            }
            return dp[n - 1];
        }
    }
}
