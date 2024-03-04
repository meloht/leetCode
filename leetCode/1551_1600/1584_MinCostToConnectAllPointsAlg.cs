using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1551_1600
{

    public class _1584_MinCostToConnectAllPointsAlg
    {
        public int MinCostConnectPoints(int[][] points)
        {
            int n = points.Length;
            UnionFind union = new UnionFind(n);
            List<Edge> list = new List<Edge>();
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    list.Add(new Edge(i, j, GetDis(points, i, j)));
                }
            }
            list.Sort((x, y) => x.Length.CompareTo(y.Length));
            int res = 0;
            int num = 1;
            foreach (var item in list)
            {
                int len = item.Length;
                if (!union.IsConnect(item.X, item.Y))
                {
                    union.Union(item.X, item.Y);
                    res += len;
                    num++;
                    if (num == n)
                    {
                        break;
                    }
                }
            }
            return res;
        }

        private int GetDis(int[][] points, int x, int y)
        {
            int dis = Math.Abs(points[x][0] - points[y][0]) + Math.Abs(points[x][1] - points[y][1]);
            return dis;
        }
        private class Edge
        {
            public int X { get; set; }
            public int Y { get; set; }
            public int Length { get; set; }

            public Edge(int x, int y, int len)
            {
                this.X = x;
                this.Y = y;
                this.Length = len;
            }
        }
        private class UnionFind
        {
            private int[] parent;
            private int[] ranks;
            private int[] size;
            private int count = 0;
            public UnionFind(int n)
            {
                this.parent = new int[n];
                this.ranks = new int[n];
                this.size = new int[n];
                this.count = n;
                for (int i = 0; i < n; i++)
                {
                    parent[i] = i;
                    this.size[i] = 1;
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
                    this.size[rootY] += size[rootX];
                }
                else if (xRank > yRank)
                {
                    this.parent[rootY] = rootX;
                    this.size[rootX] += size[rootY];
                }
                else
                {
                    parent[rootX] = rootY;
                    this.ranks[rootY]++;
                    this.size[rootY] += size[rootX];
                }
                this.count--;

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
            public int Count
            {
                get { return count; }
            }
            public int GetSize(int x)
            {
                int root = Find(x);
                return size[root];
            }

            public bool IsConnect(int x, int y)
            {
                int rootx = Find(x);
                int rooty = Find(y);
                if (rootx == rooty)
                    return true;
                return false;
            }
        }
    }
}
