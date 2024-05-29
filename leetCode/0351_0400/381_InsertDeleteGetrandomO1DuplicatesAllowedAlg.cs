using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0351_0400
{
    public class _381_InsertDeleteGetrandomO1DuplicatesAllowedAlg
    {
        public class RandomizedCollection
        {
            Random random = new Random();
            Dictionary<int, List<int>> dict = new Dictionary<int, List<int>>();
            List<int> list = new List<int>();
            public RandomizedCollection()
            {

            }

            public bool Insert(int val)
            {
                list.Add(val);

                if (dict.ContainsKey(val))
                {
                    dict[val].Add(list.Count - 1);
                    return false;
                }
                else
                {
                    dict.Add(val, [list.Count - 1]);
                    return true;
                }
            }

            public bool Remove(int val)
            {
                if (dict.ContainsKey(val))
                {
                    var listIndex = dict[val];
                    int index = listIndex[listIndex.Count - 1];

                    list[index] = list[list.Count - 1];

                    var listNum = dict[list[index]];
                    listNum[listNum.Count - 1] = index;
                    listNum.Sort();

                    list.RemoveAt(list.Count - 1);

                    dict[val].RemoveAt(listIndex.Count - 1);
                    if (dict[val].Count == 0)
                    {
                        dict.Remove(val);
                    }

                    return true;
                }

                return false;
            }

            public int GetRandom()
            {
                int index = random.Next(list.Count);

                return list[index];
            }
        }



    }
}
