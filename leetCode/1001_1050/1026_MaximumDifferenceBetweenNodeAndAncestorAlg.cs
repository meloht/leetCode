using leetCode.Model.BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1001_1050
{
    public class _1026_MaximumDifferenceBetweenNodeAndAncestorAlg
    {
        int ans = int.MinValue;
        public int MaxAncestorDiff(TreeNode root)
        {
            Dfs(root, root.val, root.val);
            return ans;
        }

        private void Dfs(TreeNode root, int min, int max)
        {
            if (root == null)
                return;

            ans = Math.Max(ans, Math.Abs(max - root.val));
            ans = Math.Max(ans, Math.Abs(min - root.val));
            min = Math.Min(min, root.val);
            max = Math.Max(max, root.val);
            Dfs(root.left, min, max);
            Dfs(root.right, min, max);
        }
    }
}
