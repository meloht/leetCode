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
            int ans = 0;
            List<int> list = new List<int>(customers);

            while (list.Count > 0 && list[list.Count - 1] == 0)
            {
                list.RemoveAt(list.Count - 1);
            }

            for (int i = 0; i < list.Count; i++)
            {
                cnum += list[i];

                if (cnum >= 4)
                {
                    cnum -= 4;
                    total = 4 * boardingCost + total;

                }
                else if (cnum > 0)
                {
                    total = cnum * boardingCost + total;
                    cnum = 0;
                }
                count++;
                total = total - runningCost;
              

            }
            if (cnum == 0)
            {
                if (total <= 0)
                    return -1;
                return count;
            }
           
            
            int profitEachTime = boardingCost * 4 - runningCost;
            if (profitEachTime <= 0)
            {
                if (total <= 0)
                    return -1;
                return count;
            }


            if (cnum > 0)
            {
                int times = cnum / 4;
                total += times * profitEachTime;
                count += times;

                int rem = cnum % 4;
                int remp = boardingCost * rem - runningCost;
                if (remp > 0)
                {
                    count++;
                    total += remp;
                }
            }

            if (total <= 0)
                return -1;
            return count;
        }

        public int MinOperationsMaxProfit2(int[] customers, int boardingCost, int runningCost)
        {
            int ans = -1;
            int maxProfit = 0;
            int totalProfit = 0;
            int operations = 0;
            int customersCount = 0;
            int n = customers.Length;
            for (int i = 0; i < n; i++)
            {
                operations++;
                customersCount += customers[i];
                int curCustomers = Math.Min(customersCount, 4);
                customersCount -= curCustomers;
                totalProfit += boardingCost * curCustomers - runningCost;
                if (totalProfit > maxProfit)
                {
                    maxProfit = totalProfit;
                    ans = operations;
                }
            }
            if (customersCount == 0)
            {
                return ans;
            }
            int profitEachTime = boardingCost * 4 - runningCost;
            if (profitEachTime <= 0)
            {
                return ans;
            }
            if (customersCount > 0)
            {
                int fullTimes = customersCount / 4;
                totalProfit += profitEachTime * fullTimes;
                operations += fullTimes;
                if (totalProfit > maxProfit)
                {
                    maxProfit = totalProfit;
                    ans = operations;
                }
                int remainingCustomers = customersCount % 4;
                int remainingProfit = boardingCost * remainingCustomers - runningCost;
                totalProfit += remainingProfit;
                if (totalProfit > maxProfit)
                {
                    maxProfit = totalProfit;
                    operations++;
                    ans++;
                }
            }
            return ans;
        }


    }
}
