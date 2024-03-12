using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0451_0500
{
    public class _476_NumberComplementAlg
    {
        public int FindComplement(int num)
        {
            string x = Convert.ToString(num, 2);
            char[] c = x.ToCharArray();
            for (int i = 0; i < c.Length; i++)
            {
                if (c[i] == '1')
                {
                    c[i] = '0';
                }
                else
                {
                    c[i] = '1';
                }
            }
            string ss = new string(c);
            int n = Convert.ToInt32(ss, 2);
            return n;
        }
    }
}
