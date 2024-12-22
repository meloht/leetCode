using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1351_1400
{
    public class _1387_SortIntegersByThePowerValueAlg
    {
        public int GetKth(int lo, int hi, int k)
        {

            Dictionary<int, int> dict = new Dictionary<int, int>();
            dict.Add(0, 0);
            dict.Add(1, 0);
            dict.Add(2, 1);
            List<int[]> list = new List<int[]>();

           
            for (int i = lo; i <= hi; i++)
            {
                int cnt = Dfs(dict, i);
                list.Add([i, cnt]);
            }
            list.Sort((x, y) =>
            {
                if (x[1] - y[1] == 0)
                {
                    return x[0] - y[0];
                }
                return x[1] - y[1];
            });

            return list[k - 1][0];
        }

        private int Dfs(Dictionary<int, int> dict, int num)
        {
            if (num == 1)
                return 0;
            if (dict.ContainsKey(num))
            {
                return dict[num];
            }

            int val = num;
            if (num % 2 == 0)
            {
                val = num / 2;
            }
            else
            {
                val = num * 3 + 1;
            }

            int count = Dfs(dict, val) + 1;

            dict.Add(num, count);

            return count;
        }
    }
}
