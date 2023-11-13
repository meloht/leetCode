using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1_50
{
    public class _45_JumpGameIIAlg
    {
        public int Jump(int[] nums)
        {
            if(nums.Length==1)
                return 0;
            int index = 0;
            int count = 0;
            while (index < nums.Length)
            {
                int num = nums[index];
                if (num == 0)
                    break;
                count++;
                int end = index + num;
                if (end >= nums.Length - 1)
                    break;
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
            return count;
        }
    }
}
