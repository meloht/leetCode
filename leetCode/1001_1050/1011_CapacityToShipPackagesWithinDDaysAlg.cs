using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1001_1050
{
    public class _1011_CapacityToShipPackagesWithinDDaysAlg
    {
        public int ShipWithinDays(int[] weights, int days)
        {
            int max = 0;
            int sum = 0;
            foreach (var item in weights)
            {
                max = Math.Max(max, item);
                sum += item;
            }
            int left = max;
            int right = sum;
            int ans = 0;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (getDays(mid, weights) <= days)
                {
                    ans = mid;
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return ans;
        }

        public int getDays(int mid, int[] weights)
        {
            int total = 0;
            int cnt = 0;
            for (int i = 0; i < weights.Length; i++)
            {
                if (total + weights[i] <= mid)
                {
                    total += weights[i];
                }
                else
                {
                    cnt++;
                    total = weights[i];

                }
                if (i == weights.Length - 1)
                {
                    cnt++;
                }
            }
            return cnt;
        }
    }
}
