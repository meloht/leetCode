using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode.WeeklyContest
{
    public class Alg_374_CountTheNumberOfInfectionSequences
    {
        private static int Mod = 1_000_000_007;
        private static int Max = 100000;
        private static long[] Fac;
        private static long[] InvFac;
        static Alg_374_CountTheNumberOfInfectionSequences()
        {
            Init();
        }

        public int NumberOfSequence(int n, int[] sick)
        {
            
            int m = sick.Length;
            int total = n - m;
            long ans = Comb(total, sick[0]) * Comb(total - sick[0], n - sick[m - 1] - 1) % Mod;
            total -= sick[0] + n - sick[m - 1] - 1;
            int e = 0;
            for (int i = 1; i < m; i++)
            {
                int k = sick[i] - sick[i - 1] - 1;
                if (k > 0)
                {
                    e += k - 1;
                    ans = ans * Comb(total, k) % Mod;
                    total -= k;
                }
            }
            return (int)(ans * Pow(2, e) % Mod);

        }
        private static long Pow(long x, int n)
        {
            long res = 1;
            for (; n > 0; n /= 2)
            {
                if (n % 2 > 0)
                {
                    res = res * x % Mod;
                }
                x = x * x % Mod;
            }
            return res;
        }

        private long Comb(int n, int k)
        {
            return Fac[n] * InvFac[k] % Mod * InvFac[n - k] % Mod;
        }
        private static void Init()
        {
            Fac = new long[Max];
            InvFac = new long[Max];
            Fac[0] = 1;
            for (int i = 1; i < Max; i++)
            {
                Fac[i] = Fac[i - 1] * i % Mod;
            }
            InvFac[Max - 1] = Pow(Fac[Max - 1], Mod - 2);
            for (int i = Max - 1; i > 0; i--)
            {
                InvFac[i - 1] = InvFac[i] * i % Mod;
            }

        }



    }
}
