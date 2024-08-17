using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0451_0500
{
    public class _479_LargestPalindromeProductAlg
    {
        public int LargestPalindrome(int n)
        {
            if (n == 1)
                return 9;
            int max = (int)Math.Pow(10, n) - 1;
            int ans = 0;
            for (int left = max; ans == 0; left--)
            {
                long p = left;
                for (int x = left; x > 0; x /= 10)
                {
                    p = p * 10 + x % 10;
                }
                for (long i = max; i * i >= p; i--)
                {
                    if (p % i == 0)
                    {
                        ans = (int)(p % 1337);
                        break;
                    }
                }
            }
            return ans;
        }
    }
}
