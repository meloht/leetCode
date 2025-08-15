using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1001_1050
{
    public class _1049_LastStoneWeightIIAlg
    {
        public int LastStoneWeightII(int[] stones)
        {
            int n = stones.Length;
            int sum = 0;
            foreach (int i in stones) sum += i;
            int t = sum / 2;
            int[] f = new int[t + 1];
            for (int i = 1; i <= n; i++)
            {
                int x = stones[i - 1];
                for (int j = t; j >= x; j--)
                {
                    f[j] = Math.Max(f[j], f[j - x] + x);
                }
            }
            return Math.Abs(sum - f[t] - f[t]);


        }
    }
}
