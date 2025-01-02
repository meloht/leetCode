using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCodeTemplates.线段树
{
    public class SegmentTreeTemplate
    {
        /// <summary>
        /// 线段树+懒标记
        /// </summary>
        public class NumArray
        {
            private Node[] tree;
            private int size;
            public NumArray(int[] nums)
            {
                size = nums.Length;
                tree = new Node[nums.Length * 4];
                Build(0, 0, size - 1, nums);

            }

            public void Update(int index, int val)
            {
                UpdateNode(0, index, val);
            }

            public int SumRange(int left, int right)
            {
                return Query(0, left, right);
            }


            private int GetLeft(int node)
            {
                return node * 2 + 1;
            }
            private int GetRight(int node)
            {
                return node * 2 + 2;
            }

            private void Build(int node, int left, int right, int[] nums)
            {
                tree[node] = new Node() { Left = left, Right = right, Sum = nums[left] };
                if (left == right)
                {
                    return;
                }
                int mid = left + (right - left) / 2;
                int leftChild = GetLeft(node);
                int rightChild = GetRight(node);
                Build(leftChild, left, mid, nums);
                Build(rightChild, mid + 1, right, nums);
                tree[node].Sum = tree[leftChild].Sum + tree[rightChild].Sum;
            }
            private int Query(int node, int begin, int end)
            {
                if (begin <= tree[node].Left && tree[node].Right <= end)
                {
                    return tree[node].Sum;
                }
                int mid = tree[node].Left + (tree[node].Right - tree[node].Left) / 2;

                int sum = 0;
                int leftChild = GetLeft(node);
                int rightChild = GetRight(node);
                if (begin <= mid)
                {
                    sum += Query(leftChild, begin, end);
                }
                if (end > mid)
                {
                    sum += Query(rightChild, begin, end);
                }
                return sum;
            }

            private void UpdateNode(int node, int x, int val)
            {
                if (x == tree[node].Left && tree[node].Right == x)
                {
                    tree[node].Sum = val;
                    return;
                }
                int leftChild = GetLeft(node);
                int rightChild = GetRight(node);
                int mid = tree[node].Left + (tree[node].Right - tree[node].Left) / 2;

                if (x <= mid)
                {
                    UpdateNode(leftChild, x, val);
                }
                else
                {
                    UpdateNode(rightChild, x, val);
                }

                tree[node].Sum = tree[leftChild].Sum + tree[rightChild].Sum;
            }

        }

        private class Node
        {
            public int Left { get; set; }
            public int Right { get; set; }
            public int Sum { get; set; }
            public int Add { get; set; }
        }
    }
}
