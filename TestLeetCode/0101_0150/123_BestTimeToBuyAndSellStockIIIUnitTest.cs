using leetCode._0101_0150;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._0101_0150
{

    [TestClass]
    public class _123_BestTimeToBuyAndSellStockIIIUnitTest
    {
        _123_BestTimeToBuyAndSellStockIIIAlg alg = new _123_BestTimeToBuyAndSellStockIIIAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] arr = [3, 3, 5, 0, 0, 3, 1, 4];
            int res = alg.MaxProfit(arr);
            Assert.AreEqual(6, res);
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
        [TestMethod]
        public void TestCase04()
        {
            int[] arr = [1];
            int res = alg.MaxProfit(arr);
            Assert.AreEqual(0, res);
        }
    }
}
