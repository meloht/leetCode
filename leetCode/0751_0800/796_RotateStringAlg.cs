using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0751_0800
{
    public class _796_RotateStringAlg
    {
        public bool RotateString(string s, string goal)
        {
            List<char> list = new List<char>(s);
            for (int i = 0; i < s.Length; i++)
            {
                list.Add(s[i]);
                list.RemoveAt(0);
                if (goal == new string(list.ToArray()))
                {
                    return true;
                }
            }
            return false;
        }

        public bool RotateString1(string s, string goal)
        {
            return s.Length == goal.Length && (s + s).Contains(goal);
        }


    }
}
