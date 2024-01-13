using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0201_0250
{
    public class _223_RectangleAreaAlg
    {
        public int ComputeArea(int ax1, int ay1, int ax2, int ay2, int bx1, int by1, int bx2, int by2)
        {
            int area = GetArea(ax1, ax2, ay1, ay2);
            area += GetArea(bx1, bx2, by1, by2);

            if (ax2 <= bx1 || ay1 >= by2 || ax1 >= bx2 || ay2 <= by1)
            {
                return area;
            }

            int x1 = Math.Min(bx2, ax2);
            int x2 = Math.Max(bx1, ax1);

            int y1 = Math.Min(by2, ay2);
            int y2 = Math.Max(by1, ay1);

            int a = GetArea(x1, x2, y1, y2);
            area -= a;

            return area;
        }

        private int GetArea(int x1, int x2, int y1, int y2)
        {
            int x = Math.Abs(x1 - x2);
            int y = Math.Abs(y1 - y2);
            int area = x * y;
            return area;
        }
    }
}
