﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0551_0600
{
    public class _564_FindTheClosestPalindromeAlg
    {
        public string NearestPalindromic(string n)
        {
            long selfNumber = long.Parse(n), ans = -1;
            IList<long> candidates = GetCandidates(n);
            foreach (long candidate in candidates)
            {
                if (candidate != selfNumber)
                {
                    if (ans == -1 ||
                        Math.Abs(candidate - selfNumber) < Math.Abs(ans - selfNumber) ||
                        Math.Abs(candidate - selfNumber) == Math.Abs(ans - selfNumber) && candidate < ans)
                    {
                        ans = candidate;
                    }
                }
            }
            return ans.ToString();
        }

        public IList<long> GetCandidates(String n)
        {
            int len = n.Length;
            IList<long> candidates = new List<long>();
            candidates.Add((long)Math.Pow(10, len - 1) - 1);
            candidates.Add((long)Math.Pow(10, len) + 1);
            long selfPrefix = long.Parse(n.Substring(0, (len + 1) / 2));
            for (long i = selfPrefix - 1; i <= selfPrefix + 1; i++)
            {
                StringBuilder sb = new StringBuilder();
                string prefix = i.ToString();
                sb.Append(prefix);
                StringBuilder suffix = new StringBuilder();
                for (int j = prefix.Length - 1 - (len & 1); j >= 0; j--)
                {
                    suffix.Append(prefix[j]);
                }
                sb.Append(suffix);
                string candidate = sb.ToString();
                try
                {
                    candidates.Add(long.Parse(candidate));
                }
                catch (OverflowException ex)
                {
                    continue;
                }
            }
            return candidates;
        }

    }
}
