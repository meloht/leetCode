using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2951_3000
{
    public class _2961_DoubleModularExponentiationAlg
    {
        public IList<int> GetGoodIndices1(int[][] variables, int target)
        {
            List<int> ans = new List<int>();
            for (int i = 0; i < variables.Length; i++)
            {
                int a = variables[i][0];
                int b = variables[i][1];
                int c = variables[i][2];
                int m = variables[i][3];

                int num = 1;
                for (int j = 0; j < b; j++)
                {
                    num = (num * a) % 10;
                }
                int nn = num;
                num = 1;
                for (int j = 0; j < c; j++)
                {
                    num = (num * nn) % m;
                }

                if (num == target)
                {
                    ans.Add(i);
                }
            }
            return ans;
        }

        public IList<int> GetGoodIndices(int[][] variables, int target)
        {
            IList<int> ans = new List<int>();
            for (int i = 0; i < variables.Length; i++)
            {
                int[] v = variables[i];
                if (PowMod(PowMod(v[0], v[1], 10), v[2], v[3]) == target)
                {
                    ans.Add(i);
                }
            }
            return ans;
        }

        public int PowMod(int x, int y, int mod)
        {
            int res = 1;
            while (y != 0)
            {
                if ((y & 1) != 0)
                {
                    res = res * x % mod;
                }
                x = x * x % mod;
                y >>= 1;
            }
            return res;
        }


    }
}
