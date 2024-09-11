using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2551_2600
{
    public class _2555_MaximizeWinFromTwoSegmentsAlg
    {
        public int MaximizeWin(int[] prizePositions, int k)
        {

            int n = prizePositions.Length;
            if (k * 2 + 1 >= prizePositions[n - 1] - prizePositions[0])
            {
                return n;
            }
            int ans = 0;
            int left = 0;
            int[] mx = new int[n + 1];
            for (int right = 0; right < n; right++)
            {
                while (prizePositions[right] - prizePositions[left] > k)
                {
                    left++;
                }
                ans = Math.Max(ans, mx[left] + right - left + 1);
                mx[right + 1] = Math.Max(mx[right], right - left + 1);
            }
            return ans;


        }
    }
}
