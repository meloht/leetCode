using leetCode._2101_2150;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2101_2150
{
    [TestClass]
    public class _2110_NumberOfSmoothDescentPeriodsOfAStockTest
    {
        _2110_NumberOfSmoothDescentPeriodsOfAStockAlg alg = new _2110_NumberOfSmoothDescentPeriodsOfAStockAlg();

        [TestMethod]
        public void Test01()
        {
            int[] prices = [3, 2, 1, 4];
            long exp = 7;
            long res = alg.GetDescentPeriods(prices);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void Test02()
        {
            int[] prices = [8, 6, 7, 7];
            long exp = 4;
            long res = alg.GetDescentPeriods(prices);
            Assert.AreEqual(exp, res);
        }
        [TestMethod]
        public void Test03()
        {
            int[] prices = [1];
            long exp = 1;
            long res = alg.GetDescentPeriods(prices);
            Assert.AreEqual(exp, res);
        }
    }
}
