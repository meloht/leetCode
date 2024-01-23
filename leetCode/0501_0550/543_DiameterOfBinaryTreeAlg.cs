using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0501_0550
{
    public class _543_DiameterOfBinaryTreeAlg
    {
        private int max = 0;
        public int DiameterOfBinaryTree(TreeNode root)
        {
            Dfs(root, -1);
            return max;
        }
        private int Dfs(TreeNode root, int depth)
        {
            if (root == null)
                return depth;
            depth++;
            max = Math.Max(max, depth);

            int left = Dfs(root.left, depth);
            int right = Dfs(root.right, depth);

            int n = left - depth + right - depth;
            max = Math.Max(max, n);
           
            return Math.Max(left,right);

        }
    }
}
