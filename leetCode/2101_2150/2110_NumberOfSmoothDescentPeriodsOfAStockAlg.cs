using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2101_2150
{
    public class _2110_NumberOfSmoothDescentPeriodsOfAStockAlg
    {
        public long GetDescentPeriods(int[] prices)
        {

            long ans = 0;
            int dec = 0;
            for (int i = 0; i < prices.Length; i++)
            {
                if (i > 0 && prices[i] == prices[i - 1] - 1)
                {
                    dec++; // 连续递减
                }
                else
                {
                    dec = 1; // 连续递减中断，重新统计
                }
                ans += dec; // dec 是右端点为 i 的连续递减子数组个数
            }
            return ans;

        }
    }
}
