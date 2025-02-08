using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0751_0800
{
    public class _790_DominoAndTrominoTilingAlg
    {
        public int NumTilings(int N)
        {
            if (N == 1) return 1;
            if (N == 2) return 2;
            if (N == 3) return 5;
            int mod = 1000000007;
            int[] dp = new int[N + 1];
            dp[1] = 1;
            dp[2] = 2;
            dp[3] = 5;
            for (int i = 4; i <= N; i++)
            {
                dp[i] = ((2 * dp[i - 1]) % mod + dp[i - 3]) % mod;
            }
            return dp[N];
        }
    }
}
