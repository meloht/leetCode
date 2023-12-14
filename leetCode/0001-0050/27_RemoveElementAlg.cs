using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1_50
{
    internal class RemoveElementAlg
    {
        public int RemoveElement(int[] nums, int val)
        {
            if (nums == null || nums.Length == 0)
                return 0;


            int j = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[j] == val && nums[i] != val)
                {
                    nums[j] = nums[i];
                    nums[i] = val;


                }
                if (nums[j] != val)
                {
                    j++;
                }

            }

            return j;
        }
    }
}
