using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._51_100
{
    public class _70_ClimbingStairsAlg
    {
        int count = 0;
        public int ClimbStairs1(int n)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            dict.Add(1, 1);
            dict.Add(2, 2);

            for (int i = 3; i <= n; i++)
            {
                if (!dict.ContainsKey(i))
                {
                    int num = dict[i - 1] + dict[i - 2];
                    dict.Add(i, num);
                }
            }
            return dict[n];
        }

        public int ClimbStairs(int n)
        {
            if (n == 1)
                return 1;
            if (n == 2)
                return 2;
            int num1 = 1;
            int num2 = 2;
            int total = num1 + num2;

            for (int i = 3; i <= n; i++)
            {
                total = num1 + num2;
                num1 = num2;
                num2 = total;

            }
            return total;
        }

        private void RunSteps(int n)
        {
            if (n <= 0)
            {
                count++;
                return;
            }
            for (int i = 1; i <= 2; i++)
            {
                if (n >= i)
                {
                    RunSteps(n - i);
                }
            }
        }




    }
}
