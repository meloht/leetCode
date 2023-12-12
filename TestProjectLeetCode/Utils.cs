using leetCode;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectLeetCode
{
    public class Utils
    {
        public static ListNode BuildListNode(int[] arr)
        {
            ListNode node = new ListNode(arr[0]);
            ListNode header = node;
            for (int i = 1; i < arr.Length; i++)
            {
                node.next = new ListNode(arr[i]);
                node = node.next;
            }

            return header;
        }

        public static TreeNode BuildBinaryTree(int?[] arr)
        {
            BinaryTreeBuilder builder = new BinaryTreeBuilder();
            TreeNode root = builder.BuildTree(arr);
            return root;
        }

        public static int?[][] GetTreeList(IList<TreeNode> list)
        {
            List<int?[]> arr = new List<int?[]>();
            foreach (TreeNode node in list)
            {
                arr.Add(PreTraversal(node).ToArray());
            }
            return arr.ToArray();
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
            foreach (var item in list)
            {
                System.Diagnostics.Debug.WriteLine("=======================");
                var dd = list2.Where(p => p.Count == item.Count).ToList();
                var b = item.ToList();
                b.Sort();
                StringBuilder sb = new StringBuilder();
                foreach (var num1 in b)
                {
                    sb.Append(num1);
                }
                System.Diagnostics.Debug.WriteLine(sb.ToString());
                sb.Clear();
                foreach (var item2 in dd)
                {
                    var a = item2.ToList();
                    a.Sort();

                    if (a.SequenceEqual(b))
                    {
                        count++;

                        foreach (var num1 in b)
                        {
                            sb.Append(num1);
                        }
                        System.Diagnostics.Debug.WriteLine(sb.ToString());
                        sb.Clear();
                    }
                }
                System.Diagnostics.Debug.WriteLine("=======================");
            }
            if (count == list.Count)
                return true;

            System.Diagnostics.Debug.WriteLine("*********************************");
            foreach (var item in list2)
            {
                foreach (var item2 in item)
                {
                    System.Diagnostics.Debug.Write(item2);
                }
                System.Diagnostics.Debug.WriteLine("");
            }

            System.Diagnostics.Debug.WriteLine("*********************************");
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
            foreach (var item in list)
            {
                System.Diagnostics.Debug.WriteLine("=======================");
                var dd = list2.Where(p => p.Count == item.Count).ToList();
                var b = item.ToList();

                StringBuilder sb = new StringBuilder();
                foreach (var num1 in b)
                {
                    sb.Append(num1);
                }
                System.Diagnostics.Debug.WriteLine(sb.ToString());
                sb.Clear();
                foreach (var item2 in dd)
                {
                    var a = item2.ToList();

                    if (a.SequenceEqual(b))
                    {
                        count++;
                        foreach (var num1 in b)
                        {
                            sb.Append(num1);
                        }
                        System.Diagnostics.Debug.WriteLine(sb.ToString());
                        sb.Clear();
                        break;
                    }
                }
                System.Diagnostics.Debug.WriteLine("=======================");
            }
            if (count == list.Count)
                return true;

            System.Diagnostics.Debug.WriteLine("*********************************");
            foreach (var item in list2)
            {
                foreach (var item2 in item)
                {
                    System.Diagnostics.Debug.Write(item2);
                }
                System.Diagnostics.Debug.WriteLine("");
            }

            System.Diagnostics.Debug.WriteLine("*********************************");
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
    }
}
