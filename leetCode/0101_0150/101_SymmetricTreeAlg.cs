using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using leetCode.Model.BinaryTree;

namespace leetCode._101_150
{
    public class _101_SymmetricTreeAlg
    {

        private List<int?> left = new List<int?>();
        private List<int?> right = new List<int?>();

        public bool IsSymmetric1(TreeNode root)
        {
            LeftTree(root.left);
            RightTree(root.right);
            if (left.SequenceEqual(right))
                return true;
            return false;
        }
        private void LeftTree(TreeNode root)
        {
            if (root == null)
            {
                left.Add(null);
                return;
            }

            left.Add(root.val);
            LeftTree(root.left);
            LeftTree(root.right);
        }

        private void RightTree(TreeNode root)
        {
            if (root == null)
            {
                right.Add(null);
                return;
            }
            right.Add(root.val);
            RightTree(root.right);
            RightTree(root.left);
        }


        public bool IsSymmetric(TreeNode root)
        {
            return IsSameTree(root.left,root.right);
        }

        private bool IsSameTree(TreeNode root1, TreeNode root2)
        {
            if (IsSameNode(root1, root2))
            {
                if (root1 != null && root2 != null)
                {
                    return IsSameTree(root1.left, root2.right) && IsSameTree(root1.right, root2.left);
                }
                return true;
            }
            return false;
        }

        private bool IsSameNode(TreeNode root1, TreeNode root2)
        {
            if (root1 == null && root2 == null)
            {
                return true;
            }
            if (root1 != null && root2 != null && root1.val == root2.val)
            {
                return true;
            }
            return false;
        }
    }
}
