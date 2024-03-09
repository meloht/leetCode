using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0401_0450
{
    public class _409_LongestPalindromeAlg
    {
        public int LongestPalindrome(string s)
        {
            Dictionary<char, int> map = new Dictionary<char, int>();
            foreach (var item in s)
            {
                if (map.ContainsKey(item))
                {
                    map[item]++;
                }
                else
                {
                    map.Add(item, 1);
                }
            }
            int ans = 0;
            foreach (var item in map)
            {
                if (item.Value > 1)
                {
                    if (item.Value % 2 == 0)
                    {
                        ans += item.Value;
                    }
                    else
                    {
                        ans = (item.Value - 1) + ans;
                    }
                }
            }
            if (ans < s.Length)
            {
                ans++;
            }
            return ans;
        }
    }
}
