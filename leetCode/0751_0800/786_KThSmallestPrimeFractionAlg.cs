using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0751_0800
{
    public class _786_KThSmallestPrimeFractionAlg
    {
        public int[] KthSmallestPrimeFraction(int[] arr, int k)
        {
            PriorityQueue<int[], double> queue = new PriorityQueue<int[], double>(Comparer<double>.Create((x, y) => y.CompareTo(x)));

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    double d = (double)arr[j] / arr[i];
                    queue.Enqueue([arr[j], arr[i]], d);
                    while (queue.Count > k)
                    {
                        queue.Dequeue();
                    }
                }
            }

           
            return queue.Peek();
        }
    }
}
