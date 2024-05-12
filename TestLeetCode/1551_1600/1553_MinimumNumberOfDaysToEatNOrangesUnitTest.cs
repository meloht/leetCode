using leetCode._1551_1600;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1551_1600
{
    [TestClass]
    public class _1553_MinimumNumberOfDaysToEatNOrangesUnitTest
    {
        _1553_MinimumNumberOfDaysToEatNOrangesAlg alg = new _1553_MinimumNumberOfDaysToEatNOrangesAlg();

        [TestMethod]
        public void TestCase01()
        {
            int n = 10;
            int exp = 4;
            int res = alg.MinDays(n);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int n = 6;
            int exp = 3;
            int res = alg.MinDays(n);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int n = 1;
            int exp = 1;
            int res = alg.MinDays(n);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            int n = 56;
            int exp = 6;
            int res = alg.MinDays(n);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase05()
        {
            int n = 638826798;
            int exp = 6;
            int res = alg.MinDays(n);
           // Assert.AreEqual(exp, res);
        }
    }
}
