using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace leetCode._3451_3500
{
    public class _3480_MaximizeSubarraysAfterRemovingOneConflictingPairAlg
    {
        public long MaxSubarrays(int n, int[][] conflictingPairs)
        {
            int[] g0 = new int[n + 1];
            int[] g1 = new int[n + 1];
            Array.Fill(g0, n + 1);
            Array.Fill(g1, n + 1);

            foreach (int[] p in conflictingPairs)
            {
                int a = p[0];
                int b = p[1];
                if (a > b)
                {
                    int tmp = a;
                    a = b;
                    b = tmp;
                }
                if (b < g0[a])
                {
                    g1[a] = g0[a];
                    g0[a] = b;
                }
                else if (b < g1[a])
                {
                    g1[a] = b;
                }
            }

            long ans = 0;
            long maxExtra = 0;
            long extra = 0;
            int b0 = n + 1;
            int b1 = n + 1;

            for (int i = n; i > 0; i--)
            {
                int preB0 = b0;

                int b = g0[i];
                if (b < b0)
                {
                    b1 = Math.Min(b0, g1[i]);
                    b0 = b;
                }
                else if (b < b1)
                {
                    b1 = b;
                }

                ans += b0 - i;
                if (b0 != preB0)
                { // 重新统计连续相同 b0 的 extra
                    extra = 0;
                }
                extra += b1 - b0;
                maxExtra = Math.Max(maxExtra, extra);
            }

            return ans + maxExtra;

        }
    }
}
