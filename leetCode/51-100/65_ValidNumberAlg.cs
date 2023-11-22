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
                return char.IsNumber(s[0]);
            }
            bool isDot = false;
            bool isFirstDot = false;
            int i = 0;
            while (i < s.Length)
            {
                if (s[i] == '.' && isDot)
                {
                    return false;
                }
                if (s[i] == '.' && isDot == false)
                {
                    isDot = true;
                    bool bl1 = false;
                    bool bl2 = false;
                    if (i > 0)
                    {
                        bl1 = char.IsNumber(s[i - 1]);
                    }

                    i++;
                    if (i < s.Length)
                    {
                        bl2 = char.IsNumber(s[i]);
                    }

                    if (bl1 == false && bl2 == false)
                    {
                        return false;
                    }
                    continue;
                }

                if (i == 0)
                {
                    if (s[i] == '+' || s[i] == '-' || s[i] == '.')
                    {

                    }
                    else
                    {
                        if (!char.IsNumber(s[i]))
                        {
                            return false;
                        }
                    }
                }
                else
                {

                    if (s[i] == '+' || s[i] == '-')
                    {
                        return false;
                    }
                    if (s[i - 1] == '.' && !char.IsNumber(s[i]) && !(s[i] == 'e' || s[i] == 'E'))
                    {
                        return false;
                    }
                    if (char.IsNumber(s[i - 1]) && !char.IsNumber(s[i]) && (s[i] == 'e' || s[i] == 'E'))
                    {
                        if ((i + 1) >= s.Length)
                        {
                            return false;
                        }
                        if (s[i + 1] == '+' || s[i + 1] == '-')
                        {
                            if ((i + 2) >= s.Length)
                            {
                                return false;
                            }
                            else
                            {
                                if (!char.IsNumber(s[i + 2]))
                                {
                                    return false;
                                }
                                i = i + 3;
                            }
                            i = i + 2;
                        }
                        else
                        {
                            i++;
                        }
                        while (i < s.Length)
                        {
                            if (!char.IsNumber(s[i]))
                            {
                                return false;
                            }
                            i++;
                        }
                        break;
                    }

                    if (!char.IsNumber(s[i]))
                    {
                        return false;
                    }

                }
                i++;
            }

            return true;
        }


        public bool IsNumber1(string s)
        {
            if (s.Length == 1)
            {
                return char.IsNumber(s[0]);
            }

            char first = s[0];
            if (!(first == '+' || first == '-' || first == '.'))
            {
                if (!char.IsNumber(first))
                {
                    return false;
                }
            }

            bool isDot = first == '.';
            int i = 1;
            while (i < s.Length)
            {
                if (first == '.' && s[i] == '.')
                    return false;

                if (isDot == false && s[i] == '.')
                {
                    isDot = true;
                    int index = i;
                    if (!CheckDot(s, ref index))
                    {
                        return false;
                    }
                    continue;
                }

                if (s[i] == '+' || s[i] == '-')
                {
                    return false;
                }
                if (s[i - 1] == '.' && !char.IsNumber(s[i]) && !(s[i] == 'e' || s[i]=='E'))
                {
                    return false;
                }


                i++;
            }
            return true;
        }

        private bool CheckDot(string s, ref int i)
        {
            bool bl1 = false;
            bool bl2 = false;
            if (i > 0)
            {
                bl1 = char.IsNumber(s[i - 1]);
            }

            i++;
            if (i < s.Length)
            {
                bl2 = char.IsNumber(s[i]);
            }

            if (bl1 == false && bl2 == false)
            {
                return false;
            }
            return true;
        }
    }
}
