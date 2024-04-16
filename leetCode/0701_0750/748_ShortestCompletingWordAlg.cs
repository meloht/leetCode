using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0701_0750
{
    public class _748_ShortestCompletingWordAlg
    {
        public string ShortestCompletingWord(string licensePlate, string[] words)
        {
            string ans = "";
            int min = int.MaxValue;
            int[] dict = new int[26];
            foreach (var item in licensePlate)
            {
                if (char.IsLetter(item))
                {
                    char ch = char.ToLower(item);
                    int index = ch - 'a';
                    dict[index]++;
                }
            }
            foreach (var item in words)
            {
                var res = item.GroupBy(x => x).ToDictionary(x => x.Key - 'a', x => x.Count());
                bool bl = true;
                for (int i = 0; i < dict.Length; i++)
                {
                    if (dict[i] > 0)
                    {
                        if (!res.ContainsKey(i))
                        {
                            bl = false;
                            break;

                        }
                        if (res[i] < dict[i])
                        {
                            bl = false;
                            break;
                        }
                    }
                }
               
                if (bl)
                {
                    if (item.Length < min)
                    {
                        ans = item;
                        min = item.Length;
                    }
                }
            }
            return ans;
        }
    }
}
