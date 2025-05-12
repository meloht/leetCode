using leetCode.Model.BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0951_1000
{
    public class _0958_CheckCompletenessOfABinaryTreeAlg
    {
        public bool IsCompleteTree(TreeNode root)
        {
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            bool bl = false;
            while (queue.Count > 0)
            {
                int count = queue.Count;
               
                for (int i = 0; i < count; i++)
                {
                    var node = queue.Dequeue();
                    var left = node.left;
                    var right = node.right;
                    if (bl && (left != null || right != null))
                    {
                        return false;
                    }
                    if (left != null && right != null)
                    {
                        queue.Enqueue(left);
                        queue.Enqueue(right);
                    }
                    else if (left != null && right == null)
                    {
                        queue.Enqueue(left);
                        bl = true;

                    }
                    else if (left == null && right != null)
                    {
                        return false;
                    }
                    else
                    {
                        bl = true;
                    }
                }
            }

            return true;
        }
    }
}
