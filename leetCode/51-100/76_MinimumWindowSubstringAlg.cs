using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._51_100
{
    public class _76_MinimumWindowSubstringAlg
    {
        public string MinWindow(string s, string t)
        {
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
            foreach (var item in arr)
            {
                sb.Clear();
                Dictionary<char, int> dictTemp = new Dictionary<char, int>(dict);
                int index = item;
                int count = 0;

                for (int i = item; i < n; i++)
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
