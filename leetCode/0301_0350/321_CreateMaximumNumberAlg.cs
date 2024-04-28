using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0301_0350
{

    public class _321_CreateMaximumNumberAlg
    {
        public int[] MaxNumber(int[] nums1, int[] nums2, int k)
        {
            int m = nums1.Length, n = nums2.Length;
            int[] maxSubsequence = new int[k];
            int start = Math.Max(0, k - n), end = Math.Min(k, m);
            for (int i = start; i <= end; i++)
            {
                int[] subsequence1 = MaxSubsequence(nums1, i);
                int[] subsequence2 = MaxSubsequence(nums2, k - i);
                int[] curMaxSubsequence = Merge(subsequence1, subsequence2);
                if (Compare(curMaxSubsequence, 0, maxSubsequence, 0) > 0)
                {
                    Array.Copy(curMaxSubsequence, 0, maxSubsequence, 0, k);
                }
            }
            return maxSubsequence;

        }

        private int[] MaxSubsequence(int[] nums, int k)
        {
            int len = nums.Length;
            int[] stack = new int[k];
            int top = -1;
            int remain = len - k;
            for (int i = 0; i < len; i++)
            {
                int num = nums[i];
                while (top >= 0 && stack[top] < num && remain > 0)
                {
                    top--;
                    remain--;
                }
                if (top < k - 1)
                {
                    stack[++top] = num;
                }
                else
                {
                    remain--;
                }

            }

            return stack;

        }

        private int[] Merge(int[] sub1, int[] sub2)
        {
            int x = sub1.Length;
            int y = sub2.Length;
            if (x == 0)
            {
                return sub2;
            }
            if (y == 0)
            {
                return sub1;
            }

            int mergeLen = x + y;
            int index1 = 0;
            int index2 = 0;
            int[] merged = new int[mergeLen];
            for (int i = 0; i < mergeLen; i++)
            {
                if (Compare(sub1, index1, sub2, index2) > 0)
                {
                    merged[i] = sub1[index1++];
                }
                else
                {
                    merged[i] = sub2[index2++];
                }

            }
            return merged;
        }


        private int Compare(int[] sub1, int index1, int[] sub2, int index2)
        {
            int x = sub1.Length;
            int y = sub2.Length;
            while (index1 < x && index2 < y)
            {
                int diff = sub1[index1] - sub2[index2];
                if (diff != 0)
                {
                    return diff;
                }
                index1++;
                index2++;
            }
            return (x - index1) - (y - index2);
        }
    }
}
