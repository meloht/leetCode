using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using leetCode.Model.BinaryTree;

namespace leetCode._101_150
{
    public class _108_ConvertSortedArrayToBinarySearchTreeAlg
    {
        public TreeNode SortedArrayToBST(int[] nums)
        {
            var tree = BuildTree(nums, 0, nums.Length - 1);

            return tree;
        }
        private TreeNode BuildTree(int[] nums, int left, int right)
        {
            if (left > right)
            {
                return null;
            }
            int mid = (left + right) / 2;

            TreeNode root = new TreeNode(nums[mid]);

            root.left = BuildTree(nums, left, mid - 1);
            root.right = BuildTree(nums, mid + 1, right);
            return root;
        }
    }
}
