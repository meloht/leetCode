using leetCode.Model.BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0651_0700
{
    public class _687_LongestUnivaluePathAlg
    {
        int ans = 0;
        public int LongestUnivaluePath(TreeNode root)
        {
            if (root == null)
                return 0;

            Dfs(root, root.val);

            return ans - 1;
        }
        public int Dfs(TreeNode root, int val)
        {
            if (root == null)
                return 0;
            if (root.val == val)
            {
                int len = 1;
                int left = Dfs(root.left, val);
                int right = Dfs(root.right, val);
                len += Math.Max(right, left);
                ans = Math.Max(left + right + 1, ans);
                ans = Math.Max(ans, len);
                return len;
            }
            else
            {
                int left = Dfs(root.left, root.val);
                int right = Dfs(root.right, root.val);
                ans = Math.Max(left + right + 1, ans);
                return 0;
            }
        }
    }
}
