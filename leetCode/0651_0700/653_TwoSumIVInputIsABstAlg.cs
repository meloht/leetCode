using leetCode.Model.BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0651_0700
{
    public class _653_TwoSumIVInputIsABstAlg
    {
        public bool FindTarget(TreeNode root, int k)
        {
            HashSet<int> set = new HashSet<int>();
            return Dfs(root, k, set);
        }

        private bool Dfs(TreeNode root, int k, HashSet<int> ls)
        {
            if (root == null)
            {
                return false;
            }
            bool l = Dfs(root.left, k, ls);
            if (l)
                return true;

            if (ls.Contains(k - root.val))
            {
                return true;
            }
            ls.Add(root.val);
            return Dfs(root.right, k, ls);

        }


    }
}
