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

        public TreeNode ConstructMaximumBinaryTree1(int[] nums)
        {
            int n = nums.Length;
            Stack<int> stack = new Stack<int>();
            int[] left = new int[n];
            int[] right = new int[n];
            Array.Fill(left, -1);
            Array.Fill(right, -1);
            TreeNode[] tree = new TreeNode[n];
            for (int i = 0; i < n; ++i)
            {
                tree[i] = new TreeNode(nums[i]);
                while (stack.Count > 0 && nums[i] > nums[stack.Peek()])
                {
                    right[stack.Pop()] = i;
                }
                if (stack.Count > 0)
                {
                    left[i] = stack.Peek();
                }
                stack.Push(i);
            }

            TreeNode root = null;
            for (int i = 0; i < n; ++i)
            {
                if (left[i] == -1 && right[i] == -1)
                {
                    root = tree[i];
                }
                else if (right[i] == -1 || (left[i] != -1 && nums[left[i]] < nums[right[i]]))
                {
                    tree[left[i]].right = tree[i];
                }
                else
                {
                    tree[right[i]].left = tree[i];
                }
            }
            return root;
        }


    }
}
