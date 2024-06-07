﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0351_0400
{
    public class _400_NthDigitAlg
    {
        public int FindNthDigit(int n)
        {
            int low = 1, high = 9;
            while (low < high)
            {
                int mid = (high - low) / 2 + low;
                if (TotalDigits(mid) < n)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid;
                }
            }
            int d = low;
            int prevDigits = TotalDigits(d - 1);
            int index = n - prevDigits - 1;
            int start = (int)Math.Pow(10, d - 1);
            int num = start + index / d;
            int digitIndex = index % d;
            int digit = (num / (int)(Math.Pow(10, d - digitIndex - 1))) % 10;
            return digit;


        }


        public int TotalDigits(int length)
        {
            int digits = 0;
            int curLength = 1, curCount = 9;
            while (curLength <= length)
            {
                digits += curLength * curCount;
                curLength++;
                curCount *= 10;
            }
            return digits;
        }

    }
}
