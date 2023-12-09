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
                arr[arr.Length - 1] = ss.Substring(0, ss.Length - 1);
            }
            int len = arr.Length - 1;
            for (int i = 0; i < len; i++)
            {
                string ss = arr[i];
                arr[i] = ss.Substring(0, ss.Length - 1);
            }

            foreach (string str in arr)
            {
                int[] nums = new int[] { 0 };
                NumWord(str, nums);
                if (nums[0] > 0)
                {
                    total *= nums[0];
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
