using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1901_1950
{
    public class _1944_NumberOfVisiblePeopleInAQueueAlg
    {
        public int[] CanSeePersonsCount(int[] heights)
        {
            int[] res = new int[heights.Length];
            Stack<NodeModel> stack = new Stack<NodeModel>();
            int len = heights.Length;

            for (int i = 0; i < len; i++)
            {
                int curr = heights[i];
                while (stack.Count > 0)
                {
                    var node = stack.Peek();
                    if (node.Max <= curr && curr < heights[node.Index])
                    {
                        node.Count++;
                        node.Max = curr;
                        break;
                    }
                    else if (curr >= heights[node.Index])
                    {
                        node.Count++;
                        res[node.Index] = node.Count;
                        stack.Pop();
                    }
                    else
                    {
                        break;
                    }
                }


                int nextIndex = i + 1;
                if (nextIndex < len)
                {
                    if (heights[nextIndex] < curr)
                    {
                        stack.Push(new NodeModel(i, 0, heights[nextIndex]));
                    }
                    else
                    {
                        res[i] = 1;
                    }
                }
                else
                {
                    res[i] = 0;
                }
            }
            while (stack.Count > 0)
            {
                var node = stack.Pop();
                res[node.Index] = node.Count;
            }


            return res;
        }
        class NodeModel
        {
            public int Index;
            public int Count;
            public int Max;
            public NodeModel(int index, int count, int max)
            {
                this.Index = index;
                this.Count = count;
                this.Max = max;
            }
        }



        public int[] CanSeePersonsCount2(int[] heights)
        {
            int n = heights.Length;
            Stack<int> stack = new Stack<int>();
            int[] res = new int[n];

            for (int i = n - 1; i >= 0; i--)
            {
                int h = heights[i];
                while (stack.Count > 0 && stack.Peek() < h)
                {
                    stack.Pop();
                    res[i]++;
                }
                if (stack.Count > 0)
                {
                    res[i]++;
                }
                stack.Push(h);
            }
            return res;
        }
    }
}
