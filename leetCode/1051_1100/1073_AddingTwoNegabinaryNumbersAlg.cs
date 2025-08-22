using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1051_1100
{
    public class _1073_AddingTwoNegabinaryNumbersAlg
    {
        public int[] AddNegabinary(int[] arr1, int[] arr2)
        {
            int i = arr1.Length - 1;
            int j = arr2.Length - 1;
            int carry = 0;
            List<int> ans = new List<int>();
            while (i >= 0 || j >= 0 || carry != 0)
            {
                int x = carry;
                if (i >= 0)
                {
                    x += arr1[i];
                }
                if (j >= 0)
                {
                    x += arr2[j];
                }
                if (x >= 2)
                {
                    ans.Add(x - 2);
                    carry = -1;
                }
                else if (x >= 0)
                {
                    ans.Add(x);
                    carry = 0;
                }
                else
                {
                    ans.Add(1);
                    carry = 1;
                }
                i--;
                j--;

            }

            while (ans.Count > 1 && ans[ans.Count - 1] == 0)
            {
                ans.RemoveAt(ans.Count - 1);
            }
            int[] res = new int[ans.Count];
            for (int k = 0, m = ans.Count - 1; k < res.Length; k++, m--)
            {
                res[k] = ans[m];
            }
            return res;
        }



    }
}
