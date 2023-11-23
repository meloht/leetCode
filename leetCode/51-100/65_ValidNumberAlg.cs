using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._51_100
{
    public class _65_ValidNumberAlg
    {
        public bool IsNumber(string s)
        {
            if (s.Length == 1)
            {
                return IsNumber(s[0]);
            }
            s = s.Trim().ToLower();
            char first = s[0];
            if (!(first == '+' || first == '-' || first == '.'))
            {
                if (!IsNumber(first))
                {
                    return false;
                }
            }

            int eIndex = s.IndexOf('e');
            if (eIndex > -1)
            {
                var arr = s.Split('e');
                if (arr.Length != 2)
                    return false;

                int num = arr[0].Replace("+", "").Replace("-", "").Length;

                if (num == 0)
                {
                    return false;
                }

                if (CheckDotOrIntNumber(arr[0]) == false)
                {
                    return false;
                }

                if (arr[1].Length > 0)
                {
                    if (arr[1][0] == '+' || arr[1][0] == '-')
                    {
                        if (arr[1].Length < 2)
                        {
                            return false;
                        }
                        if (CheckIntNumber(arr[1].Substring(1)) == false)
                            return false;
                    }
                    else
                    {
                        if (CheckIntNumber(arr[1]) == false)
                            return false;
                    }
                }
                else
                {
                    return false;
                }

            }
            else
            {
                if (CheckDotOrIntNumber(s) == false)
                {
                    return false;
                }
            }

            return true;
        }

        private bool CheckIntNumber(string s)
        {
            foreach (var item in s)
            {
                if (!IsNumber(item))
                {
                    return false;
                }
            }
            return true;
        }
        private bool CheckDotOrIntNumber(string s)
        {
            var arr = s.Split('.');
            if (arr.Length == 2)
            {
                int num = arr[0].Replace("+", "").Replace("-", "").Length;
                string ints = arr[1];
                if (num == 0 && ints.Length == 0)
                {
                    return false;
                }

                if (CheckPreNum(arr[0]) == false)
                    return false;

                if (CheckIntNumber(ints) == false)
                    return false;
            }
            else if (arr.Length == 1)
            {
                if (CheckPreNum(arr[0]) == false)
                    return false;
            }
            else
            {
                return false;
            }
            return true;
        }
        private bool CheckPreNum(string ss)
        {
            if (ss.Length == 0)
                return true;
            char first = ss[0];
            if (IsNumber(first) || first == '+' || first == '-')
            {
                if (CheckIntNumber(ss.Substring(1)) == false)
                    return false;
            }
            else
            {
                return false;
            }
            return true;
        }
        private bool IsNumber(char c)
        {
            return c >= '0' && c <= '9';
        }
    }
}
