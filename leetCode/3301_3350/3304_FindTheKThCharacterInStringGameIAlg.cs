using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3301_3350
{
    public class _3304_FindTheKThCharacterInStringGameIAlg
    {
        public char KthCharacter1(int k)
        {

            StringBuilder sb = new StringBuilder();
            sb.Append('a');
            while (sb.Length < k)
            {
                int count = sb.Length;
                for (int i = 0; i < count; i++)
                {
                    if (sb[i] == 'z')
                    {
                        sb.Append('a');
                    }
                    else
                    {
                        sb.Append((char)(sb[i] + 1));
                    }
                }
            }
            return sb[k - 1];
        }
        public char KthCharacter2(int k)
        {
            int ans = 0;
            int t;
            while (k != 1)
            {
                t = (int)Math.Log(k, 2);
                if ((1 << t) == k)
                {
                    t--;
                }
                k = k - (1 << t);
                ans++;
            }
            return (char)('a' + ans);
        }

        public char KthCharacter(int k)
        {
            return (char)('a' + int.PopCount(k - 1));
        }



    }
}
