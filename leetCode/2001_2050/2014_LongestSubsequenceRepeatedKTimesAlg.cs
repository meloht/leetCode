using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace leetCode._2001_2050
{
    public class _2014_LongestSubsequenceRepeatedKTimesAlg
    {
        private char[] ans;
        private int anslen = 0;
        public string LongestSubsequenceRepeatedK(string s, int k)
        {
            char[] ss = s.ToCharArray();
            int n = s.Length;
            int[] cnt = new int[26];
            int[][] nxt = new int[n + 1][];
            nxt[n] = new int[26];
            Array.Fill(nxt[n], n);

            for (int i = n - 1; i >= 0; i--)
            {
                int c = s[i] - 'a';
                nxt[i] = new int[26];
                Array.Copy(nxt[i + 1], nxt[i], 26);
                nxt[i][c] = i;
                cnt[c]++;

            }

            StringBuilder tem = new StringBuilder();
            for (int i = 25; i >= 0; i--)
            {
                char c = (char)('a' + i);
                int nn = cnt[i] / k;
                for (int j = 0; j < nn; j++)
                {
                    tem.Append(c);
                }
            }
            char[] a = tem.ToString().ToCharArray();
            ans = new char[a.Length];
            permute(a, k, nxt);

            return new string(ans, 0, anslen);
        }

        // 47. 全排列 II
        // 枚举从 nums 中选任意个数的所有排列，处理枚举的排列
        private void permute(char[] nums, int k, int[][] nxt)
        {
            int n = nums.Length;
            char[] path = new char[n];
            bool[] onPath = new bool[n]; // onPath[j] 表示 nums[j] 是否已经填入排列
            dfs(0, nums, path, onPath, k, nxt);
        }

        private void dfs(int i, char[] nums, char[] path, bool[] onPath, int k, int[][] nxt)
        {
            // 处理当前排列 path
            // 如果 path*k 不是 s 的子序列，那么继续往 path 后面添加元素，更不可能是 s 的子序列
            if (i > 0 && !process(path, i, k, nxt))
            {
                return; // 剪枝
            }

            if (i == nums.Length)
            {
                return;
            }

            // 枚举 nums[j] 填入 path[pathLen]
            for (int j = 0; j < nums.Length; j++)
            {
                // 如果 nums[j] 已填入排列，continue
                // 如果 nums[j] 和前一个数 nums[j-1] 相等，且 nums[j-1] 没填入排列，continue
                if (onPath[j] || j > 0 && nums[j] == nums[j - 1] && !onPath[j - 1])
                {
                    continue;
                }
                path[i] = nums[j]; // 填入排列
                onPath[j] = true; // nums[j] 已填入排列（注意标记的是下标，不是值）
                dfs(i + 1, nums, path, onPath, k, nxt); // 填排列的下一个数
                onPath[j] = false; // 恢复现场
                                   // 注意 path 无需恢复现场，直接覆盖 path[i] 就行
            }
        }

        private bool process(char[] seq, int seqLen, int k, int[][] nxt)
        {
            if (!isSubsequence(seq, seqLen, k, nxt))
            {
                return false;
            }
            if (seqLen > anslen || seqLen == anslen && compare(seq, ans, anslen) > 0)
            {
                Array.Copy(seq, 0, ans, 0, seqLen);
                anslen = seqLen;
            }
            return true;
        }

        // 比较 a 和 b 的字典序大小
        private int compare(char[] a, char[] b, int n)
        {
            for (int i = 0; i < n; i++)
            {
                if (a[i] != b[i])
                {
                    return a[i] - b[i];
                }
            }
            return 0;
        }

        // 392. 判断子序列
        // 返回 seq*k 是否为 s 的子序列
        private bool isSubsequence(char[] seq, int n, int k, int[][] nxt)
        {
            int i = -1;
            while (k-- > 0)
            {
                for (int j = 0; j < n; j++)
                {
                    char c = seq[j];
                    i = nxt[i + 1][c - 'a'];
                    if (i + 1 == nxt.Length)
                    { // c 不在 s 中，说明 seq*k 不是 s 的子序列
                        return false;
                    }
                }
            }
            return true;
        }

    }
}
