using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode.WeeklyContest._0402
{
    public class Alg_01
    {
        public int CountCompleteDayPairs(int[] hours)
        {
            int ans = 0;
            for (int i = 0; i < hours.Length; i++)
            {
                for (int j = i + 1; j < hours.Length; j++)
                {
                    int num = hours[i] + hours[j];
                    if (num >= 24 && num % 24 == 0)
                    {
                        ans++;
                    }
                }
            }
            return ans;
        }
    }
}
