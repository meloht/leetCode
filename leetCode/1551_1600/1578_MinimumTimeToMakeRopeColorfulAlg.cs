using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1551_1600
{
    public class _1578_MinimumTimeToMakeRopeColorfulAlg
    {
        public int MinCost(string colors, int[] neededTime)
        {
            int n = neededTime.Length;
            int ans = 0;
            int maxtime = 0;
            for (int i = 0; i < n; i++)
            {
                int t = neededTime[i];
                ans+= t;
                maxtime = Math.Max(maxtime, t);
                if (i == n - 1 || colors[i] != colors[i + 1])
                {
                    // 遍历到了连续同色段的末尾
                    ans -= maxtime; // 保留耗时最大的气球
                    maxtime = 0; // 准备计算下一段的最大耗时
                }
            }
            return ans;
        }
    }
}
