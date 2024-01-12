using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0201_0250
{
    public class _219_ContainsDuplicateIIAlg
    {
        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0; i <= k && i < nums.Length; i++)
            {
                if (dict.ContainsKey(nums[i]))
                {
                    return true;
                }
                else
                {
                    dict.Add(nums[i], i);
                }
            }

            for (int i = k + 1; i < nums.Length; i++)
            {

                if (dict.ContainsKey(nums[i]))
                {
                    if (i - dict[nums[i]] <= k)
                    {
                        return true;
                    }
                    dict[nums[i]] = i;
                }
                else
                {
                    dict.Add(nums[i], i);
                }
            }


            return false;
        }
    }
}
