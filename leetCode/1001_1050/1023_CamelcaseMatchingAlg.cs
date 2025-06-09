using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1001_1050
{
    public class _1023_CamelcaseMatchingAlg
    {
        public IList<bool> CamelMatch(string[] queries, string pattern)
        {
            bool[] ans = new bool[queries.Length];
            int idx = 0;
            foreach (var item in queries)
            {
                int[] arr = new int[26];
                bool flag = true;
                for (int i = 0, j = 0; i < item.Length || j < pattern.Length;)
                {
                    while (i < item.Length && char.IsAsciiLetterLower(item[i]))
                    {
                        arr[item[i] - 'a']++;
                        i++;
                    }
                    while (j < pattern.Length && char.IsAsciiLetterLower(pattern[j]))
                    {
                        if (arr[pattern[j] - 'a'] == 0)
                        {
                            flag = false;
                            break;
                        }
                        else
                        {
                            arr[pattern[j] - 'a']--;
                        }
                        j++;
                    }
                    if (!flag)
                    {
                        break;
                    }
                    if (i < item.Length && j < pattern.Length && char.IsAsciiLetterUpper(item[i]) && item[i] == pattern[j])
                    {
                        Array.Fill(arr, 0);
                        i++;
                        j++;
                    }
                    else if (i < item.Length && j < pattern.Length && char.IsAsciiLetterUpper(item[i]) && item[i] != pattern[j])
                    {
                        flag = false;
                        break;
                    }
                    else if (i < item.Length && char.IsAsciiLetterUpper(item[i]) && j >= pattern.Length)
                    {
                        flag = false;
                        break;
                    }
                    else if (j < pattern.Length && char.IsAsciiLetterUpper(pattern[j]) && i >= item.Length)
                    {
                        flag = false;
                        break;
                    }
                    else if (j >= pattern.Length || i >= item.Length)
                    {
                        break;
                    }
                }
                if (flag)
                {
                    ans[idx] = true;
                }
                idx++;
            }
            return ans;
        }

        public IList<bool> CamelMatch1(string[] queries, string pattern)
        {
            int len = queries.Length, lenP = pattern.Length;
            bool[] res = new bool[len];
            for (int k = 0; k < len; k++)
            {
                int i = 0, j = 0;
                int lenQ = queries[k].Length;
                while (i < lenQ && j < lenP)
                {
                    if (queries[k][i] == pattern[j])
                    {
                        j++;
                    }
                    else if (char.IsAsciiLetterUpper(queries[k][i])) 
                        break;
                    i++;
                }
                while (i < lenQ && char.IsAsciiLetterLower(queries[k][i])) 
                    i++;
                res[k] = (j == lenP && i == lenQ);
            }
            return res;

        }
    }
}
