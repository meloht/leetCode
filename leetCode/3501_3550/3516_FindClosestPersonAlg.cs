using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3501_3550
{
    public class _3516_FindClosestPersonAlg
    {
        public int FindClosest(int x, int y, int z)
        {
            if (Math.Abs(z - x) < Math.Abs(z - y))
            {
                return 1;
            }
            else if (Math.Abs(z - x) == Math.Abs(z - y))
            {
                return 0;
            }
            else
            {
                return 2;
            }

        }
    }
}
