using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2501_2550
{
    public class _2535_DifferenceBetweenElementSumAndDigitSumOfAnArrayAlg
    {
        public int DifferenceOfSum(int[] nums)
        {
            int sum = nums.Sum();

            int total = 0;
            foreach (var item in nums)
            {
                int n = item;
                while (n > 0)
                {
                    total += (n % 10);
                    n = n / 10;
                }
            }

            return Math.Abs(sum - total);
        }
    }
}
