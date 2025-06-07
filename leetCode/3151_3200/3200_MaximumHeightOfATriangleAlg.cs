using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3151_3200
{
    public class _3200_MaximumHeightOfATriangleAlg
    {
        public int MaxHeightOfTriangle(int red, int blue)
        {
            return Math.Max(getMax(red, blue), getMax(blue, red));
        }

        private int getMax(int a, int b)
        {
            int index = 1;
            for (int i = 0, j = 0; ;)
            {
                if (index % 2 == 1)
                {
                    i += index;
                    if (i > a)
                    {
                        return index-1;
                    }
                   
                }
                else
                {
                    j += index;
                    if (j > b)
                    {
                        return index-1;
                    }
                }
               
                index++;
            }

        }
    }
}
