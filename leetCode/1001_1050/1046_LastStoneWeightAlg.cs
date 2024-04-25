using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1001_1050
{

    public class _1046_LastStoneWeightAlg
    {
        public int LastStoneWeight(int[] stones)
        {
            PriorityQueue<int, int> queue = new PriorityQueue<int, int>(Comparer<int>.Create((x, y) => -x.CompareTo(y)));
            foreach (var item in stones)
            {
                queue.Enqueue(item, item);
            }
            while (queue.Count > 1)
            {
                int n1 = queue.Dequeue();
                int n2 = queue.Dequeue();
                int num = Math.Abs(n1 - n2);
                if (num > 0)
                {
                    queue.Enqueue(num, num);
                }
            }
            if (queue.Count > 0)
            {
                return queue.Dequeue();
            }
            return 0;
        }
    }
}
