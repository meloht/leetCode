using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3251_3300
{
    public class _3289_TheTwoSneakyNumbersOfDigitvilleAlg
    {
        public int[] GetSneakyNumbers(int[] nums)
        {
            HashSet<int> result = new HashSet<int>();
            int[] ans=new int[2];
            int idx = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (!result.Add(nums[i]))
                {
                    ans[idx++]=nums[i];
                }
            }
            return ans;
        }
    }
}
