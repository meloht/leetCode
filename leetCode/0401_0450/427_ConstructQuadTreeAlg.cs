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
        public Node Construct(int[][] grid)
        {
            int n = grid.Length;
            Node root = Dfs(grid, 0, n, 0, n);
            return root;
        }
        private Node Dfs(int[][] grid, int n0, int n1, int m0, int m1)
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
                return new Node(grid[n0][m0] == 1, true);
            }

            Node ret = new Node(
         true,
         false,
         Dfs(grid, n0, (n0 + n1) / 2, m0, (m0 + m1) / 2),
         Dfs(grid, n0, (n0 + n1) / 2, (m0 + m1) / 2, m1),
         Dfs(grid, (n0 + n1) / 2, n1, m0, (m0 + m1) / 2),
         Dfs(grid, (n0 + n1) / 2, n1, (m0 + m1) / 2, m1));


            return ret;

        }


        public int?[][] Build(Node node)
        {
            List<int?[]> list = new List<int?[]>();

            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(node);
            while (queue.Count > 0)
            {
                int count = queue.Count;
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
                        if (item.isLeaf == false)
                        {
                            queue.Enqueue(item.topLeft);
                            queue.Enqueue(item.topRight);
                            queue.Enqueue(item.bottomLeft);
                            queue.Enqueue(item.bottomRight);
                        }
                       
                    }

                }
            }

            return list.ToArray();
        }


    }
    public class Node
    {
        public bool val;
        public bool isLeaf;
        public Node topLeft;
        public Node topRight;
        public Node bottomLeft;
        public Node bottomRight;

        public Node()
        {
            val = false;
            isLeaf = false;
            topLeft = null;
            topRight = null;
            bottomLeft = null;
            bottomRight = null;
        }

        public Node(bool _val, bool _isLeaf)
        {
            val = _val;
            isLeaf = _isLeaf;
            topLeft = null;
            topRight = null;
            bottomLeft = null;
            bottomRight = null;
        }

        public Node(bool _val, bool _isLeaf, Node _topLeft, Node _topRight, Node _bottomLeft, Node _bottomRight)
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
