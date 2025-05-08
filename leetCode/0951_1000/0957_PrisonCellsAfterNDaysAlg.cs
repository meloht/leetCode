using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0951_1000
{
    public class _0957_PrisonCellsAfterNDaysAlg
    {
        public int[] PrisonAfterNDays(int[] cells, int n)
        {
            int[] arr = new int[cells.Length];


            int state = 0;
            for (int i = 0; i < 8; i++)
            {
                if (cells[i] > 0)
                {
                    state ^= 1 << i;
                }
            }

            Dictionary<int, int> dict = new Dictionary<int, int>();
            while (n > 0)
            {
                // If this is a cycle, fast forward by
                // seen.get(state) - N, the period of the cycle.
                if (dict.ContainsKey(state))
                {
                    n %= dict[state] - n;
                    dict[state] = n;
                }
                else
                {
                    dict.Add(state, n);
                }



                if (n >= 1)
                {
                    n--;
                    state = NextDay(state);
                }
            }

            int[] ans = new int[8];
            for (int i = 0; i < 8; ++i)
            {
                if (((state >> i) & 1) > 0)
                {
                    ans[i] = 1;
                }
            }

            return ans;
        }

        public int NextDay(int state)
        {
            int ans = 0;

            // We only loop from 1 to 6 because 0 and 7 are impossible,
            // as those cells only have one neighbor.
            for (int i = 1; i <= 6; ++i)
            {
                if (((state >> (i - 1)) & 1) == ((state >> (i + 1)) & 1))
                {
                    ans ^= 1 << i;
                }
            }

            return ans;
        }


    }
}
