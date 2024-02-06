using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0501_0550
{
    public class _502_IPOAlg
    {
        public int FindMaximizedCapital1(int k, int w, int[] profits, int[] capital)
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

        public int FindMaximizedCapital(int k, int w, int[] profits, int[] capital)
        {
            int n = profits.Length;
            PriorityQueue<int, int> queue = new PriorityQueue<int, int>(Comparer<int>.Create((a, b) => -a.CompareTo(b)));
            int[][] arr = new int[n][];
            for (int i = 0; i < n; i++)
            {
                arr[i] = new[] { profits[i], capital[i] };
            }
            Array.Sort(arr, (a, b) => a[1].CompareTo(b[1]));
            int count = 0;
            while (k > 0)
            {
                while (count < n && w >= arr[count][1])
                {
                    queue.Enqueue(arr[count][0], arr[count][0]);
                    count++;
                }

                if (queue.Count > 0)
                {
                    var d = queue.Dequeue();
                    w += d;
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
