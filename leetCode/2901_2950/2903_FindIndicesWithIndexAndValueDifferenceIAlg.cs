using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2901_2950
{
    public class _2903_FindIndicesWithIndexAndValueDifferenceIAlg
    {
        public int[] FindIndices(int[] nums, int indexDifference, int valueDifference)
        {
            int minIndex = 0, maxIndex = 0;
            for (int j = indexDifference; j < nums.Length; j++)
            {
                int i = j - indexDifference;
                if (nums[i] < nums[minIndex])
                {
                    minIndex = i;
                }
                if (nums[j] - nums[minIndex] >= valueDifference)
                {
                    return new int[] { minIndex, j };
                }
                if (nums[i] > nums[maxIndex])
                {
                    maxIndex = i;
                }
                if (nums[maxIndex] - nums[j] >= valueDifference)
                {
                    return new int[] { maxIndex, j };
                }
            }
            return new int[] { -1, -1 };


        }
    }
}
