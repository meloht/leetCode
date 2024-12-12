using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2901_2950
{
    public class _2931_MaximumSpendingAfterBuyingItemsAlg
    {
        public long MaxSpending(int[][] values)
        {
            int m = values.Length;
            int n = values[0].Length;
            int[] indexCol = new int[m];
            PriorityQueue<int[], int> queue = new PriorityQueue<int[], int>();
            for (int i = 0; i < m; i++)
            {
                int val = values[i][n - 1];
                queue.Enqueue([i, val], val);
                indexCol[i] = n - 1;
            }
            long ans = 0;
            long day = 1;

            while (queue.Count > 0)
            {
                var item = queue.Dequeue();
                int i = item[0];
                ans += (long)item[1] * day;
                if (indexCol[i] > 0)
                {
                    indexCol[i]--;
                    int j = indexCol[i];
                    queue.Enqueue([i, values[i][j]], values[i][j]);
                }
               
                day++;
            }
            return ans;
        }
    }
}
