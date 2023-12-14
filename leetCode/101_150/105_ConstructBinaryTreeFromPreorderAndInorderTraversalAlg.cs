﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._101_150
{
    public class _105_ConstructBinaryTreeFromPreorderAndInorderTraversalAlg
    {
        public TreeNode BuildTree(int[] preorder, int[] inorder)
        {
            TreeNode root = new TreeNode(preorder[0]);
            var preList = preorder.ToList();
            preList.Remove(preorder[0]);
            var inorderList = inorder.ToList();

            BuildTree(preList, inorderList, root);

            return root;
        }
        private void BuildTree(List<int> preorder, List<int> inorder, TreeNode parent)
        {
            if (preorder.Count == 0)
                return;
            var res = GetLeftRightList(parent.val, inorder);

            var leftTreeList = res.Item1;
            var rightTreeList = res.Item2;

            var preLeft = GetPreLeftList(preorder, leftTreeList.Count);
            var preRight = GetPreRightList(preorder, leftTreeList.Count);

            if (leftTreeList.Count > 0)
            {
                int leftVal = preLeft[0];
                TreeNode left = new TreeNode(leftVal);

                parent.left = left;
                preLeft.RemoveAt(0);

                BuildTree(preLeft, leftTreeList, left);
            }
            if (rightTreeList.Count > 0 && preRight.Count > 0)
            {
                int rightVal = preRight[0];
                TreeNode right = new TreeNode(rightVal);
                parent.right = right;
                preRight.RemoveAt(0);
                BuildTree(preRight, rightTreeList, right);
            }
        }

        private Tuple<List<int>, List<int>> GetLeftRightList(int rootVal, List<int> inorder)
        {
            var leftTreeList = new List<int>();
            var rightTreeList = new List<int>();
            bool blLeft = true;
            for (int i = 0; i < inorder.Count; i++)
            {
                if (blLeft)
                {
                    if (inorder[i] == rootVal)
                    {
                        blLeft = false;
                    }
                    else
                    {
                        leftTreeList.Add(inorder[i]);
                    }
                }
                else
                {
                    rightTreeList.Add(inorder[i]);
                }
            }

            return new Tuple<List<int>, List<int>>(leftTreeList, rightTreeList);
        }

        private List<int> GetPreLeftList(List<int> preorder, int leftCount)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < leftCount; i++)
            {
                list.Add(preorder[i]);
            }

            return list;
        }
        private List<int> GetPreRightList(List<int> preorder, int leftCount)
        {
            List<int> list = new List<int>();
            for (int i = leftCount; i < preorder.Count; i++)
            {
                list.Add(preorder[i]);
            }

            return list;
        }
    }
}