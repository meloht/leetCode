using leetCode.Model.BinaryTree;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace leetCode._0851_0900
{
    public class _889_ConstructBinaryTreeFromPreorderAndPostorderTraversalAlg
    {

        public TreeNode ConstructFromPrePost(int[] preorder, int[] postorder)
        {
            int n = preorder.Length;
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < postorder.Length; i++)
            {
                dict.Add(postorder[i], i);
            }
            TreeNode root = Dfs(preorder, postorder, dict, 0, n - 1, 0, n - 1);

            return root;
        }

        private TreeNode Dfs(int[] preorder, int[] postorder, Dictionary<int, int> dict, int preLeft, int preRight, int postLeft, int postRight)
        {
            if (preLeft > preRight)
                return null;
            int leftCount = 0;
            if (preLeft < preRight)
            {
                leftCount = dict[preorder[preLeft + 1]] - postLeft + 1;
            }

            TreeNode root = new TreeNode(preorder[preLeft]);
            root.left = Dfs(preorder, postorder, dict, preLeft + 1, preLeft + leftCount, postLeft, postLeft + leftCount - 1);
            root.right = Dfs(preorder, postorder, dict, preLeft + leftCount + 1, preRight, postLeft + leftCount, postRight - 1);

            return root;
        }



    }
}
