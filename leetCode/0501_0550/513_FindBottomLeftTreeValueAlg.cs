using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0501_0550
{
    public class _513_FindBottomLeftTreeValueAlg
    {
        public int FindBottomLeftValue(TreeNode root)
        {
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            TreeNode node = root;
            while (queue.Count > 0)
            {
                node = queue.Dequeue();
                if (node.right != null)
                {
                    queue.Enqueue(node.right);
                }
                if (node.left != null)
                {
                    queue.Enqueue(node.left);
                }
            }
            return node.val;
        }
    }
}
