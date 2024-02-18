using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using leetCode.Model.BinaryTree;

namespace leetCode._101_150
{
    public class _109_ConvertSortedListToBinarySearchTreeAlg
    {
        public TreeNode SortedListToBST(ListNode head)
        {
            List<int> list = new List<int>();
            ListNode node = head;
            while (node != null)
            {
                list.Add(node.val);
                node = node.next;
            }
            var tree = BuildTree(list, 0, list.Count - 1);

            return tree;
        }
        private TreeNode BuildTree(List<int> nums, int left, int right)
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
