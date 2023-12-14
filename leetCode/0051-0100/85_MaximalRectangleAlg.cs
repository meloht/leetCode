using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace leetCode._51_100
{
    public class _85_MaximalRectangleAlg
    {
        public int MaximalRectangle(char[][] matrix)
        {
            int max = 0;
            int[] col = new int[matrix[0].Length];
          
            for (int i = 0; i < matrix.Length; i++)
            {
                
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    if (matrix[i][j] == '1')
                    {
                        col[j] = col[j] + 1;
                       
                    }
                    else
                    {
                        max = Math.Max(max, col[j]);
                        col[j] = 0;
                    }

                }
               
                int area = LargestRectangleArea(col);
                max = Math.Max(max, area);

            }

            return max;
        }

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


    }
}
