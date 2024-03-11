using leetCode._0401_0450;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0401_0450
{
    [TestClass]
    public class _441_ArrangingCoinsUnitTest
    {
        _441_ArrangingCoinsAlg alg = new _441_ArrangingCoinsAlg();
        [TestMethod]
        public void TestCase01()
        {
            int n = 5;
            int exp = 2;
            int res = alg.ArrangeCoins(n);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int n = 8;
            int exp = 3;
            int res = alg.ArrangeCoins(n);
            Assert.AreEqual(exp, res);
        }
        [TestMethod]
        public void TestCase03()
        {
            int n = 2;
            int exp = 1;
            int res = alg.ArrangeCoins(n);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            int n = 1804289383;
            int exp = 60070;
            int res = alg.ArrangeCoins(n);
            Assert.AreEqual(exp, res);
        }
    }
}
