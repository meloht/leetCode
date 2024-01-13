using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2101_2150
{
    public class _2182_ConstructStringWithRepeatLimitAlg
    {
        public string RepeatLimitedString1(string s, int repeatLimit)
        {
            int[] dict = new int[26];
            List<char> charList = new List<char>();
            InitDict(charList, dict, s);

            Queue<char> queue = new Queue<char>();
            StringBuilder sb = new StringBuilder();
            foreach (char c in charList)
            {
                int i = c - 'a';
                while (queue.Count > 0 && dict[i] > 0)
                {
                    char c2 = queue.Peek();

                    AddChar(sb, c, dict, i, 1);

                    int i2 = c2 - 'a';
                    if (dict[i2] > repeatLimit)
                    {
                        AddChar(sb, c2, dict, i2, repeatLimit);
                    }
                    else
                    {
                        AddChar(sb, c2, dict, i2, dict[i2]);
                        queue.Dequeue();
                    }
                }

                if (dict[i] > repeatLimit)
                {
                    AddChar(sb, c, dict, i, repeatLimit);
                    queue.Enqueue(c);
                }
                else
                {
                    AddChar(sb, c, dict, i, dict[i]);
                }
            }

            return sb.ToString(); ;
        }
        private void AddChar(StringBuilder sb, char c, int[] dict, int index, int count)
        {
            for (int j = 0; j < count; j++)
            {
                sb.Append(c);
            }

            dict[index] -= count;
            if (dict[index] < 0)
            {
                dict[index] = 0;
            }
        }
        private void InitDict(List<char> charList, int[] dict, string s)
        {
            char[] chars = s.ToCharArray();
            foreach (char c in chars)
            {
                int i = c - 'a';
                if (dict[i] == 0)
                {
                    charList.Add(c);
                }
                dict[i]++;
            }
            charList.Sort((x, y) => y.CompareTo(x));
        }

        const int N = 26;
        public string RepeatLimitedString(string s, int repeatLimit)
        {
            int[] count = new int[N];
            foreach (char c in s)
            {
                count[c - 'a']++;
            }
            StringBuilder ret = new StringBuilder();
            int m = 0;
            for (int i = N - 1, j = N - 2; i >= 0 && j >= 0;)
            {
                if (count[i] == 0)
                { // 当前字符已经填完，填入后面的字符，重置 m
                    m = 0;
                    i--;
                }
                else if (m < repeatLimit)
                { // 当前字符未超过限制
                    count[i]--;
                    ret.Append((char)('a' + i));
                    m++;
                }
                else if (j >= i || count[j] == 0)
                { // 当前字符已经超过限制，查找可填入的其他字符
                    j--;
                }
                else
                { // 当前字符已经超过限制，填入其他字符，并且重置 m
                    count[j]--;
                    ret.Append((char)('a' + j));
                    m = 0;
                }
            }
            return ret.ToString();
        }


    }
}
