using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._101_150
{
    public class _105_ConstructBinaryTreeFromPreorderAndInorderTraversalAlg
    {
        public TreeNode BuildTree1(int[] preorder, int[] inorder)
        {
            TreeNode root = new TreeNode(preorder[0]);
            var preList = preorder.ToList();
            preList.Remove(preorder[0]);
            var inorderList = inorder.ToList();

            BuildTree(preList, inorderList, root);

            return root;
        }
        private void BuildTree(List<int> preorder, List<int> inorder, TreeNode parent)
        {
            if (preorder.Count == 0)
                return;
            var res = GetLeftRightList(parent.val, inorder);

            var leftTreeList = res.Item1;
            var rightTreeList = res.Item2;

            var preLeft = GetPreLeftList(preorder, leftTreeList.Count);
            var preRight = GetPreRightList(preorder, leftTreeList.Count);

            if (leftTreeList.Count > 0)
            {
                int leftVal = preLeft[0];
                TreeNode left = new TreeNode(leftVal);

                parent.left = left;
                preLeft.RemoveAt(0);

                BuildTree(preLeft, leftTreeList, left);
            }
            if (rightTreeList.Count > 0 && preRight.Count > 0)
            {
                int rightVal = preRight[0];
                TreeNode right = new TreeNode(rightVal);
                parent.right = right;
                preRight.RemoveAt(0);
                BuildTree(preRight, rightTreeList, right);
            }
        }

        private Tuple<List<int>, List<int>> GetLeftRightList(int rootVal, List<int> inorder)
        {
            var leftTreeList = new List<int>();
            var rightTreeList = new List<int>();
            bool blLeft = true;
            for (int i = 0; i < inorder.Count; i++)
            {
                if (blLeft)
                {
                    if (inorder[i] == rootVal)
                    {
                        blLeft = false;
                    }
                    else
                    {
                        leftTreeList.Add(inorder[i]);
                    }
                }
                else
                {
                    rightTreeList.Add(inorder[i]);
                }
            }

            return new Tuple<List<int>, List<int>>(leftTreeList, rightTreeList);
        }

        private List<int> GetPreLeftList(List<int> preorder, int leftCount)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < leftCount; i++)
            {
                list.Add(preorder[i]);
            }

            return list;
        }
        private List<int> GetPreRightList(List<int> preorder, int leftCount)
        {
            List<int> list = new List<int>();
            for (int i = leftCount; i < preorder.Count; i++)
            {
                list.Add(preorder[i]);
            }

            return list;
        }

        private Dictionary<int, int> dict;
        public TreeNode BuildTree(int[] preorder, int[] inorder)
        {
            int n = preorder.Length;
            dict = new Dictionary<int, int>();
            for (int i = 0; i < n; i++)
            {
                dict.Add(inorder[i], i);
            }
            return myBuildTree(preorder, inorder, 0, n - 1, 0, n - 1);

        }
        public TreeNode myBuildTree(int[] preorder, int[] inorder, int preorder_left, int preorder_right, int inorder_left, int inorder_right)
        {
            if (preorder_left > preorder_right)
            {
                return null;
            }

            // 前序遍历中的第一个节点就是根节点
            int preorder_root = preorder_left;
            // 在中序遍历中定位根节点
            int inorder_root = dict[preorder[preorder_root]];

            // 先把根节点建立出来
            TreeNode root = new TreeNode(preorder[preorder_root]);
            // 得到左子树中的节点数目
            int size_left_subtree = inorder_root - inorder_left;
            // 递归地构造左子树，并连接到根节点
            // 先序遍历中「从 左边界+1 开始的 size_left_subtree」个元素就对应了中序遍历中「从 左边界 开始到 根节点定位-1」的元素
            root.left = myBuildTree(preorder, inorder, preorder_left + 1, preorder_left + size_left_subtree, inorder_left, inorder_root - 1);
            // 递归地构造右子树，并连接到根节点
            // 先序遍历中「从 左边界+1+左子树节点数目 开始到 右边界」的元素就对应了中序遍历中「从 根节点定位+1 到 右边界」的元素
            root.right = myBuildTree(preorder, inorder, preorder_left + size_left_subtree + 1, preorder_right, inorder_root + 1, inorder_right);
            return root;
        }

    }
}
