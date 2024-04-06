using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0901_0950
{
    public class _933_NumberOfRecentCallsAlg
    {
        public class RecentCounter
        {
            Queue<int> queue = new Queue<int>();
            public RecentCounter()
            {

            }

            public int Ping(int t)
            {
                queue.Enqueue(t);
                int min = t - 3000;
                while (queue.Peek() < min)
                {
                    queue.Dequeue();
                }
                return queue.Count;
            }
        }
    }
}
