using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1251_1300
{
    public class _1287_ElementAppearingMoreThan25InSortedArrayAlg
    {
        public int FindSpecialInteger(int[] arr)
        {
            int nn = arr.Length / 4;
            int ans = 1;
            int len = arr.Length - 1;
            for (int i = 0; i < len; i++)
            {
                if (arr[i] == arr[i + 1])
                {
                    ans++;
                    if (ans > nn)
                    {
                        return arr[i];
                    }
                }
                else
                {
                    if (ans > nn)
                    {
                        return arr[i];
                    }
                    ans = 1;
                   
                }
            }
            if (ans > nn)
            {
                return arr[len];
            }
            return 0;
        }

        public int FindSpecialInteger1(int[] arr)
        {
            int n = arr.Length;
            int cur = arr[0], cnt = 0;
            for (int i = 0; i < n; ++i)
            {
                if (arr[i] == cur)
                {
                    ++cnt;
                    if (cnt * 4 > n)
                    {
                        return cur;
                    }
                }
                else
                {
                    cur = arr[i];
                    cnt = 1;
                }
            }
            return -1;
        }


    }
}
