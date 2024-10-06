using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0501_0550
{
    public class _523_ContinuousSubarraySumAlg
    {
        public bool CheckSubarraySum(int[] nums, int k)
        {
            int m = nums.Length;
            if (m < 2)
            {
                return false;
            }
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            dictionary.Add(0, -1);
            int remainder = 0;
            for (int i = 0; i < m; i++)
            {
                remainder = (remainder + nums[i]) % k;
                if (dictionary.ContainsKey(remainder))
                {
                    int prevIndex = dictionary[remainder];
                    if (i - prevIndex >= 2)
                    {
                        return true;
                    }
                }
                else
                {
                    dictionary.Add(remainder, i);
                }
            }
            return false;
        }

    }
}
