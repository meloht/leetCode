using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0101_0150
{
    public class _117_PopulatingNextRightPointersInEachNodeIIAlg
    {
        public Node Connect1(Node root)
        {
            if (root == null)
                return root;

            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                int count = queue.Count;
                Node pre = null;
                for (int i = 0; i < count; i++)
                {
                    var node = queue.Dequeue();

                    if (node.left != null && node.right != null)
                    {
                        if (pre != null)
                        {
                            pre.next = node.left;
                        }
                        node.left.next = node.right;
                        queue.Enqueue(node.left);
                        queue.Enqueue(node.right);
                        pre = node.right;
                    }
                    else if (node.left == null && node.right != null)
                    {
                        if (pre != null)
                        {
                            pre.next = node.right;
                        }
                        queue.Enqueue(node.right);
                        pre = node.right;
                    }
                    else if (node.left != null && node.right == null)
                    {
                        if (pre != null)
                        {
                            pre.next = node.left;
                        }
                        queue.Enqueue(node.left);
                        pre = node.left;
                    }
                }
            }
            return root;
        }
        public Node Connect2(Node root)
        {
            if (root == null)
            {
                return root;
            }

            if (root.right != null && root.left != null)
            {
                root.left.next = root.right;
                var next = GetNext(root.next);
                if (next != null)
                {
                    if (next.left != null)
                    {
                        root.right.next = next.left;
                    }
                    else if (next.right != null)
                    {
                        root.right.next = next.right;
                    }
                }
                Connect(root.right);
                Connect(root.left);
            }
            else if (root.right != null && root.left == null)
            {
                var next = GetNext(root.next);
                if (next != null)
                {
                    if (next.left != null)
                    {
                        root.right.next = next.left;
                    }
                    else if (next.right != null)
                    {
                        root.right.next = next.right;
                    }
                }
                Connect(root.right);
            }
            else if (root.right == null && root.left != null)
            {
                var next = GetNext(root.next);
                if (next != null)
                {
                    if (next.left != null)
                    {
                        root.left.next = next.left;
                    }
                    else if (next.right != null)
                    {
                        root.left.next = next.right;
                    }
                }
                Connect(root.left);
            }

            return root;
        }

        private Node GetNext(Node node)
        {
            if (node == null)
            {
                return null;
            }
            var temp = node;
            while (temp != null && temp.right == null && temp.left == null)
            {
                temp = temp.next;

            }
            return temp;
        }




        Node last = null, nextStart = null;

        public Node Connect(Node root)
        {
            if (root == null)
            {
                return null;
            }
            Node start = root;
            while (start != null)
            {
                last = null;
                nextStart = null;
                for (Node p = start; p != null; p = p.next)
                {
                    if (p.left != null)
                    {
                        Handle(p.left);
                    }
                    if (p.right != null)
                    {
                        Handle(p.right);
                    }
                }
                start = nextStart;
            }
            return root;
        }

        public void Handle(Node p)
        {
            if (last != null)
            {
                last.next = p;
            }
            if (nextStart == null)
            {
                nextStart = p;
            }
            last = p;
        }

    }
}
