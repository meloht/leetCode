using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1551_1600
{
    public class _1599_MaximumProfitOfOperatingACentennialWheelAlg
    {
        public int MinOperationsMaxProfit(int[] customers, int boardingCost, int runningCost)
        {
            int total = 0;
            int cnum = 0;
            int count = 0;

            for (int i = 0; i < customers.Length; i++)
            {
                cnum += customers[i];

                if (cnum >= 4)
                {
                    cnum -= 4;
                    total = 4 * boardingCost + total;
                    count++;
                    total = total - runningCost;
                }
                else if (cnum > 0)
                {
                    total = cnum * boardingCost + total;
                    cnum = 0;
                    count++;
                    total = total - runningCost;
                }
              
            }
            while (cnum > 0)
            {
                if (cnum >= 4)
                {
                    cnum -= 4;
                    total = 4 * boardingCost + total;
                    count++;
                    total = total - runningCost;
                }
                else if (cnum > 0)
                {
                    int nn = cnum * boardingCost;
                    if (nn <= runningCost)
                    {
                        break;
                    }
                    total = cnum * boardingCost + total;
                    cnum = 0;
                    count++;
                    total = total - runningCost;
                }
               

            }
            if (total <= 0)
                return -1;
            return count;
        }
    }
}
