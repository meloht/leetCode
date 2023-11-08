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
            int areaSum = 0;
            foreach (var item in list)
            {
                for (int i = item.BeginIndex; i <= item.EndIndex; i++)
                {

                }
            }

            return 0;
        }
        private int GetArea(RangeModel item, int[] height)
        {
            int area = 0;
            for (int i = item.BeginIndex; i <= item.EndIndex; i++)
            {
                int num1 = height[i];
                if ((i + 1) <= item.EndIndex)
                {
                   int num2= height[i + 1];
                }
            }
            return 0;
        }
        private int GetEndIndex(int[] height, int len, int beginIndex, int begin, List<RangeModel> list)
        {
            int endIndex = 0;
            for (int i = beginIndex + 2; i < len; i++)
            {
                if (height[i] >= begin)
                {
                    RangeModel model = new RangeModel();
                    model.BeginIndex = beginIndex;
                    model.EndIndex = i;
                    list.Add(model);
                    endIndex = i;
                    return endIndex;
                }
            }
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
