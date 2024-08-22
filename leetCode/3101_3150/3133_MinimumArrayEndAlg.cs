using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3101_3150
{
    public class _3133_MinimumArrayEndAlg
    {
        public long MinEnd(int n, int x)
        {
            n--;
            long ans = x;
            int j = 0;
            for (long t = ~x, lb=0; (n >> (int)j) > 0; t ^= lb)
            {
                lb = t & -t;
                ans |= (long)(n >> j++ & 1) * lb;
            }
            return ans;
        }
    }
}
