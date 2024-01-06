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
            bool[] visited= new bool[nums.Length];
            int first = nums[0];
            int second = Math.Max(nums[0], nums[1]);
            for (int i = 2; i < length; i++)
            {
                int temp = Math.Max(first + nums[i], second);
                first = second;
                second = temp;
            }
            return 0;
        }
    }
}
