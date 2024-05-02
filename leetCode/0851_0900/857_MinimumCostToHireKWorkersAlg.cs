﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0851_0900
{
    
    public class _857_MinimumCostToHireKWorkersAlg
    {
        public double MincostToHireWorkers(int[] quality, int[] wage, int k)
        {
            int n = quality.Length;
            int[] h = new int[n];
            for (int i = 0; i < n; i++)
            {
                h[i] = i;
            }
            Array.Sort(h, (a, b) => {
                return quality[b] * wage[a] - quality[a] * wage[b];
            });
            double res = 1e9;
            double totalq = 0.0;
            PriorityQueue<int, int> pq = new PriorityQueue<int, int>();
            for (int i = 0; i < k - 1; i++)
            {
                totalq += quality[h[i]];
                pq.Enqueue(quality[h[i]], -quality[h[i]]);
            }
            for (int i = k - 1; i < n; i++)
            {
                int idx = h[i];
                totalq += quality[idx];
                pq.Enqueue(quality[idx], -quality[idx]);
                double totalc = ((double)wage[idx] / quality[idx]) * totalq;
                res = Math.Min(res, totalc);
                totalq -= pq.Dequeue();
            }
            return res;
        }
    }
}
