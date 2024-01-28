using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0201_0250
{
    public class _239_SlidingWindowMaximumAlg
    {
        public int[] MaxSlidingWindow(int[] nums, int k)
        {
            int n = nums.Length;
            int m = n - k + 1;
            int[] res = new int[m];
            SortedList<int,int> set = new SortedList<int,int>(Comparer<int>.Create((x, y) => y - x));
            int len = k - 1;
            for (int i = 0; i < len; i++)
            {
                if (set.ContainsKey(nums[i]))
                {
                    set[nums[i]]++;
                }
                else
                {
                    set.Add(nums[i],1);
                }
              
            }
            for (int i = len, j = 0; i < n; i++, j++)
            {
                if (set.ContainsKey(nums[i]))
                {
                    set[nums[i]]++;
                }
                else
                {
                    set.Add(nums[i], 1);
                }
                foreach (var item in set)
                {
                    res[j] = item.Key;
                    break;
                }
               
                if (set.ContainsKey(nums[j]))
                {
                    set[nums[j]]--;
                    if (set[nums[j]] == 0)
                    {
                        set.Remove(nums[j]);
                    }
                }
               
            }
            return res;
        }
    }
}
