using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode.Model.BinaryTree
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }

        public override string ToString()
        {
            return $"{val}";
        }

        /// <summary>
        /// 按照数组顺序构建二叉树
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static TreeNode BuildTree(int?[] arr)
        {
            if (arr.Length == 0)
                return null;
            Queue<TreeNode> queue = new Queue<TreeNode>();
            TreeNode root = new TreeNode(arr[0].Value);
            queue.Enqueue(root);

            var list = arr.ToList();
            list.RemoveAt(0);
            while (queue.Count > 0)
            {
                if (list.Count == 0)
                    break;
                var rootNode = queue.Dequeue();
                int? left = list[0];
                list.RemoveAt(0);
                if (left != null)
                {
                    rootNode.left = new TreeNode(left.Value);
                    queue.Enqueue(rootNode.left);
                }
                if (list.Count > 0)
                {
                    int? right = list[0];
                    list.RemoveAt(0);
                    if (right != null)
                    {
                        rootNode.right = new TreeNode(right.Value);
                        queue.Enqueue(rootNode.right);
                    }
                }
            }
            return root;
        }

        public static int[] GetTreeLevel(TreeNode root)
        {
            List<int> list = new List<int>();
            if (root == null)
                return list.ToArray();
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                int count = queue.Count;
                for (int i = 0; i < count; i++)
                {
                    var node = queue.Dequeue();
                    list.Add(node.val);
                    if (node.left != null)
                    {
                        queue.Enqueue(node.left);
                    }
                    if (node.right != null)
                    {
                        queue.Enqueue(node.right);
                    }
                }
            }
            return list.ToArray();
        }

        public static TreeNode GetTreeNodeByVal(int val, TreeNode node)
        {
            if (node == null)
                return null;
            if (node.val == val)
                return node;
            var left = GetTreeNodeByVal(val, node.left);
            if (left != null)
                return left;
            var right = GetTreeNodeByVal(val, node.right);
            if (right != null)
                return right;
            return null;
        }


        /// <summary>
        /// 分层遍历
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static int?[] GetTreeLevelList(TreeNode root)
        {
            List<int?> list = new List<int?>();
            if (root == null)
                return list.ToArray();

            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                int count = queue.Count;
                for (int i = 0; i < count; i++)
                {
                    var node = queue.Dequeue();
                    if (node != null)
                    {
                        list.Add(node.val);
                        queue.Enqueue(node.left);
                        queue.Enqueue(node.right);
                    }
                    else
                    {
                        list.Add(null);
                    }
                }

            }
            int index = list.Count - 1;
            while (index >= 0 && list[index] == null)
            {
                list.RemoveAt(index);
                index--;
            }
            return list.ToArray();

        }

        /// <summary>
        /// 先序遍历
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public static int?[][] GetTreeList(IList<TreeNode> list)
        {
            List<int?[]> arr = new List<int?[]>();
            foreach (TreeNode node in list)
            {
                arr.Add(PreTraversal(node).ToArray());
            }
            return arr.ToArray();
        }
        /// <summary>
        /// 先序遍历
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static int?[] GetTreeList(TreeNode root)
        {
            var arr = PreTraversal(root).ToArray();
            return arr;
        }
        private static IList<int?> PreTraversal(TreeNode root)
        {
            List<int?> result = new List<int?>();
            if (root != null)
            {
                result.Add(root.val);
                PreOrder(root, result);
            }

            int index = result.Count - 1;
            while (index >= 0 && result[index] == null)
            {
                result.RemoveAt(index);
                index--;
            }
            return result;
        }
        private static void PreOrder(TreeNode root, List<int?> result)
        {
            if (root != null)
            {
                if (root.left != null)
                {
                    result.Add(root.left.val);
                }
                else
                {
                    result.Add(null);
                }
                if (root.right != null)
                {
                    result.Add(root.right.val);
                }
                else
                {
                    result.Add(null);
                }
                PreOrder(root.left, result);
                PreOrder(root.right, result);
            }
        }
    }
}
