using leetCode.Model.BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0851_0900
{
    public class _897_IncreasingOrderSearchTreeAlg
    {
        TreeNode node;
        TreeNode root2;
        public TreeNode IncreasingBST(TreeNode root)
        {
            Dfs(root);
            return root2;
        }

        private void Dfs(TreeNode root)
        {
            if (root == null)
            {
                return;
            }
            Dfs(root.left);

            if (node == null)
            {
                node = new TreeNode(root.val);
                root2 = node;
            }
            else
            {
                node.right = new TreeNode(root.val);
                node = node.right;
            }
            Dfs(root.right);
        }
    }
}
