using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode.WeeklyContest._0378
{
    public class Alg_378_02
    {
        public int MaximumLength(string s)
        {
            string ss = s;
            int max = s.Length - 2;

            int count = 0;
            int maxLen = -1;
            for (int i = 1; i <= max; i++)
            {
                count = 0;
                ss = s;
                string target = null;
                for (int j = 0; j < max; j++)
                {
                    count = 0;
                    target = null;
                    ss = s.Substring(j);
                    while (target == null && ss.Length > 0)
                    {
                        target = GetChildStr(ss, i);
                        if (target == null)
                        {
                            ss = ss.Substring(1);
                        }
                    }

                    while (ss.Length > 0 && !string.IsNullOrEmpty(target))
                    {

                        int index = ss.IndexOf(target);
                        if (index != -1)
                        {
                            count++;
                            if (count == 3)
                            {
                                maxLen = i;
                                break;
                            }
                            ss = ss.Substring(index + 1);
                        }
                        else
                        {
                            break;
                        }

                    }
                  
                    if (maxLen == i)
                        break;
                }

            }

            return maxLen;
        }
        private string GetChildStr(string s, int len)
        {
            if (s.Length < len)
                return null;
            if (len == 1)
                return s.Substring(0, len);

            char ch = s[0];
            StringBuilder sb = new StringBuilder();
            sb.Append(ch);
            for (int i = 1; i < len; i++)
            {
                if (s[i] != ch)
                    return null;
                sb.Append(s[i]);
            }

            return sb.ToString();
        }



    }
}
