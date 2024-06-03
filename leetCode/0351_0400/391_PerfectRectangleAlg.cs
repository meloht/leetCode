using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0351_0400
{
    public class _391_PerfectRectangleAlg
    {
        public bool IsRectangleCover(int[][] rectangles)
        {
            int minX1 = int.MaxValue;
            int minY1 = int.MaxValue;

            int maxX2 = int.MinValue;
            int maxY2 = int.MinValue;
            long sum = 0;
            Dictionary<Tuple<int, int>, int> dict = new Dictionary<Tuple<int, int>, int>();
            for (int i = 0; i < rectangles.Length; i++)
            {
                int currX1 = rectangles[i][0];
                int currY1 = rectangles[i][1];
                minX1 = Math.Min(minX1, currX1);
                minY1 = Math.Min(minY1, currY1);


                int currX2 = rectangles[i][2];
                int currY2 = rectangles[i][3];

                maxX2 = Math.Max(maxX2, currX2);
                maxY2 = Math.Max(maxY2, currY2);

                sum += ((currX2 - currX1) * (currY2 - currY1));
                Tuple<int, int> point1 = new Tuple<int, int>(currX1, currY1);
                Tuple<int, int> point2 = new Tuple<int, int>(currX1, currY2);
                Tuple<int, int> point3 = new Tuple<int, int>(currX2, currY1);
                Tuple<int, int> point4 = new Tuple<int, int>(currX2, currY2);

                AddPoint(point1, dict);
                AddPoint(point2, dict);
                AddPoint(point3, dict);
                AddPoint(point4, dict);
            }

            long total = (maxX2 - minX1) * (maxY2 - minY1);
            if (total != sum)
            {
                return false;
            }

            Tuple<int, int> pointMinMin = new Tuple<int, int>(minX1, minY1);
            Tuple<int, int> pointMinMax = new Tuple<int, int>(minX1, maxY2);
            Tuple<int, int> pointMaxMin = new Tuple<int, int>(maxX2, minY1);
            Tuple<int, int> pointMaxMax = new Tuple<int, int>(maxX2, maxY2);

            if (!dict.ContainsKey(pointMinMin) || dict[pointMinMin] != 1)
            {
                return false;
            }

            if (!dict.ContainsKey(pointMinMax) || dict[pointMinMax] != 1)
            {
                return false;
            }
            if (!dict.ContainsKey(pointMaxMin) || dict[pointMaxMin] != 1)
            {
                return false;
            }
            if (!dict.ContainsKey(pointMaxMax) || dict[pointMaxMax] != 1)
            {
                return false;
            }

            dict.Remove(pointMinMin);
            dict.Remove(pointMinMax);
            dict.Remove(pointMaxMin);
            dict.Remove(pointMaxMax);

            foreach (var item in dict)
            {
                if (item.Value != 2 && item.Value != 4)
                {
                    return false;
                }
            }


            return true;


        }

        private void AddPoint(Tuple<int, int> point1, Dictionary<Tuple<int, int>, int> dict)
        {
            if (!dict.ContainsKey(point1))
            {
                dict.Add(point1, 1);
                return;
            }
            dict[point1]++;
        }
    }
}
