using leetCode._0301_0350;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0401_0450
{
    public class _427_ConstructQuadTreeAlg
    {
        public NodeFour Construct1(int[][] grid)
        {
            int n = grid.Length;
            NodeFour root = Dfs1(grid, 0, n, 0, n);
            return root;
        }
        private NodeFour Dfs1(int[][] grid, int n0, int n1, int m0, int m1)
        {
            bool bl = true;
            for (int i = n0; i < n1; i++)
            {
                for (int j = m0; j < m1; j++)
                {
                    if (grid[i][j] != grid[n0][m0])
                    {
                        bl = false;
                        break;
                    }
                }
                if (!bl)
                {
                    break;
                }
            }
            if (bl)
            {
                return new NodeFour(grid[n0][m0] == 1, true);
            }
            var topleft = Dfs1(grid, n0, (n0 + n1) / 2, m0, (m0 + m1) / 2);
            var topright = Dfs1(grid, n0, (n0 + n1) / 2, (m0 + m1) / 2, m1);
            var bottomleft = Dfs1(grid, (n0 + n1) / 2, n1, m0, (m0 + m1) / 2);
            var bottomright = Dfs1(grid, (n0 + n1) / 2, n1, (m0 + m1) / 2, m1);

            NodeFour ret = new NodeFour(true, false,
                                topleft,
                                topright,
                                bottomleft,
                                bottomright);


            return ret;

        }

        public NodeFour Construct(int[][] grid)
        {
            int n = grid.Length;
            int[][] pre = new int[n + 1][];
            for (int i = 0; i <= n; ++i)
            {
                pre[i] = new int[n + 1];
            }
            for (int i = 1; i <= n; ++i)
            {
                for (int j = 1; j <= n; ++j)
                {
                    pre[i][j] = pre[i - 1][j] + pre[i][j - 1] - pre[i - 1][j - 1] + grid[i - 1][j - 1];
                }
            }

            NodeFour root = Dfs(grid, pre, 0, n, 0, n);
            return root;
        }
        private NodeFour Dfs(int[][] grid, int[][] pre, int n0, int n1, int m0, int m1)
        {
            int total = pre[n1][m1] - pre[n1][m0] - pre[n0][m1] + pre[n0][m0];

            if (total == 0)
            {
                return new NodeFour(false, true);
            }
            else if (total == (n1 - n0) * (m1 - m0))
            {
                return new NodeFour(true, true);
            }


            var topleft = Dfs(grid, pre, n0, (n0 + n1) / 2, m0, (m0 + m1) / 2);
            var topright = Dfs(grid, pre, n0, (n0 + n1) / 2, (m0 + m1) / 2, m1);
            var bottomleft = Dfs(grid, pre, (n0 + n1) / 2, n1, m0, (m0 + m1) / 2);
            var bottomright = Dfs(grid, pre, (n0 + n1) / 2, n1, (m0 + m1) / 2, m1);

            NodeFour ret = new NodeFour(true, false,
                                topleft,
                                topright,
                                bottomleft,
                                bottomright);


            return ret;

        }


        public int?[][] Build(NodeFour node)
        {
            List<int?[]> list = new List<int?[]>();

            Queue<NodeFour> queue = new Queue<NodeFour>();
            queue.Enqueue(node);
            while (queue.Count > 0)
            {
                int count = queue.Count;
                List<NodeFour> listNode = new List<NodeFour>();
                for (int i = 0; i < count; i++)
                {
                    var item = queue.Dequeue();
                    if (item == null)
                    {
                        list.Add(null);
                    }
                    else
                    {
                        int?[] arr = new int?[] { item.isLeaf ? 1 : 0, item.val ? 1 : 0 };
                        list.Add(arr);
                        listNode.Add(item.topLeft);
                        listNode.Add(item.topRight);
                        listNode.Add(item.bottomLeft);
                        listNode.Add(item.bottomRight);

                    }

                }
                while (listNode.Count > 0 && listNode[listNode.Count - 1] == null)
                {
                    listNode.RemoveAt(listNode.Count - 1);
                }
                foreach (var item in listNode)
                {
                    queue.Enqueue(item);
                }

            }

            return list.ToArray();
        }


    }
    public class NodeFour
    {
        public bool val;
        public bool isLeaf;
        public NodeFour topLeft;
        public NodeFour topRight;
        public NodeFour bottomLeft;
        public NodeFour bottomRight;

        public NodeFour()
        {
            val = false;
            isLeaf = false;
            topLeft = null;
            topRight = null;
            bottomLeft = null;
            bottomRight = null;
        }

        public NodeFour(bool _val, bool _isLeaf)
        {
            val = _val;
            isLeaf = _isLeaf;
            topLeft = null;
            topRight = null;
            bottomLeft = null;
            bottomRight = null;
        }

        public NodeFour(bool _val, bool _isLeaf, NodeFour _topLeft, NodeFour _topRight, NodeFour _bottomLeft, NodeFour _bottomRight)
        {
            val = _val;
            isLeaf = _isLeaf;
            topLeft = _topLeft;
            topRight = _topRight;
            bottomLeft = _bottomLeft;
            bottomRight = _bottomRight;
        }
    }
}
