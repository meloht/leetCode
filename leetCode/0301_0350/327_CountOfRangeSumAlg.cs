﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0301_0350
{
    public class _327_CountOfRangeSumAlg
    {

        public int CountRangeSum(int[] nums, int lower, int upper)
        {
            long s = 0;
            long[] sum = new long[nums.Length + 1];
            for (int i = 0; i < nums.Length; ++i)
            {
                s += nums[i];
                sum[i + 1] = s;
            }
            return countRangeSumRecursive(sum, lower, upper, 0, sum.Length - 1);
        }

        public int countRangeSumRecursive(long[] sum, int lower, int upper, int left, int right)
        {
            if (left == right)
            {
                return 0;
            }
            else
            {
                int mid = (left + right) / 2;
                int n1 = countRangeSumRecursive(sum, lower, upper, left, mid);
                int n2 = countRangeSumRecursive(sum, lower, upper, mid + 1, right);
                int ret = n1 + n2;

                // 首先统计下标对的数量
                int i = left;
                int l = mid + 1;
                int r = mid + 1;
                while (i <= mid)
                {
                    while (l <= right && sum[l] - sum[i] < lower)
                    {
                        l++;
                    }
                    while (r <= right && sum[r] - sum[i] <= upper)
                    {
                        r++;
                    }
                    ret += r - l;
                    i++;
                }

                // 随后合并两个排序数组
                long[] sorted = new long[right - left + 1];
                int p1 = left, p2 = mid + 1;
                int p = 0;
                while (p1 <= mid || p2 <= right)
                {
                    if (p1 > mid)
                    {
                        sorted[p++] = sum[p2++];
                    }
                    else if (p2 > right)
                    {
                        sorted[p++] = sum[p1++];
                    }
                    else
                    {
                        if (sum[p1] < sum[p2])
                        {
                            sorted[p++] = sum[p1++];
                        }
                        else
                        {
                            sorted[p++] = sum[p2++];
                        }
                    }
                }
                for (int j = 0; j < sorted.Length; j++)
                {
                    sum[left + j] = sorted[j];
                }
                return ret;
            }
        }

    }
}
