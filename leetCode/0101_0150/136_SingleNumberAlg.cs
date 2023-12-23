using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0101_0150
{
    public class _136_SingleNumberAlg
    {
        public int SingleNumber2(int[] nums)
        {
            Array.Sort(nums);

            int len = nums.Length - 1;
            for (int i = 0; i < len; i += 2)
            {
                if (nums[i] != nums[i + 1])
                {
                    return nums[i];
                }
            }

            return nums[len];
        }

        public int SingleNumber1(int[] nums)
        {
            HashSet<int> set = new HashSet<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!set.Add(nums[i]))
                {
                    set.Remove(nums[i]);
                }
            }
            return set.First();
        }

        public int SingleNumber(int[] nums)
        {
            if (nums.Length == 1)
                return nums[0];

            int n = 0;
            foreach (int i in nums)
            {
                n = n ^ i;
            }

            return n;
        }


    }
}
