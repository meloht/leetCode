using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._51_100
{
    public class _100_SameTreeAlg
    {
        public bool IsSameTree1(TreeNode p, TreeNode q)
        {
            var a1 = PreTraversal(p);
            var a2 = PreTraversal(q);
            bool bl = a1.SequenceEqual(a2);
            return bl;
        }


        private IList<int?> PreTraversal(TreeNode root)
        {
            List<int?> result = new List<int?>();
            PreOrder(root, result);
            return result;
        }
        private void PreOrder(TreeNode root, List<int?> result)
        {
            if (root != null)
            {
                result.Add(root.val);
                if (root.left != null)
                {
                    PreOrder(root.left, result);
                }
                else
                {
                    result.Add(null);
                }
                if (root.right != null)
                {
                    PreOrder(root.right, result);
                }
                else
                {
                    result.Add(null);
                }
            }
        }

        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            if (p == null && q == null)
                return true;
            if (IsSame(p, q) == false)
                return false;
          

            return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
        }
        private bool IsSame(TreeNode p, TreeNode q)
        {
            if (p == null && q == null)
                return true;
            if (p == null || q == null)
                return false;

            if (q.val == p.val)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}

