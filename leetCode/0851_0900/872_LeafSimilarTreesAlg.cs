using leetCode.Model.BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0851_0900
{
    public class _872_LeafSimilarTreesAlg
    {
        public bool LeafSimilar(TreeNode root1, TreeNode root2)
        {
            List<int> list = new List<int>();
            Dfs(root1, list);

            List<int> list2 = new List<int>();
            Dfs(root2, list2);
            return list2.SequenceEqual(list);
        }
        private void Dfs(TreeNode root1, List<int> list)
        {
            if (root1 == null)
                return;
            if (root1.left == null && root1.right == null)
            {
                list.Add(root1.val);
            }
            Dfs(root1.left, list);
            Dfs(root1.right, list);

        }

       
    }
}
