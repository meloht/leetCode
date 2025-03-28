using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0801_0850
{
    public class _842_SplitArrayIntoFibonacciSequenceAlg
    {

        public IList<int> SplitIntoFibonacci(string num)
        {
            long n1 = 0;
            long n2 = 0;
            for (int i = 0; i < num.Length; i++)
            {
                if (i > 9)
                {
                    return new List<int>();
                }
                n1 = n1 * 10 + num[i] - '0';
                if (n1 > int.MaxValue)
                {
                    return new List<int>();
                }
                if (i > 0 && num[0] == '0')
                {
                    return new List<int>();
                }
                n2 = 0;
                for (int j = i + 1, k = 1; j < num.Length - k; j++, k++)
                {
                    if (j - i > 1 && num[i + 1] == '0')
                    {
                        break;
                    }
                    if (j - i > 10)
                    {
                        break;
                    }
                    n2 = n2 * 10 + num[j] - '0';

                    if (n1 > int.MaxValue)
                    {
                        break;
                    }
                    List<int> list = new List<int>();
                    list.Add((int)n1);
                    list.Add((int)n2);
                    if (Dfs(num, j + 1, list))
                    {
                        return list;
                    }
                }
            }

            return [];
        }
        private bool Dfs(string num, int i, List<int> list)
        {
            if (i >= num.Length)
            {
                if (list.Count > 2)
                    return true;
                return false;
            }

            long num1 = (long)list[list.Count - 1] + (long)list[list.Count - 2];
            if (num1 > int.MaxValue)
                return false;
            string ss = num1.ToString();
            if (ss.Length > num.Length - i)
                return false;

            for (int j = i, k = 0; j < num.Length && k < ss.Length; j++, k++)
            {

                if (ss[k] != num[j])
                    return false;
            }
            list.Add((int)num1);
            return Dfs(num, i + ss.Length, list);

        }
    }
}
