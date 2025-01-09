using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0651_0700
{
    public class _689_MaximumSumOf3NonOverlappingSubarraysAlg
    {
        public int[] MaxSumOfThreeSubarrays1(int[] nums, int k)
        {
            int[] ans = new int[3];
            int sum1 = 0, maxSum1 = 0, maxSum1Idx = 0;
            int sum2 = 0, maxSum12 = 0, maxSum12Idx1 = 0, maxSum12Idx2 = 0;
            int sum3 = 0, maxTotal = 0;
            for (int i = k * 2; i < nums.Length; ++i)
            {
                sum1 += nums[i - k * 2];
                sum2 += nums[i - k];
                sum3 += nums[i];
                if (i >= k * 3 - 1)
                {
                    if (sum1 > maxSum1)
                    {
                        maxSum1 = sum1;
                        maxSum1Idx = i - k * 3 + 1;
                    }
                    if (maxSum1 + sum2 > maxSum12)
                    {
                        maxSum12 = maxSum1 + sum2;
                        maxSum12Idx1 = maxSum1Idx;
                        maxSum12Idx2 = i - k * 2 + 1;
                    }
                    if (maxSum12 + sum3 > maxTotal)
                    {
                        maxTotal = maxSum12 + sum3;
                        ans[0] = maxSum12Idx1;
                        ans[1] = maxSum12Idx2;
                        ans[2] = i - k + 1;
                    }
                    sum1 -= nums[i - k * 3 + 1];
                    sum2 -= nums[i - k * 2 + 1];
                    sum3 -= nums[i - k + 1];
                }
            }
            return ans;
        }

        public int[] MaxSumOfThreeSubarrays(int[] nums, int k)
        {
            int n = nums.Length;
            int[] ans = new int[3];

            int[] left = new int[n];
            int[] right = new int[n];

            long[] leftNum = new long[n];

            long sum = nums.Take(k).Sum();
            leftNum[0] = sum;
            for (int i = k, j = 0; i < n; i++)
            {
                sum += nums[i];
                sum -= nums[j++];
                leftNum[i - k + 1] = sum;
            }

            long max = 0;
            int idx = 0;
            for (int i = 0; i <= n - k; i++)
            {
                if (leftNum[i] > max)
                {
                    idx = i;
                    max = leftNum[i];
                }
                left[i] = idx;
            }

            long[] rightNum = new long[n];
            sum = nums.Skip(n - k).Take(k).Sum();
            rightNum[n - k] = sum;
            for (int i = n - k - 1, j = n - 1; i >= 0; i--)
            {
                sum += nums[i];
                sum -= nums[j--];
                rightNum[i] = sum;
            }

            max = 0;
            idx = 0;
            for (int i = n - k; i >= 0; i--)
            {
                if (rightNum[i] >= max)
                {
                    idx = i;
                    max = rightNum[i];
                }
                right[i] = idx;
            }

            max = 0;
            int lenn = n - 2 * k;
            sum = 0;
            for (int i = k; i <= lenn; i++)
            {
                sum = leftNum[left[i - k]] + leftNum[i] + rightNum[right[i + k]];
                if (sum > max)
                {
                    max = sum;
                    ans[0] = left[i - k];
                    ans[1] = i;
                    ans[2] = right[i + k];
                }
            }

            return ans;
        }


    }
}
