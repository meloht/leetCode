﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3201_3250
{
    public class _3259_MaximumEnergyBoostFromTwoDrinksAlg
    {
        public long MaxEnergyBoost(int[] energyDrinkA, int[] energyDrinkB)
        {
            int n = energyDrinkA.Length;
            long[,] d = new long[n + 1, 2];
            for (int i = 1; i <= n; i++)
            {
                d[i, 0] = d[i - 1, 0] + energyDrinkA[i - 1];
                d[i, 1] = d[i - 1, 1] + energyDrinkB[i - 1];
                if (i >= 2)
                {
                    d[i, 0] = Math.Max(d[i, 0], d[i - 2, 1] + energyDrinkA[i - 1]);
                    d[i, 1] = Math.Max(d[i, 1], d[i - 2, 0] + energyDrinkB[i - 1]);
                }
            }
            return Math.Max(d[n, 0], d[n, 1]);

        }
    }
}
