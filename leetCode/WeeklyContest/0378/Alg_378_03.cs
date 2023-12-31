using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode.WeeklyContest._0378
{
    public class Alg_378_03
    {

        public int MaximumLength(string s)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();

            string sss = s + "0";
            StringBuilder sb = new StringBuilder();
            sb.Append(sss[0]);
            for (int i = 1; i < sss.Length; i++)
            {
                var pre = sss[i - 1];
                var curr = sss[i];
                if (pre == curr)
                {
                    sb.Append(sss[i]);
                }
                else
                {
                    var ss = sb.ToString();
                    if (dict.ContainsKey(ss))
                    {
                        dict[ss]++;
                    }
                    else
                    {
                        dict.Add(ss, 1);
                    }
                    sb.Clear();
                    sb.Append(curr);
                }
            }
            int max = -1;
            foreach (var item in dict)
            {

                if (item.Value >= 3)
                {
                    max = Math.Max(item.Key.Length, max);
                }
                else if (item.Value < 2 && item.Key.Length >= 3)
                {
                    int len = item.Key.Length - 2;
                    max = Math.Max(len, max);
                }
                else if (item.Value == 2 && item.Key.Length >= 2)
                {
                    int len = item.Key.Length - 1;
                    max = Math.Max(len, max);
                }
                if (item.Key.Length >= 2)
                {
                    int len = item.Key.Length - 1;
                    int maxlen = len;
                    string key = item.Key.Substring(0, len);
                    while (maxlen > max)
                    {
                        if (dict.ContainsKey(key))
                        {
                            max = maxlen;
                            break;
                        }
                        else
                        {
                            len--;
                            maxlen = len;
                            if (len < 1)
                                break;
                            key = item.Key.Substring(0, len);
                        }
                    }
                }
            }
            return max;
        }


    }
}
