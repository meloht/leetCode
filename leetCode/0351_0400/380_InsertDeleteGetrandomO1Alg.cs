using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0351_0400
{
    public class _380_InsertDeleteGetrandomO1Alg
    {
        public class RandomizedSet
        {
            Random random = new Random();
            Dictionary<int, int> dict = new Dictionary<int, int>();
            List<int> list = new List<int>();
            public RandomizedSet()
            {

            }

            public bool Insert(int val)
            {
                if (dict.ContainsKey(val))
                    return false;
                dict.Add(val, list.Count);
                list.Add(val);

                return true;
            }

            public bool Remove(int val)
            {
                if (!dict.ContainsKey(val))
                    return false;
                int index = dict[val];
                int last = list[list.Count - 1];
                list[index] = last;
                dict[last] = index;
                dict.Remove(val);
                list.RemoveAt(list.Count - 1);

                return true;
            }

            public int GetRandom()
            {
                int index = random.Next(list.Count);

                return list[index];
            }
        }
    }
}
