using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1_50
{
    public class _42_TrappingRainWaterAlg
    {

        public int Trap(int[] height)
        {
            if (height.Length < 3)
                return 0;
            int maxIndex = GetMaxIndex(0, height.Length - 1, height);
            List<RangeModel> list = new List<RangeModel>();
            return 0;
        }
        private void ComputeLeftSplit(int beginIndex,int endIndex, int[] height, List<RangeModel> list)
        {
            int maxIndex = GetMaxIndex(beginIndex, endIndex-1, height);
            int diff = (endIndex - maxIndex)+1;
            if (diff > 3)
            {
                
            }

        }
        private int GetMaxIndex(int begin, int end, int[] height)
        {
            int max = 0;
            int index = 0;
            for (int i = begin; i <= end; i++)
            {
                int num = height[i];
                if (num > max)
                {
                    max = num;
                    index = i;
                }
            }
            return index;
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
                for (int i = endIndex - 1; i >= beginIndex; i--)
                {
                    if (height[i] >= height[endIndex])
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

        class RangeModel
        {
            public int BeginIndex;
            public int EndIndex;
            public int Area;
        }
    }
}
