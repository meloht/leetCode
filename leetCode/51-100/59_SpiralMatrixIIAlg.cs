using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._51_100
{
    public class _59_SpiralMatrixIIAlg
    {
        public int[][] GenerateMatrix(int n)
        {
            Queue<int> list = new Queue<int>();
            int max = n * n;
            for (int i = 1; i <= max; i++)
            {
                list.Enqueue(i);
            }
            int[][] matrix = new int[n][];
            for (int i = 0; i < n; i++)
            {
                matrix[i] = new int[n];
            }
            int yMin = 0;
            int yMax = matrix.Length - 1;
            int xMin = 0;
            int xMax = matrix[0].Length - 1;
            if (yMax == 0 && xMax == 0)
            {
                matrix[0][0] = list.Dequeue();
                return matrix;
            }

            int y = 0;
            int x = 0;
            while (y >= yMin && y <= yMax && x >= xMin && x <= xMax)
            {
                if (x < xMax && y == yMin && y <= yMax)
                {
                    while (x < xMax)
                    {
                        matrix[y][x] = list.Dequeue();
                       
                        x++;
                    }
                    if (x == xMax)
                    {
                        yMin++;
                        matrix[y][x] = list.Dequeue();
                        y++;
                    }
                }
                else if (x == xMax && x >= xMin && y < yMax)
                {
                    while (y < yMax)
                    {
                        matrix[y][x] = list.Dequeue();
                        y++;
                    }

                    if (y == yMax)
                    {
                        xMax--;
                        matrix[y][x] = list.Dequeue();
                        x--;
                    }
                }
                else if (x == xMin && x <= xMax && y > yMin)
                {

                    while (y > yMin)
                    {
                        matrix[y][x] = list.Dequeue();
                        y--;
                    }

                    if (y == yMin)
                    {
                        xMin++;
                        matrix[y][x] = list.Dequeue();
                        x++;
                    }
                }
                else if (x > xMin && y == yMax && y >= yMin)
                {
                    while (x > xMin)
                    {
                        matrix[y][x] = list.Dequeue();
                        x--;
                    }
                    if (x == xMin)
                    {
                        yMax--;
                        matrix[y][x] = list.Dequeue();
                        y--;

                    }
                }
                else
                {
                    break;
                }

            }
            return matrix;
        }


    }
}
