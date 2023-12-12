using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._51_100
{
    public class _98_ValidateBinarySearchTreeAlg
    {
        private int rootVal = 0;
        List<int> leftNum = new List<int>();
        List<int> rightNum = new List<int>();
        public bool IsValidBST(TreeNode root)
        {
            rootVal = root.val;
            if (root.left != null)
            {
                bool bl = LeftTree(root.left);
                if (bl == false)
                    return false;

                List<int> list = new List<int>(leftNum);
                list.Sort();
                if (!list.SequenceEqual(leftNum))
                    return false;
            }
            if (root.right != null)
            {
                bool bl = RightTree(root.right);
                if (bl == false)
                    return false;

                List<int> list = new List<int>(rightNum);
                list.Sort();
                if (!list.SequenceEqual(rightNum))
                    return false;
            }
            return true;
        }


        private bool LeftTree(TreeNode root)
        {
            if (root == null)
                return true;

            if (rootVal <= root.val)
                return false;
            if (root.left != null)
            {
                if (root.val <= root.left.val)
                    return false;


                if (rootVal <= root.left.val)
                    return false;

                bool bl = LeftTree(root.left);
                if (bl == false)
                    return false;
            }
            leftNum.Add(root.val);
            if (root.right != null)
            {
                if (root.val >= root.right.val)
                    return false;


                if (rootVal <= root.right.val)
                    return false;

                bool bl = LeftTree(root.right);
                if (bl == false)
                    return false;
            }

            return true;
        }

        private bool RightTree(TreeNode root)
        {
            if (root == null)
                return true;

            if (rootVal >= root.val)
                return false;
            if (root.left != null)
            {
                if (root.val <= root.left.val)
                    return false;


                if (rootVal >= root.left.val)
                    return false;

                bool bl = RightTree(root.left);
                if (bl == false)
                    return false;
            }
            rightNum.Add(root.val);
            if (root.right != null)
            {
                if (root.val >= root.right.val)
                    return false;


                if (rootVal >= root.right.val)
                    return false;

                bool bl = RightTree(root.right);
                if (bl == false)
                    return false;
            }

            return true;
        }
    }
}
