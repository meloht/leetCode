using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2601_2650
{
    public class _2614_PrimeInDiagonalAlg
    {
        public int DiagonalPrime(int[][] nums)
        {
            int ans = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (IsPrime(nums[i][i]))
                {
                    ans=Math.Max(ans, nums[i][i]);
                }
                if (IsPrime(nums[i][nums.Length - i - 1]))
                {
                    ans = Math.Max(ans, nums[i][nums.Length - i - 1]);
                }
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
