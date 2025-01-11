using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0701_0750
{
    public class _718_MaximumLengthOfRepeatedSubarrayAlg
    {
        public int FindLength1(int[] nums1, int[] nums2)
        {
            int m = nums1.Length;
            int n = nums2.Length;
            int[,] dp = new int[m + 1, n + 1];
            int maxLength = 0;

            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (nums1[i - 1] == nums2[j - 1])
                    {
                        dp[i, j] = dp[i - 1, j - 1] + 1;
                        maxLength = Math.Max(maxLength, dp[i, j]);
                    }
                    else
                    {
                        dp[i, j] = 0;
                    }
                }
            }

            return maxLength;
        }

        public int FindLength2(int[] nums1, int[] nums2)
        {
            int m = nums1.Length;
            int n = nums2.Length;
            int min = Math.Min(m, n);
            int maxLength = 0;

            for (int i = 0; i < m; i++)
            {
                int len = Math.Min(m - i, n);
                int max = GetMax(nums1, nums2, i, 0, len);
                maxLength = Math.Max(maxLength, max);
            }
            for (int i = 0; i < n; i++)
            {
                int len = Math.Min(n - i, m);
                int max = GetMax(nums1, nums2, 0, i, len);
                maxLength = Math.Max(maxLength, max);
            }

            return maxLength;
        }

        public int GetMax(int[] num1, int[] num2, int idx1, int idx2, int len)
        {
            int max = 0;
            int count = 0;
            for (int i = 0; i < len; i++)
            {
                if (num1[idx1 + i] == num2[idx2 + i])
                {
                    count++;
                }
                else
                {
                    count = 0;
                }
                max = Math.Max(count, max);
            }
            return max;
        }


        public int FindLength(int[] A, int[] B)
        {
            return A.Length < B.Length ? findMax(A, B) : findMax(B, A);
        }

        int findMax(int[] A, int[] B)
        {
            int max = 0;
            int an = A.Length, bn = B.Length;
            for (int len = 1; len <= an; len++)
            {
                max = Math.Max(max, maxLen(A, 0, B, bn - len, len));
            }
            for (int j = bn - an; j >= 0; j--)
            {
                max = Math.Max(max, maxLen(A, 0, B, j, an));
            }
            for (int i = 1; i < an; i++)
            {
                max = Math.Max(max, maxLen(A, i, B, 0, an - i));
            }
            return max;
        }

        int maxLen(int[] a, int i, int[] b, int j, int len)
        {
            int count = 0, max = 0;
            for (int k = 0; k < len; k++)
            {
                if (a[i + k] == b[j + k])
                {
                    count++;
                }
                else if (count > 0)
                {
                    max = Math.Max(max, count);
                    count = 0;
                }
            }
            return count > 0 ? Math.Max(max, count) : max;
        }


    }
}
