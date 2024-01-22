using leetCode._0651_0700;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._0651_0700
{
    [TestClass]
    public class _670_MaximumSwapUnitTest
    {
        _670_MaximumSwapAlg alg = new _670_MaximumSwapAlg();

        [TestMethod]
        public void TestCase01()
        {
            int num = 2736;
            int exp = 7236;

            int res = alg.MaximumSwap(num);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int num = 9973;
            int exp = 9973;

            int res = alg.MaximumSwap(num);
            Assert.AreEqual(exp, res);
        }
        [TestMethod]
        public void TestCase03()
        {
            int num = 98368;
            int exp = 98863;

            int res = alg.MaximumSwap(num);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            int num = 10;
            int exp = 10;

            int res = alg.MaximumSwap(num);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase05()
        {
            int num = 1993;
            int exp = 9913;

            int res = alg.MaximumSwap(num);
            Assert.AreEqual(exp, res);
        }
    }
}
