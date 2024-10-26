using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0501_0550
{
    public class _524_LongestWordInDictionaryThroughDeletingAlg
    {
        public string FindLongestWord(string s, IList<string> dictionary)
        {
            string res = "";
            foreach (string s2 in dictionary)
            {
                int idx = 0;
                int sidx = 0;
                while (idx < s.Length && sidx < s2.Length)
                {
                    if (s2[sidx] == s[idx])
                    {
                        sidx++;
                    }
                    idx++;
                }
                if (sidx == s2.Length)
                {
                    if (s2.Length > res.Length || (s2.Length == res.Length && s2.CompareTo(res) < 0))
                    {
                        res = s2;
                    }
                }
            }
           
            return res;
        }
    }
}
