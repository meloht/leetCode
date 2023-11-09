using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace leetCode._1_50
{
    public class _42_TrappingRainWaterAlg
    {

        public int Trap(int[] height)
        {
            if (height.Length < 3)
                return 0;

            int ans = 0;
            int left = 0, right = height.Length - 1;
            int leftMax = 0, rightMax = 0;
            while (left < right)
            {
                leftMax = Math.Max(leftMax, height[left]);
                rightMax = Math.Max(rightMax, height[right]);
                if (height[left] < height[right])
                {
                    ans += leftMax - height[left];
                    ++left;
                }
                else
                {
                    ans += rightMax - height[right];
                    --right;
                }
            }
            return ans;

        }
        /// <summary>
        /// 栈
        /// </summary>
        /// <param name="height"></param>
        /// <returns></returns>
        public int Trap5(int[] height)
        {
            if (height.Length < 3)
                return 0;

            int ans = 0;
            Stack<int> stack = new Stack<int>();
            int n = height.Length;
            for (int i = 0; i < n; ++i)
            {
                while (stack.Count > 0 && height[i] > height[stack.Peek()])
                {
                    int top = stack.Pop();
                    if (stack.Count == 0)
                    {
                        break;
                    }
                    int left = stack.Peek();
                    int currWidth = i - left - 1;
                    int currHeight = Math.Min(height[left], height[i]) - height[top];
                    ans += currWidth * currHeight;
                }
                stack.Push(i);
            }
            return ans;

        }


        /// <summary>
        /// 动态规划
        /// </summary>
        /// <param name="height"></param>
        /// <returns></returns>
        public int Trap4(int[] height)
        {
            if (height.Length < 3)
                return 0;
            int n = height.Length;

            int[] leftMax = new int[n];
            leftMax[0] = height[0];
            for (int i = 1; i < n; ++i)
            {
                leftMax[i] = Math.Max(leftMax[i - 1], height[i]);
            }

            int[] rightMax = new int[n];
            rightMax[n - 1] = height[n - 1];
            for (int i = n - 2; i >= 0; --i)
            {
                rightMax[i] = Math.Max(rightMax[i + 1], height[i]);
            }

            int ans = 0;
            for (int i = 0; i < n; ++i)
            {
                ans += Math.Min(leftMax[i], rightMax[i]) - height[i];
            }
            return ans;

        }
        public int Trap3(int[] height)
        {
            if (height.Length < 3)
                return 0;

            int max = 0;
            int maxIndex = 0;
            for (int i = 0; i < height.Length; i++)
            {
                int num = height[i];
                if (num > max)
                {
                    max = num;
                    maxIndex = i;
                }
            }

            List<RangeModel> list = new List<RangeModel>();

            if (maxIndex >= 2)
            {
                ComputeLeftSplit(maxIndex, height, list);
            }
            if ((maxIndex + 2) < height.Length)
            {
                ComputeRightSplit(maxIndex, height, list);
            }

            int areaSum = list.Sum(p => p.Area);
            return areaSum;
        }
        private void ComputeLeftSplit(int endIndex, int[] height, List<RangeModel> list)
        {
            var node = GetMaxMinIndex(0, endIndex - 1, height, true);
            int diff = (endIndex - node.MaxIndex) + 1;
            if (diff >= 3 && node.Min < node.Max && node.Min < height[endIndex])
            {
                RangeModel model = new RangeModel();
                model.BeginIndex = node.MaxIndex;
                model.EndIndex = endIndex;
                UpdateIndex(model, height);
                GetArea(model, height);
                list.Add(model);
            }
            if (node.MaxIndex >= 2)
            {
                ComputeLeftSplit(node.MaxIndex, height, list);
            }


        }
        private void ComputeRightSplit(int beginIndex, int[] height, List<RangeModel> list)
        {
            var node = GetMaxMinIndex(beginIndex + 1, height.Length - 1, height, false);
            int diff = (node.MaxIndex - beginIndex) + 1;
            if (diff >= 3 && node.Min < node.Max && node.Min < height[beginIndex])
            {
                RangeModel model = new RangeModel();
                model.BeginIndex = beginIndex;
                model.EndIndex = node.MaxIndex;
                UpdateIndex(model, height);
                GetArea(model, height);
                list.Add(model);
            }
            if ((node.MaxIndex + 2) < height.Length)
            {
                ComputeRightSplit(node.MaxIndex, height, list);
            }

        }
        private void UpdateIndex(RangeModel item, int[] height)
        {
            int begin = height[item.BeginIndex];
            int end = height[item.EndIndex];
            if (begin > end)
            {
                for (int i = item.BeginIndex; i < item.EndIndex; i++)
                {
                    if (height[i] >= height[item.EndIndex] && (i + 1) < item.EndIndex && height[i + 1] < end)
                    {
                        item.BeginIndex = i;
                        break;
                    }
                }
            }
            else if (end > begin)
            {
                for (int i = item.EndIndex; i > item.BeginIndex; i--)
                {
                    if (height[i] >= height[item.BeginIndex] && (i - 1) > item.BeginIndex && height[i - 1] < begin)
                    {
                        item.EndIndex = i;
                        break;
                    }
                }
            }
        }
        private Node GetMaxMinIndex(int begin, int end, int[] height, bool isLeft)
        {
            Node node = new Node();
            int max = 0;
            int min = int.MaxValue;
            int indexMin = 0;
            int indexMax = 0;
            for (int i = begin; i <= end; i++)
            {
                int num = height[i];

                if (isLeft)
                {
                    if (num > max)
                    {
                        max = num;
                        indexMax = i;
                    }
                }
                else
                {
                    if (num >= max)
                    {
                        max = num;
                        indexMax = i;
                    }
                }
                if (num <= min)
                {
                    min = num;
                    indexMin = i;
                }
            }
            node.Min = min;
            node.Max = max;

            node.MinIndex = indexMin;
            node.MaxIndex = indexMax;
            return node;
        }

        class Node
        {
            public int Max { get; set; }
            public int Min { get; set; }

            public int MaxIndex { get; set; }
            public int MinIndex { get; set; }
        }
        class RangeModel
        {
            public int BeginIndex;
            public int EndIndex;
            public int Area;
        }
        private void GetArea(RangeModel item, int[] height)
        {

            int area = 0;
            int num1 = Math.Min(height[item.BeginIndex], height[item.EndIndex]);
            for (int i = item.BeginIndex + 1; i < item.EndIndex; i++)
            {
                area = area + num1 - height[i];
            }
            item.Area = area;
        }


        /// <summary>
        /// 双指针
        /// </summary>
        /// <param name="height"></param>
        /// <returns></returns>
        public int Trap2(int[] height)
        {
            if (height.Length < 3)
                return 0;

            List<RangeModel> list = new List<RangeModel>();
            int len = height.Length;

            int beginIndex = 0;
            while (beginIndex < len)
            {
                int num = height[beginIndex];
                if ((beginIndex + 1) < len)
                {
                    if (num > height[beginIndex + 1])
                    {
                        int endIndex = GetEndIndex(height, len, beginIndex, num, list);
                        if (endIndex != 0)
                        {
                            beginIndex = endIndex;
                            continue;
                        }
                    }
                }

                beginIndex++;
            }
            int areaSum = list.Sum(p => p.Area);

            return areaSum;
        }

        private int GetEndIndex(int[] height, int len, int beginIndex, int begin, List<RangeModel> list)
        {
            int endIndex = 0;
            int min = height[beginIndex + 1];
            int end = 0;
            for (int i = beginIndex + 2; i < len; i++)
            {
                if (height[i] >= begin)
                {
                    endIndex = i;
                    break;
                }

                if (height[i] < min)
                {
                    min = height[i];
                }

                if (height[i] > min && min < begin)
                {
                    if (height[i] > end)
                    {
                        end = height[i];
                        endIndex = i;
                    }
                }

            }
            if (end < begin)
            {
                for (int i = beginIndex; i < endIndex; i++)
                {
                    if (height[i] >= height[endIndex] && (i + 1) < endIndex && height[i + 1] < end)
                    {
                        beginIndex = i;
                        break;
                    }
                }
            }

            RangeModel model = new RangeModel();
            model.BeginIndex = beginIndex;
            model.EndIndex = endIndex;
            GetArea(model, height);
            list.Add(model);
            return endIndex;
        }

    }
}
