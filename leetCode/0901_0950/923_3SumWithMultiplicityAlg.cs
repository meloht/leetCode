using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0901_0950
{
    public class _923_3SumWithMultiplicityAlg
    {
        public int ThreeSumMulti(int[] arr, int target)
        {
            int Mod = 1_000_000_007;
            int[] dict = new int[101];
            for (int i = 1; i < arr.Length; i++)
            {
                dict[arr[i]]++;
            }
            int ans = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                int n2 = arr[i];
                dict[n2]--;
                for (int j = 0; j < i; j++)
                {
                    int n1 = arr[j];
                    int n3 = target - (n1 + n2);
                    if (n3 <= 100 && n3 >= 0 && dict[n3] > 0)
                    {
                        ans = (ans + dict[n3]) % Mod;
                    }
                }
            }
            return ans;
        }
    }
}
