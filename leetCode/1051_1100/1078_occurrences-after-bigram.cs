using System;
using System.Collections.Generic;
using System.Text;

namespace leetCode._1051_1100
{
    public class _1078_occurrences_after_bigram
    {
        public string[] FindOcurrences(string text, string first, string second)
        {
            List<string> ans = new List<string>();


            string[] arr = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < arr.Length - 2; i++)
            {
                string s1 = arr[i];
                string s2 = arr[i + 1];
                string s3 = arr[i + 2];
                if (s1 == first && s2 == second)
                {
                    ans.Add(s3);
                }
            }

            return ans.ToArray();
        }
    }
}
