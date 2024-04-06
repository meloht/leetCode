using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0701_0750
{
    public class _703_KthLargestElementInAStreamAlg
    {
        public class KthLargest
        {
            PriorityQueue<int, int> queue = new PriorityQueue<int, int>();
            int Count = 0;
            public KthLargest(int k, int[] nums)
            {
                Count = k;
                foreach (var item in nums)
                {
                    queue.Enqueue(item, item);
                }
                while (queue.Count > k)
                {
                    queue.Dequeue();
                }
            }

            public int Add(int val)
            {
                queue.Enqueue(val, val);
                if (queue.Count > Count)
                {
                    queue.Dequeue();
                }
                return queue.Peek();
            }
        }
    }
}
