using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0251_0300
{
    public class _263_UglyNumberAlg
    {
        public bool IsUgly(int n)
        {

            if (n <= 0)
                return false;
            while (n % 2 == 0)
            {
                n /= 2;
            }
            while (n % 3 == 0)
            {
                n /= 3;
            }
            while (n % 5 == 0)
            {
                n /= 5;
            }
            return n == 1;
        }


    }
}
