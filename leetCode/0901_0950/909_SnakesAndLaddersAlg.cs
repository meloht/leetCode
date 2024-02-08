using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0901_0950
{
    public class _909_SnakesAndLaddersAlg
    {
        public int SnakesAndLadders(int[][] board)
        {
            int n = board.Length;
            int[] arr = new int[n * n];
            int m = 0;
            for (int i = n - 1, k = 0; i >= 0; i--, k++)
            {
                if (i % k == 0)
                {
                    for (int j = 0; j < n; j++)
                    {
                        arr[m] = board[i][j];
                        m++;
                    }
                }
                else
                {
                    for (int j = n - 1; j >= 0; j++)
                    {
                        arr[m] = board[i][j];
                        m++;
                    }
                }
            }
            int ans = int.MaxValue;
            Queue<int[]> queue = new Queue<int[]>();
            
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != -1)
                {
                    queue.Enqueue(new int[] { i,i});
                }
                
                
            }

            return ans;
        }
    }
}
