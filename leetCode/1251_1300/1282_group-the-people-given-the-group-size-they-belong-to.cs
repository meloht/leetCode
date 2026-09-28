using System;
using System.Collections.Generic;
using System.Text;

namespace leetCode._1251_1300
{
    public class _1282_group_the_people_given_the_group_size_they_belong_to
    {
        public IList<IList<int>> GroupThePeople(int[] groupSizes)
        {
            Dictionary<int, List<int>> dict = new Dictionary<int, List<int>>();
            int idx = 0;
            foreach (var item in groupSizes)
            {
                if (dict.ContainsKey(item))
                {
                    dict[item].Add(idx);
                }
                else
                {
                    dict.Add(item, [idx]);
                }
                idx++;
            }
            List<IList<int>> ans = new List<IList<int>>();
            foreach (var item in dict)
            {
                if (item.Key == item.Value.Count)
                {
                    ans.Add(item.Value.ToArray());
                }
                else
                {
                    var res = item.Value.Chunk(item.Key);
                    foreach (var item1 in res)
                    {
                        ans.Add(item1);
                    }
                }

            }

            return ans;
        }


    }
}
