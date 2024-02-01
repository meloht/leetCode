using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1501_1550
{
    public class _1534_CountGoodTripletsAlg
    {
        public int CountGoodTriplets(int[] arr, int a, int b, int c)
        {
            int ans = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int ii = arr[i];
                for (int j = i + 1; j < arr.Length; j++)
                {
                    int jj = arr[j];
                    if (Math.Abs(ii - jj) > a)
                    {
                        continue;
                    }
                    for (int k = j + 1; k < arr.Length; k++)
                    {
                        int kk = arr[k];
                        if (Math.Abs(jj - kk) <= b && Math.Abs(ii - kk) <= c)
                        {
                            ans++;
                        }
                    }
                }

            }
            return ans;
        }
    }
}
