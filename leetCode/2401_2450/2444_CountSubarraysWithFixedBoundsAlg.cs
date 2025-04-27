using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2401_2450
{
    public class _2444_CountSubarraysWithFixedBoundsAlg
    {
        public long CountSubarrays1(int[] nums, int minK, int maxK)
        {
            SortedSet<int> set = new SortedSet<int>();
            Dictionary<int, int> dict = new Dictionary<int, int>();
            long ans = 0;
            int max = int.MinValue;
            int min = int.MaxValue;


            for (int i = 0, left = 0, j = 0; i < nums.Length; i++)
            {
                if (nums[i] > maxK || nums[i] < minK)
                {
                    j = i + 1;
                    left = j;
                    max = int.MinValue;
                    min = int.MaxValue;
                    set.Clear();
                    dict.Clear();
                    continue;
                }

                min = Math.Min(nums[i], min);
                max = Math.Max(nums[i], max);
                if (dict.ContainsKey(nums[i]))
                {
                    dict[nums[i]]++;
                }
                else
                {
                    set.Add(nums[i]);
                    dict.Add(nums[i], 1);
                }

                while (j < nums.Length && max == maxK && min == minK)
                {

                    if ((nums[j] == minK || nums[j] == maxK) && dict[nums[j]] <= 1)
                    {
                        break;
                    }

                    dict[nums[j]]--;
                    if (dict[nums[j]] == 0)
                    {
                        dict.Remove(nums[j]);
                        set.Remove(nums[j]);

                        if (nums[j] == min)
                        {
                            min = set.Min();
                        }
                        if (nums[j] == max)
                        {
                            max = set.Max();
                        }
                    }
                    j++;

                }
                if (max == maxK && min == minK)
                {
                    ans += (j - left + 1);
                }
            }

            return ans;
        }

        public long CountSubarrays(int[] nums, int minK, int maxK)
        {
            long ans = 0;
            int left = 0;
            int lastMin = -1;
            int lastMax = -1;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > maxK || nums[i] < minK)
                {
                    left = i + 1;
                    lastMax = -1;
                    lastMin = -1;
                    continue;
                }
                if (nums[i] == maxK)
                {
                    lastMax = i;
                }
                if (nums[i] == minK)
                {
                    lastMin = i;
                }

                if (lastMin != -1 && lastMax != -1)
                {
                    ans += Math.Min(lastMax, lastMin) - left + 1;
                }
            }

            return ans;
        }
    }
}
