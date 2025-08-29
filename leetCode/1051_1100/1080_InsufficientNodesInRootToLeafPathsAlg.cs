using leetCode.Model.BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1051_1100
{
    public class _1080_InsufficientNodesInRootToLeafPathsAlg
    {
        public TreeNode SufficientSubset(TreeNode root, int limit)
        {
            bool ans = Dfs(root, limit, 0);
            if (!ans) 
            {
                return null;
            }
            return root;
        }

        private bool Dfs(TreeNode root, int limit, int val)
        {
            if (root == null)
            {
                return false;
            }
            if (root.left == null && root.right == null)
            {
                if (val + root.val >= limit)
                    return true;
                return false;
            }

            bool left = Dfs(root.left, limit, val + root.val);
            if (!left)
            {
                root.left = null;
            }
            bool right = Dfs(root.right, limit, val + root.val);
            if (!right)
            {
                root.right = null;
            }
            return right || left;
        }
    }
}
