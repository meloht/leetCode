using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0301_0350
{
    public class _347_TopKFrequentElementsAlg
    {
        public int[] TopKFrequent(int[] nums, int k)
        {
            List<int> result = new List<int>();
            Dictionary<int, int> dict = new Dictionary<int, int>();
            foreach (int i in nums) 
            {
                if (dict.ContainsKey(i))
                {
                    dict[i]++;
                }
                else
                {
                    dict.Add(i, 1);
                }
            }

            PriorityQueue<int,int> queue = new PriorityQueue<int,int>(Comparer<int>.Create((a, b) => b - a));
            foreach (var item in dict)
            {
                queue.Enqueue(item.Key, item.Value);
            }
            for (int i = 0; i < k; i++)
            {
                result.Add(queue.Dequeue());
            }
           
            return result.ToArray();
        }
    }
}
