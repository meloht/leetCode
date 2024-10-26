using leetCode.Model.BinaryTree;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0501_0550
{
    public class _538_ConvertBstToGreaterTreeAlg
    {
        int index = 0;
        public TreeNode ConvertBST(TreeNode root)
        {
            if (root == null)
                return root;
            List<int> list = new List<int>();
            Dfs(root, list);
            int[] arr = new int[list.Count];
            arr[arr.Length - 1] = list[arr.Length - 1];
            for (int i = arr.Length - 2; i >= 0; i--)
            {
                arr[i] = list[i] + arr[i + 1];
            }
            index = 0;
            DfsVal(root, arr);
            return root;
        }

        private void Dfs(TreeNode root, List<int> list)
        {
            if (root == null)
            {
                return;
            }
            Dfs(root.left, list);
            list.Add(root.val);
            Dfs(root.right, list);

        }

        private void DfsVal(TreeNode root, int[] arr)
        {
            if (root == null)
            {
                return;
            }
            DfsVal(root.left, arr);
            root.val = arr[index];
            index++;
           
            DfsVal(root.right, arr);

        }
    }
}
