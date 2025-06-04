using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3401_3450
{
    public class _3403_FindTheLexicographicallyLargestStringFromTheBoxI
    {
        public string AnswerString1(string word, int numFriends)
        {
            if (numFriends == 1)
            {
                return word;
            }
            int n = word.Length;
            int i = 0;
            int j = 1;
            while (j < n)
            {
                int k = 0;
                while (j + k < n && word[i + k] == word[j + k])
                {
                    k++;
                }
                if (j + k < n && word[i + k] < word[j + k])
                {
                    int t = i;
                    i = j;
                    j = Math.Max(j + 1, t + k + 1);
                }
                else
                {
                    j += k + 1;
                }
            }
            return word.Substring(i, Math.Min(n - numFriends + 1, n - i));


        }
        public string AnswerString(string word, int numFriends)
        {
            if (numFriends == 1)
            {
                return word;
            }
            int n = word.Length;
            char ch = 'a';
            foreach (var item in word)
            {
                if (item > ch)
                {
                    ch = item;
                }
            }
            int len = n - numFriends + 1;
            int start = -1;
            int end = 0;

            List<int> list = new List<int>();
            for (int i = 0; i < n; i++)
            {
                if (word[i] == ch)
                {
                    list.Add(i);
                }
            }
            foreach (int i in list)
            {
                int d = Math.Min(i + len, n);
                if (start == -1)
                {
                    start = i;
                    end = d;
                }
                else
                {
                    int res = -1;
                    for (int j = i, k = start; j < d && k < end; j++, k++)
                    {
                        if (word[j] > word[k])
                        {
                            start = i;
                            end = d;
                            res = 1;
                            break;
                        }
                        else if (word[j] == word[k])
                        {
                            res = 0;
                        }
                        else
                        {
                            res = -1;
                            break;
                        }
                    }
                    if (res == 0&&(end-start)<(d-i))
                    {
                        start = i;
                        end = d;
                    }
                }

            }
            return word.Substring(start, end - start);
        }

        public string AnswerString2(string word, int numFriends)
        {
            if (numFriends == 1)
            {
                return word;
            }
            int n = word.Length;
            string ans = "";
            for (int i = 0; i < n; i++)
            {
                string sub = word.Substring(i, Math.Min(n - numFriends + 1, n - i));
                if (sub.CompareTo(ans) > 0)
                {
                    ans = sub;
                }
            }
            return ans;
        }

    }
}
