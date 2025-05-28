using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace leetCode._0951_1000
{
    public class _0984_StringWithoutAaaOrBbbAlg
    {
        public string StrWithout3a3b(int a, int b)
        {
            StringBuilder ans = new StringBuilder();
            while (a > 0 || b> 0)
            {
                bool writeA = false;
                int L = ans.Length;
                if (L >= 2 && ans[L - 1] == ans[L - 2])
                {
                    if (ans[L - 1] == 'b')
                        writeA = true;
                }
                else
                {
                    if (a >= b)
                        writeA = true;
                }

                if (writeA)
                {
                    a--;
                    ans.Append('a');
                }
                else
                {
                    b--;
                    ans.Append('b');
                }
            }

            return ans.ToString();
        }
      


    }
}
