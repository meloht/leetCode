using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3151_4000
{
    public class _3152_SpecialArrayIIAlg
    {
        public bool[] IsArraySpecial(int[] nums, int[][] queries)
        {
            int n = nums.Length;
            BigInteger total = 1;
            BigInteger t1 = 1;

            BigInteger t2 = 1;
            for (int i = 0; i < n; i++)
            {
                t1 = t1 << 1;
                t2 = t2 << 1;
                total = total << 1;

                total = total | (nums[i] % 2);
                t1 = t1 | (i % 2);

                t2 = t2 | ((i + 1) % 2);

            }
            string ss = total.ToString("B");
            string ss1 = t2.ToString("B");
            string ss2 = t1.ToString("B");
            bool[] ans = new bool[queries.Length];
            for (int i = 0; i < queries.Length; i++)
            {
                int begin = queries[i][0];
                int end = queries[i][1];
                int left = n - end;
                int right = begin; 
                BigInteger tt = total >> right;
                BigInteger tt1 = t1 >> begin;
                BigInteger tt2 = t2 >> begin;
                if (tt.Equals(tt1) || tt.Equals(tt2))
                {
                    ans[i] = true;
                }
                else
                {
                    ans[i] = false;
                }
            }

            return ans;
        }
    }
}
