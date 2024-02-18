using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using leetCode.Model.BinaryTree;

namespace leetCode._0101_0150
{
    public class _113_PathSumIIAlg
    {
        List<IList<int>> res = new List<IList<int>>();

        public IList<IList<int>> PathSum(TreeNode root, int targetSum)
        {
            List<int> list = new List<int>();
            Dfs(root, targetSum, list);
            return res;
        }

        private void Dfs(TreeNode root, int targetSum, List<int> list)
        {
            if (root == null)
            {
                return;
            }
            targetSum -= root.val;

            list.Add(root.val);
            if (root.right == null && root.left == null)
            {
                if (targetSum == 0)
                {
                    res.Add(list.ToArray());
                }
            }
            if (root.left != null)
            {
                Dfs(root.left, targetSum, list);
            }

            if (root.right != null)
            {
                Dfs(root.right, targetSum, list);
            }
            list.RemoveAt(list.Count - 1);
        }
    }
}
