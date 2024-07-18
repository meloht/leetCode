using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3101_3150
{
    public class _3112_MinimumTimeToVisitDisappearingNodesAlg
    {
        public int[] MinimumTime(int n, int[][] edges, int[] disappear)
        {
            List<int[]>[] g = new List<int[]>[n];
            for (int i = 0; i < n; i++)
            {
                g[i] = new List<int[]>();
            }
            foreach (int[] e in edges)
            {
                int x = e[0];
                int y = e[1];
                int wt = e[2];
                g[x].Add([y, wt]);
                g[y].Add([x, wt]);
            }
            int[] dis = new int[n];
            Array.Fill(dis, -1);
            dis[0] = 0;
            PriorityQueue<int[], int> pq = new PriorityQueue<int[], int>();
            pq.Enqueue([0, 0], 0);
            while (pq.Count > 0) 
            {
                int[] p=pq.Dequeue();
                int dx = p[0];
                int x = p[1];
                if (dx > dis[x])
                {
                    continue;
                }

                foreach (int[] e in g[x])
                {
                    int y = e[0];
                    int newdis = dx + e[1];
                    if (newdis < disappear[y] && (dis[y] < 0 || newdis < dis[y]))
                    {
                        dis[y] = newdis;
                        pq.Enqueue([newdis, y], newdis);
                    }
                }
            }
            return dis;
        }
    }
}
