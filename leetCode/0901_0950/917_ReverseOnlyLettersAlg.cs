using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0901_0950
{
    public class _917_ReverseOnlyLettersAlg
    {
        public string ReverseOnlyLetters(string s)
        {
            List<char> ls = new List<char>();
            foreach (var item in s)
            {
                if (char.IsLetter(item))
                {
                    ls.Add(item);
                }
            }
            ls.Reverse();
            char[] ss = s.ToCharArray();
            int j = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (Char.IsLetter(ss[i]))
                {
                    ss[i] = ls[j];
                    j++;
                }
            }
            return new string(ss);
        }
    }
}
