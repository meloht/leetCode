using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3001_3050
{
    public class _3038_MaximumNumberOfOperationsWithTheSameScoreIAlg
    {
        public int MaxOperations(int[] nums)
        {
            int ans = 1;
            int total = nums[0] + nums[1];
            for (int i = 2; i < nums.Length; i += 2)
            {
                if (i + 1 < nums.Length && nums[i] + nums[i + 1] == total)
                {
                    ans++;
                }
                else
                {
                    break;
                }
            }
            return ans;
        }
    }
}
