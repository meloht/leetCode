using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode.WeeklyContest._0401
{
    public class Alg_03
    {
        public int MaxTotalReward(int[] rewardValues)
        {
            Array.Sort(rewardValues);
            HashSet<int> a = new HashSet<int>();
            a.Add(0);
            foreach (var item in rewardValues)
            {
                var aa = a.ToArray();
                foreach (var item1 in aa)
                {
                    if (item > item1)
                    {
                        a.Add(item1 + item);
                    }
                }

            }

            return a.Max();
        }


    }
}
