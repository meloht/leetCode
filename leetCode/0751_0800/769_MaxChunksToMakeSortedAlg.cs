using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0751_0800
{
    public class _769_MaxChunksToMakeSortedAlg
    {
        public int MaxChunksToSorted(int[] arr)
        {
            int ans = 1;
            int[] map = GetIndexMapping(arr);
            int[] right = new int[arr.Length];
            right[right.Length - 1] = map[arr.Length - 1];
            for (int i = arr.Length - 2; i >= 0; i--)
            {
                right[i] = Math.Min(right[i + 1], map[i]);
            }
            int maxIdx = map[0];
            for (int i = 0; i < arr.Length; i++)
            {
                maxIdx = Math.Max(maxIdx, map[i]);
                if (i + 1 < arr.Length)
                {
                    if (maxIdx < right[i + 1])
                    {
                        ans++;
                    }
                }
            }
            return ans;
        }
        private int[] GetIndexMapping(int[] arr)
        {
            int[] map = new int[arr.Length];
            int[][] nums = new int[arr.Length][];
            for (int i = 0; i < arr.Length; i++)
            {
                nums[i] = [arr[i], i];
            }

            Array.Sort(nums, (a, b) => a[0] - b[0]);

            for (int i = 0; i < nums.Length; i++)
            {
                map[nums[i][1]] = i;
            }
            return map;
        }

        public int MaxChunksToSorted2(int[] arr)
        {
            int m = 0, res = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                m = Math.Max(m, arr[i]);
                if (m == i)
                {
                    res++;
                }
            }
            return res;
        }
    }

}