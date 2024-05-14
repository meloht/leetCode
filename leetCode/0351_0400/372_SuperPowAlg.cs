﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0351_0400
{
    public class _372_SuperPowAlg
    {
        const int MOD = 1337;

        public int SuperPow(int a, int[] b)
        {
            int ans = 1;
            for (int i = b.Length - 1; i >= 0; --i)
            {
                ans = (int)((long)ans * Pow(a, b[i]) % MOD);
                a = Pow(a, 10);
            }
            return ans;
        }

        public int Pow(int x, int n)
        {
            int res = 1;
            while (n != 0)
            {
                if (n % 2 != 0)
                {
                    res = (int)((long)res * x % MOD);
                }
                x = (int)((long)x * x % MOD);
                n /= 2;
            }
            return res;
        }


    }
}
