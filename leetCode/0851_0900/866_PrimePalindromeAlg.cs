using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0851_0900
{
    public class _866_PrimePalindromeAlg
    {
        public int PrimePalindrome(int n)
        {
            while (true)
            {
                if (n == Reverse(n) && IsPrime(n))
                    return n;
                n++;
                if (10_000_000 < n && n < 100_000_000)
                    n = 100_000_000;

            }

        }

        private int Reverse(int n)
        {
            int ans = 0;
            while (n > 0)
            {
                ans = 10 * ans + (n % 10);
                n /= 10;
            }
            return ans;
        }
        public bool IsPrime(int n)
        {
            if (n <= 1)
                return false;
            if (n <= 3)
                return true;

            if (n % 2 == 0 || n % 3 == 0)
                return false;

            for (int i = 5; i * i <= n; i += 6)
            {
                if (n % i == 0 || n % (i + 2) == 0)
                    return false;
            }

            return true;
        }

    }
}
