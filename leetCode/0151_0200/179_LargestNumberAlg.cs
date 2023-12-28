using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0151_0200
{
    public class _179_LargestNumberAlg
    {
        public string LargestNumber(int[] nums)
        {
            var list = nums.Select(x => x.ToString()).ToList();
            list.Sort(StrComparison);
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var item in list)
            {
                stringBuilder.Append(item);
            }
            string ans = stringBuilder.ToString().TrimStart('0');
            if (ans.Length == 0)
                return "0";
            return ans;
        }
        private int StrComparison(string a, string b)
        {
            int i = 0;
            while (i < a.Length || i < b.Length)
            {
                if (i < a.Length && i < b.Length)
                {
                    if (a[i] > b[i])
                        return -1;

                    if (a[i] < b[i])
                        return 1;
                }
                else if (i < a.Length)
                {
                    string aa = a.Substring(i);
                    return StrComparison(aa, b);
                }
                else if (i < b.Length)
                {
                    string bb = b.Substring(i);
                    return StrComparison(a, bb);
                }
                i++;
            }
            return 0;
        }


    }
}
