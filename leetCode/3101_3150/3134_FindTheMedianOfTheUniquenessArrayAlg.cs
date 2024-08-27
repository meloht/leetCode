using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace leetCode._3101_3150
{
    public class _3134_FindTheMedianOfTheUniquenessArrayAlg
    {
        public int MedianOfUniquenessArray(int[] nums)
        {
            int n = nums.Length;
            long k = ((long)n * (n + 1) / 2 + 1) / 2;
            int left = 0;
            int right = n;
            while (left + 1 < right)
            {
                int mid = (left + right) / 2;
                if (Check(nums, mid, k))
                {
                    right = mid;
                }
                else
                {
                    left = mid;
                }
            }
            return right;

        }

        private bool Check(int[] nums, int upper, long k)
        {
            long cnt = 0;
            int l = 0;
            Dictionary<int, int> freq = new  Dictionary<int, int>();
            for (int r = 0; r < nums.Length; r++)
            {
                if (freq.ContainsKey(nums[r]))
                {
                    freq[nums[r]]++;
                }
                else
                {
                    freq.Add(nums[r], 1);
                }
                while (freq.Count > upper)
                { // 窗口内元素过多
                    freq[nums[l]]--;
                    if (freq[nums[l]] == 0)
                    { // 移出左端点
                        freq.Remove(nums[l]);
                    }
                    l++;
                }
                cnt += r - l + 1; // 右端点固定为 r 时，有 r-l+1 个合法左端点
                if (cnt >= k)
                {
                    return true;
                }
            }
            return false;
        }


    }
}
