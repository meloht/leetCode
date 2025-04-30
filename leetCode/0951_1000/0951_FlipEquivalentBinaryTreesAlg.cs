using leetCode.Model.BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0951_1000
{
    public class _0951_FlipEquivalentBinaryTreesAlg
    {
        public bool FlipEquiv(TreeNode root1, TreeNode root2)
        {

            if (root1 == null && root2 == null)
            {
                return true;
            }
            else if (root1 != null && root2 != null)
            {
                if (root1.val != root2.val)
                    return false;

                return (FlipEquiv(root1.left, root2.left) && FlipEquiv(root1.right, root2.right))
                    || (FlipEquiv(root1.left, root2.right) && FlipEquiv(root1.right, root2.left));
            }

            return false;
        }


    }
}
