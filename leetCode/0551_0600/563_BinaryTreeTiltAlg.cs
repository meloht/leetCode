using leetCode.Model.BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0551_0600
{
    public class _563_BinaryTreeTiltAlg
    {
        public int FindTilt(TreeNode root)
        {
            var res = Dfs(root);
            return res.abs;
        }

        private (int abs, int sum) Dfs(TreeNode root)
        {
            if (root == null)
                return (0, 0);

            var left = Dfs(root.left);
            var right = Dfs(root.right);
            int absSum = left.abs + right.abs + Math.Abs(left.sum - right.sum);
            int sum = left.sum + right.sum + root.val;
            return (absSum, sum);
        }
    }
}
