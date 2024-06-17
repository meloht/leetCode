using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0501_0550
{
    public class _522_LongestUncommonSubsequenceIIAlg
    {
        public int FindLUSlength(string[] strs)
        {
            var dict = strs.GroupBy(p => p).ToDictionary(p => p.Key, p => p.Count());

            List<string> list = dict.Keys.OrderByDescending(p => p.Length).ToList();

            for (int i = 0; i < list.Count; i++)
            {
                if (dict[list[i]] != 1)
                {
                    continue;
                }
                string s = list[i];
                bool bl = false;
                for (int j = 0; j < i; j++)
                {
                    string s2 = list[j];
                  
                    for (int k = 0, h = 0; k < s2.Length && h < s.Length; k++)
                    {
                        if (s2[k] == s[h])
                        {
                            if (h == s.Length - 1)
                            {
                                bl = true;
                                break;
                            }
                            h++;
                        }
                       
                    }
                    if (bl)
                    {
                        break;
                    }
                }

                if (bl==false)
                {
                    return s.Length;
                }
            }

            return -1;
        }
    }
}
