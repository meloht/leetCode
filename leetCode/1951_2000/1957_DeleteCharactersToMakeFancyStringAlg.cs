using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1951_2000
{
    public class _1957_DeleteCharactersToMakeFancyStringAlg
    {
        public string MakeFancyString(string s)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < s.Length; i++)
            {
                if (sb.Length < 2)
                {
                    sb.Append(s[i]);
                }
                else
                {
                    if (sb[sb.Length - 2] == s[i] && sb[sb.Length - 1] == s[i])
                    {
                        continue;
                    }
                    sb.Append(s[i]);
                }
            }

            return sb.ToString();
        }
    }
}
