using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2051_2100
{
    public class _2094_Finding3DigitEvenNumbersAlg
    {
        public int[] FindEvenNumbers(int[] digits)
        {
            int[] dict = new int[10];

            foreach (var item in digits)
            {
                dict[item]++;
            }

            List<int> ans = new List<int>();

            for (int i = 100; i < 1000; i += 2)
            {
                int[] map = new int[10];
                bool bl = true;
                for (int j = i; j > 0; j /= 10)
                {
                    int d = j % 10;
                    map[d]++;
                    if (map[d] > dict[d])
                    {
                        bl = false;
                        break;
                    }
                }
                if (bl)
                {
                    ans.Add(i);
                }
            }
            return ans.ToArray();
        }
        public int[] FindEvenNumbers1(int[] digits)
        {
            int[] dict = new int[10];

            foreach (var item in digits)
            {
                dict[item]++;
            }
            List<int> ans = new List<int>();
            Dfs(0, 0, dict, ans);
            return ans.ToArray();
        }

        public void Dfs(int i, int x, int[] cnt, List<int> ans)
        {
            if (i == 3)
            {
                ans.Add(x);
                return;
            }
            for (int j = 0; j < 10; j++)
            {
                if (cnt[j] > 0 && ((i == 0 && j > 0) || i == 1 || (i == 2 && j % 2 == 0)))
                {
                    cnt[j]--;
                    Dfs(i + 1, x * 10+j, cnt, ans);
                    cnt[j]++;
                }
            }
        }



    }
}
