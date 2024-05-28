using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace leetCode._0351_0400
{

    public class _378_KthSmallestElementInASortedMatrixAlg
    {
        public int KthSmallest1(int[][] matrix, int k)
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

        public int KthSmallest(int[][] matrix, int k)
        {
            int n = matrix.Length;
            int left = matrix[0][0];
            int right = matrix[n - 1][n - 1];
            while (left < right)
            {
                int mid = left + ((right - left) >> 1);
                if (check(matrix, mid, k, n))
                {
                    right = mid;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return left;

        }
        public bool check(int[][] matrix, int mid, int k, int n)
        {
            int i = n - 1;
            int j = 0;
            int num = 0;
            while (i >= 0 && j < n)
            {
                if (matrix[i][j] <= mid)
                {
                    num += i + 1;
                    j++;
                }
                else
                {
                    i--;
                }
            }
            return num >= k;
        }

      

    }
}
