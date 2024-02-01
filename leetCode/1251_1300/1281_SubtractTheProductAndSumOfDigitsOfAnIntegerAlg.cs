using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1251_1300
{
    public class _1281_SubtractTheProductAndSumOfDigitsOfAnIntegerAlg
    {
        public int SubtractProductAndSum(int n)
        {
            int muti = 1;
            int sum = 0;
            while (n > 0)
            {
                int m = n % 10;
                muti *= m;
                sum += m;
                n /= 10;
            }
            return muti - sum;
        }
    }
}
