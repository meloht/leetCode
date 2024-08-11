using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1001_1050
{
    public class _1035_UncrossedLinesAlg
    {
        public int MaxUncrossedLines(int[] nums1, int[] nums2)
        {
            int n = nums1.Length;
            int m = nums2.Length;

            int[][] memo = new int[n][];
            for (int i = 0; i < n; i++)
            {
                memo[i] = new int[m];
                Array.Fill(memo[i], -1);
            }
            return Dfs(n - 1, m - 1, nums1, nums2, memo);
        }

        private int Dfs(int i, int j, int[] s, int[] t, int[][] memo)
        {
            if (i < 0 || j < 0)
                return 0;

            if (memo[i][j] != -1)
                return memo[i][j];

            if (s[i] == t[j])
            {
                memo[i][j] = Dfs(i - 1, j - 1, s, t, memo) + 1;
                return memo[i][j];
            }
            memo[i][j] = Math.Max(Dfs(i - 1, j, s, t, memo), Dfs(i, j - 1, s, t, memo));
            return memo[i][j];
        }
    }
}
