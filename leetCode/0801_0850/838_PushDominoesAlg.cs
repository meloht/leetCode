using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0801_0850
{
    public class _838_PushDominoesAlg
    {
        public string PushDominoes(string dominoes)
        {
            char[] s = dominoes.ToCharArray();

            int n = dominoes.Length;
            int i = 0;
            char left = 'L';
            while (i < n)
            {
                int j = i;
                while (j < n && s[j] == '.')
                {
                    j++;
                }
                char right = j < n ? s[j] : 'R';
                if (left == right)
                {
                    while (i < j)
                    {
                        s[i++] = right;
                    }
                }
                else if (left == 'R' && right == 'L')
                {
                    int k = j - 1;
                    while (i < k)
                    {
                        s[i++] = 'R';
                        s[k--] = 'L';
                    }
                }
                left = right;
                i = j + 1;
            }

            return new string(s);


        }
    }
}
