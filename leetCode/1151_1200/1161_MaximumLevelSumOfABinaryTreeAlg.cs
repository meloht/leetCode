using leetCode.Model.BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1151_1200
{
    public class _1161_MaximumLevelSumOfABinaryTreeAlg
    {
        public int MaxLevelSum(TreeNode root)
        {
            int max = int.MinValue;
            int level = 1;
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            int idx = 1;
            while (queue.Count > 0)
            {
                int cnt = queue.Count;
                int sum = 0;
                for (int i = 0; i < cnt; i++)
                {
                    var node = queue.Dequeue();
                    sum += node.val;
                    if (node.right != null)
                    {
                        queue.Enqueue(node.right);
                    }
                    if (node.left != null)
                    {
                        queue.Enqueue(node.left);
                    }
                }
                if (sum > max)
                {
                    max = sum;
                    level = idx;
                }
                idx++;
            }

            return level;
        }
    }
}
