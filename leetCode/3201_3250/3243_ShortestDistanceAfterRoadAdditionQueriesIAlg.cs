﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3201_3250
{
    public class _3243_ShortestDistanceAfterRoadAdditionQueriesIAlg
    {
        public int[] ShortestDistanceAfterQueries(int n, int[][] queries)
        {
            List<List<int>> neighbors = new List<List<int>>();
            for (int i = 0; i < n; i++)
            {
                neighbors.Add(new List<int>());
            }
            for (int i = 0; i < n - 1; i++)
            {
                neighbors[i].Add(i + 1);
            }
            int[] res = new int[queries.Length];
            for (int i = 0; i < queries.Length; i++)
            {
                neighbors[queries[i][0]].Add(queries[i][1]);
                res[i] = Bfs(n, neighbors);
            }
            return res;
        }

        private int Bfs(int n, List<List<int>> neighbors)
        {
            int[] dist = new int[n];
            for (int i = 1; i < n; i++)
            {
                dist[i] = -1;
            }
            Queue<int> q = new Queue<int>();
            q.Enqueue(0);
            dist[0] = 0;
            while (q.Count > 0)
            {
                int x = q.Dequeue();
                foreach (int y in neighbors[x])
                {
                    if (dist[y] >= 0)
                    {
                        continue;
                    }
                    q.Enqueue(y);
                    dist[y] = dist[x] + 1;
                }
            }
            return dist[n - 1];
        }

    }
}
