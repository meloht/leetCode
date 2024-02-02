using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1751_1800
{
    public class _1768_MergeStringsAlternatelyAlg
    {
        public string MergeAlternately(string word1, string word2)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0, j = 0; i < word1.Length || j < word2.Length; i++, j++)
            {
                if (i < word1.Length)
                {
                    sb.Append(word1[i]);
                }
                if (j < word2.Length)
                {
                    sb.Append(word2[i]);
                }
            }
            return sb.ToString();
        }
    }
}
