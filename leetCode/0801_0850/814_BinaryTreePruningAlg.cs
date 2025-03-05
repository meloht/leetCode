using leetCode.Model.BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0801_0850
{
    public class _814_BinaryTreePruningAlg
    {
        public TreeNode PruneTree(TreeNode root)
        {
            if (Dfs(root)) 
            {
                return null;
            }
            return root;
        }


        private bool Dfs(TreeNode node) 
        {
            if (node == null)
                return true;
            bool left = Dfs(node.left);
            bool right = Dfs(node.right);
            if (left)
            {
                node.left = null;
            }
            if (right)
            {
                node.right = null;
            }
            if (left && right)
            {
                if (node.val == 0)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
