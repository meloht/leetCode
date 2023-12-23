using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode
{
    public class GraphNode
    {
        public int val;
        public IList<GraphNode> neighbors;

        public GraphNode()
        {
            val = 0;
            neighbors = new List<GraphNode>();
        }

        public GraphNode(int _val)
        {
            val = _val;
            neighbors = new List<GraphNode>();
        }

        public GraphNode(int _val, List<GraphNode> _neighbors)
        {
            val = _val;
            neighbors = _neighbors;
        }
        public override string ToString()
        {
            return val.ToString();
        }


        public static GraphNode Build(int[][] adjList)
        {
            if (adjList.Length == 0)
                return null;

            Dictionary<int, GraphNode> dict = new Dictionary<int, GraphNode>();
            for (int i = 0; i < adjList.Length; i++)
            {
                int val = i + 1;
                GraphNode node = new GraphNode(val);
                dict.Add(val, node);

            }

            for (int i = 0; i < adjList.Length; i++)
            {
                int val = i + 1;
                GraphNode node = dict[val];
                var list = adjList[i];
                List<GraphNode> ls = new List<GraphNode>();
                foreach (var item in list)
                {
                    var n = dict[item];
                    ls.Add(n);
                }
                node.neighbors = ls;

            }

            return dict[1];
        }

        public static int[][] GetList(GraphNode root)
        {
            List<int[]> res = new List<int[]>();
            if (root == null)
                return res.ToArray();
            HashSet<int> set = new HashSet<int>();
            Queue<GraphNode> queue = new Queue<GraphNode>();
            queue.Enqueue(root);

            set.Add(root.val);
            List<GraphNode> list = new List<GraphNode>();
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
