using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace leetCode._3051_3100
{
    public class _3075_MaximizeHappinessOfSelectedChildrenAlg
    {
        public long MaximumHappinessSum(int[] happiness, int k)
        {
            Array.Sort(happiness);
            int n = happiness.Length;
            long ans = 0;
            for (int i = n - 1; i >= n - k && happiness[i] > n - 1 - i; i--)
            {
                ans += happiness[i] - (n - 1 - i);
            }
            return ans;
        }
    }
}
