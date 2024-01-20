using leetCode._0351_0400;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._0351_0400
{
    [TestClass]
    public class _357_CountNumbersWithUniqueDigitsUnitTest
    {
        _357_CountNumbersWithUniqueDigitsAlg alg = new _357_CountNumbersWithUniqueDigitsAlg();

        [TestMethod]
        public void TestCase01()
        {
            int n = 2;
            int exp = 91;
            int res = alg.CountNumbersWithUniqueDigits(n);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int n = 0;
            int exp = 1;
            int res = alg.CountNumbersWithUniqueDigits(n);
            Assert.AreEqual(exp, res);
        }
    }
}
