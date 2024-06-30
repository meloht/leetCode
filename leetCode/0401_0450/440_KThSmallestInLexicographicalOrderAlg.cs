using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0401_0450
{
    public class _440_KThSmallestInLexicographicalOrderAlg
    {
        public int FindKthNumber(int n, int k)
        {
            int curr = 1;
            long kk = k - 1;
            while (kk > 0)
            {
                long step = GetSteps(curr, n);
                if (step <= kk)
                {
                    kk -= step;
                    curr++;
                }
                else
                {
                    curr = curr * 10;
                    kk--;
                }
            }
            return curr;
        }
        private long GetSteps(int curr, int n)
        {
            long steps = 0;
            long first = curr;
            long last = curr;
            while (first <= n)
            {
                steps += (Math.Min(last, n) - first + 1);
                first = first * 10;
                last = last * 10 + 9;
            }
            return steps;
        }



    }
}
