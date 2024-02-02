using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0601_0650
{
    public class _637_AverageOfLevelsInBinaryTreeAlg
    {
        public IList<double> AverageOfLevels(TreeNode root)
        {
            List<double> res=new List<double>();

            if(root==null)
                return res;

            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while(queue.Count > 0) 
            {
                int count = queue.Count;
                double avg = 0.0d;

                for (int i = 0; i < count; i++)
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
                    avg += node.val;
                }
                avg = Math.Round(avg / count, 5);
                res.Add(avg);
            }

            return res;
        }
    }
}
