using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3301_3350
{
    public class _3342_FindMinimumTimeToReachLastRoomIIAlg
    {
        private readonly static int[][] DIRS = [[-1, 0], [1, 0], [0, -1], [0, 1]];
        public int MinTimeToReach(int[][] moveTime)
        {
            int n = moveTime.Length;
            int m = moveTime[0].Length;

            int[][] dis = new int[n][];
            for (int i = 0; i < dis.Length; i++)
            {
                dis[i] = new int[m];
                Array.Fill(dis[i], int.MaxValue);
            }
            dis[0][0] = 0;

            PriorityQueue<int[], int> pq = new PriorityQueue<int[], int>(Comparer<int>.Create((x, y) => x - y));
            pq.Enqueue([0, 0, 0], 0);

            while (true)
            {
                int[] p = pq.Dequeue();
                int d = p[0], i = p[1], j = p[2];
                if (i == n - 1 && j == m - 1)
                {
                    return d;
                }
                if (d > dis[i][j])
                {
                    continue;
                }
                int time = (i + j) % 2 + 1;
                foreach (int[] item in DIRS)
                {
                    int x = i + item[0], y = j + item[1];
                    if (0 <= x && x < n && 0 <= y && y < m)
                    {
                        int newDis = Math.Max(d, moveTime[x][y]) + time;
                        if (newDis < dis[x][y])
                        {
                            dis[x][y] = newDis;
                            pq.Enqueue([newDis, x, y], newDis);
                        }
                    }

                }

            }

        }
    }
}
