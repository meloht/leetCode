using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3151_3200
{
    public class _3165_MaximumSumOfSubsequenceWithNonAdjacentElementsAlg
    {
        public int MaximumSumSubsequence(int[] nums, int[][] queries)
        {
            int n = nums.Length;
            // 4 个数分别保存 f00, f01, f10, f11
            long[][] t = new long[2 << (32 - int.LeadingZeroCount(n))][];
            for (int i = 0; i < t.Length; i++)
            {
                t[i] = new long[4];
            }
            build(t, nums, 1, 0, n - 1);

            long ans = 0;
            foreach (int[] q in queries)
            {
                update(t, 1, 0, n - 1, q[0], q[1]);
                ans += t[1][3]; // 注意 f11 没有任何限制，也就是整个数组的打家劫舍
            }
            return (int)(ans % 1_000_000_007);
        }
       

        // 合并左右儿子
        private void maintain(long[][] t, int o)
        {
            long[] a = t[o * 2];
            long[] b = t[o * 2 + 1];
            t[o][0] = Math.Max(a[0] + b[2], a[1] + b[0]);
            t[o][1] = Math.Max(a[0] + b[3], a[1] + b[1]);
            t[o][2] = Math.Max(a[2] + b[2], a[3] + b[0]);
            t[o][3] = Math.Max(a[2] + b[3], a[3] + b[1]);
        }

        // 用 nums 初始化线段树
        private void build(long[][] t, int[] nums, int o, int l, int r)
        {
            if (l == r)
            {
                t[o][3] = Math.Max(nums[l], 0);
                return;
            }
            int m = (l + r) / 2;
            build(t, nums, o * 2, l, m);
            build(t, nums, o * 2 + 1, m + 1, r);
            maintain(t, o);
        }

        // 把 nums[i] 改成 val
        private void update(long[][] t, int o, int l, int r, int i, int val)
        {
            if (l == r)
            {
                t[o][3] = Math.Max(val, 0);
                return;
            }
            int m = (l + r) / 2;
            if (i <= m)
            {
                update(t, o * 2, l, m, i, val);
            }
            else
            {
                update(t, o * 2 + 1, m + 1, r, i, val);
            }
            maintain(t, o);
        }



    }
}
