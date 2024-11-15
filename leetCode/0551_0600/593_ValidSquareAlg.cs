using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0551_0600
{
    public class _593_ValidSquareAlg
    {
        public bool ValidSquare(int[] p1, int[] p2, int[] p3, int[] p4)
        {
           
            int[][] arr = new int[4][];
            arr[0] = p1;
            arr[1] = p2;
            arr[2] = p3;
            arr[3] = p4;
            Array.Sort(arr, (x, y) => x[0].CompareTo(y[0]));

            if (arr[0][0] != arr[1][0])
                return false;
            if (arr[2][0] != arr[3][0])
                return false;

            

            Array.Sort(arr, (x, y) => x[1].CompareTo(y[1]));

            if (arr[0][1] != arr[1][1])
                return false;
            if (arr[2][1] != arr[3][1])
                return false;



            return false;
        }
        private long Dis(int[] p1, int[] p2)
        {
            long x = p1[0] - p2[0];
            long y = p1[1] - p2[1];
            return x * x + y * y;
        }
    }
}
