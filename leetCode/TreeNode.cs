using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }

        public override string ToString() 
        {
            return $"{val}";
        }

        public IList<int?> PreTraversal()
        {
            List<int?> result = new List<int?>();
            PreOrder(this, result);
            return result;
        }
        private void PreOrder(TreeNode root, List<int?> result)
        {
            if (root != null)
            {
                result.Add(root.val);
                if (root.left != null)
                {
                    PreOrder(root.left, result);
                }
                else
                {
                    result.Add(null);
                }
                if (root.right != null)
                {
                    PreOrder(root.right, result);
                }
                else
                {
                    result.Add(null);
                }
            }
        }
    }
}
