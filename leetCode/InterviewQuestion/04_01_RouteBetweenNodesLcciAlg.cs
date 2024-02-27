using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode.InterviewQuestion
{
    public class _04_01_RouteBetweenNodesLcciAlg
    {
        public bool FindWhetherExistsPath(int n, int[][] graph, int start, int target)
        {
            List<int>[] adj = new List<int>[n];
            foreach (int[] item in graph)
            {
                if (adj[item[0]] == null)
                {
                    adj[item[0]] = new List<int>();
                }
                if (item[0] == item[1])
                    continue;
                adj[item[0]].Add(item[1]);
            }

            bool[] visited = new bool[n];

            return DFS(start, visited, adj, target);
        }
        private bool DFS(int node, bool[] visited, List<int>[] adj, int target)
        {
            if (node == target)
                return true;
            visited[node] = true;
            if (adj[node] == null)
                return false;
            foreach (int neighbor in adj[node])
            {
                if (!visited[neighbor])
                {
                    bool bl = DFS(neighbor, visited, adj, target);
                    if (bl)
                    {
                        return bl;
                    }
                }
            }
            return false;
        }



    }
}
