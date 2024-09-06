using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0451_0500
{
    public class _493_ReversePairsAlg
    {
        public int ReversePairs(int[] nums)
        {
            if (nums.Length == 0)
            {
                return 0;
            }
            return ReversePairsRecursive(nums, 0, nums.Length - 1);
        }


        public int ReversePairsRecursive(int[] nums, int left, int right)
        {
            if (left == right)
            {
                return 0;
            }
            else
            {
                int mid = (left + right) / 2;
                int n1 = ReversePairsRecursive(nums, left, mid);
                int n2 = ReversePairsRecursive(nums, mid + 1, right);
                int ret = n1 + n2;

                // 首先统计下标对的数量
                int i = left;
                int j = mid + 1;
                while (i <= mid)
                {
                    while (j <= right && (long)nums[i] > 2 * (long)nums[j])
                    {
                        j++;
                    }
                    ret += j - mid - 1;
                    i++;
                }

                // 随后合并两个排序数组
                int[] sorted = new int[right - left + 1];
                int p1 = left, p2 = mid + 1;
                int p = 0;
                while (p1 <= mid || p2 <= right)
                {
                    if (p1 > mid)
                    {
                        sorted[p++] = nums[p2++];
                    }
                    else if (p2 > right)
                    {
                        sorted[p++] = nums[p1++];
                    }
                    else
                    {
                        if (nums[p1] < nums[p2])
                        {
                            sorted[p++] = nums[p1++];
                        }
                        else
                        {
                            sorted[p++] = nums[p2++];
                        }
                    }
                }
                for (int k = 0; k < sorted.Length; k++)
                {
                    nums[left + k] = sorted[k];
                }
                return ret;
            }
        }



    }
}
