using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace leetCode._51_100
{
    public class _84_LargestRectangleInHistogramAlg
    {

        public int LargestRectangleArea(int[] heights)
        {
            if (heights.Length == 1)
                return heights[0];
            int max = 0;
            Stack<Node> stack = new Stack<Node>();

            Node nodeFirst = new Node(heights[0], 0);
            max = Math.Max(max, nodeFirst.GetArea(1));
            stack.Push(nodeFirst);

            for (int i = 1; i < heights.Length; i++)
            {
                int currentHeight = heights[i];
                int preHeight = heights[i - 1];
                if (currentHeight == 0)
                {
                    while (stack.Count > 0)
                    {
                        var node = stack.Pop();
                        max = Math.Max(max, node.GetArea(i));
                    }
                    continue;
                }
                if (currentHeight > preHeight)
                {
                    max = Math.Max(max, currentHeight);
                    Node node = new Node(currentHeight, i);
                    stack.Push(node);
                }
                else
                {
                    int index = i;
                    Node preNode = null;
                    while (stack.Count > 0)
                    {
                        if (stack.Peek().Height >= currentHeight)
                        {
                            preNode = stack.Pop();
                            max = Math.Max(max, preNode.GetArea(i));
                        }
                        else
                        {
                            break;
                        }
                    }

                    if (preNode != null)
                    {
                        index = preNode.Index;
                    }

                    Node node = new Node(currentHeight, index);
                    max = Math.Max(max, node.GetArea(i));
                    stack.Push(node);
                }

            }

            while (stack.Count > 0)
            {
                var node = stack.Pop();
                max = Math.Max(max, node.GetArea(heights.Length));
            }
            return max;
        }

        class Node
        {
            public int Height;
            public int Index;
            public Node(int height, int index)
            {
                this.Height = height;
                Index = index;
            }

            public int GetArea(int i)
            {
                return (i - Index) * this.Height;
            }
        }


        public int LargestRectangleArea1(int[] heights)
        {
            int n = heights.Length;
            int[] left = new int[n];
            int[] right = new int[n];
            for (int i = 0; i < right.Length; i++)
            {
                right[i] = n;
            }

            Stack<int> mono_stack = new Stack<int>();
            for (int i = 0; i < n; ++i)
            {
                while (mono_stack.Count > 0 && heights[mono_stack.Peek()] >= heights[i])
                {
                    right[mono_stack.Peek()] = i;
                    mono_stack.Pop();
                }
                left[i] = (mono_stack.Count == 0 ? -1 : mono_stack.Peek());
                mono_stack.Push(i);
            }

            int ans = 0;
            for (int i = 0; i < n; ++i)
            {
                ans = Math.Max(ans, (right[i] - left[i] - 1) * heights[i]);
            }
            return ans;
        }

    }
}
