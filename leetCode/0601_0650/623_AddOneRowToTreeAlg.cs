using leetCode.Model.BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0601_0650
{
    public class _623_AddOneRowToTreeAlg
    {
        public TreeNode AddOneRow(TreeNode root, int val, int depth)
        {
            if (depth == 1)
            {
                TreeNode node = new TreeNode(val);
                node.left = root;
                return node;
            }
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            int dep = 0;
            while (queue.Count > 0)
            {
                dep++;

                int cnt = queue.Count;
                for (int i = 0; i < cnt; i++)
                {
                    var node = queue.Dequeue();
                    if (node.left != null)
                    {
                        queue.Enqueue(node.left);
                    }
                    if (node.right != null)
                    {
                        queue.Enqueue(node.right);
                    }
                    if (dep == depth - 1)
                    {
                        TreeNode left = new TreeNode(val, node.left);
                        TreeNode right = new TreeNode(val, null, node.right);
                        node.left = left;
                        node.right = right;
                    }
                }
                if (dep == depth - 1)
                {
                    break;
                }
            }

            return root;
        }


    }
}
