using leetCode.Model.BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0251_0300
{
    public class _297_SerializeAndDeserializeBinaryTreeAlg
    {
        public class Codec
        {

            // Encodes a tree to a single string.
            public string serialize(TreeNode root)
            {
                var arr = GetTreeLevelList(root);
                StringBuilder sb = new StringBuilder();
                sb.Append("[");
                foreach (var item in arr)
                {
                    if (item == null)
                    {
                        sb.Append("null,");
                    }
                    else
                    {
                        sb.Append(item.ToString()).Append(",");
                    }
                }
                if (arr.Length > 0)
                {
                    sb.Remove(sb.Length - 1, 1);
                }
                sb.Append("]");
                return sb.ToString();
            }

            // Decodes your encoded data to tree.
            public TreeNode deserialize(string data)
            {
                List<int?> list = new List<int?>();
                var arr = data.Substring(1, data.Length - 2).Split(',', StringSplitOptions.RemoveEmptyEntries);
                foreach ( var item in arr ) 
                {
                    if (item == "null")
                    {
                        list.Add(null);
                    }
                    else
                    {
                        list.Add(int.Parse(item));
                    }
                }
                var tree = BuildTree(list.ToArray());

                return tree;
            }
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
        }


       

    }
}
