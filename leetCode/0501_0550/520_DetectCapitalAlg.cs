using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0501_0550
{
    public class _520_DetectCapitalAlg
    {
        public bool DetectCapitalUse(string word)
        {
            if (word.Length == 1)
                return true;

            if (char.IsUpper(word[0]) && char.IsUpper(word[1]))
            {
                for (int i = 1; i < word.Length; i++)
                {
                    if (char.IsLower(word[i]))
                    {
                        return false;
                    }
                }
            }
            else if (char.IsUpper(word[0]) && char.IsLower(word[1]))
            {
                for (int i = 2; i < word.Length; i++)
                {
                    if (char.IsUpper(word[i]))
                    {
                        return false;
                    }
                }
            }
            else
            {
                for (int i = 0; i < word.Length; i++)
                {
                    if (char.IsUpper(word[i]))
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
