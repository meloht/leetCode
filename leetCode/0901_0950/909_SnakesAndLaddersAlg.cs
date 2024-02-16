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
            if (board[0][0] != -1)
                return -1;
            if (n < 3)
                return 1;

            bool[] vis = new bool[n * n + 1];

            Queue<Tuple<int, int>> queue = new Queue<Tuple<int, int>>();

            queue.Enqueue(new Tuple<int, int>(1, 0));
            int total = n * n;
            while (queue.Count > 0)
            {
                var item = queue.Dequeue();
                for (int i = 1; i <= 6; i++)
                {
                    int next = item.Item1 + i;
                    if (next > total)
                    {
                        break;
                    }
                    var rowCol = GetNextColRow(next, n);
                    if (board[rowCol.Item1][rowCol.Item2] > 0)
                    {
                        next = board[rowCol.Item1][rowCol.Item2];
                    }
                    if (next == total)
                    {
                        return item.Item2 + 1;
                    }
                    if (!vis[next])
                    {
                        vis[next] = true;
                        queue.Enqueue(new Tuple<int, int>(next, item.Item2 + 1));
                    }

                }
            }

            return -1;
        }

        private Tuple<int, int> GetNextColRow(int index, int n)
        {
            int row = (index - 1) / n, col = (index - 1) % n;
            if (row % 2 == 1)
            {
                col = n - 1 - col;
            }
            return new Tuple<int, int>(n - 1 - row, col);
        }


    }
}
