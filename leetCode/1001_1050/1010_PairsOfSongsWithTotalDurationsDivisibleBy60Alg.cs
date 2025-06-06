using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1001_1050
{
    public class _1010_PairsOfSongsWithTotalDurationsDivisibleBy60Alg
    {
        public int NumPairsDivisibleBy60(int[] time)
        {
            int[] arr = new int[60];
            int ans = 0;
            foreach (var item in time)
            {
                int num = item % 60;
                ans += arr[(60 - num) % 60];
                arr[num]++;

            }
            return ans;
        }
    }
}
