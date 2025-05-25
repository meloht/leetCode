using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0951_1000
{
    public class _0967_NumbersWithSameConsecutiveDifferencesAlg
    {
        public int[] NumsSameConsecDiff(int n, int k)
        {
          List<int> list = new List<int>();

            for (int i = 1; i <= 9; i++)
            {
                Dfs(i, 1, n, k, list);
            }
            return list.ToArray();
        }

        private void Dfs(int num,int length,int n,int k,List<int> list)
        {
            if (length == n)
            {
                list.Add(num);
                return;
            }
            int last = num % 10;
            int num1 = last - k;
            int num2 = last + k;
            if (num1 >= 0)
            {
                Dfs(num * 10 + num1, length + 1, n, k, list);
            }
            if (num2 <= 9 && num1 != num2)
            {
                Dfs(num * 10 + num2, length + 1, n, k, list);
            }
        }
    }
}
