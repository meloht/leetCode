using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2301_2350
{
    public class _2338_CountTheNumberOfIdealArraysAlg
    {
        const int Mod = 1_000_000_007;
        const int maxN = 10000;
        const int maxE = 13;
        private static List<int>[] EXP = new List<int>[maxN + 1];
        private static int[,] C = new int[maxN + maxE, maxE + 1];
        private static bool done = false;

        private void Init()
        {
            if (done)
            {
                return;
            }
            done = true;
            // EXP[x] 为 x 分解质因数后，每个质因数的指数
            for (int x = 1; x < EXP.Length; x++)
            {
                EXP[x] = new List<int>();
                int t = x;
                for (int i = 2; i * i <= t; i++)
                {
                    int e = 0;
                    for (; t % i == 0; t /= i)
                    {
                        e++;
                    }
                    if (e > 0)
                    {
                        EXP[x].Add(e);
                    }
                }
                if (t > 1)
                {
                    EXP[x].Add(1);
                }
            }

            // 预处理组合数
            for (int i = 0; i < maxN + maxE; i++)
            {
                C[i, 0] = 1;
                for (int j = 1; j <= Math.Min(i, maxE); j++)
                {
                    C[i, j] = (C[i - 1, j] + C[i - 1, j - 1]) % Mod;
                }
            }


        }
        public int IdealArrays(int n, int maxValue)
        {
            Init();

            long ans = 0;
            for (int i = 1; i <= maxValue; i++)
            {
                long mul = 1;
                foreach (int e in EXP[i])
                {
                    mul = mul * C[n + e - 1, e] % Mod;
                }
                ans += mul;
            }

            return (int)(ans % Mod);
        }
    }
}
