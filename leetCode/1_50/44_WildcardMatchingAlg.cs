using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1_50
{
    public class _44_WildcardMatchingAlg
    {
        public bool IsMatch(string s, string p)
        {
            bool blX = p.Contains("*");
            bool blY = p.Contains("?");
            if (!blX && !blY)
                return s == p;

            if (p == "*")
                return true;

            if (!blX && p.Length != s.Length)
            {
                return false;
            }
            if (blX)
            {
                string item = p.Replace("*", "");
                if (item.Length > s.Length)
                    return false;

                if (item.Length == s.Length)
                {
                    p = item;
                }
                if (p == s)
                {
                    return true;
                }
            }
            if (p[p.Length - 1] != s[s.Length - 1] && p[p.Length - 1] != '*' && p[p.Length-1] != '?')
            {
                return false;
            }
            if (blX)
            {
                if (p.Length == s.Length)
                {
                    for (int i = 0; i < s.Length; i++)
                    {
                        if (p[i] != '*' && p[i] != '?' && p[i] != s[i])
                        {
                            return false;
                        }
                    }
                    return true;
                }
                else
                {
                    int i = 0, j = 0;
                    while (i < s.Length && j < p.Length)
                    {
                        if (p[j] != '*')
                        {
                            if (p[j] != '?' && p[j] != s[i])
                            {
                                return false;
                            }
                        }
                        else
                        {
                            if (p[j] == '*' && j == p.Length - 1)
                            {
                                return true;
                            }

     
                            string pp = p.Substring(j + 1);
                            int nextIndex = j + 1;
                            int starIndex = pp.IndexOf("*");
                            string nextItem = pp;

                            if (starIndex != -1)
                            {
                                nextItem = pp.Substring(0, starIndex);
                                j = nextIndex + starIndex;
                            }
                            else
                            {
                                j = nextIndex + nextItem.Length;
                            }

                            int questionIndex = nextItem.IndexOf("?");
                            if (questionIndex != -1)
                            {
                                nextItem = nextItem.Substring(0, questionIndex);
                                j = nextIndex + questionIndex;
                            }

                            var sIndex = s.Substring(i).IndexOf(nextItem);
                            if (sIndex == 0)
                            {
                                sIndex = s.Substring(i + 1).IndexOf(nextItem);
                                i = sIndex + nextItem.Length + i + 1;
                                continue;
                            }
                            else if (sIndex > 0)
                            {
                                i = sIndex + nextItem.Length + i;
                                continue;
                            }
                            else
                            {
                                return false;
                            }


                        }
                        i++;
                        j++;
                    }

                   
                    return true;
                }
            }
            else
            {
                for (int i = 0; i < s.Length; i++)
                {
                    if (p[i] != '?' && p[i] != s[i])
                    {
                        return false;
                    }
                }
                return true;
            }

        }

    }
}
