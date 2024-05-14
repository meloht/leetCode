using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2201_2250
{
    public class _2244_MinimumRoundsToCompleteAllTasksAlg
    {
        public int MinimumRounds(int[] tasks)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            foreach (int num in tasks)
            {
                if (!dict.ContainsKey(num))
                {
                    dict.Add(num, 1);
                }
                else
                {
                    dict[num]++;
                }
            }

            int count = 0;
            foreach (var item in dict)
            {
                
                int num = dict[item.Key];
                if (num == 1)
                {
                    return -1;
                }
                if (num % 3 == 0)
                {
                    count += num / 3;
                }

                else
                {
                    count += num / 3;
                    count++;
                }
            }
            return count;
        }


    }
}
