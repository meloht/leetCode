using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1801_1850
{
    public class _1822_SignOfTheProductOfAnArrayAlg
    {
        public int ArraySign(int[] nums)
        {
            int sum = 1;
            foreach (var item in nums)
            {
                if (item == 0)
                {
                    return 0;
                }
                else if (item < 0)
                {
                    sum = -sum;
                }
            }

            return sum;
        }
    }
}
