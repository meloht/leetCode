using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0851_0900
{
    public class _859_BuddyStringsAlg
    {
        public bool BuddyStrings(string s, string goal)
        {
            if (s.Length != goal.Length)
                return false;
            int[] map = GetMap(s);
            int[] map2 = GetMap(goal);

            if (map.SequenceEqual(map2))
            {
                int n1 = map.Count(p => p > 0);
                int n2 = map2.Count(p => p > 0);
                if (n1 == n2 && n1 == goal.Length && s == goal)
                {
                    return false;
                }
                int num = 0;
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] != goal[i])
                    {
                        num++;
                    }
                }
                if (num > 2)
                {
                    return false;
                }
                return true;
            }
            return false;
        }
        private int[] GetMap(string s)
        {
            int[] map = new int[26];
            foreach (var item in s)
            {
                int index = item - 'a';
                map[index]++;
            }
            return map;
        }
    }
}
