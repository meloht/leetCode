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
