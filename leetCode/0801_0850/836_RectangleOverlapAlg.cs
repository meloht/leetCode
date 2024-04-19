using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0801_0850
{
    public class _836_RectangleOverlapAlg
    {
        public bool IsRectangleOverlap(int[] rec1, int[] rec2)
        {
            int x1 = rec1[0];
            int y1 = rec1[1];
            int x2 = rec1[2];
            int y2 = rec1[3];

            int a1 = rec2[0];
            int b1 = rec2[1];
            int a2 = rec2[2];
            int b2 = rec2[3];
            if (x1 >= a2) 
            {
                return false;
            }
            if (x2 <= a1)
            {
                return false;
            }
            if (y1 >= b2)
            {
                return false;
            }
            if (y2 <= b1)
            {
                return false;
            }
            return true;
        }
    }
}
