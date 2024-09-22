using leetCode.Model.BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0501_0550
{
    public class _515_FindLargestValueInEachTreeRowAlg
    {
        public IList<int> LargestValues(TreeNode root)
        {
            List<int> result = new List<int>();
            if (root == null)
                return result;
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                int count = queue.Count;
                int max = int.MinValue;
                for (int i = 0; i < count; i++)
                {
                    var node = queue.Dequeue();
                    max = Math.Max(max, node.val);
                    if (node.left != null)
                    {
                        queue.Enqueue(node.left);
                    }
                    if (node.right != null)
                    {
                        queue.Enqueue(node.right);
                    }


                }
                result.Add(max);
            }
            return result;
        }
    }
}
