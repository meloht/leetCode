using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0751_0800
{
    public class _784_LetterCasePermutationAlg
    {
        public IList<string> LetterCasePermutation(string s)
        {
            List<string> result = new List<string>();
            result.Add(s);
            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsLetter(s[i]))
                {
                    int count = result.Count;
                    for (int j = 0; j < count; j++)
                    {
                        char[] temp = result[j].ToCharArray();
                        temp[i] = char.IsUpper(s[i]) ? char.ToLower(s[i]) : char.ToUpper(s[i]);
                        result.Add(new string(temp));
                    }
                }
            }
            return result;
        }
    }
}
