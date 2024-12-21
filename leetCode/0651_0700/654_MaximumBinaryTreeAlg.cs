using leetCode.Model.BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0651_0700
{
    public class _654_MaximumBinaryTreeAlg
    {
        public TreeNode ConstructMaximumBinaryTree(int[] nums)
        {
            int[] arr = GetMax(nums, 0, nums.Length - 1);

            TreeNode root = new TreeNode(arr[0]);

            Dfs(root, nums, 0, arr[1], nums.Length - 1);
            return root;
        }

        private void Dfs(TreeNode root, int[] nums, int left, int mid, int right)
        {
            int[] maxL = GetMax(nums, left, mid - 1);
            if (maxL != null)
            {
                TreeNode leftNode = new TreeNode(maxL[0]);
                root.left = leftNode;
                Dfs(leftNode, nums, left, maxL[1], mid - 1);
            }

            int[] maxR = GetMax(nums, mid + 1, right);
            if (maxR != null)
            {
                TreeNode rightNode = new TreeNode(maxR[0]);
                root.right = rightNode;
                Dfs(rightNode, nums, mid + 1, maxR[1], right);
            }
        }
        private int[] GetMax(int[] nums, int left, int right)
        {
            if (left > right)
                return null;

            int max = -1;
            int idx = 0;
            for (int i = left; i <= right; i++)
            {
                if (max < nums[i])
                {
                    max = nums[i];
                    idx = i;
                }
            }
            return [max, idx];
        }
    }
}
