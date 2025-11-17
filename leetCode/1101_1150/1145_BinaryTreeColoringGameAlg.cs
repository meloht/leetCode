using leetCode.Model.BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1101_1150
{
    public class _1145_BinaryTreeColoringGameAlg
    {
        private int x, lsz, rsz;
        public bool BtreeGameWinningMove(TreeNode root, int n, int x)
        {
            this.x = x;
            dfs(root);
            return Math.Max(Math.Max(lsz, rsz), n - 1 - lsz - rsz) * 2 > n;

        }

        private int dfs(TreeNode node)
        {
            if (node == null)
                return 0;
            int ls = dfs(node.left);
            int rs = dfs(node.right);
            if (node.val == x)
            {
                lsz = ls;
                rsz = rs;
            }
            return ls + rs + 1;
        }


    }
}
