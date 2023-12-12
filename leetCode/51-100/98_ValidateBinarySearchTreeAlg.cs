using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._51_100
{
    public class _98_ValidateBinarySearchTreeAlg
    {
        public bool IsValidBST(TreeNode root)
        {
            bool bl = MidTravel(root);
            return bl;
        }

        private bool MidTravel(TreeNode root)
        {
            if (root != null)
            {
                if (root.left != null)
                {
                    if (root.val <= root.left.val)
                        return false;

                    bool bl = MidTravel(root.left);
                    if (bl == false)
                        return false;
                }
                if (root.right != null)
                {
                    if (root.val >= root.right.val)
                        return false;

                    bool bl = MidTravel(root.right);
                    if (bl == false)
                        return false;
                }
            }
            return true;
        }
    }
}
