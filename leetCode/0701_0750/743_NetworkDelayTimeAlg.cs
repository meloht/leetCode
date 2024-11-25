using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0701_0750
{
    public class _743_NetworkDelayTimeAlg
    {
        public int NetworkDelayTime(int[][] times, int n, int k)
        {
            List<int[]>[] g = new List<int[]>[n];
            for (int i = 0; i < n; i++)
            {
                g[i] = new List<int[]>();
            }
            foreach (var item in times)
            {
                g[item[0] - 1].Add([item[1] - 1, item[2]]);
            }
            int maxDis = 0;
            int left = n;
            int[] dis = new int[n];
            Array.Fill(dis, int.MaxValue);
            dis[k - 1] = 0;
            PriorityQueue<int[], int> pq = new PriorityQueue<int[], int>(Comparer<int>.Create((x, y) => x.CompareTo(y)));
            pq.Enqueue([0, k - 1], 0);

            while (pq.Count > 0)
            {
                int[] p = pq.Dequeue();
                int dx = p[0];
                int x = p[1];

                if (dx > dis[x])
                {
                    continue;
                }
                maxDis = dx;
                left--;

                foreach (int[] e in g[x])
                {
                    int y = e[0];
                    int newDis = dx + e[1];
                    if (newDis < dis[y])
                    {
                        dis[y] = newDis; // 更新 x 的邻居的最短路
                        pq.Enqueue([newDis, y], newDis);
                    }
                }



            }
            return left == 0 ? maxDis : -1;
        }
    }
}
