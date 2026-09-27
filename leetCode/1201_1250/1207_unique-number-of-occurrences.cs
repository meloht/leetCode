using System;
using System.Collections.Generic;
using System.Text;

namespace leetCode._1201_1250
{
    public class _1207_unique_number_of_occurrences
    {
        public bool UniqueOccurrences(int[] arr)
        {

            var dict = arr.GroupBy(p => p).ToDictionary(p => p.Key, p => p.Count());
            HashSet<int> set = new HashSet<int>();
            foreach (var i in dict.Values)
            {
                if (!set.Add(i))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
