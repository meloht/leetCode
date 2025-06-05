using leetCode.Model.BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1001_1050
{
    public class _1008_ConstructBinarySearchTreeFromPreorderTraversalAlg
    {
        public TreeNode BstFromPreorder(int[] preorder)
        {
            int[] order = new int[preorder.Length];
            Array.Copy(preorder, order, order.Length);
            Array.Sort(order);

            return BuildTree(preorder, order);
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


        private int index = 0;
        private int[] preorder;
        private int len;

        /**
         * 深度优先遍历，遍历的时候把左右边界的值传下去
         *
         * @param preorder
         * @return
         */
        public TreeNode BstFromPreorder1(int[] preorder)
        {
            this.preorder = preorder;
            this.len = preorder.Length;
            return dfs(int.MinValue, int.MaxValue);
        }

        /**
         * 通过下限和上限来控制指针移动的范围
         *
         * @param lowerBound
         * @param upperBound
         * @return
         */
        private TreeNode dfs(int lowerBound, int upperBound)
        {
            // 所有的元素都已经添加到了二叉树中
            if (index == len)
            {
                return null;
            }

            int cur = preorder[index];
            if (cur < lowerBound || cur > upperBound)
            {
                return null;
            }

            index++;
            TreeNode root = new TreeNode(cur);
            root.left = dfs(lowerBound, cur);
            root.right = dfs(cur, upperBound);
            return root;
        }

    }
}
