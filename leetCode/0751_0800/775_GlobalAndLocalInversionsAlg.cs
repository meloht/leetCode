using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0751_0800
{
    public class _775_GlobalAndLocalInversionsAlg
    {
        public bool IsIdealPermutation1(int[] nums)
        {
            int global = 0;
            int local = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (i + 1 < nums.Length && nums[i] > nums[i + 1])
                {
                    local++;
                }
                if (i < nums[i])
                {
                    global += nums[i] - i;
                }
                else if (i - nums[i] > 1)
                {
                    global += i - nums[i] - 1;
                }
            }

            return global == local;
        }

        public bool IsIdealPermutation(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (Math.Abs(nums[i] - i) > 1)
                {
                    return false;
                }
            }
            return true;
        }


    }
}
