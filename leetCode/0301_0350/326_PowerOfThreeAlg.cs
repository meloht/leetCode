using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0301_0350
{
    public class _326_PowerOfThreeAlg
    {
        public bool IsPowerOfThree(int n)
        {
            while (n > 0 && n % 3 == 0)
            {
                n /= 3;
            }
            bool bl = n == 1;
            return bl;
        }
        /// <summary>
        /// 32 位有符号整数的范围内，最大的 3 的幂为 3^19=1162261467 
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public bool IsPowerOfThree2(int n)
        {
            return n > 0 && 1162261467 % n == 0;
        }


    }
}
