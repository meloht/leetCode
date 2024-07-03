using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3051_3100
{
    public class _3099_HarshadNumberAlg
    {
        public int SumOfTheDigitsOfHarshadNumber(int x)
        {
            int sum = 0;
            int n = x;
            while (n > 0)
            {
                sum += n % 10;
                n /= 10;
            }
            if (x % sum == 0)
                return sum;
            return -1;
        }
    }
}
