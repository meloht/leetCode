using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1_50
{
    internal class LongestPalindromeAlg
    {
        public string LongestPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s))
                return string.Empty;
            if (s.Length == 1)
                return s;
            string news = GetNewString(s);
            int i;
            int mx = 0;
            int id = 0;
            int[] p = new int[news.Length - 1];
            for (i = 1; i < news.Length - 1; i++)
            {
                if (mx > i)
                    p[i] = Math.Min(p[2 * id - i], mx - i);
                else
                    p[i] = 1;

                while (i + p[i] < news.Length && i - p[i] < news.Length && news[i + p[i]] == news[i - p[i]])
                {
                    p[i]++;
                }
                if (p[i] + i > mx)
                {
                    mx = p[i] + i;
                    id = i;
                }
            }
            int max = 0;
            int maxIndex = 0;
            for (int n = 0; n < p.Length; n++)
            {
                if (p[n] > max)
                {
                    max = p[n];
                    maxIndex = n;
                }
            }
            int begin = maxIndex - (max - 1);
            string ss = news.Substring(begin, 2 * max - 1);
            return ss.Replace("#", "").Replace("$", "");
        }
        public static string GetNewString(string s)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("$");
            foreach (var item in s)
            {
                sb.Append("#");
                sb.Append(item.ToString());

            }
            sb.Append("#");
            sb.Append("$");
            return sb.ToString();
        }
    }
}
