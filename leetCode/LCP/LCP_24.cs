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
                bool bl = n % 2 == 0;
                if (n > 1)
                {
                    int avg = sum / n;
                    if (sum % n > 0)
                    {
                        if (bl)
                        {
                            int n1 = GetEvenAns(i, avg, nums);
                            int n2 = GetEvenAns(i, avg + 1, nums);
                            res[i] = Math.Min(n1, n2);
                        }
                        else
                        {
                            int n0 = GetOddAns(i, avg, nums);
                            int n1 = GetOddAns(i, avg + 1, nums);
                            int n2 = GetOddAns(i, avg + 2, nums);
                            res[i] = Math.Min(n1, n2);
                            res[i] = Math.Min(res[i], n0);
                        }
                    }
                    else
                    {
                        if (bl)
                        {
                            int n1 = GetEvenAns(i, avg - 1, nums);
                            int n2 = GetEvenAns(i, avg, nums);
                            res[i] = Math.Min(n1, n2);
                        }
                        else
                        {
                            int n1 = GetOddAns(i, avg, nums);
                            res[i] = n1;
                        }
                    }
                }


            }

            return res;
        }

        private int GetEvenAns(int n, int avg, int[] nums)
        {
            int h = n / 2;
            int ans = 0;
            for (int i = h, j = avg; i >= 0; i--, j--)
            {
                ans += Math.Abs(j - nums[i]);
            }
            for (int i = h + 1, j = avg + 1; i <= n; i++, j++)
            {
                ans += Math.Abs(j - nums[i]);
            }
            return ans;
        }

        private int GetOddAns(int n, int avg, int[] nums)
        {
            int h = n / 2;
            int ans = 0;
            for (int i = h - 1, j = avg - 1; i >= 0; i--, j--)
            {
                ans += Math.Abs(j - nums[i]);
            }
            for (int i = h, j = avg; i <= n; i++, j++)
            {
                ans += Math.Abs(j - nums[i]);
            }
            return ans;
        }


    }
}
