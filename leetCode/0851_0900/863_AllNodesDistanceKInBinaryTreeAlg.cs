using leetCode.Model.BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0851_0900
{
    public class _863_AllNodesDistanceKInBinaryTreeAlg
    {
        List<TreeNode> listNode = new List<TreeNode>();
        public IList<int> DistanceK(TreeNode root, TreeNode target, int k)
        {
            List<int> list = new List<int>();
            if (k == 0)
            {
                list.Add(target.val);
                return list;
            }

            Dfs(root, target, new List<TreeNode>(), k);
            var targetNode = listNode[0];
            HashSet<int> set = new HashSet<int>();
            foreach (var item in listNode)
            {
                set.Add(item.val);
            }

            DfsNode(targetNode.left, k - 1, list, set);
            DfsNode(targetNode.right, k - 1, list, set);

            for (int i = 1, j = 1; i < listNode.Count; i++, j++)
            {
                if (i == k)
                {
                    list.Add(listNode[i].val);
                }
                DfsNode(listNode[i].right, k - j - 1, list, set);
                DfsNode(listNode[i].left, k - j - 1, list, set);
            }

            return list;
        }

        private void DfsNode(TreeNode root, int k, List<int> list, HashSet<int> set)
        {
            if (root == null)
                return;
            if (set.Contains(root.val))
                return;
            if (k == 0)
            {
                list.Add(root.val);
                return;
            }
            DfsNode(root.left, k - 1, list, set);
            DfsNode(root.right, k - 1, list, set);

        }

        private void Dfs(TreeNode root, TreeNode target, List<TreeNode> listPrev, int k)
        {
            if (root == null)
            {
                return;
            }

            listPrev.Add(root);
            if (root.val == target.val)
            {
                for (int i = listPrev.Count - 1, j = k; i >= 0 && j >= 0; i--, j--)
                {
                    listNode.Add(listPrev[i]);
                }
                return;
            }
            Dfs(root.left, target, listPrev, k);
            Dfs(root.right, target, listPrev, k);
            listPrev.Remove(root);
        }

    }
}
