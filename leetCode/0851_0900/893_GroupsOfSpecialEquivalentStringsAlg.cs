using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0851_0900
{
    public class _893_GroupsOfSpecialEquivalentStringsAlg
    {
        public int NumSpecialEquivGroups(string[] words)
        {
            HashSet<string> set = new HashSet<string>();

            foreach (string word in words)
            {
                char[] chars = new char[word.Length];
                int n1 = 0;
                int n2 = (word.Length + 1) / 2;
                for (int i = 0; i < word.Length; i++)
                {
                    if ((i & 1) == 0)
                    {
                        chars[n1++] = word[i];
                    }
                    else
                    {
                        chars[n2++] = word[i];
                    }
                }
                Array.Sort(chars, 0, word.Length / 2);
                Array.Sort(chars, word.Length / 2, (word.Length + 1) / 2);
                set.Add(new string(chars));
            }

            return set.Count;
        }
    }
}
