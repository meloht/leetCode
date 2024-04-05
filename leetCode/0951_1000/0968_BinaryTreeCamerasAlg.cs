using leetCode.Model.BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0951_1000
{
    public class _0968_BinaryTreeCamerasAlg
    {
        public int MinCameraCover(TreeNode root)
        {
            var res = Dfs(root);
            long min = Math.Min(res.choose, res.byChild);
            return (int)min;
        }
        private (long choose, long byFather, long byChild) Dfs(TreeNode node)
        {
            if (node == null)
            {
                return (int.MaxValue / 2, 0, 0);
            }
            var left = Dfs(node.left);
            var right = Dfs(node.right);

            long l_choose = Math.Min(left.choose, left.byFather);
            l_choose = Math.Min(l_choose, left.byChild);

            long r_choose = Math.Min(right.choose, right.byFather);
            r_choose = Math.Min(r_choose, right.byChild);

            long choose = l_choose + r_choose + 1;

            long byFather = Math.Min(left.choose, left.byChild) + Math.Min(right.choose, right.byChild);
            long byChild = Math.Min(left.choose + right.byChild, left.byChild + right.choose);
            byChild = Math.Min(byChild, left.choose + right.choose);

            return (choose, byFather, byChild);

        }


    }
}
