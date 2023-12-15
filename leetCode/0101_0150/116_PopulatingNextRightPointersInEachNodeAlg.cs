using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace leetCode._0101_0150
{
    public class _116_PopulatingNextRightPointersInEachNodeAlg
    {
        public Node Connect(Node root)
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
                }
            }
            return root;
        }
    }
}
