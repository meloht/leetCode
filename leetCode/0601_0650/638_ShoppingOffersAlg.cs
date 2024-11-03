using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0601_0650
{
    public class _638_ShoppingOffersAlg
    {
        Dictionary<IList<int>, int> memo = new Dictionary<IList<int>, int>();
        public int ShoppingOffers(IList<int> price, IList<IList<int>> special, IList<int> needs)
        {
            int n = price.Count;

            // 过滤不需要计算的大礼包，只保留需要计算的大礼包
            IList<IList<int>> filterSpecial = new List<IList<int>>();
            foreach (IList<int> sp in special)
            {
                int totalCount = 0, totalPrice = 0;
                for (int i = 0; i < n; ++i)
                {
                    totalCount += sp[i];
                    totalPrice += sp[i] * price[i];
                }
                if (totalCount > 0 && totalPrice > sp[n])
                {
                    filterSpecial.Add(sp);
                }
            }

            return DFS(price, special, needs, filterSpecial, n);

        }

        // 记忆化搜索计算满足购物清单所需花费的最低价格
        public int DFS(IList<int> price, IList<IList<int>> special, IList<int> curNeeds, IList<IList<int>> filterSpecial, int n)
        {
            if (!memo.ContainsKey(curNeeds))
            {
                int minPrice = 0;
                for (int i = 0; i < n; ++i)
                {
                    minPrice += curNeeds[i] * price[i]; // 不购买任何大礼包，原价购买购物清单中的所有物品
                }
                foreach (IList<int> curSpecial in filterSpecial)
                {
                    int specialPrice = curSpecial[n];
                    IList<int> nxtNeeds = new List<int>();
                    for (int i = 0; i < n; ++i)
                    {
                        if (curSpecial[i] > curNeeds[i])
                        { // 不能购买超出购物清单指定数量的物品
                            break;
                        }
                        nxtNeeds.Add(curNeeds[i] - curSpecial[i]);
                    }
                    if (nxtNeeds.Count == n)
                    { // 大礼包可以购买
                        minPrice = Math.Min(minPrice, DFS(price, special, nxtNeeds, filterSpecial, n) + specialPrice);
                    }
                }
                memo.Add(curNeeds, minPrice);
            }
            return memo[curNeeds];
        }

    }
}
