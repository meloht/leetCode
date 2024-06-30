using leetCode._0401_0450;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0401_0450
{
    [TestClass]
    public class _440_KThSmallestInLexicographicalOrderTest
    {
        _440_KThSmallestInLexicographicalOrderAlg alg = new _440_KThSmallestInLexicographicalOrderAlg();

        [TestMethod]
        public void TestCase01()
        {
            int n = 13, k = 2;
            int exp = 10;
            int res = alg.FindKthNumber(n, k);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int n = 1, k = 1;
            int exp = 1;
            int res = alg.FindKthNumber(n, k);
            Assert.AreEqual(exp, res);
        }



        [TestMethod]
        public void TestCase03()
        {
            int n = 681692778, k = 351251360;
            int exp = 416126219;
            int res = alg.FindKthNumber(n, k);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            int n = 13, k = 5;
            int exp = 13;
            int res = alg.FindKthNumber(n, k);
            Assert.AreEqual(exp, res);
        }
        [TestMethod]
        public void TestCase05()
        {
            int n = 13, k = 13;
            int exp = 9;
            int res = alg.FindKthNumber(n, k);
            Assert.AreEqual(exp, res);
        }
        [TestMethod]
        public void TestCase06()
        {
            int n = 13, k = 1;
            int exp = 1;
            int res = alg.FindKthNumber(n, k);
            Assert.AreEqual(exp, res);
        }
    }

}
