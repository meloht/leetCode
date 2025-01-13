using leetCode._0701_0750;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0701_0750
{
    [TestClass]
    public class _738_MonotoneIncreasingDigitsTest
    {
        _738_MonotoneIncreasingDigitsAlg alg = new _738_MonotoneIncreasingDigitsAlg();

        [TestMethod]
        public void TestCase01()
        {
            int n = 10;
            int exp = 9;
            int res = alg.MonotoneIncreasingDigits(n);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int n = 1234;
            int exp = 1234;
            int res = alg.MonotoneIncreasingDigits(n);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int n = 332;
            int exp = 299;
            int res = alg.MonotoneIncreasingDigits(n);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            int n = 120;
            int exp = 119;
            int res = alg.MonotoneIncreasingDigits(n);
            Assert.AreEqual(exp, res);
        }
    }
}
