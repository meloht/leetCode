using leetCode._0901_0950;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._0901_0950
{
    [TestClass]
    public class _902_NumbersAtMostNGivenDigitSetUnitTest
    {
        _902_NumbersAtMostNGivenDigitSetAlg alg = new _902_NumbersAtMostNGivenDigitSetAlg();

        [TestMethod]
        public void TestCase01()
        {
            string[] digits = ["1", "3", "5", "7"];
            int n = 100;
            int exp = 20;
            int res = alg.AtMostNGivenDigitSet(digits, n);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string[] digits = ["1", "4", "9"];
            int n = 1000000000;
            int exp = 29523;
            int res = alg.AtMostNGivenDigitSet(digits, n);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            string[] digits = ["7"];
            int n = 8;
            int exp = 1;
            int res = alg.AtMostNGivenDigitSet(digits, n);
            Assert.AreEqual(exp, res);
        }
    }
}
