using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode.Model.NTreeNode
{
    public class Node
    {
        public int val;
        public IList<Node> children;

        public Node() { }

        public Node(int _val)
        {
            val = _val;
        }

        public Node(int _val, IList<Node> _children)
        {
            val = _val;
            children = _children;
        }

        public static Node Build(int?[] arr)
        {
            Node root = new Node(arr[0].Value);
            List<int[]> list = new List<int[]>();
            List<int> ls = new List<int>();
            for (int i = 2; i < arr.Length; i++)
            {
                if (arr[i] == null)
                {
                    list.Add(ls.ToArray());
                    ls.Clear();
                }
                else
                {
                    ls.Add(arr[i].Value);
                }
            }
            if (ls.Count > 0)
            {
                list.Add(ls.ToArray());
            }
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);
            int level = 0;
            while (queue.Count > 0)
            {
                int count = queue.Count;
                for (int i = 0; i < count; i++)
                {
                    Node node = queue.Dequeue();
                    node.children = new List<Node>();
                    if (level < list.Count)
                    {
                        var childs = list[level];
                        foreach (int item in childs)
                        {
                            Node nn = new Node(item);
                            node.children.Add(nn);
                            queue.Enqueue(nn);
                        }
                    }

                    level++;
                }


            }

            return root;

        }
    }
}
