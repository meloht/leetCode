using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0351_0400
{

    public class _378_KthSmallestElementInASortedMatrixAlg
    {
        public int KthSmallest(int[][] matrix, int k)
        {
            PriorityQueue<int, int> queue =
                new PriorityQueue<int, int>(Comparer<int>.Create((x, y) => y.CompareTo(x)));

            int n = matrix.Length;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    queue.Enqueue(matrix[i][j], matrix[i][j]);
                    if (queue.Count > k)
                    {
                        queue.Dequeue();
                    }
                }
            }

            return queue.Peek();
        }
    }
}
