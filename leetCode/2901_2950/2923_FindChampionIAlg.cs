using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2901_2950
{
    public class _2923_FindChampionIAlg
    {
        public int FindChampion1(int[][] grid)
        {
            HashSet<int> result = new HashSet<int>();
            HashSet<int> failed = new HashSet<int>();
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    if (i != j)
                    {
                        if (grid[i][j] == 1)
                        {

                            if (!failed.Contains(i))
                            {
                                result.Add(i);
                            }
                            failed.Add(j);
                            result.Remove(j);
                        }
                        else
                        {
                            if (!failed.Contains(j))
                            {
                                result.Add(j);
                            }

                            failed.Add(i);
                            result.Remove(i);
                        }
                    }
                   
                }
            }
            if (result.Count > 0)
            {
                return result.First();
            }
            return 0;
        }
        public int FindChampion(int[][] grid)
        {
            int n = grid.Length;
            for (int i = 0; i < n; i++)
            {
                int[] line = grid[i];
                int sum = line.Sum();
                if (sum == n - 1)
                {
                    return i;
                }
            }
            return -1;
        }


    }
}
