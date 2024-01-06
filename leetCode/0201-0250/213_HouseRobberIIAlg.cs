using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0201_0250
{
    public class _213_HouseRobberIIAlg
    {
        public int Rob(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                return 0;
            }
            int length = nums.Length;
            if (length == 1)
            {
                return nums[0];
            }
            else if (length == 2)
            {
                return Math.Max(nums[0], nums[1]);
            }

            int max1 = Rob(nums, 0, length - 2);
            int max2 = Rob(nums, 1, length - 1);

            return Math.Max(max1, max2);
        }

        private int Rob(int[] nums, int begin, int end)
        {
            int first = nums[begin];
            int second = Math.Max(nums[begin], nums[begin + 1]);
            for (int i = begin + 2; i <= end; i++)
            {
                int temp = Math.Max(first + nums[i], second);
                first = second;
                second = temp;
            }
            return second;
        }


    }
}
