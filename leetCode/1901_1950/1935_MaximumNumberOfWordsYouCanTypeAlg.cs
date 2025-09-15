using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1901_1950
{
    public class _1935_MaximumNumberOfWordsYouCanTypeAlg
    {
        public int CanBeTypedWords(string text, string brokenLetters)
        {
            bool[] chData = new bool[26];
            foreach (var item in brokenLetters)
            {
                chData[item - 'a'] = true;
            }
            int ans = 0;
            bool flag = true;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ' ' )
                {
                    if (flag)
                    {
                        ans++;
                    }
                    flag = true;
                }
                else
                {
                    if (chData[text[i] - 'a'])
                    {
                        flag = false;
                    }
                }
                if (i == text.Length - 1&&flag)
                {
                    ans++;
                }
            }
            return ans;
        }
    }
}
