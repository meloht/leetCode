using System;
using System.Collections.Generic;
using System.Text;

namespace leetCode._1151_1200
{
    public class _1175_prime_arrangements
    {
        const int MOD = 1000000007;

        public int NumPrimeArrangements(int n)
        {
            int numPrimes = 0;
            for (int i = 1; i <= n; i++)
            {
                if (IsPrime(i))
                {
                    numPrimes++;
                }
            }
            return (int)(Factorial(numPrimes) * Factorial(n - numPrimes) % MOD);
        }

        public bool IsPrime(int n)
        {
            if (n == 1)
            {
                return false;
            }
            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public long Factorial(int n)
        {
            long res = 1;
            for (int i = 1; i <= n; i++)
            {
                res *= i;
                res %= MOD;
            }
            return res;
        }




    }
}
