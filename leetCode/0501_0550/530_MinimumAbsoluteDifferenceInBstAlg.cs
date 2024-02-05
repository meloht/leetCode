using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0501_0550
{
    public class _530_MinimumAbsoluteDifferenceInBstAlg
    {
       
        public int GetMinimumDifference(TreeNode root)
        {
            int min = int.MaxValue;
            List<int> list = new List<int>();
            Dfs(root, list);
            for (int i = 1; i < list.Count; i++)
            {
                int prev = list[i - 1];
                int curr = list[i];
                min = Math.Min(min, curr - prev);
            }
            return min;
        }

        private void Dfs(TreeNode root, List<int> list)
        {
            if (root == null)
                return;
            Dfs(root.left, list);
            list.Add(root.val);
            Dfs(root.right, list);

        }

        public int min = int.MaxValue;
        TreeNode prev;

        public int MinDiffInBST(TreeNode root)
        {
            Inorder(root);
            return min;
        }

        void Inorder(TreeNode root)
        {
            if (root == null) return;

            Inorder(root.left);
            if (prev != null) min = Math.Min(min, root.val - prev.val);
            prev = root;

            Inorder(root.right);
        }
    }
}
