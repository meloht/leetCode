using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode.WeeklyContest._400
{
    public class Alg_400_02
    {
        public int CountDays(int days, int[][] meetings)
        {
            int ans = 0;
            Array.Sort(meetings, (x, y) => x[0].CompareTo(y[0]));
            Dictionary<int, int> dict = new Dictionary<int, int>();

            int j = 0;
            while (j < meetings.Length)
            {
                int[] item = meetings[j];
                int begin = item[0];
                int end = item[1];
                for (int k = j + 1; k < meetings.Length; k++)
                {
                    int[] itemEnd = meetings[k];
                    if (itemEnd[0] <= end)
                    {
                        end = Math.Max(end, itemEnd[1]);
                        j = k;
                    }
                    else
                    {
                        break;
                    }
                }
                dict.Add(begin, end);
                j++;
            }

             ans = days;
            foreach (var item in dict)
            {
                ans -= (item.Value - item.Key + 1);
            }


          
            return ans;
        }
    }
}
