using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0101_0150
{
    public class _128_LongestConsecutiveSequenceAlg
    {
        public int LongestConsecutive1(int[] nums)
        {
            if (nums.Length == 0)
                return 0;
            if (nums.Length < 2)
                return 1;
            Array.Sort(nums);
            int max = 1;
            int count = 1;
            int len = nums.Length - 1;
            for (int i = 0; i < len; i++)
            {
                int curr = nums[i];
                int next = nums[i + 1];
                if (curr == next)
                    continue;
                if (next - curr == 1)
                {
                    count++;
                }
                else
                {
                    max = Math.Max(max, count);
                    count = 1;
                }
            }
            max = Math.Max(max, count);
            return max;
        }
        public int LongestConsecutive(int[] nums)
        {
            if (nums.Length == 0)
                return 0;
            if (nums.Length < 2)
                return 1;
            HashSet<int> arr = new HashSet<int>();
            int max = 1;
            int count = 1;
            int len = nums.Length;

            for (int i = 0; i < len; i++)
            {
                arr.Add(nums[i]);

            }

            foreach (var item in arr)
            {
                if (arr.Contains(item - 1))
                    continue;
                count = 1;
                int next = item + 1;
                while (arr.Contains(next))
                {
                    count++;
                    next++;
                }
                max = Math.Max(max, count);

            }

            return max;
        }
    }
}
