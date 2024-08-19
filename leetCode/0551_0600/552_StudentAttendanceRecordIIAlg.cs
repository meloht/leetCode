using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0551_0600
{
    public class _552_StudentAttendanceRecordIIAlg
    {
        public static int Mod = 1_000_000_007;

        public int CheckRecord(int n)
        {
            int[][][] dp = new int[n + 1][][];
            for (int i = 0; i < n; i++)
            {
                dp[i] = new int[2][];
                for (int j = 0; j < 2; j++)
                {
                    int[] aa = new int[4];
                    Array.Fill(aa, -1);
                    dp[i][j] = aa;
                }
            }
            return Dfs(0, n, 0, 0, dp);
        }

        private int Dfs(int idx, int n, int a, int l, int[][][] dp)
        {

            if (a > 1)
            {
                return 0;
            }
            if (l >= 3)
            {
                return 0;
            }
            if (idx >= n)
            {
                return 1;
            }
            if (dp[idx][a][l] != -1)
            {
                return dp[idx][a][l];
            }
            int ans = 0;
            if (l > 0)
            {
                ans = (ans + Dfs(idx + 1, n, a, l + 1, dp)) % Mod;
            }
            else
            {
                ans = (ans + Dfs(idx + 1, n, a, 1, dp)) % Mod;
            }
            ans = (ans + Dfs(idx + 1, n, a + 1, 0, dp)) % Mod;
            ans = (ans + Dfs(idx + 1, n, a, 0, dp)) % Mod;
            dp[idx][a][l] = ans % Mod;
            return ans;
        }
    }
}
