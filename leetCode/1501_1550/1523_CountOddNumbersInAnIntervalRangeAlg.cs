using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1501_1550
{
    public class _1523_CountOddNumbersInAnIntervalRangeAlg
    {
        public int CountOdds(int low, int high)
        {
            int num = high - low;
            if (low % 2 == 0)
            {
                if (num % 2 == 0)
                {
                    return num / 2;
                }
                else
                {

                    return num / 2 + 1;
                }
            }
            else
            {
                return num / 2 + 1;
            }
        }
    }
}
