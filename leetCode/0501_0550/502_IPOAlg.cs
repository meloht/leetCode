using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0501_0550
{
    public class _502_IPOAlg
    {
        public int FindMaximizedCapital(int k, int w, int[] profits, int[] capital)
        {
            PriorityQueue<int[], int> queue = new PriorityQueue<int[], int>(Comparer<int>.Create((a, b) => -a.CompareTo(b)));
            PriorityQueue<int[], int> queueTemp = new PriorityQueue<int[], int>();
            for (int i = 0; i < profits.Length; i++)
            {
                queueTemp.Enqueue(new[] { profits[i], capital[i] }, capital[i]);
            }
            while (k > 0)
            {
                while (queueTemp.Count > 0 && w >= queueTemp.Peek()[1])
                {
                    var data = queueTemp.Dequeue();
                    queue.Enqueue(data, data[0]);
                }

                if (queue.Count > 0)
                {
                    var d = queue.Dequeue();
                    w += d[0];
                    k--;
                }
                else
                {
                    break;
                }
            }

            return w;
        }
    }
}
