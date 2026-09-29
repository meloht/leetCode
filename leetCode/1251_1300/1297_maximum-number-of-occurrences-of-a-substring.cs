using System;
using System.Collections.Generic;
using System.Text;

namespace leetCode._1251_1300
{
    public class _1297_maximum_number_of_occurrences_of_a_substring
    {
        public int MaxFreq(string s, int maxLetters, int minSize, int maxSize)
        {
            Dictionary<string, int> strCnt = new Dictionary<string, int>();
            int[] charCnt= new int[26];
            int kinds = 0;
            int ans = 0;
            for (int i = 0; i < s.Length; i++)
            {
                int inum = s[i] - 'a';
                if (charCnt[inum] == 0)
                {
                    kinds++;
                }
                charCnt[inum]++;

                int left = i - minSize + 1;
                if (left < 0)
                {
                    continue;
                }

                if (kinds <= maxLetters)
                {
                    string subStr = s.Substring(left,  minSize);
     
                    if (strCnt.ContainsKey(subStr))
                    {
                        strCnt[subStr]++;
                    }
                    else
                    {
                        strCnt.Add(subStr, 1);
                    }
                    int cnt = strCnt[subStr];
                    ans = Math.Max(ans, cnt);
                }

                int outNum = s[left] - 'a';
                charCnt[outNum]--;
                if (charCnt[outNum] == 0)
                {
                    kinds--;
                }


            }
            return ans;
        }
    }
}
