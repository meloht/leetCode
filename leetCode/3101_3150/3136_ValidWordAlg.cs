using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3101_3150
{
    public class _3136_ValidWordAlg
    {
        public bool IsValid(string word)
        {
            if (word.Length < 3)
                return false;

            bool ch1 = false;
            bool ch2 = false;

            foreach (var item in word)
            {

                if (char.IsLetter(item))
                {
                    char aa = char.ToLower(item);
                    if (aa == 'a' || aa == 'e' || aa == 'i' || aa == 'o' || aa == 'u')
                    {
                        ch1 = true;
                    }
                    else
                    {
                        ch2 = true;
                    }
                }
                else if (!char.IsNumber(item))
                {
                    return false;
                }

            }
            return ch1 && ch2;
        }
    }
}
