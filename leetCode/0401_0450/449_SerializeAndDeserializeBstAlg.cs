﻿using leetCode.Model.BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0401_0450
{
    public class _449_SerializeAndDeserializeBstAlg
    {
        public string serialize(TreeNode root)
        {
            IList<int> list = new List<int>();
            PostOrder(root, list);
            return string.Join(",", list);
        }

        public TreeNode deserialize(string data)
        {
            if (data.Length == 0)
            {
                return null;
            }
            string[] arr = data.Split(",");
            Stack<int> stack = new Stack<int>();
            int length = arr.Length;
            for (int i = 0; i < length; i++)
            {
                stack.Push(int.Parse(arr[i]));
            }
            return Construct(int.MinValue, int.MaxValue, stack);
        }

        private void PostOrder(TreeNode root, IList<int> list)
        {
            if (root == null)
            {
                return;
            }
            PostOrder(root.left, list);
            PostOrder(root.right, list);
            list.Add(root.val);
        }

        private TreeNode Construct(int lower, int upper, Stack<int> stack)
        {
            if (stack.Count == 0 || stack.Peek() < lower || stack.Peek() > upper)
            {
                return null;
            }
            int val = stack.Pop();
            TreeNode root = new TreeNode(val);
            root.right = Construct(val, upper, stack);
            root.left = Construct(lower, val, stack);
            return root;
        }

    }
}
