using leetCode.Model.BinaryTree;
using leetCode.Model.Graph;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0951_1000
{
    public class _0979_DistributeCoinsInBinaryTreeAlg
    {
        int ans = 0;
        public int DistributeCoins(TreeNode root)
        {
            Dfs(root);
            return ans;
        }
        private int Dfs(TreeNode root)
        {
            if (root == null)
                return 0;
            int d = Dfs(root.left) + Dfs(root.right) + root.val - 1;
            ans += Math.Abs(d);
            return d;
        }
    }
}
