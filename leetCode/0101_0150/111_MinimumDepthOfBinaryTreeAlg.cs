using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using leetCode.Model.BinaryTree;

namespace leetCode._0101_0150
{
    public class _111_MinimumDepthOfBinaryTreeAlg
    {
        public int MinDepth1(TreeNode root)
        {
            int mm = GetMin(root, 0);
            return mm;

        }

        private int GetMin(TreeNode root, int num)
        {
            if (root == null)
                return num;
            num++;
            if (root.left == null && root.right == null)
            {
                return num;
            }

            int left = GetMin(root.left, num);
            int right = GetMin(root.right, num);

            if (root.left != null && root.right == null)
            {
                return left;
            }
            else if (root.right != null && root.left == null)
            {
                return right;
            }
            else if (root.right != null && root.left != null)
            {
                int mm = Math.Min(left, right);
                return mm;
            }
          
            return num;
        }

        public int MinDepth(TreeNode root)
        {
            if (root == null)
                return 0;
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            int num = 0; 
            while (queue.Count > 0) 
            {
                int count = queue.Count;
                num++;
                for (int i = 0; i < count; i++)
                {
                    var node = queue.Dequeue();
                    if (node.right == null && node.left == null)
                    {
                        return num;
                    }
                    else
                    {
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
            }
            return num;
        }
    }
}
