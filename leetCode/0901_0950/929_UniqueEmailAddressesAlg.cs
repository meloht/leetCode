using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0901_0950
{
    public class _929_UniqueEmailAddressesAlg
    {
        public int NumUniqueEmails(string[] emails)
        {
            HashSet<string> addresses = new HashSet<string>();
            foreach (var item in emails)
            {
                string mail = item.Substring(0, item.IndexOf('@') + 1);
                StringBuilder sb = new StringBuilder();

                foreach (var ch in mail)
                {
                    if (char.IsLetter(ch))
                    {
                        sb.Append(ch);
                    }
                    else if (ch == '+')
                    {
                        break;
                    }
                   
                }
                sb.Append(item.Substring(item.IndexOf('@')));
                addresses.Add(sb.ToString());
            }
            return addresses.Count;
        }
    }
}
