using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace leetCode._1601_1650
{
    public class _1631_PathWithMinimumEffortAlg
    {
        public int MinimumEffortPath(int[][] heights)
        {
            int rows = heights.Length;
            int cols = heights[0].Length;

            List<int[]> edges = new List<int[]>();

            for (int i = 0; i < rows; ++i)
            {
                for (int j = 0; j < cols; ++j)
                {
                    int id = i * cols + j;
                    if (i > 0)
                    {
                        edges.Add(new int[] { id - cols, id, Math.Abs(heights[i][j] - heights[i - 1][j]) });
                    }
                    if (j > 0)
                    {
                        edges.Add(new int[] { id - 1, id, Math.Abs(heights[i][j] - heights[i][j - 1]) });
                    }
                }
            }

            edges.Sort((x, y) => x[2].CompareTo(y[2]));
            UnionFind unionFind = new UnionFind(rows * cols);
            int end = rows * cols - 1;

            int ans = 0;
            foreach (var item in edges)
            {
                int x = item[0], y = item[1], v = item[2];
                unionFind.Union(x, y);
                if (unionFind.IsConnected(0, end))
                {
                    ans = v;
                    break;
                }
            }
            return ans;
        }

        private class UnionFind
        {
            private int[] parent;
            private int[] ranks;

            public UnionFind(int n)
            {
                this.parent = new int[n];
                this.ranks = new int[n];
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

            public bool IsConnected(int x, int y)
            {
                int rootX = Find(x);
                int rootY = Find(y);
                if (rootX == rootY)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }
    }
}
