using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3151_3200
{
    public class _3152_SpecialArrayIIAlg
    {

        public bool[] IsArraySpecial(int[] nums, int[][] queries)
        {
            int n = nums.Length;
            int[] dp = new int[n];
            Array.Fill(dp, 1);
            for (int i = 1; i < n; i++)
            {
                if (((nums[i] ^ nums[i - 1]) & 1) != 0)
                {
                    dp[i] = dp[i - 1] + 1;
                }
            }

            bool[] res = new bool[queries.Length];
            for (int i = 0; i < queries.Length; i++)
            {
                int x = queries[i][0], y = queries[i][1];
                res[i] = dp[y] >= y - x + 1;
            }
            return res;
        }


        public bool[] IsArraySpecial1(int[] nums, int[][] queries)
        {
            int n = nums.Length;
            BigInteger total = BigInteger.One;
            BigInteger t1 = BigInteger.One;

            BigInteger t2 = BigInteger.One;
            for (int i = 0; i < n; i++)
            {
                t1 = t1 << 1;
                t2 = t2 << 1;
                total = total << 1;

                total = total | (nums[i] % 2);
                t1 = t1 | (i % 2);

                t2 = t2 | ((i + 1) % 2);

            }

            bool[] ans = new bool[queries.Length];
            for (int i = 0; i < queries.Length; i++)
            {
                int begin = queries[i][0];
                int end = queries[i][1];
                int left = n - end-1;
                int right = end-begin+1;
                BigInteger tt = GetDis(queries[i], n, total);
                BigInteger tt1 = GetDis(queries[i], n, t1);
                BigInteger tt2 = GetDis(queries[i], n, t2);
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

        private BigInteger GetDis(int[] arr,int n, BigInteger t) 
        {
            int begin = arr[0];
            int end = arr[1];
            int left = n - end - 1;
            int right = end - begin + 1;
            BigInteger tt = t >> left;
            BigInteger ttt = tt >> right;
            ttt = ttt << right;
            ttt = tt ^ ttt;
            return ttt;
        }
    }
}
