using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0301_0350
{
    public class _310_MinimumHeightTreesAlg
    {
        public IList<int> FindMinHeightTrees(int n, int[][] edges)
        {
            List<int> result = new List<int>();
            if (n == 1)
            {
                result.Add(0);
                return result;
            }
            int[] degree = new int[n];
            List<List<int>> map = new List<List<int>>();
            for (int i = 0; i < n; i++)
            {
                map.Add(new List<int>());
            }
            foreach (int[] edge in edges)
            {
                degree[edge[0]]++;
                degree[edge[1]]++;
                map[edge[0]].Add(edge[1]);
                map[edge[1]].Add(edge[0]);
            }
            Queue<int> queue = new Queue<int>();
            for (int i = 0; i < n; i++)
            {
                if (degree[i] == 1)
                {
                    queue.Enqueue(i);
                }
            }
            while (queue.Count > 0)
            {
                result = new List<int>();
                int size = queue.Count;
                for (int i = 0; i < size; i++)
                {
                    int curr = queue.Dequeue();
                    result.Add(curr);

                    List<int> neighbors = map[curr];

                    foreach (var item in neighbors)
                    {
                        degree[item]--;
                        if (degree[item] == 1)
                        {
                            queue.Enqueue(item);
                        }
                    }
                }
            }
            return result;
        }
    }
}
