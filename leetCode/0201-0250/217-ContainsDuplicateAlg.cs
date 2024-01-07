using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0201_0250
{
    public class _217_ContainsDuplicateAlg
    {
        public bool ContainsDuplicate1(int[] nums)
        {
            HashSet<int> result = new HashSet<int>();
            foreach (int num in nums)
            {
                if (result.Add(num) == false)
                    return true; ;
            }

            return false;
        }

        public bool ContainsDuplicate(int[] nums)
        {
            Array.Sort(nums);
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i - 1] == nums[i])
                    return true;
            }
            return false;
        }
    }
}
