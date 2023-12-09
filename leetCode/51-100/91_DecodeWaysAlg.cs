using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._51_100
{
    public class _91_DecodeWaysAlg
    {
        public int NumDecodings(string s)
        {
            if (s.StartsWith("0"))
                return 0;

            int total = 1;
            if (s.Split("00").Length > 1)
                return 0;
            string[] arr = s.Split('0', StringSplitOptions.RemoveEmptyEntries);
            if (arr.Length > 0 && s.EndsWith("0"))
            {
                string ss = arr[arr.Length - 1];
                if (ss[ss.Length - 1] > '2')
                    return 0;
                string res = ss.Substring(0, ss.Length - 1);
                if (res.Length == 0)
                    return 1;
                arr[arr.Length - 1] = res;

            }
            int len = arr.Length - 1;
            for (int i = 0; i < len; i++)
            {
                string ss = arr[i];
                if (ss[ss.Length - 1] > '2')
                    return 0;
                arr[i] = ss.Substring(0, ss.Length - 1);
            }

            foreach (string str in arr)
            {
                total *= NumDp(str);
            }
            return total;
        }
        private int NumDp(string code)
        {
            if (code.Length == 1)
            {
                return 1;
            }

            int currNum1 = 1;
            int currNum2 = 1;
            int total = 1;

            for (int i = 1; i < code.Length; i++)
            {
                var curr = code[i - 1];
                var next = code[i];
                if ((curr <= '2' && next <= '6') || (curr == '1'))
                {
                    int temp = currNum2;
                    currNum2 = currNum2 + currNum1;
                    currNum1 = temp;
                }
                else
                {
                    total *= currNum2;
                    currNum2 = 1;
                    currNum1 = 1;

                }
                if (i == code.Length - 1)
                {
                    total *= currNum2;
                }
            }
            return total;
        }

        private void NumWord(string s, int[] nums)
        {
            if (s.Length == 1 || s.Length == 0)
            {
                nums[0]++;
                return;
            }
            var curr = s[0];
            string ss = s.Substring(1);

            var next = s[1];
            if ((curr <= '2' && next <= '6') || (curr == '1'))
            {
                string ss2 = s.Substring(2);
                NumWord(ss2, nums);

            }
            NumWord(ss, nums);
        }

    }
}
