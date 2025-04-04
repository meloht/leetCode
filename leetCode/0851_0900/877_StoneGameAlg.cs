using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0851_0900
{
    public class _877_StoneGameAlg
    {
        public bool StoneGame1(int[] piles)
        {
            int n = piles.Length;
            int total = piles.Sum();
            bool[,] dp = new bool[n, n];

            return Dfs(piles, 0, piles.Length - 1, 0, 0, dp);
        }



        private bool Dfs(int[] piles, int i, int j, int num1, int total, bool[,] dp)
        {
            if (i > j)
            {
                if (num1 > total - num1)
                    return true;
                return false;
            }
            if (dp[i, j])
                return true;
            bool bl = Dfs(piles, i + 1, j - 1, num1 + piles[i], total, dp);
            if (bl)
            {
                dp[i, j] = true;
                return true;
            }

            bl = Dfs(piles, i + 1, j - 1, num1 + piles[j], total, dp);
            if (bl)
            {
                dp[i, j] = true;
                return true;
            }
            if (i + 1 < piles.Length)
            {
                bl = Dfs(piles, i + 2, j, num1 + piles[i], total, dp);
                if (bl)
                {
                    dp[i, j] = true;
                    return true;
                }
            }

            if (j - 1 >= 0)
            {
                bl = Dfs(piles, i, j - 2, num1 + piles[j], total, dp);
                if (bl)
                {
                    dp[i, j] = true;
                    return true;
                }

            }

            return false;

        }

        public bool StoneGame(int[] piles)
        {
            int n = piles.Length;
            int[,] dp = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                dp[i, i] = piles[i];
            }

            for (int i = n - 2; i >= 0; i--)
            {
                for (int j = i + 1; j < n; j++)
                {
                    dp[i, j] = Math.Max(piles[i] - dp[i + 1, j], piles[j] - dp[i, j - 1]);
                }
            }


            return dp[0, n - 1] > 0;
        }
    }
}
