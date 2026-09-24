using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3501_3550
{
    public class _3550_SmallestIndexWithDigitSumEqualToIndexAlg
    {
        public int SmallestIndex(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                int num = nums[i];
                int sum = 0;
                while (num > 0)
                {
                    sum += num % 10;
                    num = num / 10;

                }
                if (sum == i)
                    return i;

            }
            return -1;
        }
    }
}
