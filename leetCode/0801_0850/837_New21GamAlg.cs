using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0801_0850
{
    public class _837_New21GamAlg
    {
        public double New21Game(int n, int k, int maxPts)
        {
            if (k == 0 || n >= k + maxPts - 1)
            {
                return 1.0;
            }

            double[] dp = new double[k + maxPts];
            for (int i = k; i <= Math.Min(n, k + maxPts - 1); i++)
            {
                dp[i] = 1.0;
            }

            double sum = 0;
            for (int i = k; i < k + maxPts; i++)
            {
                sum += dp[i];
            }

            for (int i = k - 1; i >= 0; i--)
            {
                dp[i] = sum / maxPts;
                sum = sum - dp[i + maxPts] + dp[i];
            }

            return dp[0];
        }
    }
}
