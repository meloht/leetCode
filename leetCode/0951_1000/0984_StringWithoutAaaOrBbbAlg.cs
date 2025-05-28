using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0951_1000
{
    public class _0984_StringWithoutAaaOrBbbAlg
    {
        public string StrWithout3a3b(int a, int b)
        {
            StringBuilder sb = new StringBuilder();
            int a1 = a / 2;
            int b1 = b / 2;
            int a11 = a % 2;
            int b11 = b % 2;
            string[] arr = GetStr(a1, "aa");
            string[] brr = GetStr(b1, "bb");
            for (int i = 0, j = 0; i < a1 || j < b1; i++, j++)
            {
                if (i < a1 && j < b1)
                {
                    sb.Append(arr[i]).Append(brr[j]);
                }
                else if (i < a1)
                {
                    if (b11 > 0)
                    {
                        sb.Append(arr[i]).Append('b');
                        b11 = 0;
                    }
                    else
                    {
                        sb.Append(arr[i]);
                    }
                }
                else if (j < b1)
                {
                    if (a11 > 0)
                    {
                        sb.Append(brr[j]).Append('a');
                        a11 = 0;
                    }
                    else
                    {
                        sb.Append(brr[j]);
                    }
                }
            }
            if (a11 > 0 && b11 > 0)
            {
                if (sb[sb.Length - 1] == 'a')
                {
                    sb.Append("ba");
                }
                else
                {
                    sb.Append("ab");
                }
            }
            else if (a11 > 0)
            {
                if (!sb.ToString().EndsWith("aa"))
                {
                    sb.Append('a');
                }
            }
            else
            {
                if (!sb.ToString().EndsWith("bb"))
                {
                    sb.Append('b');
                }
            }

            return sb.ToString();
        }
        private string[] GetStr(int num, string c)
        {
            string[] arr = new string[num];
            for (int i = 0; i < num; i++)
            {
                arr[i] = c;
            }
            return arr;
        }


    }
}
