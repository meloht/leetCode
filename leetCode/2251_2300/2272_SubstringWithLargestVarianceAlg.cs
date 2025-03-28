﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2251_2300
{
    public class _2272_SubstringWithLargestVarianceAlg
    {
        public int LargestVariance(string s)
        {
            var pos = new Dictionary<char, List<int>>();
            for (int i = 0; i < s.Length; i++)
            {
                char ch = s[i];
                if (!pos.ContainsKey(ch)) pos[ch] = new List<int>();
                pos[ch].Add(i);
            }

            int ans = 0;
            foreach (var c0 in pos)
            {
                foreach (var c1 in pos)
                {
                    if (c0.Key != c1.Key)
                    {
                        List<int> pos0 = c0.Value;
                        List<int> pos1 = c1.Value;
                        int i = 0, j = 0;
                        int f = 0, g = int.MinValue;
                        while (i < pos0.Count || j < pos1.Count)
                        {
                            if (j == pos1.Count || (i < pos0.Count && pos0[i] < pos1[j]))
                            {
                                f = Math.Max(f, 0) + 1;
                                g = g + 1;
                                i++;
                            }
                            else
                            {
                                g = Math.Max(f, Math.Max(g, 0)) - 1;
                                f = Math.Max(f, 0) - 1;
                                j++;
                            }
                            ans = Math.Max(ans, g);
                        }
                    }
                }
            }
            return ans;

        }
    }
}
