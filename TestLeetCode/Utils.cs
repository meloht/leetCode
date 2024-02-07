using leetCode;
using leetCode._51_100;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Utils
    {
        public static ListNode BuildListNode(int[] arr)
        {
            if (arr.Length == 0)
                return null;
            ListNode node = new ListNode(arr[0]);
            ListNode header = node;
            for (int i = 1; i < arr.Length; i++)
            {
                node.next = new ListNode(arr[i]);
                node = node.next;
            }

            return header;
        }

        public static int[] GetLinkNodeList(ListNode head)
        {
            List<int> list = new List<int>();
            ListNode node = head;
            while (node != null)
            {
                list.Add(node.val);
                node = node.next;
            }
            return list.ToArray();
        }

        public static ListNode BuildListNode(int[] arr, int pos)
        {
            if (arr.Length == 0)
                return null;
            ListNode node = new ListNode(arr[0]);
            ListNode header = node;
            Dictionary<int, ListNode> dict = new Dictionary<int, ListNode>();
            dict.Add(0, header);
            for (int i = 1; i < arr.Length; i++)
            {
                node.next = new ListNode(arr[i]);
                node = node.next;
                dict.Add(i, node);
            }
            if (pos != -1)
            {
                dict[arr.Length - 1].next = dict[pos];
            }

            return header;
        }

        /// <summary>
        /// 先序遍历构造
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static TreeNode BuildBinaryTree(int?[] arr)
        {
            BinaryTreeBuilder builder = new BinaryTreeBuilder();
            TreeNode root = builder.BuildTree(arr);
            return root;
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

        public static TreeNode BuildBSTTree(int?[] arr)
        {
            BinarySearchTree bst = new BinarySearchTree();
            bst.Insert(arr);
            return bst.root;
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
        /// 按照数组顺序构建二叉树
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static Node BuildNodeTree(int?[] arr)
        {
            if (arr.Length == 0)
                return null;
            Queue<Node> queue = new Queue<Node>();
            Node root = new Node(arr[0].Value);
            queue.Enqueue(root);

            var list = arr.ToList();
            list.RemoveAt(0);
            while (queue.Count > 0)
            {
                if (list.Count == 0)
                    break;

                int count = queue.Count;
                for (int i = 0; i < count; i++)
                {
                    var node = queue.Dequeue();
                    if (list.Count > 0)
                    {
                        if (list[0] != null)
                        {
                            Node left = new Node(list[0].Value);

                            node.left = left;
                            queue.Enqueue(left);
                        }
                        list.RemoveAt(0);

                    }
                    if (list.Count > 0)
                    {
                        if (list[0] != null)
                        {
                            Node right = new Node(list[0].Value);

                            node.right = right;
                            queue.Enqueue(right);
                        }
                        list.RemoveAt(0);

                    }
                }


            }
            return root;
        }

        public static int?[] GetNodeList(Node root)
        {
            List<int?> list = new List<int?>();
            if (root == null)
                return list.ToArray();

            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                int count = queue.Count;
                for (int i = 0; i < count; i++)
                {
                    var node = queue.Dequeue();
                    list.Add(node.val);
                    if (node.next == null)
                    {
                        list.Add(null);
                    }
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


        public static bool ListNodeSame(ListNode header, int[] arr)
        {
            List<int> list = new List<int>();
            ListNode node = header;
            while (node != null)
            {
                list.Add(node.val);
                node = node.next;
            }
            bool bl = arr.SequenceEqual(list.ToArray());
            return bl;
        }
        /// <summary>
        /// 排序后比较
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <param name="list2"></param>
        /// <returns></returns>
        public static bool IsSame<T>(IList<IList<T>> list, IList<IList<T>> list2)
        {
            if (list.Count != list2.Count)
                return false;

            int count = 0;
            HashSet<int> set = new HashSet<int>();
            foreach (var item in list)
            {
                var ls1 = item.ToList();
                ls1.Sort();
                for (int i = 0; i < list2.Count; i++)
                {
                    if (set.Contains(i))
                        continue;
                    var item2 = list2[i];
                    if (item.Count != item2.Count)
                        continue;

                    var ls2 = item2.ToList();
                    ls2.Sort();
                    if (ls1.SequenceEqual(ls2))
                    {
                        count++;
                        set.Add(i);
                        break;
                    }
                }

            }
            if (count == list.Count)
                return true;
            return false;
        }
        /// <summary>
        /// 没有排序比较
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <param name="list2"></param>
        /// <returns></returns>

        public static bool IsSameList<T>(IList<IList<T>> list, IList<IList<T>> list2)
        {
            if (list.Count != list2.Count)
                return false;

            int count = 0;
            HashSet<int> set = new HashSet<int>();
            foreach (var item in list)
            {
                for (int i = 0; i < list2.Count; i++)
                {
                    if (set.Contains(i))
                        continue;
                    var item2 = list2[i];

                    if (item.Count != item2.Count)
                        continue;

                    if (item.SequenceEqual(item2))
                    {
                        set.Add(i);
                        count++;
                        break;
                    }
                }
            }
            if (count == list.Count)
                return true;
            return false;
        }

        /// <summary>
        /// 严格相同
        /// </summary>
        /// <param name="arr1"></param>
        /// <param name="arr2"></param>
        /// <returns></returns>
        public static bool IsSameArr(int[][] arr1, int[][] arr2)
        {

            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr1[i].Length; j++)
                {
                    if (arr1[i][j] != arr2[i][j])
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public static bool IsSameArrNull(int?[][] arr1, int?[][] arr2)
        {

            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] == null && arr2[i] != null)
                {
                    return false;
                }
                if (arr1[i] == null)
                    continue;
                for (int j = 0; j < arr1[i].Length; j++)
                {
                    if (arr1[i][j] != arr2[i][j])
                    {
                        return false;
                    }
                }
            }

            return true;
        }
        public static bool IsSameArr(char[][] arr1, char[][] arr2)
        {

            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr1[i].Length; j++)
                {
                    if (arr1[i][j] != arr2[i][j])
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        /// <summary>
        /// 排序后相同
        /// </summary>
        /// <returns></returns>
        public static bool IsSameArr<T>(T[] arr1, T[] arr2)
        {
            Array.Sort(arr1);
            Array.Sort(arr2);
            return arr1.SequenceEqual(arr2);
        }
    }
}
