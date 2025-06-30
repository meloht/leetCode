using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3401_3450
{
    public class _3443_MaximumManhattanDistanceAfterKChangesAlg
    {
        private int left;
        public int MaxDistance(string s, int k)
        {
            int ans = 0;
            int[] cnt = new int['X']; // 'W' + 1 = 'X'
            foreach (char ch in s)
            {
                cnt[ch]++;
                left = k;
                ans = Math.Max(ans, f(cnt['N'], cnt['S']) + f(cnt['E'], cnt['W']));
            }
            return ans;
        }




        private int f(int a, int b)
        {
            int d = Math.Min(Math.Min(a, b), left);
            left -= d;
            return Math.Abs(a - b) + d * 2;
        }


    }
}
