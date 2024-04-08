using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0501_0550
{
    public class _521_LongestUncommonSubsequenceIAlg
    {
        public int FindLUSlength(string a, string b)
        {
            if (a != b)
                return Math.Max(a.Length, b.Length);
            return -1;
        }


    }
}
