using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3601_3650
{
    public class _3623_CountNumberOfTrapezoidsIAlg
    {
        public int CountTrapezoids(int[][] points)
        {
            int MOD = 1_000_000_007;
            Dictionary<int, int> cnt = []; // 预分配空间
            foreach (int[] p in points)
            {
               
                if (cnt.ContainsKey(p[1]))
                {
                    cnt[p[1]]++;
                }
                else
                {
                    cnt.Add(p[1], 1);
                }
                
            }

            long ans = 0, s = 0;
            foreach (int c in cnt.Values)
            {
                long k = (long)c * (c - 1) / 2;
                ans += s * k;
                s += k;
            }
            return (int)(ans % MOD);


        }
    }
}
