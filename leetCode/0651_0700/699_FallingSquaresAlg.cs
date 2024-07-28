using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0651_0700
{
    public class _699_FallingSquaresAlg
    {
        public IList<int> FallingSquares(int[][] positions)
        {
            List<int> ans = new List<int>();
            SegmentTree tree = new SegmentTree();
            int mx = 0;
            foreach (int[] p in positions)
            {
                int l = p[0], w = p[1], r = l + w - 1;
                int h = tree.query(l, r) + w;
                mx = Math.Max(mx, h);
                ans.Add(mx);
                tree.modify(l, r, h);
            }
            return ans;


        }
        class Node
        {
            public Node left;
            public Node right;
            public int l;
            public int r;
            public int mid;
            public int v;
            public int add;
            public Node(int l, int r)
            {
                this.l = l;
                this.r = r;
                this.mid = (l + r) >> 1;
            }
        }

        class SegmentTree
        {
            private Node root = new Node(1, (int)1e9);

            public SegmentTree()
            {
            }

            public void modify(int l, int r, int v)
            {
                modify(l, r, v, root);
            }

            public void modify(int l, int r, int v, Node node)
            {
                if (l > r)
                {
                    return;
                }
                if (node.l >= l && node.r <= r)
                {
                    node.v = v;
                    node.add = v;
                    return;
                }
                pushdown(node);
                if (l <= node.mid)
                {
                    modify(l, r, v, node.left);
                }
                if (r > node.mid)
                {
                    modify(l, r, v, node.right);
                }
                pushup(node);
            }

            public int query(int l, int r)
            {
                return query(l, r, root);
            }

            public int query(int l, int r, Node node)
            {
                if (l > r)
                {
                    return 0;
                }
                if (node.l >= l && node.r <= r)
                {
                    return node.v;
                }
                pushdown(node);
                int v = 0;
                if (l <= node.mid)
                {
                    v = Math.Max(v, query(l, r, node.left));
                }
                if (r > node.mid)
                {
                    v = Math.Max(v, query(l, r, node.right));
                }
                return v;
            }

            public void pushup(Node node)
            {
                node.v = Math.Max(node.left.v, node.right.v);
            }

            public void pushdown(Node node)
            {
                if (node.left == null)
                {
                    node.left = new Node(node.l, node.mid);
                }
                if (node.right == null)
                {
                    node.right = new Node(node.mid + 1, node.r);
                }
                if (node.add != 0)
                {
                    Node left = node.left, right = node.right;
                    left.add = node.add;
                    right.add = node.add;
                    left.v = node.add;
                    right.v = node.add;
                    node.add = 0;
                }
            }
        }
    }





}
