using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0701_0750
{
    public class _747_LargestNumberAtLeastTwiceOfOthersAlg
    {
        public int DominantIndex(int[] nums)
        {
            int max = int.MinValue;
            int index = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > max)
                {
                    index = i;
                    max = nums[i];
                }
            }
            for (int i = 0; i < nums.Length; i++)
            {
                if (i == index)
                {
                    continue;
                }
                if (nums[i] != 0 && max / nums[i] < 2 && max % nums[i] != 0)
                {
                    return -1;
                }
            }
            return index;
        }
    }
}
