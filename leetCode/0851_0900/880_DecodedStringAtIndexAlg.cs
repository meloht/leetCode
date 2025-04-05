using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0851_0900
{
    public class _880_DecodedStringAtIndexAlg
    {
        public string DecodeAtIndex(string s, int k)
        {
            long len = 0;
            char prev = ' ';
            long kk = k;
            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsDigit(s[i]))
                {
                    long cnt= len * (s[i] - '0' - 1);
                    if (kk > cnt)
                    {
                        kk -= cnt;
                    }
                    else
                    {
                        long idx = kk % len;
                        if (idx == 0)
                        {
                            return prev.ToString();
                        }
                        return DecodeAtIndex(s, (int)idx);
                    }
                    len += cnt;
                }
                else
                {
                    prev = s[i];
                    len++;
                    kk--;
                    if (kk == 0)
                    {
                        return s[i].ToString();
                    }
                }
            }
            return "";
        }

        public string DecodeAtIndex1(string s, int k)
        {
            long size = 0;
            int N = s.Length;
            long kk = k;
            // Find size = length of decoded string
            for (int i = 0; i < N; ++i)
            {
                char c = s[i];
                if (char.IsDigit(c))
                    size *= c - '0';
                else
                    size++;
            }

            for (int i = N - 1; i >= 0; --i)
            {
                char c = s[i];
                kk %= size;
                if (kk == 0 && char.IsLetter(c))
                    return c.ToString();

                if (char.IsDigit(c))
                    size /= c - '0';
                else
                    size--;
            }

            return null;
        }



     
    }
}
