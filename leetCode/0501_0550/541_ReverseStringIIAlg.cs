using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0501_0550
{

    public class _541_ReverseStringIIAlg
    {
        public string ReverseStr(string s, int k)
        {
            if (s.Length < k)
            {
                return new string(s.Reverse().ToArray());
            }

            StringBuilder sb = new StringBuilder();
            int k2 = 2 * k;

            for (int i = 1; i <= s.Length; i++)
            {
                if (i % k2 == 0)
                {
                    var sub = s.Substring(i - k2, k);
                    var rev = new string(sub.Reverse().ToArray());
                    sb.Append(rev);
                    sb.Append(s.Substring(i - k, k));
                }
                else
                {
                    if (i == s.Length)
                    {
                        int n = s.Length - sb.Length;
                        if (n <= k)
                        {
                            string ss = s.Substring(s.Length - n);
                            sb.Append(new string(ss.Reverse().ToArray()));
                        }
                        else
                        {
                            string ss = s.Substring(s.Length - n,k);
                            sb.Append(new string(ss.Reverse().ToArray()));

                            string sss = s.Substring(s.Length - n + k);
                            sb.Append(sss);
                        }
                    }
                }
            }

            return sb.ToString();
        }
    }
}
