using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0151_0200
{
    public class _187_RepeatedDnaSequencesAlg
    {
        public IList<string> FindRepeatedDnaSequences(string s)
        {
            HashSet<string> res = new HashSet<string>();
            if (s.Length <= 10)
                return res.ToList();

            HashSet<string> set = new HashSet<string>();
           
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
            {
                if (i < 10)
                {
                    sb.Append(s[i]);
                    if (i == 9)
                    {
                        string ss = sb.ToString();
                        set.Add(ss);
                    }
                }
                else
                {
                    sb.Remove(0, 1);
                    sb.Append(s[i]);
                    string ss = sb.ToString();
                    if (set.Contains(ss))
                    {
                        res.Add(ss);
                    }
                    else
                    {
                        set.Add(ss);
                    }
                }
            }

            return res.ToList();
        }
    }
}
