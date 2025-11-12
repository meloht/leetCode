using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2651_2700
{
    public class _2654_MinimumNumberOfOperationsToMakeAllArrayElementsEqualTo1Alg
    {
        public int MinOperations(int[] nums)
        {
            int n = nums.Length, gcdAll = 0, cnt1 = 0;
            foreach (int x in nums)
            {
                gcdAll = gcd(gcdAll, x);
                if (x == 1) ++cnt1;
            }
            if (gcdAll > 1) return -1;
            if (cnt1 > 0) return n - cnt1;

            int minSize = n;
            List<int[]> g = new List<int[]>(); // [GCD，相同 GCD 闭区间的右端点]
            for (int i = 0; i < n; i++)
            {
                g.Add(new int[] { nums[i], i });
                // 原地去重，因为相同的 GCD 都相邻在一起
                var j = 0;
                for (int k = 0; k < g.Count; k++)
                {
                    var p = g[k];
                    p[0] = gcd(p[0], nums[i]);
                    if (g[j][0] == p[0])
                        g[j][1] = p[1]; // 合并相同值，下标取最小的
                    else g[++j] = p;
                }

                g.RemoveRange(j + 1, g.Count - j - 1);
             
                if (g[0][0] == 1)
                    // 这里本来是 i-g.get(0)[1]+1，把 +1 提出来合并到 return 中
                    minSize = Math.Min(minSize, i - g[0][1]);
            }
            return minSize + n - 1;


        }

        private int gcd(int a, int b)
        {
            while (a != 0)
            {
                int tmp = a;
                a = b % a;
                b = tmp;
            }
            return b;
        }

    }
}
