using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0401_0450
{
    public class _441_ArrangingCoinsAlg
    {
        public int ArrangeCoins(int n)
        {
            long left = 1;
            long right = n;
            while (left <= right)
            {
                long mid = left + (right - left) / 2;
                long num = (mid + 1) * mid / 2;
                if (num > n)
                {
                    right = mid - 1;
                }
                else if (num == n)
                {
                    return (int)mid;
                }
                else
                {
                    left = mid + 1;
                }

            }
            return (int)left - 1;
        }

        public int ArrangeCoins2(int n)
        {
            int left = 1, right = n;
            while (left < right)
            {
                int mid = (right - left + 1) / 2 + left;
                if ((long)mid * (mid + 1) <= (long)2 * n)
                {
                    left = mid;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return left;
        }


    }
}
