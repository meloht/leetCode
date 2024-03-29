﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1401_1450
{
    public class _1422_MaximumScoreAfterSplittingAStringAlg
    {
        public int MaxScore1(string s)
        {
            int[] suffix = new int[s.Length];
            int n = 0;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] == '1')
                {
                    n++;
                }
                suffix[i] = n;
            }
            n = 0;
            int ans = 0;
            int len = s.Length - 1;
            for (int i = 0; i < len; i++)
            {
                if (s[i] == '0')
                {
                    n++;
                }
                ans = Math.Max(ans, suffix[i + 1] + n);
            }
            return ans;
        }

        public int MaxScore(string s)
        {

            int n = 0;
            for (int i = 1; i < s.Length; i++)
            {
                if (s[i] == '1')
                {
                    n++;
                }
            }
            if (s[0] == '0')
            {
                n++;
            }
            int ans = n;
            int len = s.Length - 1;
            for (int i = 1; i < len; i++)
            {
                if (s[i] == '0')
                {
                    n++;
                }
                else
                {
                    n--;
                }
                ans = Math.Max(ans, n);
            }
            return ans;
        }
    }
}
