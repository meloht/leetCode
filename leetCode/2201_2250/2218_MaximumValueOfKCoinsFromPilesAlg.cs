using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2201_2250
{
    public class _2218_MaximumValueOfKCoinsFromPilesAlg
    {
        public int MaxValueOfCoins(IList<IList<int>> piles, int k)
        {
            int[] f = new int[k + 1];
            int sumN = 0;
            foreach (List<int> Pile in piles)
            {
                int[] pile = Pile.ToArray(); // 转成数组处理更快更方便
                int n = pile.Length;
                for (int i = 1; i < n; i++)
                {
                    pile[i] += pile[i - 1]; // 提前计算 pile 的前缀和
                }
                sumN = Math.Min(sumN + n, k);
                for (int j = sumN; j > 0; j--)
                { // 优化：j 从前 i 个栈的大小之和开始枚举
                    for (int w = 0; w < Math.Min(n, j); w++)
                    {
                        f[j] = Math.Max(f[j], f[j - w - 1] + pile[w]); // w 从 0 开始，物品体积为 w+1
                    }
                }
            }
            return f[k];

        }
    }
}
