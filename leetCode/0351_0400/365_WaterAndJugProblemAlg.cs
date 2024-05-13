using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0351_0400
{
    public class _365_WaterAndJugProblemAlg
    {
        public bool CanMeasureWater(int x, int y, int target)
        {
            if ((x + y) < target)
                return false;

            if (x + y < target)
            {
                return false;
            }
            if (x == 0 || y == 0)
            {
                return target == 0 || x + y == target;
            }
            return target % GCD(x, y) == 0;


        }
        public static int GCD(int a, int b)
        {
            while (b != 0)
            {
                int tmp = a % b;
                a = b;
                b = tmp;
            }
            return a;
        }
    }
}
