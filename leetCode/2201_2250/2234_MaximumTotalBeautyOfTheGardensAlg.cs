using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2201_2250
{
    public class _2234_MaximumTotalBeautyOfTheGardensAlg
    {
        public long MaximumBeauty(int[] flowers, long newFlowers, int target, int full, int partial)
        {
            int n = flowers.Length;
            long leftFlowers = newFlowers - (long)target * n;
            for (int i = 0; i < n; i++)
            {
                flowers[i] = Math.Min(flowers[i], target);
                leftFlowers += flowers[i];
            }
            // 没有种花，所有花园都已种满
            if (leftFlowers == newFlowers)
            {
                return (long)n * full; // 答案只能是 n*full（注意不能减少花的数量）
            }

            if (leftFlowers >= 0)
            {
                return Math.Max((long)(target - 1) * partial + (long)(n - 1) * full, (long)n * full);
            }

            Array.Sort(flowers);

            long ans = 0;
            long preSum = 0;
            int j = 0;
            // 枚举 i，表示后缀 [i, n-1] 种满（i=0 的情况上面已讨论）
            for (int i = 1; i <= n; i++)
            {
                // 撤销，flowers[i-1] 不变成 target
                leftFlowers += target - flowers[i - 1];
                if (leftFlowers < 0)
                { // 花不能为负数，需要继续撤销
                    continue;
                }

                // 满足以下条件说明 [0, j] 都可以种 flowers[j] 朵花
                while (j < i && (long)flowers[j] * j <= preSum + leftFlowers)
                {
                    preSum += flowers[j];
                    j++;
                }

                // 计算总美丽值
                // 在前缀 [0, j-1] 中均匀种花，这样最小值最大
                long avg = (leftFlowers + preSum) / j; // 由于上面特判了，这里 avg 一定小于 target
                long totalBeauty = avg * partial + (long)(n - i) *full;
                ans = Math.Max(ans, totalBeauty);
            }

            return ans;

        }
    }
}
