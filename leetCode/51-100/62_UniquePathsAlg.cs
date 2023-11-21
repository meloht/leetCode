using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._51_100
{
    public class _62_UniquePathsAlg
    {
        private int mMax = 0;
        private int nMax = 0;
        private int count = 0;
        public int UniquePaths(int m, int n)
        {
            int[,] map = new int[m, n];
            mMax = m - 1;
            nMax = n - 1;
            SetWay(map, 0, 0);
            return count;
        }

        private void SetWay(int[,] map, int x, int y)
        {
            if (x == mMax && y == nMax)
            {
                count++;
                return;
            }
            else
            {
                if (x > mMax || y > nMax)
                    return;
                if (map[x, y] == 0)
                {
                    map[x, y] = 1;
                    SetWay(map, x + 1, y);
                    SetWay(map, x, y + 1);
                    map[x, y] = 0;
                }
              
            }
        }
    }
}
