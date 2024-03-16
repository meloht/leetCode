using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0451_0500
{
    public class _492_ConstructTheRectangleAlg
    {
        public int[] ConstructRectangle(int area)
        {
            int w = (int)Math.Sqrt(area);
            while (area % w != 0)
            {
                --w;
            }
            return new int[] { area / w, w };

        }
    }
}
