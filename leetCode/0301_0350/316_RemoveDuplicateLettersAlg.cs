using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0301_0350
{
    public class _316_RemoveDuplicateLettersAlg
    {
        public string RemoveDuplicateLetters(string s)
        {
            int[] arr = new int[26];
            bool[] used = new bool[26];
            foreach (var item in s)
            {
                int i = item - 'a';
                arr[i]++;

            }
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
            {
                int index = s[i] - 'a';
                if (used[index] == false)
                {
                    while (sb.Length > 0 && sb[sb.Length - 1] > s[i])
                    {
                        if (arr[sb[sb.Length - 1] - 'a'] > 0)
                        {
                            used[sb[sb.Length - 1] - 'a'] = false;
                            sb.Remove(sb.Length - 1, 1);
                        }
                        else
                        {
                            break;
                        }
                    }
                    used[index] = true;
                    sb.Append(s[i]);
                }
                arr[index]--;
            }

            return sb.ToString();
        }
    }
}
