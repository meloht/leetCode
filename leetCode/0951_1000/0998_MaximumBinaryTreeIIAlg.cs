using leetCode.Model.BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0951_1000
{
    public class _0998_MaximumBinaryTreeIIAlg
    {
        public TreeNode InsertIntoMaxTree1(TreeNode root, int val)
        {
            List<int> list = new List<int>();
            Dfs(root, list);
            list.Add(val);

            return ConstructMaximumBinaryTree(list.ToArray());
        }
        public TreeNode InsertIntoMaxTree(TreeNode root, int val)
        {
            if (root == null || root.val < val)
            {
                return new TreeNode(val, root, null);
            }
            root.right = InsertIntoMaxTree(root.right, val);
            return root;
        }
        public TreeNode InsertIntoMaxTree2(TreeNode root, int val)
        {
            TreeNode parent = null;
            TreeNode cur = root;
            while (cur != null)
            {
                if (val > cur.val)
                {
                    if (parent == null)
                    {
                        return new TreeNode(val, root, null);
                    }
                    TreeNode node = new TreeNode(val, cur, null);
                    parent.right = node;
                    return root;
                }
                else
                {
                    parent = cur;
                    cur = cur.right;
                }
            }
            parent.right = new TreeNode(val);
            return root;
        }


        private void Dfs(TreeNode root, List<int> ls)
        {
            if (root == null)
                return;
            Dfs(root.left, ls);
            ls.Add(root.val);
            Dfs(root.right, ls);
        }

        public TreeNode ConstructMaximumBinaryTree(int[] nums)
        {
            int n = nums.Length;
            IList<int> stack = new List<int>();
            TreeNode[] tree = new TreeNode[n];
            for (int i = 0; i < n; ++i)
            {
                tree[i] = new TreeNode(nums[i]);
                while (stack.Count > 0 && nums[i] > nums[stack[stack.Count - 1]])
                {
                    tree[i].left = tree[stack[stack.Count - 1]];
                    stack.RemoveAt(stack.Count - 1);
                }
                if (stack.Count > 0)
                {
                    tree[stack[stack.Count - 1]].right = tree[i];
                }
                stack.Add(i);
            }
            return tree[stack[0]];
        }


    }

}
