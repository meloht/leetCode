using leetCode.Model.BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2551_2600
{
    public class _2583_KthLargestSumInABinaryTreeAlg
    {
        public long KthLargestLevelSum(TreeNode root, int k)
        {
            PriorityQueue<long, long> priorityQueue = new PriorityQueue<long, long>();
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                int count = queue.Count;
                long sum = 0;
                for (int i = 0; i < count; i++)
                {
                    var node = queue.Dequeue();
                    sum += node.val;
                    if (node.left != null)
                    {
                        queue.Enqueue(node.left);
                    }
                    if (node.right != null)
                    {
                        queue.Enqueue(node.right);
                    }
                }
                priorityQueue.Enqueue(sum, sum);
                if (priorityQueue.Count > k)
                {
                    priorityQueue.Dequeue();
                }
            }
            if (priorityQueue.Count < k)
                return -1;
            return priorityQueue.Dequeue();
        }
    }
}
