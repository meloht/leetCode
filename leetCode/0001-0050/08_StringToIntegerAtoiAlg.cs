using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1_50
{
    internal class StringToIntegerAtoiAlg
    {
        public int MyAtoi(string str)
        {
            if (string.IsNullOrEmpty(str))
                return 0;

            StringBuilder sb = new StringBuilder();

            bool isf = false;
            bool isFirst = false;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].ToString().Trim() == string.Empty && isFirst == false)
                {
                    continue;
                }
                if (str[i].ToString().Trim() == string.Empty && isFirst)
                {
                    break;
                }

                if (str[i] == '-' && sb.Length == 0 && !isFirst)
                {
                    isf = true;
                    isFirst = true;
                    continue;
                }
                if (str[i] == '+' && sb.Length == 0 && !isFirst)
                {

                    isf = false;
                    isFirst = true;
                    continue;
                }


                if (char.IsDigit(str[i]))
                {
                    isFirst = true;
                    sb.Append(str[i].ToString());
                }
                else
                {
                    if (isFirst)
                        break;

                    if (sb.Length >= 0)
                        break;
                }
            }
            if (sb.Length == 0)
                return 0;
            string ss = sb.ToString().TrimStart('0');
            List<char> ls = ss.Reverse().ToList();

            long num = 0;
            for (int i = 0; i < ls.Count; i++)
            {
                if (i == 0)
                {
                    num += long.Parse(ls[i].ToString());
                }
                else
                {

                    double db = Math.Pow(10, i);
                    if (db > int.MaxValue)
                    {
                        if (isf)
                        {
                            return int.MinValue;
                        }
                        else
                        {
                            return int.MaxValue;
                        }


                    }

                    num += long.Parse(ls[i].ToString()) * (long)db;
                }

                if (isf)
                {
                    if (-num < int.MinValue)
                    {
                        return int.MinValue;
                    }
                }
                else
                {
                    if (num > int.MaxValue)
                    {
                        return int.MaxValue;
                    }
                }

            }
            if (isf)
            {
                return -(int)num;
            }

            return (int)num;
        }
    }
}
