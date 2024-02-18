using leetCode.Model.BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode.Model.ThreeTreeNode
{
    public class Node
    {
        public int val;
        public Node left;
        public Node right;
        public Node next;

        public Node() { }

        public Node(int _val)
        {
            val = _val;
        }

        public Node(int _val, Node _left, Node _right, Node _next)
        {
            val = _val;
            left = _left;
            right = _right;
            next = _next;
        }

        public override string ToString()
        {
            return val.ToString();
        }

        public static int?[] GetNodeList(Node root)
        {
            List<int?> list = new List<int?>();
            if (root == null)
                return list.ToArray();

            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                int count = queue.Count;
                for (int i = 0; i < count; i++)
                {
                    var node = queue.Dequeue();
                    list.Add(node.val);
                    if (node.next == null)
                    {
                        list.Add(null);
                    }
                    if (node.left != null)
                    {
                        queue.Enqueue(node.left);
                    }
                    if (node.right != null)
                    {
                        queue.Enqueue(node.right);
                    }
                }
            }

            return list.ToArray();
        }


        /// <summary>
        /// 按照数组顺序构建树
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static Node BuildNodeTree(int?[] arr)
        {
            if (arr.Length == 0)
                return null;
            Queue<Node> queue = new Queue<Node>();
            Node root = new Node(arr[0].Value);
            queue.Enqueue(root);

            var list = arr.ToList();
            list.RemoveAt(0);
            while (queue.Count > 0)
            {
                if (list.Count == 0)
                    break;

                int count = queue.Count;
                for (int i = 0; i < count; i++)
                {
                    var node = queue.Dequeue();
                    if (list.Count > 0)
                    {
                        if (list[0] != null)
                        {
                            Node left = new Node(list[0].Value);

                            node.left = left;
                            queue.Enqueue(left);
                        }
                        list.RemoveAt(0);

                    }
                    if (list.Count > 0)
                    {
                        if (list[0] != null)
                        {
                            Node right = new Node(list[0].Value);

                            node.right = right;
                            queue.Enqueue(right);
                        }
                        list.RemoveAt(0);

                    }
                }


            }
            return root;
        }

    }
}
