using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0101_0150
{

    public class _133_CloneGraphAlg
    {
        public GraphNode CloneGraph(GraphNode node)
        {
            if (node == null)
                return null;
            List<GraphNode> list = new List<GraphNode>();
            Dictionary<int, int[]> dict = new Dictionary<int, int[]>();
            HashSet<int> set = new HashSet<int>();
            Queue<GraphNode> queue = new Queue<GraphNode>();
            queue.Enqueue(node);
            list.Add(node);
            set.Add(node.val);
            dict.Add(node.val, node.neighbors.Select(p => p.val).ToArray());
            while (queue.Count > 0)
            {
                int count = queue.Count;
                for (int i = 0; i < count; i++)
                {
                    var node11 = queue.Dequeue();
                    var ls = node11.neighbors;
                    foreach (var item in ls)
                    {
                        if (!set.Contains(item.val))
                        {
                            set.Add(item.val);
                            list.Add(item);
                            dict.Add(item.val, item.neighbors.Select(p => p.val).ToArray());
                            queue.Enqueue(item);
                        }
                    }
                }
            }
            set = null;
            queue = null;
            GraphNode root = null;
            Dictionary<int, GraphNode> dictNode = new Dictionary<int, GraphNode>();
            for (int i = 0; i < list.Count; i++)
            {
                GraphNode nodev = new GraphNode(list[i].val);
                dictNode.Add(nodev.val, nodev);
                if (i == 0)
                {
                    root = nodev;
                }
            }
            foreach (var item in dictNode)
            {
                var ls = dict[item.Key];
                List<GraphNode> nlist = new List<GraphNode>();
                foreach (var val in ls)
                {
                    nlist.Add(dictNode[val]);
                }
                item.Value.neighbors = nlist;
            }

            return root;
        }
    }
}
