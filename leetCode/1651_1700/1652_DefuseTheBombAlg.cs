using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1651_1700
{
    public class _1652_DefuseTheBombAlg
    {
        public int[] Decrypt1(int[] code, int k)
        {
            int kk = Math.Abs(k);
            int[] res = new int[code.Length];

            int num = 0;
            int i = 1;
            int ii = 1;
            if (k > 0)
            {
                for (int j = 0; i < code.Length && j < kk; i++, j++)
                {
                    num += code[i];
                    if (i == code.Length - 1)
                    {
                        i = -1;
                    }

                }
            }
            else if (k < 0)
            {
                i = code.Length - 1;
                ii = code.Length - 1;
                for (int j = 0; i >= 0 && j < kk; i--, j++)
                {
                    num += code[i];
                    if (i == 0)
                    {
                        i = code.Length;
                    }
                }
                i++;
                ii++;
                i = i % code.Length;
                ii = ii % code.Length;
            }
          
            res[0] = num;

            for (int j = 1; j < code.Length; j++)
            {
                if (k == 0)
                {
                    res[j] = 0;
                }
                else if (k > 0)
                {
                    num += code[i];
                    num -= code[ii];
                    res[j] = num;
                    i++;
                    ii++;
                    i = i % code.Length;
                    ii = ii % code.Length;
                }
                else
                {
                    num += code[ii];
                    num -= code[i];
                    res[j] = num;
                    i++;
                    ii++;
                    i = i % code.Length;
                    ii = ii % code.Length;
                }
            }
            return res;
        }

        public int[] Decrypt(int[] code, int k)
        {
            int n = code.Length;
            if (k == 0)
            {
                return new int[n];
            }
            int[] res = new int[n];
            int[] newCode = new int[n * 2];
            Array.Copy(code, 0, newCode, 0, n);
            Array.Copy(code, 0, newCode, n, n);
            code = newCode;
            int l = k > 0 ? 1 : n + k;
            int r = k > 0 ? k : n - 1;
            int w = 0;
            for (int i = l; i <= r; i++)
            {
                w += code[i];
            }
            for (int i = 0; i < n; i++)
            {
                res[i] = w;
                w -= code[l];
                w += code[r + 1];
                l++;
                r++;
            }
            return res;
        }


    }
}
