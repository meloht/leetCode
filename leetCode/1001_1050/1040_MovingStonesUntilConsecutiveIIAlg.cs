using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1001_1050
{
    public class _1040_MovingStonesUntilConsecutiveIIAlg
    {
        public int[] NumMovesStonesII(int[] stones)
        {
            Array.Sort(stones);

            int n = stones.Length;
            int e1 = stones[n - 2] - stones[0] - n + 2;
            int e2 = stones[n - 1] - stones[1] - n + 2; // 计算空位
            int maxMove = Math.Max(e1, e2);
            if (e1 == 0 || e2 == 0) // 特殊情况：没有空位
                return new int[] { Math.Min(2, maxMove), maxMove };
            int maxCnt = 0, left = 0;
            for (int right = 0; right < n; ++right)
            { // 滑动窗口：枚举右端点所在石子
                while (stones[right] - stones[left] + 1 > n) // 窗口长度大于 n
                    ++left; // 缩小窗口长度
                maxCnt = Math.Max(maxCnt, right - left + 1); // 维护窗口内的最大石子数
            }
            return [n - maxCnt, maxMove];
        }
    }
}
