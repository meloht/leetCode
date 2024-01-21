using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCodeTemplates.字符串.KMP
{
    public class KMPAlgorithm
    {
        private int[] ComputeLPSArray(string pattern)
        {
            int m = pattern.Length;
            int[] lps = new int[m];
            int len = 0;
            int i = 1;

            while (i < m)
            {
                if (pattern[i] == pattern[len])
                {
                    len++;
                    lps[i] = len;
                    i++;
                }
                else
                {
                    if (len != 0)
                    {
                        len = lps[len - 1];
                    }
                    else
                    {
                        lps[i] = 0;
                        i++;
                    }
                }
            }

            return lps;
        }

        private void KMPSearch(string text, string pattern)
        {
            int n = text.Length;
            int m = pattern.Length;

            int[] lps = ComputeLPSArray(pattern);

            int i = 0; // index for text
            int j = 0; // index for pattern

            while (i < n)
            {
                if (pattern[j] == text[i])
                {
                    j++;
                    i++;
                }

                if (j == m)
                {
                    Console.WriteLine($"Found pattern at index {i - j}");
                    j = lps[j - 1];
                }
                else if (i < n && pattern[j] != text[i])
                {
                    if (j != 0)
                    {
                        j = lps[j - 1];
                    }
                    else
                    {
                        i++;
                    }
                }
            }
        }

        private void Test()
        {
            string text = "ABABDABACDABABCABAB";
            string pattern = "ABABCABAB";

            Console.WriteLine("Text: " + text);
            Console.WriteLine("Pattern: " + pattern);
            Console.WriteLine("Pattern found at indices:");

            KMPSearch(text, pattern);
        }
    }
}
