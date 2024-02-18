using leetCode.Model.BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0201_0250
{
    public class _226_InvertBinaryTreeAlg
    {
        public TreeNode InvertTree(TreeNode root)
        {
            Dfs(root);
            return root;
        }
        private void Dfs(TreeNode root)
        {
            if (root == null)
                return;

            var left = root.left;
            root.left = root.right;
            root.right = left;

            Dfs(root.left);
            Dfs(root.right);
        }
        
    }
}
