using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0801_0850
{
    public class _811_SubdomainVisitCountAlg
    {
        public IList<string> SubdomainVisits(string[] cpdomains)
        {
            List<string> list = new List<string>();
            Dictionary<string, int> dict = new Dictionary<string, int>();

            foreach (var item in cpdomains)
            {
                int num = 0;
                int i = 0;
                for (; i < item.Length; i++)
                {
                    if (item[i] == ' ')
                        break;

                    num = num * 10 + item[i] - '0';
                }

                i++;
                string sub = item.Substring(i);
                string[] arr = sub.Split('.', StringSplitOptions.RemoveEmptyEntries);
                StringBuilder sb = new StringBuilder();
                for (int j = arr.Length - 1; j >= 0; j--)
                {
                    if (sb.Length == 0)
                    {
                        sb.Append(arr[j]);
                    }
                    else
                    {
                        sb.Insert(0, '.');
                        sb.Insert(0, arr[j]);
                    }

                    AddNum(dict, sb.ToString(), num);
                }


            }

            foreach (var item in dict)
            {
                list.Add($"{item.Value} {item.Key}");
            }

            return list;
        }

        private void AddNum(Dictionary<string, int> dict, string key, int num)
        {
            if (dict.ContainsKey(key))
            {
                dict[key] += num;
            }
            else
            {
                dict.Add(key, num);
            }
        }


    }
}
