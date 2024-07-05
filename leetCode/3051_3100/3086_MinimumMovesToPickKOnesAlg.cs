using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3051_3100
{
    public class _3086_MinimumMovesToPickKOnesAlg
    {
        public long MinimumMoves(int[] nums, int k, int maxChanges)
        {
            List<int> pos = new List<int>();
            int c = 0; // nums 中连续的 1 长度
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0) 
                    continue;
                pos.Add(i); // 记录 1 的位置
                c = Math.Max(c, 1);
                if (i > 0 && nums[i - 1] == 1)
                {
                    if (i > 1 && nums[i - 2] == 1)
                    {
                        c = 3; // 有 3 个连续的 1
                    }
                    else
                    {
                        c = Math.Max(c, 2); // 有 2 个连续的 1
                    }
                }
            }

            c = Math.Min(c, k);
            if (maxChanges >= k - c)
            {
                // 其余 k-c 个 1 可以全部用两次操作得到
                return Math.Max(c - 1, 0) + (k - c) * 2;
            }

            int n = pos.Count;
            long[] sum = new long[n + 1];
            for (int i = 0; i < n; i++)
            {
                sum[i + 1] = sum[i] + pos[i];
            }

            long ans = long.MaxValue;
            // 除了 maxChanges 个数可以用两次操作得到，其余的 1 只能一步步移动到 pos[i]
            int size = k - maxChanges;
            for (int right = size; right <= n; right++)
            {
                // s1+s2 是 j 在 [left, right) 中的所有 pos[j] 到 index=pos[(left+right)/2] 的距离之和
                int left = right - size;
                int i = left + size / 2;
                long index = pos[i];
                long s1 = index * (i - left) - (sum[i] - sum[left]);
                long s2 = sum[right] - sum[i] - index * (right - i);
                ans = Math.Min(ans, s1 + s2);
            }
            return ans + maxChanges * 2;


        }
    }
}
