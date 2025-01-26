using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3401_3450
{
    public class _3434_MaximumFrequencyAfterSubarrayOperationAlg
    {
        public int MaxFrequency(int[] nums, int k)
        {
            int ans = 0;
            int total = 0;
            HashSet<int> set = new HashSet<int>();
            foreach (int num in nums)
            {
                if (num == k)
                {
                    total++;
                }
                set.Add(num);
            }

            foreach (var val in set)
            {
                int pre = 0;
                int min = 0;
                foreach (var item in nums)
                {
                    if (item == val)
                    {
                        pre++;
                    }
                    if (item == k)
                    {
                        pre--;
                    }
                    min = Math.Min(min, pre);
                    ans = Math.Max(ans, pre - min + total);
                }
            }
           

            return ans;
        }

        public int MaxFrequency1(int[] nums, int k)
        {
            int kCnt = nums.Count(x => x == k);
            int ans = 0;

            for (int i = 1; i < 51; i++)
            {
                int pre = 0;
                int min = 0;
                foreach (var item in nums)
                {
                    if (item == i)
                    {
                        pre++;
                    }
                    if (item == k)
                    {
                        pre--;
                    }
                    min = Math.Min(min, pre);
                    ans = Math.Max(ans, pre - min + kCnt);
                }
            }

            return ans;
        }

    }
}
