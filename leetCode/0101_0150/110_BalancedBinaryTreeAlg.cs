using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using leetCode.Model.BinaryTree;

namespace leetCode._101_150
{
    public class _110_BalancedBinaryTreeAlg
    {
        public bool IsBalanced(TreeNode root)
        {
            var res = GetMax(root, 0);
            return res.Item2;
        }

        private Tuple<int, bool> GetMax(TreeNode root, int num)
        {
            if (root == null)
                return new Tuple<int, bool>(num, true);
            num++;
            var left = GetMax(root.left, num);

            if (left.Item2 == false)
            {
                return left;
            }
            var right = GetMax(root.right, num);
            if (right.Item2 == false)
            {
                return right;
            }

            int mm = Math.Max(left.Item1, right.Item1);

            if (Math.Abs(left.Item1 - right.Item1) > 1)
                return new Tuple<int, bool>(mm, false);
            return new Tuple<int, bool>(mm, true);
        }
    }
}
