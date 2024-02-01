using leetCode._0301_0350;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0301_0350
{
    [TestClass]
    public class _309_BestTimeToBuyAndSellStockWithCooldownUnitTest
    {
        _309_BestTimeToBuyAndSellStockWithCooldownAlg alg = new _309_BestTimeToBuyAndSellStockWithCooldownAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] prices = [1, 2, 3, 0, 2];
            int exp = 3;
            int res = alg.MaxProfit(prices);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] prices = [1];
            int exp = 0;
            int res = alg.MaxProfit(prices);
            Assert.AreEqual(exp, res);
        }
    }
}
