using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._51_100
{
    public class _94_BinaryTreeInorderTraversalAlg
    {
        public IList<int> InorderTraversal(TreeNode root)
        {
            List<int> result = new List<int>();
            MidOrder(root, result);
            return result;
        }
        private void MidOrder(TreeNode root, List<int> result)
        {
            if (root != null)
            {
                if (root.left != null)
                {
                    MidOrder(root.left, result);
                }
                result.Add(root.val);
                if (root.right != null)
                {
                    MidOrder(root.right, result);
                }
            }
        }
    }
}
