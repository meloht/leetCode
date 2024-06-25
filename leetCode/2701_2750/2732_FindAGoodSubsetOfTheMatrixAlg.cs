using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2701_2750
{
    public class _2732_FindAGoodSubsetOfTheMatrixAlg
    {
        public IList<int> GoodSubsetofBinaryMatrix1(int[][] grid)
        {
            for (int i = 0; i < grid.Length; i++)
            {
                int cnt = 0;
                for (int j = 0; j < grid[0].Length; j++)
                {
                    if (grid[i][j] == 0)
                    {
                        cnt++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (cnt == grid[0].Length)
                {
                    return [i];
                }
            }
            for (int i = 0; i < grid.Length; i++)
            {

                for (int k = i + 1; k < grid.Length; k++)
                {
                    int cnt = 0;
                    for (int j = 0; j < grid[0].Length; j++)
                    {
                        if (grid[i][j] + grid[k][j] < 2)
                        {
                            cnt++;
                        }
                        else
                        {
                            break;
                        }
                    }
                    if (cnt == grid[0].Length)
                    {
                        return [i, k];
                    }
                }

            }

            return [];
        }

        public IList<int> GoodSubsetofBinaryMatrix(int[][] grid)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0; i < grid.Length; i++)
            {
                int mask = 0;
                for (int j = 0; j < grid[0].Length; j++)
                {
                    mask |= grid[i][j]<<j;
                }
                if (mask == 0)
                {
                    return [i];
                }
                if (dict.ContainsKey(mask))
                {
                    dict[mask] = i;
                }
                else
                {
                    dict.Add(mask,i);
                }
            }

            foreach (var item1 in dict)
            {
                foreach (var item2 in dict)
                {
                    if ((item1.Key & item2.Key) == 0)
                    {
                        return item1.Value > item2.Value ? [item2.Value, item1.Value] : [item1.Value, item2.Value];
                    }
                }
            }

            return [];
        }
    }
}
