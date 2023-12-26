using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0151_0200
{
    public class _151_ReverseWordsInAStringAlg
    {
        public string ReverseWords(string s)
        {
            s = s.Trim();
            var ls = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            var res = ls.Reverse();

            return string.Join(" ", res);
        }
    }
}
