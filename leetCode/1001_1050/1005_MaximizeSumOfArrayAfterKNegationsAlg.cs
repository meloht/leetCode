using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1001_1050
{
    public class _1005_MaximizeSumOfArrayAfterKNegationsAlg
    {
        public int LargestSumAfterKNegations(int[] nums, int k)
        {
            Array.Sort(nums);
            int indexZero = -1;
            int indexMin = -1;
            int min = int.MaxValue;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0 && indexZero == -1)
                {
                    indexZero = i;
                }
                if (Math.Abs(nums[i]) <= min)
                {
                    indexMin = i;
                    min = Math.Abs(nums[i]);
                }
                if (nums[i] < 0 && k > 0)
                {
                    nums[i] = -nums[i];
                    k--;
                }

            }
            if (k > 0)
            {
                if (indexZero != -1)
                {
                    return nums.Sum();
                }
                else
                {
                    k = k % 2;
                    if (k == 1)
                    {
                        nums[indexMin] = -nums[indexMin];
                    }

                    return nums.Sum();
                }
            }
            else
            {
                return nums.Sum();
            }
        }
    }
}
