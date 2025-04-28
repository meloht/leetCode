using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0901_0950
{
    public class _945_MinimumIncrementToMakeArrayUniqueAlg
    {
        public int MinIncrementForUnique1(int[] nums)
        {
            Array.Sort(nums);

            int ans = 0;
            int last = int.MinValue;
            for (int i = 1; i < nums.Length; i++)
            {
                if (last >= nums[i])
                {
                    int diff = last - nums[i] + 1;
                    nums[i] += diff;
                    last = nums[i];
                    ans += diff;

                }
                if (nums[i - 1] == nums[i])
                {
                    nums[i]++;
                    last = nums[i];
                    ans++;
                }
            }
            return ans;
        }

        public int MinIncrementForUnique(int[] nums)
        {
            int min = int.MaxValue;
            int max = int.MinValue;
            foreach (int item in nums)
            {
                min = Math.Min(min, item);
                max = Math.Max(max, item);
            }
            int[] dict = new int[max + 1];
            foreach (int item in nums)
            {
                dict[item]++; 
            }
            int ans = 0;
            int last = -1;
            for (int i = min; i <= max; i++)
            {
                if (dict[i] == 0)
                {
                    continue;
                }

                if (last >= i)
                {
                    int diff = last - i + 1;
                    ans += ((diff + diff + dict[i] - 1) * dict[i] / 2);
                    last = i + diff + dict[i] - 1;
                }
                else
                {
                    ans += (dict[i] - 1) * dict[i] / 2;
                    last = i + dict[i] - 1;
                }
            }
            return ans;
        }
    }
}
