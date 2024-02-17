using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0351_0400
{
    public class _399_EvaluateDivisionAlg
    {
        public double[] CalcEquation(IList<IList<string>> equations, double[] values, IList<IList<string>> queries)
        {
            double[] res = new double[queries.Count];

            int size = equations.Count;

            UnionFind unionFind = new UnionFind(2 * size);

            Dictionary<string, int> dict = new Dictionary<string, int>(2 * size);
            int id = 0;
            for (int i = 0; i < size; i++)
            {
                IList<string> equation = equations[i];
                string v1 = equation[0];
                string v2 = equation[1];
                if (!dict.ContainsKey(v1))
                {
                    dict.Add(v1, id);
                    id++;
                }
                if (!dict.ContainsKey(v2))
                {
                    dict.Add(v2, id);
                    id++;
                }

                unionFind.Union(dict[v1], dict[v2], values[i]);
            }

            int qsize = queries.Count;

            for (int i = 0; i < qsize; i++)
            {
                string v1 = queries[i][0];
                string v2 = queries[i][1];

                if (dict.ContainsKey(v1) && dict.ContainsKey(v2))
                {
                    int id1 = dict[v1];
                    int id2 = dict[v2];
                    res[i] = unionFind.IsConnected(id1, id2);
                }
                else
                {
                    res[i] = -1;
                }

            }

            return res;
        }

        private class UnionFind
        {
            private int[] parent;
            private double[] weight;

            public UnionFind(int n)
            {
                this.parent = new int[n];
                this.weight = new double[n];
                for (int i = 0; i < n; i++)
                {
                    parent[i] = i;
                    weight[i] = 1.0d;
                }
            }

            public void Union(int x, int y, double value)
            {
                int rootX = Find(x);
                int rootY = Find(y);
                if (rootX == rootY)
                {
                    return;
                }
                parent[rootX] = rootY;
                weight[rootX] = weight[y] * value / weight[x];
            }

            /// <summary>
            /// 路径压缩
            /// </summary>
            /// <returns></returns>
            public int Find(int x)
            {
                if (x != parent[x])
                {
                    int origin = parent[x];
                    parent[x] = Find(parent[x]);
                    weight[x] *= weight[origin];
                }
                return parent[x];
            }

            public double IsConnected(int x, int y)
            {
                int rootX = Find(x);
                int rootY = Find(y);
                if (rootX == rootY)
                {
                    return weight[x] / weight[y];
                }
                else
                {
                    return -1.0d;
                }
            }
        }


    }
}
