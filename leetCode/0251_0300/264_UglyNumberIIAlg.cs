using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0251_0300
{
    public class _264_UglyNumberIIAlg
    {
        public int NthUglyNumber1(int n)
        {
            int[] nums = [2, 3, 5];
            HashSet<long> set = new HashSet<long>();
            PriorityQueue<long, long> queue = new PriorityQueue<long, long>();
            queue.Enqueue(1, 1);
            long ans = 0;
            for (int i = 0; i < n; i++)
            {
                long curr = queue.Dequeue();
                ans = curr;
                foreach (var item in nums)
                {
                    long next = item * curr;
                    if (set.Add(next)) 
                    {
                        queue.Enqueue(next, next);

                    }

                }
            }
            return (int)ans;

        }

        public int NthUglyNumber(int n)
        {
            int[] dp = new int[n + 1];
            dp[1] = 1;
            int p2 = 1, p3 = 1, p5 = 1;
            for (int i = 2; i <= n; i++)
            {
                int num2 = dp[p2] * 2, num3 = dp[p3] * 3, num5 = dp[p5] * 5;
                dp[i] = Math.Min(Math.Min(num2, num3), num5);
                if (dp[i] == num2)
                {
                    p2++;
                }
                if (dp[i] == num3)
                {
                    p3++;
                }
                if (dp[i] == num5)
                {
                    p5++;
                }
            }
            return dp[n];
        }

       
    }
}
