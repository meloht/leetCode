using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace leetCode._3251_3300
{
    public class _3287_FindTheMaximumSequenceValueOfArrayAlg
    {
        public int MaxValue2(int[] nums, int k)
        {
            int MX = 1 << 7;
            int n = nums.Length;
            bool[][] suf = new bool[n - k + 1][];
            bool[][] f = new bool[k + 1][];
            for (int i = 0; i < k+1; i++)
            {
                f[i] = new bool[MX];
            }
            f[0][0] = true;
            for (int i = n - 1; i >= k; i--)
            {
                int v = nums[i];
                // 注意当 i 比较大的时候，循环次数应和 i 有关，因为更大的 j，对应的 f[j] 全为 false
                for (int j = Math.Min(k - 1, n - 1 - i); j >= 0; j--)
                {
                    for (int x = 0; x < MX; x++)
                    {
                        if (f[j][x])
                        {
                            f[j + 1][x | v] = true;
                        }
                    }
                }
                if (i <= n - k)
                {
                    suf[i] = f[k].ToArray();
                }
            }

            int ans = 0;
            f = new bool[k + 1][];
            for (int i = 0; i < k + 1; i++)
            {
                f[i] = new bool[MX];
            }
            f[0][0] = true;
            for (int i = 0; i < n - k; i++)
            {
                int v = nums[i];
                for (int j = Math.Min(k - 1, i); j >= 0; j--)
                {
                    for (int x = 0; x < MX; x++)
                    {
                        if (f[j][x])
                        {
                            f[j + 1][x | v] = true;
                        }
                    }
                }
                if (i < k - 1)
                {
                    continue;
                }
                // 这里 f[k] 就是 pre[i]
                for (int x = 0; x < MX; x++)
                {
                    if (f[k][x])
                    {
                        for (int y = 0; y < MX; y++)
                        {
                            if (suf[i + 1][y])
                            {
                                ans = Math.Max(ans, x ^ y);
                            }
                        }
                    }
                }
                if (ans == MX - 1)
                {
                    return ans;
                }
            }
            return ans;
        }

        private const  int BIT_WIDTH = 7;

        public int MaxValue(int[] nums, int k)
        {
            int MX = 1 << BIT_WIDTH;
            int n = nums.Length;
            int k2 = Math.Min(k, BIT_WIDTH); // 至多选 k2 个数

            bool[][] suf = new bool[n - k + 1][];
            bool[][] f = new bool[k2 + 1][];
            for (int i = 0; i < k2 + 1; i++)
            {
                f[i] = new bool[MX];
            }
            f[0][0] = true;
            int[] maxI = new int[MX];
            int[] cnt = new int[MX];
            for (int i = n - 1; i >= k; i--)
            {
                int v = nums[i];
                for (int j = Math.Min(k2 - 1, n - 1 - i); j >= 0; j--)
                {
                    for (int x = 0; x < MX; x++)
                    {
                        if (f[j][x])
                        {
                            f[j + 1][x | v] = true;
                        }
                    }
                }
                if (i <= n - k)
                {
                    suf[i] = f[k2].ToArray();
                }
                // 枚举 v 的超集
                for (int s = v; s < MX; s = (s + 1) | v)
                {
                    if (++cnt[s] == k)
                    {
                        // 从 n-1 开始遍历，至少要遍历到 i 才有可能找到 k 个数 OR 等于 s
                        maxI[s] = i;
                    }
                }
            }

            int ans = 0;
            bool[][] pre = new bool[k2 + 1][];
            for (int i = 0; i < k2 + 1; i++)
            {
                pre[i] = new bool[MX];
            }
            pre[0][0] = true;
            int[] minI = new int[MX];
            Array.Fill(minI, int.MaxValue);
            Array.Fill(cnt, 0);
            int[] a = new int[MX];
            int[] b = new int[MX];
            for (int i = 0; i < n - k; i++)
            {
                int v = nums[i];
                for (int j = Math.Min(k2 - 1, i); j >= 0; j--)
                {
                    for (int x = 0; x < MX; x++)
                    {
                        if (pre[j][x])
                        {
                            pre[j + 1][x | v] = true;
                        }
                    }
                }
                // 枚举 v 的超集
                for (int s = v; s < MX; s = (s + 1) | v)
                {
                    if (++cnt[s] == k)
                    {
                        // 从 0 开始遍历，至少要遍历到 i 才有可能找到 k 个数 OR 等于 s
                        minI[s] = i;
                    }
                }
                if (i < k - 1)
                {
                    continue;
                }
                int na = 0;
                int nb = 0;
                for (int x = 0; x < MX; x++)
                {
                    if (pre[k2][x] && minI[x] <= i)
                    {
                        a[na++] = x;
                    }
                    if (suf[i + 1][x] && maxI[x] > i)
                    {
                        b[nb++] = x;
                    }
                }
                ans = Math.Max(ans, findMaximumXOR(a, na, b, nb));
                if (ans == MX - 1)
                {
                    return ans;
                }
            }
            return ans;
        }

        // 421. 数组中两个数的最大异或值
        // 改成两个数组的最大异或值，做法是类似的，仍然可以用【试填法】解决
        private int findMaximumXOR(int[] a, int n, int[] b, int m)
        {
            int ans = 0;
            int mask = 0;
            bool[] seen = new bool[1 << BIT_WIDTH];
            for (int i = BIT_WIDTH - 1; i >= 0; i--)
            { // 从最高位开始枚举
                mask |= 1 << i;
                int newAns = ans | (1 << i); // 这个比特位可以是 1 吗？
                Array.Fill(seen, false);
                for (int j = 0; j < n; j++)
                {
                    seen[a[j] & mask] = true; // 低于 i 的比特位置为 0
                }
                for (int j = 0; j < m; j++)
                {
                    int x = b[j] & mask; // 低于 i 的比特位置为 0
                    if (seen[newAns ^ x])
                    {
                        ans = newAns; // 这个比特位可以是 1
                        break;
                    }
                }
            }
            return ans;
        }




        public int MaxValue1(int[] nums, int k)
        {
            var A = FindORs(nums, k);
            Array.Reverse(nums);
            var B = FindORs(nums, k);
            int mx = 0;
            for (int i = k - 1; i < nums.Length - k; i++)
            {
                foreach (int a in A[i])
                {
                    foreach (int b in B[nums.Length - i - 2])
                    {
                        mx = Math.Max(mx, a ^ b);
                    }
                }
            }
            return mx;
        }

        public List<HashSet<int>> FindORs(int[] nums, int k)
        {
            var dp = new List<HashSet<int>>();
            var prev = new List<HashSet<int>>();
            for (int i = 0; i <= k; i++)
            {
                prev.Add(new HashSet<int>());
            }
            prev[0].Add(0);
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = Math.Min(k - 1, i + 1); j >= 0; j--)
                {
                    foreach (int x in prev[j])
                    {
                        prev[j + 1].Add(x | nums[i]);
                    }
                }
                dp.Add(new HashSet<int>(prev[k]));
            }
            return dp;
        }



    }
}
