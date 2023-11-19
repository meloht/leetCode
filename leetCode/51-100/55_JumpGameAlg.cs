using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._51_100
{
    public class _55_JumpGameAlg
    {
        public bool CanJump(int[] nums)
        {
            if (nums.Length == 1)
            {
                return true;
            }
            int index = 0;
            int endIndex = nums.Length - 1;
            while (index < nums.Length)
            {
                int num = nums[index];
                if (num == 0 && index != endIndex)
                {
                    return false;
                }

                int end = index + num;
                if (end >= nums.Length - 1)
                {
                    return true;
                }
                int nextIndex = 0;
                int max = 0;
                for (int i = index + 1; i <= end; i++)
                {
                    int temp = nums[i] + i;
                    if (temp > max)
                    {
                        max = temp;
                        nextIndex = i;
                    }
                }
                index = nextIndex;
            }
            return false;
        }
    }
}
