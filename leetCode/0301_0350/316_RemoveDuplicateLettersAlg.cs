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
            List<int> list = new List<int>();
            foreach (var item in s)
            {
                int i = item - 'a';
                arr[i]++;
                if (arr[i] > 1)
                {
                    list.Add(i);
                }
            }
            list.Sort();

            for (int i = 0; i < s.Length; i++)
            {
                int k = s[i] - 'a';
                if (arr[k] > 1)
                {
                    
                }
            }


            return "";
        }
    }
}
