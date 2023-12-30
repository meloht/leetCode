using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0151_0200
{
    public class _199_BinaryTreeRightSideViewAlg
    {
        int dep = 0;
        public IList<int> RightSideView(TreeNode root)
        {
            var res = new List<int>();

            if (root == null)
                return res;

            Dfs(root, res, 0);

            return res;
        }

        private void Dfs(TreeNode root, List<int> res, int depth)
        {
            if (root == null)
                return;
            depth++;
            if (depth > dep)
            {
                res.Add(root.val);
                dep = depth;
            }
            Dfs(root.right, res, depth);
            Dfs(root.left, res, depth);
        }
    }
}
