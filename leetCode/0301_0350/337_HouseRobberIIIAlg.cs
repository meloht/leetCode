using leetCode.Model.BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0301_0350
{
    public class _337_HouseRobberIIIAlg
    {
        public int Rob(TreeNode root)
        {
            var res = Dfs(root);
            return Math.Max(res.noRob, res.rob);
        }
        private (int rob, int noRob) Dfs(TreeNode root)
        {
            if (root == null)
            {
                return (0, 0);
            }
            var left = Dfs(root.left);
            var right = Dfs(root.right);
            int rob = left.noRob + right.noRob + root.val;
            int noRob = Math.Max(left.rob, left.noRob) + Math.Max(right.rob, right.noRob);
            return (rob, noRob);
        }
    }
}
