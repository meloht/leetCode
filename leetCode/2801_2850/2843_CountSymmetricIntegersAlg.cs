using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2801_2850
{
    public class _2843_CountSymmetricIntegersAlg
    {
        public int CountSymmetricIntegers(int low, int high)
        {
            int ans = 0;
            List<int> ls = new List<int>();
            for (int i = low; i <= high; i++)
            {
                ls.Clear();
                int n = i;
                while (n > 0)
                {
                    ls.Add(n % 10);
                    n = n / 10;
                }

                if (ls.Count % 2 == 1)
                    continue;

                int n1 = 0;
                int n2 = 0;
                for (int j = 0, k = ls.Count - 1; j < k; j++, k--)
                {
                    n1 += ls[j];
                    n2 += ls[k];
                }
                if (n1 == n2)
                {
                    ans++;
                }
            }
            return ans;
        }
    }
}
