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
            if (yMax == 0 && xMax == 0)
            {
                list.Add(matrix[0][0]);
                return list;
            }

            int y = 0;
            int x = 0;
            while (y >= yMin && y <= yMax && x >= xMin && x <= xMax)
            {
                if (x < xMax && y == yMin && y <= yMax)
                {
                    while (x < xMax)
                    {
                        list.Add(matrix[y][x]);
                        x++;
                    }
                    if (x == xMax)
                    {
                        yMin++;
                        list.Add(matrix[y][x]);
                        y++;
                    }
                }
                else if (x == xMax && x >= xMin && y < yMax)
                {
                    while (y < yMax)
                    {
                        list.Add(matrix[y][x]);
                        y++;
                    }

                    if (y == yMax)
                    {
                        xMax--;
                        list.Add(matrix[y][x]);
                        x--;
                    }
                }
                else if (x == xMin && x <= xMax && y > yMin)
                {

                    while (y > yMin)
                    {
                        list.Add(matrix[y][x]);
                        y--;
                    }

                    if (y == yMin)
                    {
                        xMin++;
                        list.Add(matrix[y][x]);
                        x++;
                    }
                }
                else if (x > xMin && y == yMax && y >= yMin)
                {
                    while (x > xMin)
                    {
                        list.Add(matrix[y][x]);
                        x--;
                    }
                    if (x == xMin)
                    {
                        yMax--;
                        list.Add(matrix[y][x]);
                        y--;

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
