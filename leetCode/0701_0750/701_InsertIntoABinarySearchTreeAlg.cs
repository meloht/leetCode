using leetCode.Model.BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0701_0750
{
    public class _701_InsertIntoABinarySearchTreeAlg
    {
        public TreeNode InsertIntoBST(TreeNode root, int val)
        {
            if (root == null)
            {
                root = new TreeNode(val);
                return root;
            }
            Dfs(root, val);
            return root;
        }

        public void Dfs(TreeNode root, int val)
        {
            if (root == null)
                return;

            if (val > root.val)
            {
                if (root.right == null)
                {
                    root.right = new TreeNode(val);
                    return;
                }
                Dfs(root.right, val);
            }
            else
            {
                if (root.left == null)
                {
                    root.left = new TreeNode(val);
                    return;
                }
                Dfs(root.left, val);
            }
        }
    }
}
