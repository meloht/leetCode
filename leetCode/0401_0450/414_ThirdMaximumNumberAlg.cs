using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0401_0450
{
    public class _414_ThirdMaximumNumberAlg
    {
        public int ThirdMax(int[] nums)
        {
            Array.Sort(nums);
            if (nums.Length < 3)
            {
                return nums[nums.Length - 1];
            }
            int num =0;
            int count = 0;
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                if (count == 0)
                {
                    num = nums[i];
                   
                }
                else
                {
                    if (num == nums[i])
                    {
                        continue;
                    }
                    else
                    {
                        num = nums[i];
                    }
                }
                count++;
                if (count == 3)
                {
                    return num;
                }
            }

            return nums[nums.Length - 1];
        }
    }
}
