using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2251_2300
{
    public class _2294_PartitionArraySuchThatMaximumDifferenceIsKAlg
    {
        public int PartitionArray1(int[] nums, int k)
        {
            if (nums.Length == 1)
                return 1;
            Array.Sort(nums);
            int ans = 0;
            int pre = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] - pre > k)
                {
                    ans++;
                    pre = nums[i];
                }
                if (i == nums.Length - 1)
                {
                    ans++;
                }
            }

            return ans;
        }

        public int PartitionArray(int[] nums, int k)
        {
            Array.Sort(nums);
            int ans = 0;
            int pre = int.MinValue / 2;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] - pre > k)
                {
                    ans++;
                    pre = nums[i];
                }

            }

            return ans;
        }
    }
}
