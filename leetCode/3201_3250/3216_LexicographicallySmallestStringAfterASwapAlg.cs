using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3201_3250
{
    public class _3216_LexicographicallySmallestStringAfterASwapAlg
    {
        public string GetSmallestString(string s)
        {
            char[] chars = s.ToCharArray();
            for (int i = 0; i < s.Length - 1; i++)
            {

                if (s[i] % 2 == s[i + 1] % 2 && s[i] > s[i + 1])
                {
                    char temp = chars[i];
                    chars[i] = chars[i + 1];
                    chars[i + 1] = temp;
                    break;
                }
            }
            return new string(chars);
        }
    }
}
