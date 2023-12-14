using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._101_150
{
    public class _107_BinaryTreeLevelOrderTraversalIIAlg
    {
        public IList<IList<int>> LevelOrderBottom(TreeNode root)
        {
            List<IList<int>> res = new List<IList<int>>();
            if (root == null)
                return res;

            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                List<int> ls = new List<int>();
                int count = queue.Count;
                for (int i = 0; i < count; i++)
                {
                    var node = queue.Dequeue();
                    ls.Add(node.val);
                    if (node.left != null)
                    {
                        queue.Enqueue(node.left);
                    }
                    if (node.right != null)
                    {
                        queue.Enqueue(node.right);
                    }
                }
                res.Add(ls);
            }
            res.Reverse();

            return res;
        }
    }
}
