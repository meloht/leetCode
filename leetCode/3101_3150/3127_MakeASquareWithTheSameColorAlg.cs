using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3101_3150
{
    public class _3127_MakeASquareWithTheSameColorAlg
    {
        public bool CanMakeSquare(char[][] grid)
        {

            for (int i = 0; i < grid.Length - 1; i++)
            {
                for (int j = 0; j < grid[0].Length - 1; j++)
                {
                    int b = 0;
                    int w = 0;
                    for (int k = i; k <= i + 1; k++)
                    {
                        for (int m = j; m <= j + 1; m++)
                        {
                            if (grid[k][m] == 'B')
                            {
                                b++;
                            }
                            else
                            {
                                w++;
                            }
                        }
                    }

                    if (b >= 3 || w >= 3)
                        return true;
                }
            }

            return false;
        }


    }
}
