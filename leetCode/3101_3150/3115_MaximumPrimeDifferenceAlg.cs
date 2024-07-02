using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3101_3150
{
    public class _3115_MaximumPrimeDifferenceAlg
    {
        public int MaximumPrimeDifference(int[] nums)
        {

            int i = 0;
            int j = nums.Length - 1;
            bool bl = false;

            while (i < j)
            {
                if (!IsPrime(nums[i]))
                {
                    i++;
                    continue;
                }
                bl = true;
                break;
            }

            while (i < j)
            {

                if (IsPrime(nums[j]) && bl)
                {
                    return j - i;
                }
                j--;

            }
            return 0;
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
