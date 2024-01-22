using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0201_0250
{
    public class _231_PowerOfTwoAlg
    {
        public bool IsPowerOfTwo1(int n)
        {
            if (n <= 0)
                return false;
            if (n == 1)
                return true;
            if (n % 2 > 0)
            {
                return false;
            }
            n = n / 2;
            return IsPowerOfTwo1(n);
        }

        public bool IsPowerOfTwo2(int n)
        {
            if (n <= 0)
                return false;

            return (n & (n - 1)) == 0;
        }

        public bool IsPowerOfTwo3(int n)
        {
            return n > 0 && (n & -n) == n;
        }

        const int BIG = 1 << 30;

        public bool IsPowerOfTwo(int n)
        {
            return n > 0 && BIG % n == 0;
        }

    }
}
