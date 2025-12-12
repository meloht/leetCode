using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace leetCode._3501_3550
{
    public class _3531_CountCoveredBuildingsAlg
    {
        public int CountCoveredBuildings(int n, int[][] buildings)
        {
            int[] rowMin = new int[n + 1];
            int[] rowMax = new int[n + 1];
            int[] colMin = new int[n + 1];
            int[] colMax = new int[n + 1];
            Array.Fill(rowMin, n + 1);
            Array.Fill(colMin, n + 1);

            foreach (int[] p in buildings)
            {
                int x = p[0], y = p[1];
                rowMin[y] = Math.Min(rowMin[y], x);
                rowMax[y] = Math.Max(rowMax[y], x);
                colMin[x] = Math.Min(colMin[x], y);
                colMax[x] = Math.Max(colMax[x], y);
            }

            int ans = 0;
            foreach (int[] p in buildings)
            {
                int x = p[0], y = p[1];
                if (rowMin[y] < x && x < rowMax[y] && colMin[x] < y && y < colMax[x])
                {
                    ans++;
                }
            }
            return ans;


        }
    }
}
