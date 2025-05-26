using leetCode.Model.BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0951_1000
{
    public class _0971_FlipBinaryTreeToMatchPreorderTraversalAlg
    {
        List<int> ans;
        int idx = 0;
        public IList<int> FlipMatchVoyage(TreeNode root, int[] voyage)
        {
            ans = new List<int>();
            idx = 0;
            if (Dfs(root, voyage))
            {
                return ans;
            }
            return [-1];
        }

        private bool Dfs(TreeNode root, int[] voyage)
        {
            if (root == null)
                return true;

            if (root.val != voyage[idx])
            {
                return false;
            }
            idx++;
            bool bl = Dfs(root.left, voyage);
            if (bl == false)
            {
                ans.Add(root.val);
                return Dfs(root.right, voyage) && Dfs(root.left, voyage);
            }
            else
            {
                bl = Dfs(root.right, voyage);
                if (bl == false)
                {
                    ans.Add(root.val);
                    return Dfs(root.right, voyage) && Dfs(root.left, voyage);
                }
                return bl;

            }
        }
    }
}
