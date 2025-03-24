using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0801_0850
{
    public class _831_MaskingPersonalInformationAlg
    {
        public string MaskPII(string s)
        {
            if (s.Contains("@"))
            {
                return GetMail(s);
            }
            return GetTel(s);
        }

        private string GetMail(string s)
        {
            StringBuilder sb = new StringBuilder();

            string[] ss = s.ToLower().Split('@', StringSplitOptions.RemoveEmptyEntries);

            sb.Append(ss[0][0]);
            sb.Append("*****");
            sb.Append(ss[0][ss[0].Length - 1]);
            sb.Append('@');
            sb.Append(ss[1]);


            return sb.ToString();
        }

        private string GetTel(string s)
        {
            StringBuilder sb = new StringBuilder();

            List<char> ls = new List<char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsNumber(s[i]))
                {
                    ls.Add(s[i]);
                }
            }
            int n = ls.Count - 10;
            if (n > 0)
            {
                sb.Append('+');
                for (int i = 0; i < n; i++)
                {
                    sb.Append('*');
                }
                sb.Append('-');
               
            }
            sb.Append("***-***-");


            for (int i = ls.Count - 4; i < ls.Count; i++)
            {
                sb.Append(ls[i]);
            }

            return sb.ToString();
        }
    }
}
