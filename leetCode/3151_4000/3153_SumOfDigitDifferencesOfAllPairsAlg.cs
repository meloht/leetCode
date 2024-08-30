using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3151_4000
{
    public class _3153_SumOfDigitDifferencesOfAllPairsAlg
    {
        public long SumDigitDifferences(int[] nums)
        {
            long res = 0;
            int n = nums.Length;
            while (nums[0] > 0)
            {
                int[] cnt = new int[10];
                for (int i = 0; i < n; i++)
                {
                    cnt[nums[i] % 10]++;
                    nums[i] /= 10;
                }
                for (int i = 0; i < 10; i++)
                {
                    res += (long)(n - cnt[i]) * cnt[i];
                }
            }
            return res / 2;

        }
    }
}
