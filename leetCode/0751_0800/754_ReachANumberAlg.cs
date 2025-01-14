using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0751_0800
{
    public class _754_ReachANumberAlg
    {
        public int ReachNumber(int target)
        {
            int t = Math.Abs(target);
            int sum = 0;
            int s = 0;
            while (sum < t)
            {
                s++;
                sum += s;
            }
            int dis = sum - t;
            if (dis % 2 == 0)
                return s;
            if (s % 2 == 0)
            {
                return s + 1;
            }

            return s + 2;
        }
    }
}
