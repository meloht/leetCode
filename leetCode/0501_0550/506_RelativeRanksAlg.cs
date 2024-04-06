using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0501_0550
{
    public class _506_RelativeRanksAlg
    {
        public string[] FindRelativeRanks(int[] score)
        {
            PriorityQueue<int[], int> priorityQueue = new PriorityQueue<int[], int>(Comparer<int>.Create((x, y) => y.CompareTo(x)));
            string[] ranks = ["Gold Medal", "Silver Medal", "Bronze Medal"];

            for (int i = 0; i < score.Length; i++)
            {
                priorityQueue.Enqueue([score[i], i], score[i]);
            }

            string[] res = new string[score.Length];
            int index = 0;
            while (priorityQueue.Count > 0)
            {
                var val = priorityQueue.Dequeue();
                if (index < 3)
                {
                    res[val[1]] = ranks[index];
                }
                else
                {
                    res[val[1]] = (index + 1).ToString();
                }
                index++;

            }
            return res;
        }
    }
}
