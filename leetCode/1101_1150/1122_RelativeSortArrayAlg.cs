using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1101_1150
{
    public class _1122_RelativeSortArrayAlg
    {
        public int[] RelativeSortArray(int[] arr1, int[] arr2)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();

            foreach (var item in arr1)
            {
                if (dict.ContainsKey(item))
                {
                    dict[item]++;
                }
                else
                {
                    dict.Add(item, 1);
                }
            }
            List<int> list = new List<int>();
            foreach (var item in arr2)
            {
                int count = dict[item];
                for (int i = 0; i < count; i++)
                {
                    list.Add(item);
                }
                dict.Remove(item);
            }

            List<int> ls = new List<int>();
            foreach (var item in dict)
            {
                int count = item.Value;
                for (int i = 0; i < count; i++)
                {
                    ls.Add(item.Key);
                }
            }
            ls.Sort();
            list.AddRange(ls);
            return list.ToArray();
        }
    }
}
