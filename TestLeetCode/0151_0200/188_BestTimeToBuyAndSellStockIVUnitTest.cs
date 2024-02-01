using leetCode._0151_0200;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0151_0200
{
    [TestClass]
    public class _188_BestTimeToBuyAndSellStockIVUnitTest
    {
        _188_BestTimeToBuyAndSellStockIVAlg alg = new _188_BestTimeToBuyAndSellStockIVAlg();

        [TestMethod]
        public void TestCase01()
        {
            int k = 2;
            int[] prices = [2, 4, 1];
            int exp = 2;
            int res = alg.MaxProfit(k, prices);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int k = 2;
            int[] prices = [3, 2, 6, 5, 0, 3];
            int exp = 7;
            int res = alg.MaxProfit(k, prices);
            Assert.AreEqual(exp, res);
        }
    }
}
