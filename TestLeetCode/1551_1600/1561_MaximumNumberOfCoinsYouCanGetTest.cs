using leetCode._1551_1600;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1551_1600
{
    [TestClass]
    public class _1561_MaximumNumberOfCoinsYouCanGetTest
    {
        _1561_MaximumNumberOfCoinsYouCanGetAlg alg = new _1561_MaximumNumberOfCoinsYouCanGetAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] piles = [2, 4, 1, 2, 7, 8];
            int exp = 9;
            int res = alg.MaxCoins(piles);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] piles = [2, 4, 5];
            int exp = 4;
            int res = alg.MaxCoins(piles);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] piles = [9, 8, 7, 6, 5, 1, 2, 3, 4];
            int exp = 18;
            int res = alg.MaxCoins(piles);
            Assert.AreEqual(exp, res);
        }
    }
}
