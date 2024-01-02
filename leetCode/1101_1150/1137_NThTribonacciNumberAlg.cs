using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1101_1150
{
    public class _1137_NThTribonacciNumberAlg
    {
        public int Tribonacci(int n)
        {
            if (n <= 1)
                return n;
            if (n == 2)
                return 1;

            int t0 = 0;
            int t1 = 0;
            int t2 = 1;
            int ans = 1;
            for (int i = 3; i <= n; i++)
            {
                t0 = t1;
                t1 = t2;
                t2 = ans;

                ans = t0 + t1 + t2;

            }

            return ans;
        }



    }
}
