using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0301_0350
{
    public class _342_PowerOfGourAlg
    {
        public bool IsPowerOfFour(int n)
        {
            if (n <= 0)
                return false;
            if (n == 1)
                return true;
            if (n % 4 > 0)
            {
                return false;
            }
            n = n / 4;

            return IsPowerOfFour(n);
       
        }

        public bool IsPowerOfFour1(int n)
        {
            return n > 0 && (n & (n - 1)) == 0 && n % 3 == 1;
        }
    }
}
