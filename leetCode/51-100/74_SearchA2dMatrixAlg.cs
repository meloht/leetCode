using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace leetCode._51_100
{
    public class _74_SearchA2dMatrixAlg
    {
        public bool SearchMatrix(int[][] matrix, int target)
        {
            List<Node> list = new List<Node>(matrix.Length);
            for (int i = 0; i < matrix.Length; i++)
            {
                list.Add(new Node(matrix[i][0], matrix[i][matrix[i].Length - 1], matrix[i]));

            }

            bool bl = GetBinaryIndex(list, 0, list.Count - 1, target); ;

            return bl;
        }
        private bool GetBinaryIndex(List<Node> list, int left, int right, int target)
        {
            if (left == right)
            {
                if (left < list.Count)
                {
                    return list[left].Arr.Contains(target);
                }
                return false;
            }

            int mid = (left + right) / 2;

            var node = list[mid];


            if (target >= node.Begin && target <= node.End)
            {
                return node.Arr.Any(p => p == target);
            }
            else if (target > node.End)
            {
                int next = mid + 1;
                if (next < list.Count)
                {
                    var nextNode = list[next];
                    if (target >= nextNode.Begin && target <= nextNode.End)
                    {
                        return nextNode.Arr.Any(p => p == target);
                    }
                    else if (target < nextNode.Begin)
                    {
                        return false;
                    }
                    else
                    {
                        return GetBinaryIndex(list, mid + 2, right, target);
                    }
                }
                else
                {
                    return false;
                }
            }
            else if (target < node.Begin)
            {
                int pre = mid - 1;
                if (pre >= 0)
                {
                    var preNode = list[pre];
                    if (target >= preNode.Begin && target <= preNode.End)
                    {
                        return preNode.Arr.Any(p => p == target);
                    }
                    else if (target < preNode.Begin)
                    {
                        return GetBinaryIndex(list, left, mid - 2, target); ;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;

                }

            }

            return false;
        }

        class Node
        {
            public int Begin;
            public int End;
            public int[] Arr;
            public Node(int begin, int end, int[] arr)
            {
                this.Begin = begin;
                this.End = end;
                Arr = arr;
            }
        }
    }
}
