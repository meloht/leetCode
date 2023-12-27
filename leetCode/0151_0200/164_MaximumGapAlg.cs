using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0151_0200
{
    public class _164_MaximumGapAlg
    {
        public int MaximumGap1(int[] nums)
        {
            if (nums.Length < 2)
                return 0;
            int max = 0;
            Array.Sort(nums);
            int len = nums.Length - 1;
            for (int i = 0; i < len; i++)
            {
                int curr = nums[i];
                int next = nums[i + 1];
                max = Math.Max(max, next - curr);
            }


            return max;
        }

        public int MaximumGap(int[] nums)
        {
            int maxLen = nums.Max().ToString().Length;

            int[,] bucket = new int[10, nums.Length];

            int[] bucketCounts = new int[10];
            for (int i = 0, n = 1; i < maxLen; i++, n *= 10)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    int digitOfElement = nums[j] / n % 10;
                    bucket[digitOfElement, bucketCounts[digitOfElement]] = nums[j];
                    bucketCounts[digitOfElement]++;
                }

                int index = 0;
                for (int j = 0; j < bucketCounts.Length; j++)
                {
                    if (bucketCounts[j] != 0)
                    {
                        for (int k = 0; k < bucketCounts[j]; k++)
                        {
                            nums[index++] = bucket[j, k];
                        }
                    }
                    bucketCounts[j] = 0;

                }
            }
            int max = 0;
            int len = nums.Length - 1;
            for (int i = 0; i < len; i++)
            {
                int curr = nums[i];
                int next = nums[i + 1];
                max = Math.Max(max, next - curr);
            }

            return max;
        }
    }
}
