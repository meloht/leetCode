using leetCode._0901_0950;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0901_0950
{
    [TestClass]
    public class _914_XOfAKindInADeckOfCardsUnitTest
    {
        _914_XOfAKindInADeckOfCardsAlg alg = new _914_XOfAKindInADeckOfCardsAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] deck = [1, 2, 3, 4, 4, 3, 2, 1];
            bool exp = true;
            bool res = alg.HasGroupsSizeX(deck);
            Assert.AreEqual(exp, res );
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] deck = [1, 1, 1, 2, 2, 2, 3, 3];
            bool exp = false;
            bool res = alg.HasGroupsSizeX(deck);
            Assert.AreEqual(exp, res);
        }
        [TestMethod]
        public void TestCase03()
        {
            int[] deck = [1, 1, 2, 2, 2, 2];
            bool exp = true;
            bool res = alg.HasGroupsSizeX(deck);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            int[] deck = [1, 1, 1, 1, 2, 2, 2, 2, 2, 2];
            bool exp = true;
            bool res = alg.HasGroupsSizeX(deck);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase05()
        {
            int[] deck = [0, 0, 0, 0, 1, 1, 2, 2, 3, 3];
            bool exp = true;
            bool res = alg.HasGroupsSizeX(deck);
            Assert.AreEqual(exp, res);
        }
    }
}
