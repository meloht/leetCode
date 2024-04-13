using leetCode.Model.BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0651_0700
{
    public class _671_SecondMinimumNodeInABinaryTreeAlg
    {
        public int FindSecondMinimumValue(TreeNode root)
        {
            int ans = Dfs(root, root.val);

            return ans;
        }
        private int Dfs(TreeNode root, int val)
        {
            if (root == null)
                return -1;
            if (root.val != val)
            {
                return root.val;
            }
            int left = Dfs(root.left, val);
            int right = Dfs(root.right, val);
            if (left != -1 && right != -1)
            {
                return Math.Min(left, right);
            }
            else if (right != -1)
            {
                return right;
            }
            else if (left != -1)
            {
                return left;
            }
            return -1;
        }
    }
}
