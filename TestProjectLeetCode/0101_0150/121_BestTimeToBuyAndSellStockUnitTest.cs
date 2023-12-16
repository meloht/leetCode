using leetCode._0101_0150;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectLeetCode._0101_0150
{
    [TestClass]
    public class _121_BestTimeToBuyAndSellStockUnitTest
    {
        _121_BestTimeToBuyAndSellStockAlg alg = new _121_BestTimeToBuyAndSellStockAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] arr = [7, 1, 5, 3, 6, 4];
            int res = alg.MaxProfit(arr);
            Assert.AreEqual(5, res);
        }
        [TestMethod]
        public void TestCase02()
        {
            int[] arr = [7, 6, 4, 3, 1];
            int res = alg.MaxProfit(arr);
            Assert.AreEqual(0, res);
        }
    }
}

