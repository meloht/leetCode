using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0401_0450
{
    public class _403_FrogJumpAlg
    {
        public bool CanCross(int[] stones)
        {
            int n = stones.Length;

            bool[,] dp = new bool[n, n];
            dp[0, 0] = true;
            for (int i = 1; i < n; i++)
            {
                if (stones[i] - stones[i - 1] > i)
                {
                    return false;
                }
            }

            for (int i = 1; i < n; i++)
            {
                for (int j = i - 1; j >= 0; j--)
                {
                    int k = stones[i] - stones[j];
                    if (k > j + 1)
                    {
                        break;
                    }
                    dp[i, k] = dp[j, k - 1] || dp[j, k] || dp[j, k + 1];
                    if (i == n - 1 && dp[i, k])
                    {
                        return true;
                    }
                }
            }
            return false;
        }


    }
}
