﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1001_1050
{
    public class _1042_FlowerPlantingWithNoAdjacentAlg
    {
        public int[] GardenNoAdj(int n, int[][] paths)
        {
            IList<int>[] adj = new IList<int>[n];
            for (int i = 0; i < n; i++)
            {
                adj[i] = new List<int>();
            }
            foreach (int[] path in paths)
            {
                adj[path[0] - 1].Add(path[1] - 1);
                adj[path[1] - 1].Add(path[0] - 1);
            }
            int[] ans = new int[n];
            for (int i = 0; i < n; i++)
            {
                bool[] colored = new bool[5];
                foreach (int vertex in adj[i])
                {
                    colored[ans[vertex]] = true;
                }
                for (int j = 1; j <= 4; j++)
                {
                    if (!colored[j])
                    {
                        ans[i] = j;
                        break;
                    }
                }
            }
            return ans;

        }
    }
}
