using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1_50
{
    internal class FindTheIndexOfTheFirstOccurrenceInAStringAlg
    {
        public int StrStr(string haystack, string needle)
        {

            int tSize = haystack.Length;
            int pSize = needle.Length;
            if (pSize > tSize)
                return -1;
            if (needle == "")
                return 0;
            int[] move = new int[256];
            for (int i = 0; i < 256; i++)
            {
                move[i] = pSize + 1;
            }
            for (int i = 0; i < pSize; i++)
            {
                move[needle[i]] = pSize - i;
            }

            int s = 0;//模式串头部在字符串位置

            int j = 0;//模式串已经匹配了的长度

            while (s <= tSize - pSize)
            {//到达末尾之前
                j = 0;
                while (haystack[s + j] == needle[j])
                {
                    j++;
                    if (j >= pSize)
                    {
                        return s;
                    }
                }
                if (s + pSize < tSize)
                {
                    s += move[haystack[s + pSize]];

                }
                else
                {
                    break;
                }

            }
            return -1;
        }
    }
}
