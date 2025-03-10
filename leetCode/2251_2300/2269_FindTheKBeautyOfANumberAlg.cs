using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2251_2300
{
    public class _2269_FindTheKBeautyOfANumberAlg
    {
        public int DivisorSubstrings(int num, int k)
        {
            int ans = 0;
            string s = num.ToString();
            StringBuilder sb = new StringBuilder();
            sb.Append(s.Substring(0, k));
            int val = int.Parse(sb.ToString());
            if (num % val == 0)
            {
                ans++;
            }
            for (int i = k; i < s.Length; i++)
            {
                sb.Remove(0, 1);

                sb.Append(s[i]);
                val = int.Parse(sb.ToString());
                if (val > 0 && num % val == 0)
                {
                    ans++;
                }
            }

            return ans;
        }
    }
}
