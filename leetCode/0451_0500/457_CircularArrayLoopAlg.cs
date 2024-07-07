using leetCode._1501_1550;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0451_0500
{
    public class _457_CircularArrayLoopAlg
    {
        public bool CircularArrayLoop(int[] nums)
        {
            int n = nums.Length;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                    continue;

                int slow = i;
                int fast = Next(nums, i);
                while (nums[slow] * nums[fast] > 0 && nums[slow] * nums[Next(nums, fast)] > 0)
                {
                    if (slow == fast)
                    {
                        if (slow != Next(nums, slow))
                        {
                            return true;
                        }
                        else
                        {
                            break;
                        }
                    }
                    slow = Next(nums, slow);
                    fast = Next(nums, Next(nums, fast));
                }
                int add = i;
                while (nums[add] * nums[Next(nums, add)] > 0)
                {
                    int temp = add;
                    add = Next(nums, add);
                    nums[temp] = 0;
                }
            }


            return false;
        }
        private int Next(int[] nums, int cur)
        {
            int n = nums.Length;
            return ((cur + nums[cur]) % n + n) % n;
        }
    }
}
