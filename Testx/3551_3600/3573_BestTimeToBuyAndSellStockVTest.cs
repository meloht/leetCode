using leetCode._3551_3600;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._3551_3600
{
    public class _3573_BestTimeToBuyAndSellStockVTest
    {
        _3573_BestTimeToBuyAndSellStockVAlg alg = new _3573_BestTimeToBuyAndSellStockVAlg();

        [Fact]
        public void Test1()
        {
            int[] prices = [1, 7, 9, 8, 2];
            int k = 2;
            long exp = 14;
            long res = alg.MaximumProfit(prices, k);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test2()
        {
            int[] prices = [12, 16, 19, 19, 8, 1, 19, 13, 9];
            int k = 3;
            long exp = 36;
            long res = alg.MaximumProfit(prices, k);
            Assert.Equal(exp, res);
        }
    }
}
