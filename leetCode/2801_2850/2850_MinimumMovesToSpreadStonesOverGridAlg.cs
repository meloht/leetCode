﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2801_2850
{
    public class _2850_MinimumMovesToSpreadStonesOverGridAlg
    {
        public int MinimumMoves(int[][] grid)
        {
            IList<int[]> more = new List<int[]>();
            IList<int[]> less = new List<int[]>();
            for (int i = 0; i < 3; ++i)
            {
                for (int j = 0; j < 3; ++j)
                {
                    if (grid[i][j] > 1)
                    {
                        for (int k = 2; k <= grid[i][j]; ++k)
                        {
                            more.Add(new int[] { i, j });
                        }
                    }
                    else if (grid[i][j] == 0)
                    {
                        less.Add(new int[] { i, j });
                    }
                }
            }

            int ans = int.MaxValue;
            do
            {
                int steps = 0;
                for (int i = 0; i < more.Count; i++)
                {
                    steps += Math.Abs(less[i][0] - more[i][0]) + Math.Abs(less[i][1] - more[i][1]);
                }
                ans = Math.Min(ans, steps);
            } while (NextPermutation(more));
            return ans;
        }

        public bool NextPermutation(IList<int[]> more)
        {
            int p = -1;
            for (int idx = 0; idx < more.Count - 1; idx++)
            {
                if (IsLess(more[idx], more[idx + 1]))
                {
                    p = idx;
                }
            }
            if (p == -1)
            {
                return false;
            }
            int q = -1;
            for (int idx = p + 1; idx < more.Count; idx++)
            {
                if (IsLess(more[p], more[idx]))
                {
                    q = idx;
                }
            }
            Swap(more, p, q);
            int i = p + 1, j = more.Count - 1;
            while (i < j)
            {
                Swap(more, i, j);
                i++;
                j--;
            }
            return true;
        }

        public bool IsLess(int[] pair1, int[] pair2)
        {
            return pair1[0] < pair2[0] || (pair1[0] == pair2[0] && pair1[1] < pair2[1]);
        }

        public void Swap(IList<int[]> more, int index1, int index2)
        {
            int[] temp = more[index1];
            more[index1] = more[index2];
            more[index2] = temp;
        }

    }
}
