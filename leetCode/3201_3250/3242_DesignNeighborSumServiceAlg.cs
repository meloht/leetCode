using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3201_3250
{
    public class _3242_DesignNeighborSumServiceAlg
    {
        public class NeighborSum
        {
            Dictionary<int, int[]> dict = new Dictionary<int, int[]>();
            private int[][] grid;
            private int[][] dir = [[1, 0], [-1, 0], [0, 1], [0, -1]];
            private int[][] dia = [[1, 1], [-1, 1], [1, -1], [-1, -1]];
            public NeighborSum(int[][] grid)
            {
                this.grid = grid;
                for (int i = 0; i < this.grid.Length; i++)
                {
                    for (int j = 0; j < this.grid[0].Length; j++)
                    {
                        dict.Add(grid[i][j], [i, j]);
                    }
                }
            }

            public int AdjacentSum(int value)
            {
                var arr = dict[value];
                int sum = 0;
                foreach (var item in dir)
                {
                    int x = arr[0] + item[0];
                    int y = arr[1] + item[1];
                    if (isGrid(x, y))
                    {
                        sum+= grid[x][y];
                    }
                }
                return sum;
            }

            public int DiagonalSum(int value)
            {
                var arr = dict[value];
                int sum = 0;
                foreach (var item in dia)
                {
                    int x = arr[0] + item[0];
                    int y = arr[1] + item[1];
                    if (isGrid(x, y))
                    {
                        sum += grid[x][y];
                    }
                }
                return sum;
            }

            private bool isGrid(int x, int y)
            {
                if (x >= 0 && x < this.grid.Length && y >= 0 && y < this.grid[0].Length)
                {
                    return true;
                }
                return false;
            }
        }
    }
}
