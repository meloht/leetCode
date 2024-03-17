using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1451_1500
{
    public class _1498_NumberOfSubsequencesThatSatisfyTheGivenSumConditionAlg
    {
        static int Mod = 1_000_000_007;
        public int NumSubseq(int[] nums, int target)
        {
            Array.Sort(nums);
            int ans = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                int tt = target - nums[i];
                if (tt < 0)
                {
                    break;
                }
                if (tt < nums[i])
                {
                    break;
                }
                int left = i;
                int right = nums.Length - 1;
                int kk = i;
                while (left <= right)
                {
                    int mid = (right - left) / 2 + left;
                    int num = nums[mid];
                    if (num <= tt)
                    {
                        kk = mid;
                        left = mid + 1;
                    }
                    else
                    {
                        right = mid - 1;
                    }
                }
                int numm = (int)(MyPow(2, kk - i) % Mod);
                ans = (ans + numm) % Mod;

            }


            return ans;
        }

        private long MyPow(long x, int n)
        {
            if (n == 0)
            {
                return 1;
            }
            if (n % 2 == 0)
            {
                var num = (x * x) % Mod;
                return MyPow(num, n / 2);
            }
            else
            {
                var num = MyPow((x * x) % Mod, n / 2) % Mod;
                if (n > 0)
                {
                    num = (num * x) % Mod;
                }
                return num;
            }
        }


    }


}
