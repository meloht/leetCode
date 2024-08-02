using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0451_0500
{
    public class _468_ValidateIpAddressAlg
    {
        public string ValidIPAddress(string queryIP)
        {
            bool bl4 = queryIP.Contains('.');
            bool bl6 = queryIP.Contains(':');
            if (bl4 && bl6)
                return "Neither";

            if (bl4)
            {
                string[] arr = queryIP.Split('.');
                if (arr.Length != 4)
                    return "Neither";

                foreach (string item in arr)
                {
                    if (item.Length > 3 || item.Length == 0)
                        return "Neither";

                    if (item.Length != 1 && item.StartsWith('0'))
                        return "Neither";

                    int num = 0;

                    foreach (var ch in item)
                    {
                        if (!char.IsDigit(ch))
                        {
                            return "Neither";
                        }
                        num = num * 10;
                        num += ch - '0';

                    }
                    if (num > 255)
                    {
                        return "Neither";
                    }
                }

                return "IPv4";
            }
            if (bl6)
            {
                string[] arr = queryIP.Split(':');
                if (arr.Length != 8)
                    return "Neither";
                foreach (var item in arr)
                {
                    if (item.Length == 0 || item.Length > 4)
                        return "Neither";

                    foreach (var ch in item)
                    {
                        if (!char.IsLetterOrDigit(ch))
                        {
                            return "Neither";
                        }
                        if (char.IsLetter(ch) && char.ToLower(ch) > 'f')
                        {
                            return "Neither";
                        }

                    }
                }
                return "IPv6";
            }

            return "Neither";
        }
    }
}
