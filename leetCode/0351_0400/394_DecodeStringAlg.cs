using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0351_0400
{
    public class _394_DecodeStringAlg
    {
        public string DecodeString(string s)
        {
            if (s.Length == 1)
                return s;

            StringBuilder sb = new StringBuilder();
            int i = 0;
            while (i < s.Length)
            {
                if (char.IsNumber(s[i]))
                {
                    var res = GetStr(s, i);
                    i = res.Item2;
                    sb.Append(res.Item1);

                }
                else if (s[i] != '[' && s[i] != ']')
                {
                    while (i < s.Length && !char.IsNumber(s[i]) && s[i] != '[' && s[i] != ']')
                    {
                        sb.Append(s[i]);
                        i++;
                    }
                    continue;
                }

                i++;

            }
            return sb.ToString();
        }

        private void AddItem(StringBuilder sb, string item, int n)
        {
            for (int i = 0; i < n; i++)
            {
                sb.Append(item);
            }
        }

        private Tuple<int, int> GetNum(string arr, int i)
        {
            StringBuilder sb = new StringBuilder();
            while (i < arr.Length && char.IsNumber(arr[i]))
            {
                sb.Append(arr[i]);
                i++;
            }

            int num = int.Parse(sb.ToString());
            return new Tuple<int, int>(num, i);
        }
        public Tuple<string, int> GetStr(string arr, int i)
        {
            StringBuilder sb = new StringBuilder();
            int num = 1;
            if (i < arr.Length && char.IsNumber(arr[i]))
            {
                var res = GetNum(arr, i);
                num = res.Item1;
                i = res.Item2;
                i++;
            }
            
            while (i < arr.Length && !char.IsNumber(arr[i]) && arr[i] != '[' && arr[i] != ']')
            {
                sb.Append(arr[i]);
                i++;
            }
            if (i < arr.Length && char.IsNumber(arr[i]))
            {
                var res = GetStr(arr, i);
                i = res.Item2;
                sb.Append(res.Item1);
            }

            StringBuilder sb2 = new StringBuilder();
            AddItem(sb2, sb.ToString(), num);
            return new Tuple<string, int>(sb2.ToString(), i);
        }

    }
}
