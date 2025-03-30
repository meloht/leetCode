using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2101_2150
{
    public class _2109_AddingSpacesToAStringAlg
    {
        public string AddSpaces(string s, int[] spaces)
        {
            StringBuilder sb = new StringBuilder();
            bool[] arr = new bool[s.Length];
         
            for (int i = 0; i < spaces.Length; i++)
            {
                arr[spaces[i]] = true;
            }

            for (int i = 0; i < s.Length; i++)
            {
                if (arr[i])
                {
                    sb.Append(' ');
                }
                sb.Append(s[i]);
            }

            return sb.ToString();
        }
    }
}
