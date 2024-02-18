using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using leetCode.Model.NTreeNode;

namespace leetCode._0401_0450
{
    public class _429_NAryTreeLevelOrderTraversalAlg
    {
        public IList<IList<int>> LevelOrder(Node root)
        {
            IList<IList<int>> list = new List<IList<int>>();
            if (root == null)
                return list;

            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                int count = queue.Count;
                List<int> ls=new List<int>();
                for (int i = 0; i < count; i++)
                {
                    var node = queue.Dequeue();
                    ls.Add(node.val);
                    foreach (Node n in node.children)
                    {
                        queue.Enqueue(n);
                    }
                   
                }
                list.Add(ls);
            }

            return list;
        }
    }

  
}
