using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._101_150
{
    public class _106_ConstructBinaryTreeFromInorderAndPostorderTraversalAlg
    {
        private Dictionary<int, int> dict;
        public TreeNode BuildTree(int[] inorder, int[] postorder)
        {
            int n = postorder.Length;
            dict = new Dictionary<int, int>();
            for (int i = 0; i < n; i++)
            {
                dict.Add(inorder[i], i);
            }
            return BuildTree(postorder, inorder, 0, n - 1, 0, n - 1);
        }

        private TreeNode BuildTree(int[] postorder, int[] inorder, int postOrderLeft, int postOrderRight, int inorderLeft, int inorderRight)
        {
            if (postOrderLeft > postOrderRight)
            {
                return null;
            }
            int postOrderRoot = postOrderRight;
            // 在中序遍历中定位根节点
            int inorderRoot = dict[postorder[postOrderRoot]];

            // 先把根节点建立出来
            TreeNode root = new TreeNode(postorder[postOrderRoot]);

            // 得到左子树中的节点数目
            int size_left_subtree = inorderRoot - inorderLeft;

            root.left = BuildTree(postorder, inorder, postOrderLeft, postOrderLeft + size_left_subtree - 1, inorderLeft, inorderRoot - 1);

            root.right = BuildTree(postorder, inorder, postOrderLeft + size_left_subtree, postOrderRight - 1, inorderRoot + 1, inorderRight);
            return root;
        }
    }
}
