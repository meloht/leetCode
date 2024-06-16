using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode.WeeklyContest._0402
{
    public class Alg_02
    {
        public long CountCompleteDayPairs(int[] hours)
        {
            long ans = 0;

            List<int> hoursList = new List<int>();
            List<int> hoursList2 = new List<int>();
            foreach (var item in hours)
            {
                if (item >= 24 && item % 24 == 0)
                {
                    hoursList.Add(item);
                }
                else
                {
                    hoursList2.Add(item % 24);
                }
            }
            for (int i = 1; i <= hoursList.Count; i++)
            {
                ans += (hoursList.Count - i);
            }
            Dictionary<int, int> dict = new Dictionary<int, int>();
            foreach (int day in hoursList2)
            {
                if (dict.ContainsKey(day))
                {
                    dict[day]++;
                }
                else
                {
                    dict.Add(day, 1);
                }
            }

            foreach (int item in hoursList2)
            {

                dict[item]--;

                int nn = 24 - item;

                if (dict.ContainsKey(nn) && dict[nn] > 0)
                {
                    ans += dict[nn];
                }
            }

            return ans;
        }

        public long CountCompleteDayPairs1(int[] hours)
        {
            int ans = 0;
            int[] cnt = new int[24];
            foreach (var hour in hours)
            {
                int h = hour % 24;
                ans += cnt[(24 - h % 24) % 24];
                cnt[h]++;

            }
            return ans;
        }
    }
}
