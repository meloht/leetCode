using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode.WeeklyContest._0401
{
    public class Alg_02
    {
        int Mod = 1_000_000_007;
        public int ValueAfterKSeconds(int n, int k)
        {
            int[] sumNums = new int[n + 1];
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                sumNums[i + 1] = sumNums[i] + 1;
            }


            while (k > 0)
            {
                for (int i = 0; i < n; i++)
                {

                    arr[i] = sumNums[i + 1] % Mod;
                    sumNums[i + 1] = sumNums[i] % Mod + arr[i] % Mod;
                }
                k--;
            }
            return arr[n - 1];
        }
    }
}
