using leetCode._0351_0400;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0351_0400
{
    [TestClass]
    public class _390_EliminationGameUnitTest
    {
        _390_EliminationGameAlg alg = new _390_EliminationGameAlg();

        [TestMethod]
        public void TestCase01()
        {
            int n = 9;
            int exp = 6;
            int res = alg.LastRemaining(n);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int n = 1;
            int exp = 1;
            int res = alg.LastRemaining(n);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int n = 1000000;
            int exp = 481110;
            int res = alg.LastRemaining(n);
            Assert.AreEqual(exp, res);
        }
        [TestMethod]
        public void TestCase04()
        {
            int n = 10;
            int exp = 8;
            int res = alg.LastRemaining(n);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase05()
        {
            int n = 11;
            int exp = 8;
            int res = alg.LastRemaining(n);
            Assert.AreEqual(exp, res);
        }
        [TestMethod]
        public void TestCase06()
        {
            int n = 16;
            int exp = 6;
            int res = alg.LastRemaining(n);
            Assert.AreEqual(exp, res);
        }

    }
}
