﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0801_0850
{
    public class _816_AmbiguousCoordinatesAlg
    {
        public IList<string> AmbiguousCoordinates(string s)
        {
            int n = s.Length - 2;
            IList<string> res = new List<string>();
            s = s.Substring(1, s.Length - 2);
            for (int l = 1; l < n; ++l)
            {
                IList<string> lt = GetPos(s.Substring(0, l));
                if (lt.Count == 0)
                {
                    continue;
                }
                IList<string> rt = GetPos(s.Substring(l));
                if (rt.Count == 0)
                {
                    continue;
                }
                foreach (string i in lt)
                {
                    foreach (string j in rt)
                    {
                        res.Add("(" + i + ", " + j + ")");
                    }
                }
            }
            return res;
        }

        public IList<string> GetPos(string s)
        {
            IList<string> pos = new List<string>();
            if (s[0] != '0' || "0".Equals(s))
            {
                pos.Add(s);
            }
            for (int p = 1; p < s.Length; ++p)
            {
                if ((p != 1 && s[0] == '0') || s[s.Length - 1] == '0')
                {
                    continue;
                }
                pos.Add(s.Substring(0, p) + "." + s.Substring(p));
            }
            return pos;
        }

    }
}
