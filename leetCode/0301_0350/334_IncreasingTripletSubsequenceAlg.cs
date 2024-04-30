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
            if (nums.Length < 3)
                return false;
            int first = nums[0];
            int second = int.MaxValue;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > second)
                {
                    return true;
                }
                else if (nums[i] > first)
                {
                    second = nums[i];
                }
                else
                {
                    first = nums[i];
                }

            }
            return false;
        }
    }
}
