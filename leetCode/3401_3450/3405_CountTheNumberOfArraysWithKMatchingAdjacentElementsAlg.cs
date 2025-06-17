using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace leetCode._3401_3450
{
    public class _3405_CountTheNumberOfArraysWithKMatchingAdjacentElementsAlg
    {
        const int MOD = 1_000_000_007;
        const int MX = 100000;
        static long[] fac = new long[MX];
        static long[] invF = new long[MX];

        private static bool initialized = false;

        private void init()
        {
            if (initialized)
            {
                return;
            }
            initialized = true;

            fac[0] = 1;
            for (int i = 1; i < MX; i++)
            {
                fac[i] = fac[i - 1] * i % MOD;
            }

            invF[MX - 1] = pow(fac[MX - 1], MOD - 2);
            for (int i = MX - 1; i > 0; i--)
            {
                invF[i - 1] = invF[i] * i % MOD;
            }
        }
        private long pow(long x, int n)
        {
            long res = 1;
            for (; n > 0; n /= 2)
            {
                if (n % 2 > 0)
                {
                    res = res * x % MOD;
                }
                x = x * x % MOD;
            }
            return res;
        }
        private long comb(int n, int m)
        {
            return fac[n] * invF[m] % MOD * invF[n - m] % MOD;
        }



        public int CountGoodArrays(int n, int m, int k)
        {
            init();
            return (int)(comb(n - 1, k) * m % MOD * pow(m - 1, n - k - 1) % MOD);

        }
    }
}
