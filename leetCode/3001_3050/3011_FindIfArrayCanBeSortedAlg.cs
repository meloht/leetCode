using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3001_3050
{
    public class _3011_FindIfArrayCanBeSortedAlg
    {
        public bool CanSortArray(int[] nums)
        {
            int n = nums.Length;
            int preMax = 0;
            for (int i = 0; i < n; )
            {
                int mx = 0;
                int cnt = int.PopCount(nums[i]);
                while (i < n && int.PopCount(nums[i]) == cnt)
                {
                    if (nums[i] < preMax)
                    {
                        return false;
                    }
                    mx = Math.Max(mx, nums[i++]);
                }
                preMax = mx;
            }

            return true;
        }

        private int GetOneCount(int num)
        {
            int count = 0;
            while (num > 0)
            {
                count += num % 2;
                num /= 2;
            }
            return count;
        }
    }
}
