using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode.Model.Graph
{
    public class Node
    {
        public int val;
        public IList<Node> neighbors;

        public Node()
        {
            val = 0;
            neighbors = new List<Node>();
        }

        public Node(int _val)
        {
            val = _val;
            neighbors = new List<Node>();
        }

        public Node(int _val, List<Node> _neighbors)
        {
            val = _val;
            neighbors = _neighbors;
        }
        public override string ToString()
        {
            return val.ToString();
        }


        public static Node Build(int[][] adjList)
        {
            if (adjList.Length == 0)
                return null;

            Dictionary<int, Node> dict = new Dictionary<int, Node>();
            for (int i = 0; i < adjList.Length; i++)
            {
                int val = i + 1;
                Node node = new Node(val);
                dict.Add(val, node);

            }

            for (int i = 0; i < adjList.Length; i++)
            {
                int val = i + 1;
                Node node = dict[val];
                var list = adjList[i];
                List<Node> ls = new List<Node>();
                foreach (var item in list)
                {
                    var n = dict[item];
                    ls.Add(n);
                }
                node.neighbors = ls;

            }

            return dict[1];
        }

        public static int[][] GetList(Node root)
        {
            List<int[]> res = new List<int[]>();
            if (root == null)
                return res.ToArray();
            HashSet<int> set = new HashSet<int>();
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);

            set.Add(root.val);
            List<Node> list = new List<Node>();
            list.Add(root);
            while (queue.Count > 0)
            {
                int count = queue.Count;
                for (int i = 0; i < count; i++)
                {
                    var node = queue.Dequeue();
                    var ls = node.neighbors;
                    foreach (var item in ls)
                    {
                        if (!set.Contains(item.val))
                        {
                            set.Add(item.val);
                            list.Add(item);
                            queue.Enqueue(item);
                        }
                    }
                }
            }
            foreach (var item in list)
            {
                res.Add(item.neighbors.Select(p => p.val).ToArray());
            }
            return res.ToArray();
        }
    }
}
