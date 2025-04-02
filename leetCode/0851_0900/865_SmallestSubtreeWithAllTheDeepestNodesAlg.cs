using leetCode.Model.BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0851_0900
{
    public class _865_SmallestSubtreeWithAllTheDeepestNodesAlg
    {
        TreeNode ans = null;
        int deptMax = 0;
        public TreeNode SubtreeWithAllDeepest(TreeNode root)
        {
            ans = root;
            Dfs(root, 0);
            return ans;
        }

        private int Dfs(TreeNode root, int dept)
        {
            if (root == null)
                return dept - 1;
            if (dept > deptMax)
            {
                deptMax = dept;
                ans = root;
            }

            int l = Dfs(root.left, dept + 1);
            int r = Dfs(root.right, dept + 1);

            if (l == deptMax && r == deptMax)
            {
                ans = root;

            }

            return Math.Max(l, r);
        }
    }
}
