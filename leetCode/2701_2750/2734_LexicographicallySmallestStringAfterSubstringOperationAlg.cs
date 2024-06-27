using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2701_2750
{
    public class _2734_LexicographicallySmallestStringAfterSubstringOperationAlg
    {
        public string SmallestString(string s)
        {
            int left = -1;
            int right = s.Length - 1;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != 'a' && left == -1)
                {
                    left = i;
                }
                if (s[i] != 'a')
                {
                    right = i;
                }
                else
                {
                    if (right != s.Length - 1)
                    {
                        break;
                    }
                }
            }
            StringBuilder sb = new StringBuilder();
            if (left == -1)
            {
                char[] chars = s.ToCharArray();
                chars[s.Length - 1] = 'z';
                return new string(chars);
            }
            sb.Append(s.Substring(0, left));
            for (int i = left; i <= right; i++)
            {
                char ch = (char)(s[i] - 1);
                sb.Append(ch);
            }
            if (right != s.Length - 1)
            {
                sb.Append(s.Substring(right + 1));
            }

            return sb.ToString();
        }
    }
}
