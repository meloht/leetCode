using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0301_0350
{
    public class _334_IncreasingTripletSubsequenceAlg
    {
        public bool IncreasingTriplet(int[] nums)
        {
            for (int i = 0; i < nums.Length - 2; i++)
            {
                for (int j = i + 1; j < nums.Length - 1; j++)
                {
                    if (nums[j] <= nums[i])
                        continue;

                    for (int k = j + 1; k < nums.Length; k++)
                    {
                        if (nums[k] > nums[j])
                            return true;
                    }
                }
            }
            return false;
        }
    }
}
