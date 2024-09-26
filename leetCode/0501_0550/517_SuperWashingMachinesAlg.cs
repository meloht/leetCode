﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0501_0550
{
    public class _517_SuperWashingMachinesAlg
    {
        public int FindMinMoves(int[] machines)
        {
            int tot = machines.Sum();
            int n = machines.Length;
            if (tot % n != 0)
            {
                return -1;
            }
            int avg = tot / n;
            int ans = 0, sum = 0;
            foreach (int num in machines)
            {
                int tmp = num - avg;
                sum += tmp;
                ans = Math.Max(ans, Math.Max(Math.Abs(sum), tmp));
            }
            return ans;

        }
    }
}
