using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._1351_1400
{
    public class _1399_CountLargestGroupAlg
    {
        public int CountLargestGroup(int n)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            int max = 0;
            for (int i = 1; i <= n; i++)
            {
                int num = i;
                int sum = 0;

                while (num > 0)
                {
                    int d = num % 10;
                    sum += d;
                    num /= 10;
                }
                if (dict.ContainsKey(sum))
                {
                    dict[sum]++;
                }
                else
                {
                    dict.Add(sum, 1);
                }
                max=Math.Max(max, dict[sum]);
            }

            int ans = 0;

            foreach (var item in dict)
            {
                if (item.Value == max)
                {
                    ans++;
                }
            }

            return ans; 
        }
    }
}
