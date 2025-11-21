using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace leetCode._1901_1950
{
    public class _1930_UniqueLength3PalindromicSubsequencesAlg
    {
        public int CountPalindromicSubsequence(string s)
        {
            int ans = 0;
            for (char alpha = 'a'; alpha <= 'z'; alpha++)
            { // 枚举两侧字母 alpha
                int i = s.IndexOf(alpha); // 最左边的 alpha 的下标
                if (i < 0)
                { // s 中没有 alpha
                    continue;
                }
                int j = s.LastIndexOf(alpha); // 最右边的 alpha 的下标

                bool[] has = new bool[26];
                for (int k = i + 1; k < j; k++)
                { // 枚举中间字母 mid
                    int mid = s[k] - 'a';
                    if (!has[mid])
                    {
                        has[mid] = true; // 避免重复统计
                        ans++;
                    }
                }
            }
            return ans;

        }
    }
}
