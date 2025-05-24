using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2901_2950
{
    public class _2942_FindWordsContainingCharacterAlg
    {
        public IList<int> FindWordsContaining(string[] words, char x)
        {
            List<int> result = new List<int>();

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].IndexOf(x) >= 0)
                {
                    result.Add(i);
                }
            }

            return result;
        }
    }
}
