using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._51_100
{
    public class _54_SpiralMatrixAlg
    {
        public IList<int> SpiralOrder(int[][] matrix)
        {
            List<int> list = new List<int>();
            int yMin = 0;
            int yMax = matrix.Length - 1;
            int xMin = 0;
            int xMax = matrix[0].Length - 1;

            int tempYMin = 0;
            int tempYMax = matrix.Length - 1;

            int tempXMin = 0;
            int tempXMax = matrix[0].Length - 1;

            int y = 0;
            int x = 0;
            while (y >= yMin && y <= yMax && x >= xMin && x <= xMax)
            {
                if (x <= xMax && y == yMin && y <= yMax)
                {
                    if (x == xMin)
                    {
                        xMin = tempXMin;
                    }
                    list.Add(matrix[y][x]);
                    x++;
                    if (x == xMax)
                    {
                        tempYMin = yMin + 1;
                        y = yMin;
                    }

                }
                else if (x == xMax + 1 && x >= xMin && y <= yMax)
                {
                    if (y == yMin)
                    {
                        yMin = tempYMin;
                    }
                    list.Add(matrix[y][x]);
                    y++;
                    if (y == yMax)
                    {
                        tempXMax = xMax - 1;
                        x = xMax;
                    }
                }
                else if (x == xMin && x <= xMax && y >= yMin)
                {
                    if (y == yMax)
                    {
                        yMax = tempYMax;
                    }
                    list.Add(matrix[y][x]);
                    y--;

                    if (y == yMin)
                    {
                        tempXMin = xMin + 1;
                        x = xMin;
                    }
                }
                else if (x >= xMin && y == yMax + 1 && y >= yMin)
                {
                    if (x == xMax)
                    {
                        xMax = tempXMax;
                    }
                    list.Add(matrix[y][x]);
                    x--;
                    if (x == xMin)
                    {
                        tempYMax = yMax - 1;
                        y= yMax;

                    }
                }
                else
                {
                    break;
                }

            }
            return list;
        }
    }
}
