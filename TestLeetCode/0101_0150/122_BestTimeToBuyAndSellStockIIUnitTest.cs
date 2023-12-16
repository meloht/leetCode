using leetCode._0101_0150;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._0101_0150
{
    [TestClass]
    public class _122_BestTimeToBuyAndSellStockIIUnitTest
    {
        _122_BestTimeToBuyAndSellStockIIAlg alg = new _122_BestTimeToBuyAndSellStockIIAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] arr = [7, 1, 5, 3, 6, 4];
            int res = alg.MaxProfit(arr);
            Assert.AreEqual(7, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] arr = [1, 2, 3, 4, 5];
            int res = alg.MaxProfit(arr);
            Assert.AreEqual(4, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] arr = [7, 6, 4, 3, 1];
            int res = alg.MaxProfit(arr);
            Assert.AreEqual(0, res);
        }
    }
}
