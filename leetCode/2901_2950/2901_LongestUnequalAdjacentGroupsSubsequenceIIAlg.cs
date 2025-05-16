using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2901_2950
{
    public class _2901_LongestUnequalAdjacentGroupsSubsequenceIIAlg
    {
        private record Info(int maxF, int j, int maxF2, int j2)
        {
        }
        public IList<string> GetWordsInLongestSubsequence(string[] words, int[] groups)
        {
            int n = words.Length;
            Dictionary<long, Info> fMap = new();
            int[] from = new int[n];
            int globalMaxF = 0;
            int maxI = 0;

            for (int i = n - 1; i >= 0; i--)
            {
                char[] w = words[i].ToCharArray();
                int g = groups[i];

                // 计算 w 的哈希值
                long hash = 0;
                foreach (char c in w)
                {
                    hash = (hash << 5) | (c & 31);
                }

                int f = 0; // 方法一中的 f[i]
                for (int k = 0; k < w.Length; k++)
                {
                    long h = hash | (31L << (k * 5)); // 用记号笔把 w[k] 涂黑（置为 11111）
                    if (!fMap.ContainsKey(h))
                        continue;

                    Info t = fMap[h];

                    if (g != groups[t.j])
                    { // 可以从最大值转移过来
                        if (t.maxF > f)
                        {
                            f = t.maxF;
                            from[i] = t.j;
                        }
                    }
                    else
                    { // 只能从次大值转移过来
                        if (t.maxF2 > f)
                        {
                            f = t.maxF2;
                            from[i] = t.j2;
                        }
                    }
                }

                f++;
                if (f > globalMaxF)
                {
                    globalMaxF = f;
                    maxI = i;
                }

                // 用 f 更新 fMap[h] 的最大次大
                // 注意要保证最大次大的 group 值不同
                for (int k = 0; k < w.Length; k++)
                {
                    long h = hash | (31L << (k * 5));
                    Info t;
                    if (!fMap.ContainsKey(h))
                    {
                        t = new Info(0, 0, 0, 0);
                    }
                    else
                    {
                        t = fMap[h];
                    }

                    int maxF = t.maxF, j = t.j, maxF2 = t.maxF2, j2 = t.j2;
                    if (f > maxF)
                    { // 最大值需要更新
                        if (g != groups[j])
                        {
                            maxF2 = maxF; // 旧最大值变成次大值
                            j2 = j;
                        }
                        maxF = f;
                        j = i;
                    }
                    else if (f > maxF2 && g != groups[j])
                    { // 次大值需要更新
                        maxF2 = f;
                        j2 = i;
                    }
                    if (fMap.ContainsKey(h))
                    {
                        fMap[h] = new Info(maxF, j, maxF2, j2);
                    }
                    else
                    {
                        fMap.Add(h, new Info(maxF, j, maxF2, j2));
                    }

                }
            }

            List<string> ans = new List<string>(globalMaxF); // 预分配空间
            int ii = maxI;
            for (int k = 0; k < globalMaxF; k++)
            {
                ans.Add(words[ii]);
                ii = from[ii];
            }
            return ans;
        }
    }
}
