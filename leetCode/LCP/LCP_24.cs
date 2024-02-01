using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode.LCP
{
    public class LCP_24
    {
        int Mod = 1_000_000_007;
        public int[] NumsGame(int[] nums)
        {
            int[] res = new int[nums.Length];

            int sum = 0;
            for (int i = 0, n = 1; i < nums.Length; i++, n++)
            {
                sum += nums[i];

                if (n > 1)
                {
                    int avg = sum / n;
                    if (sum % n > 0)
                    {
                        int n1 = GetAns(n, avg, nums);
                        int n2 = GetAns(n, avg + 1, nums);
                        res[i] = Math.Min(n1, n2);
                    }
                    else
                    {
                        int n1 = GetAns(n, avg - 1, nums);
                        int n2 = GetAns(n, avg, nums);
                        res[i] = Math.Min(n1, n2);
                    }
                }


            }

            return res;
        }


        private int GetAns(int n, int avg, int[] nums)
        {
            int h = n / 2;
            int ans = 0;
            for (int i = h - 1, j = avg; i >= 0; i--, j--)
            {
                ans += Math.Abs(j - nums[i]);
            }
            for (int i = h, j = avg + 1; i < n; i++, j++)
            {
                ans += Math.Abs(j - nums[i]);
            }
            return ans;
        }


    }
}
