using leetCode._3651_3700;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._3651_3700
{
    public class _3652_BestTimeToBuyAndSellStockUsingStrategyTest
    {
        _3652_BestTimeToBuyAndSellStockUsingStrategyAlg alg = new _3652_BestTimeToBuyAndSellStockUsingStrategyAlg();

        [Fact]
        public void Test1()
        {
            int[] prices = [4, 2, 8], strategy = [-1, 0, 1];
            int k = 2;
            long exp = 10;
            long res = alg.MaxProfit(prices, strategy, k);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test2()
        {
            int[] prices = [5, 4, 3], strategy = [1, 1, 0];
            int k = 2;
            long exp = 9;
            long res = alg.MaxProfit(prices, strategy, k);
            Assert.Equal(exp, res);
        }


    }
}
