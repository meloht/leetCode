using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0801_0850
{
    public class _804_UniqueMorseCodeWordsAlg
    {
        public int UniqueMorseRepresentations(string[] words)
        {
            string[] map = [".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.."];

            HashSet<string> set=new HashSet<string>();
            foreach (string word in words) 
            {
                StringBuilder sb = new StringBuilder();
                foreach (char c in word) 
                {
                    int i = c - 'a';
                    sb.Append(map[i]);
                }
                set.Add(sb.ToString());
            }

            return set.Count;
        }
    }
}
