using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0101_0150
{
    public class _136_SingleNumberAlg
    {
        public int SingleNumber(int[] nums)
        {
            Array.Sort(nums);

            int len = nums.Length - 1;
            for (int i = 0; i < len; i += 2)
            {
                if (nums[i] != nums[i + 1])
                {
                    return nums[i];
                }
            }
            
            return nums[len];
        }
    }
}
