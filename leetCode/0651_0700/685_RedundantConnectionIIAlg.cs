using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace leetCode._0651_0700
{
    public class _685_RedundantConnectionIIAlg
    {
        public int[] FindRedundantDirectedConnection(int[][] edges)
        {
            int n = edges.Length;

            int[] inDegree = new int[n + 1];
            foreach (var item in edges)
            {
                inDegree[item[1]]++;
            }
            List<int> list = new List<int>();
            for (int i = n - 1; i >= 0; i--)
            {
                if (inDegree[edges[i][1]] == 2)
                {
                    list.Add(i);
                }
            }
            if (list.Count > 0)
            {
                // 入度为2是由两条边引起的,要么删靠后那条要么删靠前条,优先尝试删靠后条
                if (RemoveEdge(edges, list[0]))
                {
                    return edges[list[0]];
                }
                // 删靠后面一条无法满足条件,那么只能是删除靠前面的一条
                return edges[list[1]];
            }
            return removeCycleEdge(edges);
        }
        private bool RemoveEdge(int[][] edges, int delEdge)
        {
            UnionFind union = new UnionFind(edges.Length + 1);
            for (int i = 0; i < edges.Length; i++)
            {
                int[] edge = edges[i];
                // 如果不是要删除的边
                if (i != delEdge)
                {
                    // 有环
                    if (union.Find(edge[0]) == union.Find(edge[1]))
                    {
                        return false;
                    }
                    // 合并并查集
                    union.Union(edge[0], edge[1]);
                }
            }
            return true;
        }
        private int[] removeCycleEdge(int[][] edges)
        {
            UnionFind union = new UnionFind(edges.Length + 1);
            // 初始化并查集遍历所有的边,找到构成环的边
            foreach (int[] edge in edges)
            {
                // 如果u顶点和v顶点父节点一致,那么这时加入这条边[u,v]则会产生环
                // 这里之所以返回的一定是最后出现在给定二维数组的答案是因为:
                // 如果存在一个环,那么加入最后一条边才会刚好形成闭环,那么这条边是最靠后的,也就是答案
                if (union.Find(edge[0]) == union.Find(edge[1]))
                {
                    return edge;
                }
                // 否则合并并查集
                union.Union(edge[0], edge[1]);
            }
            return null;
        }

        private class UnionFind
        {
            private int[] parent;
            private int[] ranks;
            private int count;

            public UnionFind(int n)
            {
                this.parent = new int[n];
                this.ranks = new int[n];
                this.count = n;
                for (int i = 0; i < n; i++)
                {
                    parent[i] = i;
                }
            }


            public void Union(int x, int y)
            {
                int rootX = Find(x);
                int rootY = Find(y);
                if (rootX == rootY)
                {
                    return;
                }

                int xRank = this.ranks[rootX];
                int yRank = this.ranks[rootY];
                if (xRank < yRank)
                {
                    this.parent[rootX] = rootY;
                }
                else if (xRank > yRank)
                {
                    this.parent[rootY] = rootX;
                }
                else
                {
                    parent[rootX] = rootY;
                    this.ranks[rootY]++;
                }
                this.count--;
            }
            public int GetCount()
            {
                return this.count;
            }

            /// <summary>
            /// 路径压缩
            /// </summary>
            /// <returns></returns>
            public int Find(int x)
            {
                if (x != parent[x])
                {
                    parent[x] = Find(parent[x]);
                }
                return parent[x];
            }

        }
    }
}
