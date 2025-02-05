using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0751_0800
{
    public class _786_KThSmallestPrimeFractionAlg
    {
        public int[] KthSmallestPrimeFraction1(int[] arr, int k)
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

        public int[] KthSmallestPrimeFraction2(int[] arr, int k)
        {
            PriorityQueue<int[], int[]> queue = new PriorityQueue<int[], int[]>(Comparer<int[]>.Create((x, y) => arr[x[0]] * arr[y[1]] - arr[x[1]] * arr[y[0]]));

            for (int i = 1; i < arr.Length; i++)
            {
                int[] item = [0, i];
                queue.Enqueue(item, item);
            }

            for (int i = 1; i < k; i++)
            {
                int[] item = queue.Dequeue();
                if (item[0] + 1 < item[1])
                {
                    int[] itemNew = [item[0] + 1, item[1]];
                    queue.Enqueue(itemNew, itemNew);
                }
            }


            return [arr[queue.Peek()[0]], arr[queue.Peek()[1]]];
        }

        public int[] KthSmallestPrimeFraction(int[] arr, int k)
        {
            int n = arr.Length;
            double left = 0.0, right = 1.0;
            while (true)
            {
                double mid = (left + right) / 2;
                int i = -1, count = 0;
                // 记录最大的分数
                int x = 0, y = 1;

                for (int j = 1; j < n; ++j)
                {
                    while ((double)arr[i + 1] / arr[j] < mid)
                    {
                        ++i;
                        if (arr[i] * y > arr[j] * x)
                        {
                            x = arr[i];
                            y = arr[j];
                        }
                    }
                    count += i + 1;
                }

                if (count == k)
                {
                    return new int[] { x, y };
                }
                if (count < k)
                {
                    left = mid;
                }
                else
                {
                    right = mid;
                }
            }
        }

    }
}
