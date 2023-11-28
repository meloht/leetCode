using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._51_100
{
    public class _76_MinimumWindowSubstringAlg
    {
        public string MinWindow2(string s, string t)
        {
            if (s.Length < t.Length)
                return string.Empty;

            int n = s.Length;
            Dictionary<char, int> dict = new Dictionary<char, int>();
            foreach (char c in t)
            {
                if (!dict.ContainsKey(c))
                {
                    dict.Add(c, 1);
                }
                else
                {
                    dict[c]++;
                }
            }
            int begin = 0;
            for (int i = 0; i < n; i++)
            {
                if (dict.ContainsKey(s[i]))
                {
                    begin = i;
                    break;
                }
            }
            int min = n + 1;
            string res = "";
            Dictionary<char, int> dictTemp = new Dictionary<char, int>(dict);
            List<char> list = new List<char>();
            for (int i = begin; i < n; i++)
            {
                char ch = s[i];
                list.Add(ch);
                if (dictTemp.ContainsKey(s[i]))
                {
                    dictTemp[s[i]]--;
                    if (dictTemp[s[i]] == 0)
                    {
                        dictTemp.Remove(s[i]);
                        if (dictTemp.Count == 0)
                        {
                            begin = i + 1;
                            min = list.Count;
                            res = string.Join("", list);
                            break;
                        }
                    }
                }
            }

            for (int i = begin; i < n; i++)
            {

            }

            return null;
        }
        public string MinWindow(string s, string t)
        {
            if (s.Length < t.Length)
                return string.Empty;

            int n = s.Length;
            Dictionary<char, int> dict = new Dictionary<char, int>();
            foreach (char c in t)
            {
                if (!dict.ContainsKey(c))
                {
                    dict.Add(c, 1);
                }
                else
                {
                    dict[c]++;
                }
            }
            List<int> arr = new List<int>();
            for (int i = 0; i < n; i++)
            {
                if (dict.ContainsKey(s[i]))
                {
                    arr.Add(i);
                }
            }
            if (arr.Count == 0 || arr.Count < t.Length)
                return string.Empty;

            string res = "";
            int min = n + 1;
            StringBuilder sb = new StringBuilder();
            bool bl = false;
            for (int j = 0; j < arr.Count; j++)
            {
                if (bl)
                {
                    int total = n - arr[j];
                    if (total < t.Length)
                        break;

                    bl = false;
                }
                sb.Clear();
                Dictionary<char, int> dictTemp = new Dictionary<char, int>(dict);

                int count = 0;

                for (int i = arr[j]; i < n; i++)
                {
                    sb.Append(s[i]);
                    if (dictTemp.ContainsKey(s[i]))
                    {
                        dictTemp[s[i]]--;
                        if (dictTemp[s[i]] == 0)
                        {
                            dictTemp.Remove(s[i]);
                            if (dictTemp.Count == 0)
                            {
                                if ((count + 1) < min)
                                {
                                    res = sb.ToString();
                                    min = count + 1;
                                    bl = true;
                                    break;
                                }
                            }
                        }
                    }

                    count++;
                }

            }
            return res;
        }


    }
}
