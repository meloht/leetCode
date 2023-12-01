using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            Node nodeFirst = new Node(heights[0], 1);
            max = Math.Max(max, nodeFirst.GetArea());
            stack.Push(nodeFirst);

            for (int i = 1; i < heights.Length; i++)
            {
                int currentHeight = heights[i];
                int preHeight = heights[i - 1];
                if (currentHeight == 0)
                {
                    stack.Clear();
                    continue;
                }
                if (currentHeight >= preHeight)
                {
                    foreach (var item in stack)
                    {
                        item.Count++;
                        max = Math.Max(max, item.GetArea());
                    }
                    max = Math.Max(max, currentHeight);
                    Node node = new Node(currentHeight, 1);
                    stack.Push(node);
                }
                else
                {
                    int count = 0;
                    while (stack.Count > 0)
                    {
                        Node preNode = stack.Peek();
                        if (preNode.Height >= currentHeight)
                        {
                            count = preNode.Count;
                            stack.Pop();
                        }
                        else
                        {
                            break;
                        }
                    }
                    foreach (var item in stack)
                    {
                        item.Count++;
                        max = Math.Max(max, item.GetArea());
                    }

                    Node node = new Node(currentHeight, count + 1);
                    max = Math.Max(max, node.GetArea());
                    stack.Push(node);
                }

            }
            return max;
        }

        class Node
        {
            public int Height;
            public int Count;
            public Node(int height, int count)
            {
                this.Height = height;
                this.Count = count;
            }
            public int GetArea()
            {
                return this.Count * this.Height;
            }

            public override string ToString()
            {
                return $"{Height} {Count}";
            }
        }
    }
}
