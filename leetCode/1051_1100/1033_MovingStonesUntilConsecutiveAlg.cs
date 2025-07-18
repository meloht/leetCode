using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1051_1100
{
    public class _1033_MovingStonesUntilConsecutiveAlg
    {
        public int[] NumMovesStones(int a, int b, int c)
        {
            int[] arr = [a, b, c];
            Array.Sort(arr);
            int left = arr[1] - arr[0] - 1;
            int right = arr[2] - arr[1] - 1;
            if (left == right && left == 0)
                return [0, 0];

            int min = 0;
            int minDis = Math.Min(left, right);
            if (minDis > 1)
            {
                min = 2;
            }
            else
            {
                min = 1;
            }

            int max = right + left;


            return [min, max];
        }
    }
}
