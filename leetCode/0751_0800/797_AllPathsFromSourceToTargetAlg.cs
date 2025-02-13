using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0751_0800
{
    public class _797_AllPathsFromSourceToTargetAlg
    {
        public IList<IList<int>> AllPathsSourceTarget(int[][] graph)
        {
            IList<IList<int>> res = new List<IList<int>>();
            IList<int> path = new List<int>();
            path.Add(0);
            DFS(graph, 0, path, res);
            return res;
        }

        private void DFS(int[][] graph, int node, IList<int> path, IList<IList<int>> res)
        {
            if (node == graph.Length - 1)
            {
                res.Add(new List<int>(path));
                return;
            }
            foreach (int next in graph[node])
            {
                path.Add(next);
                DFS(graph, next, path, res);
                path.RemoveAt(path.Count - 1);
            }
        }
    }
}
