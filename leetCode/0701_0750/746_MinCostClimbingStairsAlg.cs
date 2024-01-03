using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0701_0750
{
    public class _746_MinCostClimbingStairsAlg
    {
        public int MinCostClimbingStairs1(int[] cost)
        {
            int[] dp = new int[cost.Length + 1];
            dp[0] = cost[0];
            dp[1] = cost[1];
            for (int i = 2; i <= cost.Length; i++)
            {
                if (i < cost.Length)
                {
                    dp[i] = Math.Min(dp[i - 2], dp[i - 1]) + cost[i];
                }
                else
                {
                    dp[i] = Math.Min(dp[i - 2], dp[i - 1]);
                }

            }
            return dp[cost.Length];
        }

        public int MinCostClimbingStairs2(int[] cost)
        {
            int[] dp = new int[cost.Length + 1];
            dp[0] = 0;
            dp[1] = 0;
            for (int i = 2; i <= cost.Length; i++)
            {
                dp[i] = Math.Min(dp[i - 2] + cost[i - 2], dp[i - 1] + cost[i - 1]);

            }
            return dp[cost.Length];
        }
        public int MinCostClimbingStairs(int[] cost)
        {
            int prev = 0;
            int curr = 0;
            for (int i = 2; i <= cost.Length; i++)
            {
                int next= Math.Min(prev + cost[i - 2], curr + cost[i - 1]);
                prev = curr;
                curr = next;

            }
            return curr;
        }
    }
}
