using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0401_0450
{
    public class _443_StringCompressionAlg
    {
        public int Compress(char[] chars)
        {
            int j = 0;
            int i = 0;
            while (i < chars.Length && j < chars.Length)
            {
                int cnt = 1;
                int ch = j;
                while (j < chars.Length - 1 && chars[j] == chars[j + 1])
                {
                    cnt++;
                    j++;
                }
                j++;
                chars[i] = chars[ch];
                if (cnt > 1)
                {
                    i++;
                    int idx = i;
                    while (cnt > 0)
                    {
                        chars[i++] = (char)(cnt % 10 + '0');
                        cnt /= 10;
                    }
                    Reverse(chars, idx, i - 1);
                    continue;
                }

                i++;
            }
            return i;
        }
        public void Reverse(char[] chars, int left, int right)
        {
            while (left < right)
            {
                char temp = chars[left];
                chars[left] = chars[right];
                chars[right] = temp;
                left++;
                right--;
            }
        }

    }
}
