﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode
{
    internal class Utils
    {
        public static int gcd(int a, int b)
        {
            return b != 0 ? gcd(b, a % b) : a;
        }

        public static int GCD(int a, int b)
        {
            while (b != 0)
            {
                int tmp = a % b;
                a = b;
                b = tmp;
            }
            return a;
        }


    }
}
