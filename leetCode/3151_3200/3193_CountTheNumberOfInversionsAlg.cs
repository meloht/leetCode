using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace leetCode._3151_3200
{
    public class _3193_CountTheNumberOfInversionsAlg
    {
        public int NumberOfPermutations(int n, int[][] requirements)
        {
            int MOD = 1_000_000_007;
            int[] req = new int[n];
            Array.Fill(req, -1);
            req[0] = 0;
            int m = 0;
            foreach (int[] p in requirements)
            {
                req[p[0]] = p[1];
                m = Math.Max(m, p[1]);
            }
            if (req[0] > 0)
            {
                return 0;
            }

            int[] f = new int[m + 1];
            f[0] = 1;
            for (int i = 1; i < n; i++)
            {
                int mx = req[i] < 0 ? m : req[i];
                int r = req[i - 1];
                if (r >= 0)
                {
                    Array.Fill(f, 0, 0, r);
                    Array.Fill(f, f[r], r + 1, Math.Min(i + r, mx) - r);
                    Array.Fill(f, 0, Math.Min(i + r, mx) + 1, m - Math.Min(i + r, mx));
                }
                else
                {
                    for (int j = 1; j <= mx; j++)
                    { // 计算前缀和
                        f[j] = (f[j] + f[j - 1]) % MOD;
                    }
                    for (int j = mx; j > i; j--)
                    { // 计算子数组和
                        f[j] = (f[j] - f[j - i - 1] + MOD) % MOD;
                    }
                }
            }
            return f[req[n - 1]];


        }
    }
}
