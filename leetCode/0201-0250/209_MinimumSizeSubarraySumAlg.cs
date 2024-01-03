﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0201_0250
{
    public class _209_MinimumSizeSubarraySumAlg
    {
        public int MinSubArrayLen1(int target, int[] nums)
        {
            Queue<int> q = new Queue<int>();
            int sum = 0;
            int min = int.MaxValue;
            for (int i = 0; i < nums.Length; i++)
            {
                if (sum < target)
                {
                    q.Enqueue(nums[i]);
                    sum += nums[i];
                }
                else
                {
                    while (sum >= target)
                    {
                        min = Math.Min(min, q.Count);
                        sum = sum - q.Dequeue();
                    }
                   
                    q.Enqueue(nums[i]);
                    sum += nums[i];
                }
            }
            while (sum >= target)
            {
                min = Math.Min(min, q.Count);
                sum = sum - q.Dequeue();
            }
           
            if (min < int.MaxValue)
                return min;

            return 0;
        }

        public int MinSubArrayLen2(int target, int[] nums)
        {
            int n = nums.Length;
            if (n == 0)
            {
                return 0;
            }

            int ans = int.MaxValue;
            int start = 0, end = 0;
            int sum = 0;
            while (end < n)
            {
                sum += nums[end];
                while (sum >= target)
                {
                    ans = Math.Min(ans, end - start + 1);
                    sum -= nums[start];
                    ++start;
                }

                ++end;
            }

            return ans == int.MaxValue ? 0 : ans;


        }

        private int LowerBound(int[] a, int l, int r, int target)
        {
            int mid = -1, originL = l, originR = r;
            while (l < r)
            {
                mid = (l + r) >> 1;
                if (a[mid] < target) l = mid + 1;
                else r = mid;
            }

            return (a[l] >= target) ? l : -1;
        }

        public int MinSubArrayLen(int s, int[] nums)
        {
            int n = nums.Length;
            if (n == 0)
            {
                return 0;
            }

            int ans = int.MaxValue;
            int[] sums = new int[n + 1];
            // 为了方便计算，令 size = n + 1 
            // sums[0] = 0 意味着前 0 个元素的前缀和为 0
            // sums[1] = A[0] 前 1 个元素的前缀和为 A[0]
            // 以此类推
            for (int i = 1; i <= n; ++i)
            {
                sums[i] = sums[i - 1] + nums[i - 1];
            }

            for (int i = 1; i <= n; ++i)
            {
                int target = s + sums[i - 1];
                int bound = LowerBound(sums, i, n, target);
                if (bound != -1)
                {
                    ans = Math.Min(ans, bound - i + 1);
                }
            }

            return ans == int.MaxValue ? 0 : ans;
        }

    }
}
