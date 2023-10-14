using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1_50
{
    internal class LongestCommonPrefixAlg
    {
        public string LongestCommonPrefix(string[] strs)
        {
            int len = 0;
            for (int i = 0; i < strs.Length; i++)
            {
                if (i == 0)
                {
                    len = strs[i].Length;
                }
                else
                {
                    if (strs[i].Length < len)
                    {
                        len = strs[i].Length;
                    }
                }
            }
            StringBuilder sb = new StringBuilder();
            char ch = char.MinValue;
            int count = 0;
            for (int i = 0; i < len; i++)
            {
                count = 0;
                for (int n = 0; n < strs.Length; n++)
                {
                    if (n == 0)
                    {
                        ch = strs[n][i];
                    }
                    else
                    {
                        if (ch == strs[n][i])
                        {
                            count++;
                        }
                    }

                }
                if (count == (strs.Length - 1))
                {
                    sb.Append(ch.ToString());
                }
                else
                {
                    return sb.ToString();
                }
            }
            return sb.ToString();
        }
    }
}
