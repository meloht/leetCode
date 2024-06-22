using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2651_2700
{
    public class _2663_LexicographicallySmallestBeautifulStringAlg
    {
        public string SmallestBeautifulString(string s, int k)
        {
            k += 'a';
            char[] ss = s.ToCharArray();
            int n = s.Length;
            int i = n - 1;
            ss[i]++;
            while (i < n)
            {
                if (ss[i] == k)
                {
                    if (i == 0)
                    {
                        return string.Empty;
                    }
                    ss[i] = 'a';
                    ss[--i]++;

                }
                else if (i > 0 && ss[i] == ss[i - 1] || i > 1 && ss[i] == ss[i - 2])
                {
                    ss[i]++;
                }
                else
                {
                    i++;
                }
            }
            return new string(ss);
        }
        public string SmallestBeautifulString1(string s, int k)
        {
            char[] arr = s.ToCharArray();
            for (int i = s.Length - 1; i >= 0; i--)
            {
                int c = s[i] - 'a';
                if (c >= k - 1)
                {
                    continue;
                }
                for (int h = c + 1; h <= k - 1; h++)
                {
                    var ch = (char)(h + 'a');
                    arr[i] = ch;
                    if (!IsStr(arr, i))
                    {
                        StringBuilder sb = new StringBuilder();
                        for (int j = 0; j < i; j++)
                        {
                            sb.Append(s[j]);
                        }
                        sb.Append(ch);

                        for (int j = i + 1; j < s.Length; j++)
                        {
                            int end = s[j] - 'a';
                            for (int i1 = 0; i1 < k; i1++)
                            {
                                var ch11 = (char)(i1 + 'a');

                                arr[j] = ch11;
                                if (!IsStr(arr, j))
                                {
                                    sb.Append(ch11);
                                    break;
                                }
                            }
                        }

                        return sb.ToString();
                    }
                }

            }

            return "";
        }
        private bool IsStr(char[] chs, int index)
        {
            bool bl = true;
            int count = 0;
            int i = 0;
            int j = index;
            while (i < j)
            {
                if (chs[i] == chs[j])
                {
                    count++;
                    j--;
                    bl = true;
                }
                else
                {
                    j = index;
                    bl = false;
                    count = 0;
                }
                i++;
            }

            if (bl && count > 0)
            {
                return true;
            }
            return false;
        }
    }
}
