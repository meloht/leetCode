using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._101_150
{
    public class _101_SymmetricTreeAlg
    {
       
        private List<int?> left=new List<int?>();
        private List<int?> right=new List<int?>();    

        public bool IsSymmetric(TreeNode root)
        {
            LeftTree(root.left);
            RightTree(root.right);
            if(left.SequenceEqual(right))
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
    }
}
