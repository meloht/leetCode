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
            Dictionary<int, HashSet<int>> dict = new Dictionary<int, HashSet<int>>();
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
                    int index = listIndex.First();
                    int lastNum = list[list.Count - 1];
                    list[index] = lastNum;
                    dict[val].Remove(index);

                    var listNum = dict[lastNum];
                    listNum.Remove(list.Count - 1);
                    if (index < list.Count - 1)
                    {
                        listNum.Add(index);
                    }
                  
                    if (dict[val].Count == 0)
                    {
                        dict.Remove(val);
                    }
                    list.RemoveAt(list.Count - 1);
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
