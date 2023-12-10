using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._51_100
{
    public class _93_RestoreIpAddressesAlg
    {
        public IList<string> RestoreIpAddresses(string s)
        {
            List<string> list = new List<string>();
            if (s == null || s.Length < 3)
                return list;
            int len = 0;
            int deLen = 0;
            for (int first = 0; first < 3; first++)
            {
                string s1 = s.Substring(0, first + 1);
                if (!IsIPNum(s1))
                    continue;

                int end2 = first + 3;
                for (int second = first + 1; second <= end2 && second < s.Length; second++)
                {
                    len = second - first;

                    deLen = s.Length - s1.Length - len;
                    if (deLen > 6)
                        continue;

                    string s2 = s.Substring(first + 1, len);
                    if (!IsIPNum(s2))
                        continue;

                    int end3 = second + 3;

                    for (int three = second + 1; three <= end3 && three < s.Length; three++)
                    {

                        len = three - second;

                        deLen = s.Length - s1.Length - s2.Length - len;
                        if (deLen > 3)
                            continue;

                        string s3 = s.Substring(second + 1, len);
                        if (!IsIPNum(s3))
                            continue;

                        string s4 = s.Substring(three + 1);
                        if (!IsIPNum(s4))
                            continue;

                        string ip = $"{s1}.{s2}.{s3}.{s4}";
                        list.Add(ip);
                    }
                }
            }

            return list;
        }

        private bool IsIPNum(string s)
        {
            if (s.Length == 0)
                return false;
            if (s.StartsWith("0") && s.Length > 1)
                return false;
            int num = int.Parse(s);
            if (num >= 0 && num <= 255)
                return true;

            return false;
        }

    }
}
