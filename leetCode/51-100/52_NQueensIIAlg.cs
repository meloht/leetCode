using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._51_100
{
    public class _52_NQueensIIAlg
    {
        int count = 0;
        public int TotalNQueens(int n)
        {
            int[] arr = new int[n];
            Check(0, n, arr);
            return count;
        }

        private void Check(int n, int max, int[] arr)
        {
            if (n == max)
            {
                count++;
                return;
            }
            for (int i = 0; i < max; i++)
            {
                arr[n] = i;
                if (Judge(n, arr))
                {
                    Check(n + 1, max, arr);
                }
            }
        }


        private bool Judge(int n, int[] arr)
        {
            for (int i = 0; i < n; i++)
            {
                if (arr[i] == arr[n] || Math.Abs(n - i) == Math.Abs(arr[n] - arr[i]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
