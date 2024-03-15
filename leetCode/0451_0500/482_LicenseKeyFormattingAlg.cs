using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0451_0500
{
    public class _482_LicenseKeyFormattingAlg
    {
        public string LicenseKeyFormatting(string s, int k)
        {
            int count = s.Count(p => p != '-');
            int d = count % k;
            int first = k;
            if (d > 0)
            {
                first = d;
            }
            StringBuilder sb = new StringBuilder();

            int num = 0;
            int i = 0;
            for (; i < s.Length; i++)
            {

                if (s[i] != '-')
                {
                    sb.Append(char.ToUpper(s[i]));
                    num++;
                }
                if (num == first)
                {
                    break;
                }
            }
            List<string> list = new List<string>();
            list.Add(sb.ToString());
            sb.Clear();
            num = 0;

            for (i = i + 1; i < s.Length; i++)
            {
                if (s[i] != '-')
                {
                    sb.Append(char.ToUpper(s[i]));
                    num++;
                }
                if (num == k)
                {
                    num = 0;
                    list.Add(sb.ToString());
                    sb.Clear();
                }
            }

            return string.Join("-", list);
        }
    }
}
