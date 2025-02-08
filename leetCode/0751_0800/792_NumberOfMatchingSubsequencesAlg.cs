﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0751_0800
{
    public class _792_NumberOfMatchingSubsequencesAlg
    {
        public int NumMatchingSubseq(string s, string[] words)
        {
            IList<int>[] pos = new IList<int>[26];
            for (int i = 0; i < 26; ++i)
            {
                pos[i] = new List<int>();
            }
            for (int i = 0; i < s.Length; ++i)
            {
                pos[s[i] - 'a'].Add(i);
            }
            int res = words.Length;
            foreach (string w in words)
            {
                if (w.Length > s.Length)
                {
                    --res;
                    continue;
                }
                int p = -1;
                for (int i = 0; i < w.Length; ++i)
                {
                    char c = w[i];
                    int idx = pos[c - 'a'].Count - 1;
                    if (pos[c - 'a'].Count == 0 || pos[c - 'a'][idx] <= p)
                    {
                        --res;
                        break;
                    }
                    p = BinarySearch(pos[c - 'a'], p);
                }
            }
            return res;


        }

        public int BinarySearch(IList<int> list, int target)
        {
            int left = 0, right = list.Count - 1;
            while (left < right)
            {
                int mid = left + (right - left) / 2;
                if (list[mid] > target)
                {
                    right = mid;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return list[left];
        }

    }
}
