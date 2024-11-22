﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3201_3250
{
    public class _3233_FindTheCountOfNumbersWhichAreNotSpecialAlg
    {
        public int NonSpecialCount(int l, int r)
        {
            int n = (int)Math.Sqrt(r);
            int[] v = new int[n + 1];
            int res = r - l + 1;
            for (int i = 2; i <= n; i++)
            {
                if (v[i] == 0)
                {
                    if (i * i >= l && i * i <= r)
                    {
                        res--;
                    }
                    for (int j = i * 2; j <= n; j += i)
                    {
                        v[j] = 1;
                    }
                }
            }
            return res;

        }
    }
}
