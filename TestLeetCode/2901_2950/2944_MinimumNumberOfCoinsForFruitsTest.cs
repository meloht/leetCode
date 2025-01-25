using leetCode._2901_2950;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2901_2950
{
    [TestClass]
    public class _2944_MinimumNumberOfCoinsForFruitsTest
    {
        _2944_MinimumNumberOfCoinsForFruitsAlg alg=new _2944_MinimumNumberOfCoinsForFruitsAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] prices = [3, 1, 2];
            int exp = 4;
            int res = alg.MinimumCoins(prices);
            Assert.AreEqual(exp, res);
        }
        [TestMethod]
        public void TestCase02()
        {
            int[] prices = [1, 10, 1, 1];
            int exp = 2;
            int res = alg.MinimumCoins(prices);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] prices = [26, 18, 6, 12, 49, 7, 45, 45];
            int exp = 39;
            int res = alg.MinimumCoins(prices);
            Assert.AreEqual(exp, res);
        }
    }
}
