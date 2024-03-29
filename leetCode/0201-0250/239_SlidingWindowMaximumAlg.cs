﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0201_0250
{
    public class _239_SlidingWindowMaximumAlg
    {
        public int[] MaxSlidingWindow1(int[] nums, int k)
        {
            int n = nums.Length;
            int m = n - k + 1;
            int[] res = new int[m];
            SortedList<int, int> set = new SortedList<int, int>(Comparer<int>.Create((x, y) => y - x));
            int len = k - 1;
            for (int i = 0; i < len; i++)
            {
                if (set.ContainsKey(nums[i]))
                {
                    set[nums[i]]++;
                }
                else
                {
                    set.Add(nums[i], 1);
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

        public int[] MaxSlidingWindow2(int[] nums, int k)
        {
            int n = nums.Length;
            int m = n - k + 1;
            int[] res = new int[m];

            LinkedList<int> list = new LinkedList<int>();

            for (int i = 0; i < k; i++)
            {
                while (list.Count > 0 && nums[i] >= nums[list.Last.Value])
                {
                    list.RemoveLast();
                }
                list.AddLast(i);
            }
            res[0] = nums[list.First.Value];

            for (int i = k, j = 1; i < n; i++, j++)
            {

                while (list.Count > 0 && nums[i] >= nums[list.Last.Value])
                {
                    list.RemoveLast();
                }
                list.AddLast(i);

                while (list.First.Value < j)
                {
                    list.RemoveFirst();
                }
                res[j] = nums[list.First.Value];

            }
            return res;
        }

        public int[] MaxSlidingWindow(int[] nums, int k)
        {
            int n = nums.Length;
            int m = n - k + 1;
            int[] res = new int[m];

            int[] prefixMax = new int[n];
            int[] suffixMax = new int[n];

            for (int i = 0; i < n; i++)
            {
                if (i % k == 0)
                {
                    prefixMax[i] = nums[i];
                }
                else
                {
                    prefixMax[i] = Math.Max(prefixMax[i-1], nums[i]);
                }
            }
            for (int i = n - 1; i >= 0; i--)
            {
                if (i == n - 1 || (i + 1) % k == 0)
                {
                    suffixMax[i] = nums[i];
                }
                else
                {
                    suffixMax[i] = Math.Max(suffixMax[i + 1], nums[i]);
                }
            }

            for (int i = 0; i <m; i++)
            {
                res[i] = Math.Max(suffixMax[i], prefixMax[i + k - 1]);
            }

            return res;
        }
    }
}
