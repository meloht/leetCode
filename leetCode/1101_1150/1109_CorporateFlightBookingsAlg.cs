using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1101_1150
{
    public class _1109_CorporateFlightBookingsAlg
    {
        public int[] CorpFlightBookings(int[][] bookings, int n)
        {
            int[] nums = new int[n];
            foreach (int[] booking in bookings)
            {
                nums[booking[0] - 1] += booking[2];
                if (booking[1] < n)
                {
                    nums[booking[1]] -= booking[2];
                }
            }
            for (int i = 1; i < n; i++)
            {
                nums[i] += nums[i - 1];
            }
            return nums;
        }
    }
}
